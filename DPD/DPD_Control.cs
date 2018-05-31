using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using NLog;
using System.Reflection;
using System.Threading;

namespace DPD
{
    public partial class DPD_Control : DevExpress.XtraEditors.XtraUserControl
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private RegisteredWaitHandle handle = null;
        private AutoResetEvent ev = null;

        public DPD_Control()
        {
            InitializeComponent();
            try
            {
                string filename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings_DPD.xml");
                bool ok = SerializeStatic.Deserialize(typeof(Settings), filename);
            }
            catch (Exception ex)
            {
                logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
            }
            dStart.DateTime = DateTime.Today.AddDays(-3);
            dEnd.DateTime = DateTime.Today;
            DataFill();
            GetNewLogMessages();

            ev = new AutoResetEvent(false);
            handle = ThreadPool.RegisterWaitForSingleObject(ev, new WaitOrTimerCallback(AutoRefresh), "SomeState", Convert.ToUInt32(Settings.RefreshDelay), false);
        }

        private void DataFill()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)DataFill);
            }
            else
            {
                int[] rs = gridView1.GetSelectedRows();
                bool changeCursor = Cursor.Current != Cursors.WaitCursor;
                if (changeCursor)
                    Cursor.Current = Cursors.WaitCursor;
                try
                {
                    string sql = "";
                    sql = "EXEC	[dpd].[GetGridData] ";
                    sql += string.Format("@StartDate = '{0:yyyy-MM-dd} 00:00:00', ", dStart.DateTime);
                    sql += string.Format("@EndDate = '{0:yyyy-MM-dd} 23:59:59' ", dEnd.DateTime);
                    DataTable dt = dtExecuteSQL(sql);

                    gridControl1.DataSource = dt;
                    gridControl1.RefreshDataSource();
                    if (rs.Length > 0)
                    {
                        foreach (int r in rs)
                            gridView1.SelectRow(r);

                        gridView1.FocusedRowHandle = rs[0];
                        gridView1.MakeRowVisible(rs[0]);
                    }

                    sql = "SELECT v.VarValue FROM dbo.Variables v WHERE v.VarName = 'DPDPickDate'";
                    DataTable dt1 = dtExecuteSQL(sql);
                    if (dt1.Rows.Count == 1)
                    {
                        dSend.DateTime = DateTime.Parse(dt1.Rows[0][0].ToString());
                    }
                    else
                    {
                        dSend.DateTime = DateTime.Today;
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
                }

                if (changeCursor)
                    Cursor.Current = Cursors.Default;
            }
        }
        public int ExecuteSQL(string sql)
        {
            logger.Debug("{0}", MethodBase.GetCurrentMethod());
            logger.Debug("SQL: {0}", sql);

            int res = -1;
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.db_conn_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand() { CommandType = CommandType.Text, Connection = conn, CommandText = sql })
                    {
                        res = cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
            }
            logger.Debug("Result {0}", res);
            return res;
        }
        public DataTable dtExecuteSQL(string sql)
        {
            logger.Debug("{0}", MethodBase.GetCurrentMethod());
            DataTable dt = new DataTable();
            logger.Debug("SQL: {0}", sql);
            try
            {
                using (SqlConnection conn = new SqlConnection(Settings.db_conn_string))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand() { CommandType = CommandType.Text, Connection = conn, CommandText = sql })
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        dt.Load(dr);
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
            }
            logger.Debug("Result DataTable Record Count: {0}", dt?.Rows?.Count);
            return dt;
        }
        private bool ShipBox(string OrderCode)
        {
            string sql = string.Format("SELECT lc.SSCC FROM dbo.LV_Containers lc INNER JOIN dbo.LV_Orders lo ON lc.OrderID = lo.ord_ID WHERE lo.OrderCode = '{0}'", OrderCode);
            bool res = false;
            DataTable dt = dtExecuteSQL(sql);
            foreach (DataRow row in dt.Rows)
            {
                res = true;
                try
                {
                    sql = string.Format(@"EXEC [dbo].[ShipBox] @SSCC = N'{0}', @OrderCode = N'{1}'", row[0], OrderCode);
                    int i = ExecuteSQL(sql);
                }
                catch (Exception ex)
                {
                    logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
                    res = false;
                }
            }
            return res;
        }
        private void cMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextMenuStrip m = (ContextMenuStrip)sender;
            DevExpress.XtraGrid.GridControl grid = (DevExpress.XtraGrid.GridControl)m.SourceControl;
            m.Close();

            GridView view = grid.DefaultView as GridView;
            int[] selRowsPost = view.GetSelectedRows();
            int count = 0;
            bool i = false;

            bool changeCursor = Cursor.Current != Cursors.WaitCursor;
            if (changeCursor)
                Cursor.Current = Cursors.WaitCursor;

            foreach (int r in selRowsPost)
            {
                DataRow row = gridView1.GetDataRow(r);
                count++;
                tStatus.Text = string.Format("Обработка заказа {0} ({1}/{2})", row[1], count, selRowsPost.Length);
                Application.DoEvents();
                switch (e.ClickedItem.Name)
                {
                    case "EditAddressItem":
                        (new FormAddressNew(row["OrderCode"].ToString())).ShowDialog();
                        break;
                    case "ShipBoxItem":
                        i = ShipBox(row["OrderCode"].ToString());
                        break;
                    case "showInfo":
                        (new FormInfo(row["OrderCode"].ToString())).ShowDialog();
                        break;
                }
            }
            if (changeCursor)
                Cursor.Current = Cursors.Default;
            tStatus.Text = "Готов";
            DataFill();
        }

        #region Controls 
        private void bRefill_Click(object sender, EventArgs e)
        {
            DataFill();
        }
        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            GridView view = (GridView)sender;
            if (e.HitInfo.InRow)
                cMenu.Show(view.GridControl, e.Point);
        }
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            tStatus.Text = String.Format("Выбрано {0} из {1} короба(ов)", gridView1.SelectedRowsCount, gridView1.RowCount);
        }
        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView gv = (GridView)sender;
            if (e.RowHandle >= 0)
            {
                string code = (string)gv.GetRowCellValue(e.RowHandle, "lv_status_code");
                string dpd_status = (string)gv.GetRowCellValue(e.RowHandle, "dpd_status");
                if (dpd_status.Length > 0)
                {
                    switch (code)
                    {
                        case "99":
                            e.Appearance.BackColor = Color.FromArgb(120, 120, 120);
                            break;
                        case "90":
                            e.Appearance.BackColor = Color.FromArgb(200, 200, 200);
                            break;
                        default:
                            if (dpd_status != "OK" & dpd_status.Length > 0)
                                e.Appearance.BackColor = Color.FromArgb(255, 150, 150);
                            //else if (status.Contains("WAR"))
                            //    e.Appearance.BackColor = Color.FromArgb(255, 255, 150);
                            break;
                    }
                }
            }
        }
        private void Send_EditValueChanged(object sender, EventArgs e)
        {
            dSend.BackColor = Color.LightPink;
            string sql = string.Format("UPDATE [dbo].[Variables] SET [VarValue] = '{0:yyyy-MM-dd}' WHERE[VarName] = 'DPDPickDate'", dSend.DateTime);
            int ok = ExecuteSQL(sql);
            if (ok == 1)
            {
                DateTime start = DateTime.Now;
                while ((DateTime.Now - start).TotalMilliseconds < 300)
                    Application.DoEvents();
                dSend.BackColor = Color.LightGreen;
                if (dSend.DateTime < DateTime.Today)
                    dSend.BackColor = Color.Yellow;
            }
        }
        private void bLog_Click(object sender, EventArgs e)
        {
            grLog.Visible = true;
        }
        private void bCloseLog_Click(object sender, EventArgs e)
        {
            grLog.Visible = false;
        }
        #endregion

        private void AutoRefresh(object data, bool timerOut)
        {
            GetLogMessages();
        }
        private void GetNewLogMessages()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)GetNewLogMessages);
            }
            else
            {
                string t = "";
                DataTable dt = dtExecuteSQL("EXEC [dbo].[MsgGet] @appName = N'FILUET_DPD_Print', @new = 0");
                DataTable sortedDT = new DataTable();
                if (dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.Sort = "Date DESC";
                    sortedDT = dv.ToTable();
                }
                bool n = false;
                foreach (DataRow row in sortedDT.Rows)
                {
                    t += string.Format("{0:dd.MM.yyyy HH:mm:ss} {1}{2}{3}{2}{2}", row[3], row[5], Environment.NewLine, row[1]);
                    n |= row[4].ToString() == "False";
                }
                grLog.Visible = n;
                tLog.Text = t;
            }
        }
        private void GetLogMessages()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)GetLogMessages);
            }
            else
            {
                string t = tLog.Text;
                DataTable dt = dtExecuteSQL("EXEC [dbo].[MsgGet] @appName = N'FILUET_DPD_Print'");
                DataTable sortedDT = new DataTable();
                if (dt.Rows.Count > 0)
                {
                    DataView dv = dt.DefaultView;
                    dv.Sort = "Date DESC";
                    sortedDT = dv.ToTable();
                }
                if (sortedDT.Rows.Count > 0)
                    grLog.Visible = true;

                foreach (DataRow row in sortedDT.Rows)
                {
                    t += string.Format("{0:dd.MM.yyyy HH:mm:ss} {1}{2}{3}{2}{2}", row[3], row[5], Environment.NewLine, row[1]);
                }
                tLog.Text = t;
            }
        }

    }
}