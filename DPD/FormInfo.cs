using System;
using System.Data;
using System.Windows.Forms;
using NLog;
using System.Reflection;
using System.Data.SqlClient;

namespace DPD
{
    public partial class FormInfo : DevExpress.XtraEditors.XtraForm
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public FormInfo(string order_code)
        {
            InitializeComponent();
            this.Text = "Информация для заказа " + order_code;
            get_dpd_data(order_code);
            get_containers_info(order_code);
        }

        public void get_dpd_data(string order_code)
        {
            string sql = string.Format(@"SELECT     isnull(do.status, '') as status,
                                                    isnull(do.error_msg, '') as error_msg,
                                                    isnull(do.printed,0) as printed,
                                                    isnull(do.dpd_id, '') as dpd_id,
                                                    isnull(do.ship_date,'') as ship_date
                                        FROM dbo.dpd_orders do WHERE do.order_code = '{0}';", order_code);
            DataTable dt = dtExecuteSQL(sql);
            t_dpd_id.Text = "";
            t_dpd_status.Text = "";
            t_error_msg.Text = "";
            t_printed.Text = "";
            t_ship_date.Text = "";
            if(dt.Rows.Count>0)
            {
                t_dpd_id.Text = dt.Rows[0]["dpd_id"].ToString();
                t_dpd_status.Text = dt.Rows[0]["status"].ToString(); 
                t_error_msg.Text = dt.Rows[0]["error_msg"].ToString();
                t_printed.Text = dt.Rows[0]["printed"].ToString() == "1" ? "Да" : "Нет";
                t_ship_date.Text = string.Format("{0:dd.MM.yyyy}",dt.Rows[0]["ship_date"]);

            }
        }

        public void get_containers_info(string order_code)
        {
            bool changeCursor = Cursor.Current != Cursors.WaitCursor;
            if (changeCursor)
                Cursor.Current = Cursors.WaitCursor;
            try
            {
                string sql = string.Format("EXEC dpd.get_containers_info @order_code = N'{0}'", order_code);
                DataTable dt = dtExecuteSQL(sql);
                gridControl1.DataSource = dt;
                gridControl1.RefreshDataSource();
            }
            catch (Exception ex)
            {
                logger.Error("{0} | {1}", MethodBase.GetCurrentMethod(), ex.Message);
            }
            if (changeCursor)
                Cursor.Current = Cursors.Default;
        }

        public DataTable dtExecuteSQL(string sql)
        {
            DataTable dt = new DataTable();
            logger.Debug("{0} | {1}", MethodBase.GetCurrentMethod(), sql);
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
            return dt;
        }

    }
}