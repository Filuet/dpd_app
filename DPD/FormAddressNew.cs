using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using NLog;
using System.Reflection;
using System.Diagnostics;

namespace DPD
{
    public partial class FormAddressNew : XtraForm
    {
        private string ordNo = "";
        private int typeId = 0;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public FormAddressNew(string OrderCode)
        {
            InitializeComponent();
            this.Text = "Коррекция Адреса для заказа " + OrderCode;
            ordNo = OrderCode;
            FillAddressLVision(OrderCode);
            FillOrderAddress(OrderCode);
        }

        private void FillAddressLVision(string OrderCode)
        {
            string sql = "USE [Lvision]; DECLARE @ord varchar(50);";
            sql += String.Format("SET @ord = N'{0}';", OrderCode);
            sql += "SELECT    t1.ord_TypeID, t2.orr_FullName, t2.orr_Contact, t2.orr_Address, t2.orr_Area, t2.orr_City, t2.orr_ZipCode, t2.orr_Phone FROM LV_Order AS t1 INNER JOIN LV_OrderReceiver AS t2 ON t1.ord_ID = t2.orr_OrderID WHERE (t1.ord_Code = @ord)";
            DataTable dt = dtExecuteSQL(sql);

            if (dt.Rows.Count == 1)
            {
                lNameLV.Text = dt.Rows[0]["orr_FullName"].ToString();
                tNameLV.Text = dt.Rows[0]["orr_FullName"].ToString();

                lAddressLV.Text = dt.Rows[0]["orr_Address"].ToString();
                tAddressLV.Text = dt.Rows[0]["orr_Address"].ToString();

                lCityLV.Text = dt.Rows[0]["orr_City"].ToString();
                tCityLV.Text = dt.Rows[0]["orr_City"].ToString();

                lRegionLV.Text = dt.Rows[0]["orr_Area"].ToString();
                tRegionLV.Text = dt.Rows[0]["orr_Area"].ToString();

                lIndexLV.Text = dt.Rows[0]["orr_ZipCode"].ToString();
                tIndexLV.Text = dt.Rows[0]["orr_ZipCode"].ToString();

                lPhoneLV.Text = dt.Rows[0]["orr_Phone"].ToString();
                tPhoneLV.Text = dt.Rows[0]["orr_Phone"].ToString();

                int.TryParse(dt.Rows[0]["ord_TypeID"].ToString(), out typeId);
            }
        }

        private void FillOrderAddress(string OrderCode)
        {
            string sql = string.Format("EXEC dbo.GetOrderAddressInfo @ordCode = '{0}'", OrderCode);
            DataTable dt = dtExecuteSQL(sql);
            if (dt.Rows.Count == 1)
            {
                tPretty.Text=(dt.Rows[0]["Pretty"]??"").ToString();
                tPrecision.Text= (dt.Rows[0]["Precision"]??"").ToString();
                tRecall.Text= (dt.Rows[0]["Recall"]??"").ToString();
                tWarning.Text= (dt.Rows[0]["Warnings"]??"").ToString();

                if ((dt.Rows[0]["PrecisionAlert"]??"").ToString() == "1")
                    tPrecision.BackColor = Color.LightPink;

                if ((dt.Rows[0]["RecallAlert"] ?? "").ToString() == "1")
                    tRecall.BackColor = Color.LightPink;

                if ((dt.Rows[0]["Warnings"] ?? "").ToString().Length>0)
                    tWarning.BackColor = Color.LightPink;
            }
        }

        public DataTable dtExecuteSQL(string sql)
        {
            DataTable dt = new DataTable();
            //string connStr = string.Format("Server={0};Database={1};User Id={2};Password={3}", Settings.db_sqlServer, Settings.db_dbName, Settings.db_userID, Settings.db_password);
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            string sql = string.Format(@"EXEC [ExchangeDB].[dbo].[Register_UpdateOrderReceiver] 
                @name = N'{0}', 
                @ordNo = N'{1}', 
                @address = N'{2}',
		        @reg = N'{3}',
		        @city = N'{4}',
		        @index = N'{5}',
		        @phone = N'{6}'", tNameLV.Text, ordNo, tAddressLV.Text, tRegionLV.Text, tCityLV.Text, tIndexLV.Text, tPhoneLV.Text);
            DataTable dt = dtExecuteSQL(sql);
            Close();
        }

        private void textEdit_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit te = (TextEdit)sender;
            int l = 0;
            switch (te.Name)
            {
                case "tNameLV":
                case "tPhoneLV":
                    l = 64;
                    break;
                case "tAddressLV":
                    l = 100;
                    break;
                case "tCityLV":
                case "tRegionLV":
                    l = 32;
                    break;
                case "tIndexLV":
                    l = 10;
                    break;
            }

            if (te.Text.Length > l)
                te.BackColor = Color.LightPink;
            else
                te.BackColor = Color.White;

        }

        private void bEmail_Click(object sender, EventArgs e)
        {
            string msg = String.Format("Добрый день.\r\n\r\nОбнаружена ошибка в данных получателя заказа {0}.\r\n\r\n", ordNo);
            msg += "Данные в заказе:\r\n";
            msg += String.Format("Имя: {0}\r\n", lNameLV.Text);
            msg += String.Format("Адрес: {0}\r\n", lAddressLV.Text);
            msg += String.Format("Город: {0}\r\n", lCityLV.Text);
            msg += String.Format("Область: {0}\r\n", lRegionLV.Text);
            msg += String.Format("Индекс: {0}\r\n", lIndexLV.Text);
            msg += String.Format("Телефон: {0}\r\n", lPhoneLV.Text);

            msg += "\r\nПрошу скорректировать данные получателя заказа.\r\n\r\n";
            string cmd = Uri.EscapeUriString(string.Format("mailto:lenaA@herbalife.com;ValeriaB@herbalife.com;Alesiao@herbalife.com&cc=inna.chernetskaya@filuet.ru;operator.2@filuet.ru;AfterSalesGroupRussia@herbalife.com&subject=Address Correction (Order {0})&body={1}", ordNo,msg));
            System.Diagnostics.Process.Start(cmd);
        }
    }
}

