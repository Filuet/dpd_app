namespace DPD
{
    partial class FormInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.t_dpd_status = new DevExpress.XtraEditors.TextEdit();
            this.t_ship_date = new DevExpress.XtraEditors.TextEdit();
            this.t_printed = new DevExpress.XtraEditors.TextEdit();
            this.t_dpd_id = new DevExpress.XtraEditors.TextEdit();
            this.t_error_msg = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.t_dpd_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ship_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_printed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_dpd_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_error_msg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 93);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ДПД Статус";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 41);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(77, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Дата Отгрузки";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 67);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(159, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Печать этикеток при упаковке";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 15);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(46, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "ДПД Код";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 119);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(114, 13);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Сообщение об ошибке";
            // 
            // t_dpd_status
            // 
            this.t_dpd_status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_dpd_status.Location = new System.Drawing.Point(192, 90);
            this.t_dpd_status.Name = "t_dpd_status";
            this.t_dpd_status.Properties.ReadOnly = true;
            this.t_dpd_status.Size = new System.Drawing.Size(273, 20);
            this.t_dpd_status.TabIndex = 7;
            // 
            // t_ship_date
            // 
            this.t_ship_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_ship_date.Location = new System.Drawing.Point(192, 38);
            this.t_ship_date.Name = "t_ship_date";
            this.t_ship_date.Properties.ReadOnly = true;
            this.t_ship_date.Size = new System.Drawing.Size(273, 20);
            this.t_ship_date.TabIndex = 8;
            // 
            // t_printed
            // 
            this.t_printed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_printed.Location = new System.Drawing.Point(192, 64);
            this.t_printed.Name = "t_printed";
            this.t_printed.Properties.ReadOnly = true;
            this.t_printed.Size = new System.Drawing.Size(273, 20);
            this.t_printed.TabIndex = 9;
            // 
            // t_dpd_id
            // 
            this.t_dpd_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_dpd_id.Location = new System.Drawing.Point(192, 12);
            this.t_dpd_id.Name = "t_dpd_id";
            this.t_dpd_id.Properties.ReadOnly = true;
            this.t_dpd_id.Size = new System.Drawing.Size(273, 20);
            this.t_dpd_id.TabIndex = 10;
            // 
            // t_error_msg
            // 
            this.t_error_msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_error_msg.Location = new System.Drawing.Point(12, 138);
            this.t_error_msg.Name = "t_error_msg";
            this.t_error_msg.Properties.ReadOnly = true;
            this.t_error_msg.Size = new System.Drawing.Size(453, 100);
            this.t_error_msg.TabIndex = 11;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 244);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(141, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Информация о контейнерах";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 263);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(453, 266);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "SSCC";
            this.gridColumn1.FieldName = "SSCC";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Вес";
            this.gridColumn2.DisplayFormat.FormatString = "0.000";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "GrossWeight";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Габариты";
            this.gridColumn3.FieldName = "Size";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 541);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.t_error_msg);
            this.Controls.Add(this.t_dpd_id);
            this.Controls.Add(this.t_printed);
            this.Controls.Add(this.t_ship_date);
            this.Controls.Add(this.t_dpd_status);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl1);
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            ((System.ComponentModel.ISupportInitialize)(this.t_dpd_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_ship_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_printed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_dpd_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_error_msg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit t_dpd_status;
        private DevExpress.XtraEditors.TextEdit t_ship_date;
        private DevExpress.XtraEditors.TextEdit t_printed;
        private DevExpress.XtraEditors.TextEdit t_dpd_id;
        private DevExpress.XtraEditors.MemoEdit t_error_msg;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}