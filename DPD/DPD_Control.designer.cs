namespace DPD
{
    partial class DPD_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bRefill = new DevExpress.XtraEditors.SimpleButton();
            this.tStatus = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInputDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collvOrderStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceiverName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditAddressItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ShipBoxItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dStart = new DevExpress.XtraEditors.DateEdit();
            this.dEnd = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dSend = new DevExpress.XtraEditors.DateEdit();
            this.bLog = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.grLog = new DevExpress.XtraEditors.GroupControl();
            this.tLog = new DevExpress.XtraEditors.MemoEdit();
            this.bCloseLog = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.showInfo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.cMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSend.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grLog)).BeginInit();
            this.grLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tLog.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bRefill
            // 
            this.bRefill.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bRefill.Location = new System.Drawing.Point(192, 39);
            this.bRefill.Name = "bRefill";
            this.bRefill.Size = new System.Drawing.Size(107, 20);
            this.bRefill.TabIndex = 1;
            this.bRefill.Text = "Обновить Данные";
            this.bRefill.Click += new System.EventHandler(this.bRefill_Click);
            // 
            // tStatus
            // 
            this.tStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.tStatus.Location = new System.Drawing.Point(4, 503);
            this.tStatus.Name = "tStatus";
            this.tStatus.Size = new System.Drawing.Size(927, 14);
            this.tStatus.TabIndex = 5;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(4, 77);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(927, 420);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderCode,
            this.colInputDate,
            this.gridColumn2,
            this.collvOrderStatus,
            this.colReceiverName,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.ShowCloseButton = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.gridView1_PopupMenuShowing);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // colOrderCode
            // 
            this.colOrderCode.Caption = "Номер Заказа";
            this.colOrderCode.FieldName = "OrderCode";
            this.colOrderCode.Name = "colOrderCode";
            this.colOrderCode.OptionsColumn.ReadOnly = true;
            this.colOrderCode.Visible = true;
            this.colOrderCode.VisibleIndex = 0;
            // 
            // colInputDate
            // 
            this.colInputDate.Caption = "Дата Заказа";
            this.colInputDate.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.colInputDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colInputDate.FieldName = "InputDate";
            this.colInputDate.Name = "colInputDate";
            this.colInputDate.OptionsColumn.AllowEdit = false;
            this.colInputDate.OptionsColumn.ReadOnly = true;
            this.colInputDate.Visible = true;
            this.colInputDate.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Дата Выполнения";
            this.gridColumn2.DisplayFormat.FormatString = "dd.MM.yyyy HH:mm";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "ExecuteDate";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // collvOrderStatus
            // 
            this.collvOrderStatus.Caption = "Статус Заказа";
            this.collvOrderStatus.FieldName = "lv_status";
            this.collvOrderStatus.Name = "collvOrderStatus";
            this.collvOrderStatus.OptionsColumn.AllowEdit = false;
            this.collvOrderStatus.OptionsColumn.ReadOnly = true;
            this.collvOrderStatus.Visible = true;
            this.collvOrderStatus.VisibleIndex = 3;
            // 
            // colReceiverName
            // 
            this.colReceiverName.Caption = "ФИО Получателя";
            this.colReceiverName.FieldName = "ReceiverName";
            this.colReceiverName.Name = "colReceiverName";
            this.colReceiverName.OptionsColumn.ReadOnly = true;
            this.colReceiverName.Visible = true;
            this.colReceiverName.VisibleIndex = 4;
            // 
            // cMenu
            // 
            this.cMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditAddressItem,
            this.toolStripSeparator2,
            this.ShipBoxItem,
            this.showInfo});
            this.cMenu.Name = "cMenu";
            this.cMenu.Size = new System.Drawing.Size(209, 98);
            this.cMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cMenu_ItemClicked);
            // 
            // EditAddressItem
            // 
            this.EditAddressItem.Name = "EditAddressItem";
            this.EditAddressItem.Size = new System.Drawing.Size(208, 22);
            this.EditAddressItem.Text = "Изменить адрес в заказе";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // ShipBoxItem
            // 
            this.ShipBoxItem.Name = "ShipBoxItem";
            this.ShipBoxItem.Size = new System.Drawing.Size(208, 22);
            this.ShipBoxItem.Text = "Отгрузить Короба";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(14, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "От";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(101, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(14, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "До";
            // 
            // dStart
            // 
            this.dStart.EditValue = null;
            this.dStart.Location = new System.Drawing.Point(10, 40);
            this.dStart.Name = "dStart";
            this.dStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dStart.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dStart.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.dStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dStart.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.dStart.Size = new System.Drawing.Size(85, 20);
            this.dStart.TabIndex = 18;
            // 
            // dEnd
            // 
            this.dEnd.EditValue = null;
            this.dEnd.Location = new System.Drawing.Point(101, 39);
            this.dEnd.Name = "dEnd";
            this.dEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dEnd.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dEnd.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.dEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dEnd.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.dEnd.Size = new System.Drawing.Size(85, 20);
            this.dEnd.TabIndex = 19;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bRefill);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.dEnd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.dStart);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 68);
            this.groupControl1.TabIndex = 20;
            this.groupControl1.Text = "Период для загрузки заказов";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Controls.Add(this.dSend);
            this.groupControl2.Location = new System.Drawing.Point(323, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(559, 68);
            this.groupControl2.TabIndex = 21;
            this.groupControl2.Text = "Настройка Даты Отгрузки";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(26, 13);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = "Дата";
            // 
            // dSend
            // 
            this.dSend.EditValue = null;
            this.dSend.Location = new System.Drawing.Point(15, 39);
            this.dSend.Name = "dSend";
            this.dSend.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dSend.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dSend.Properties.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.dSend.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dSend.Properties.EditFormat.FormatString = "dd.MM.yyyy";
            this.dSend.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dSend.Properties.Mask.EditMask = "dd.MM.yyyy";
            this.dSend.Size = new System.Drawing.Size(85, 20);
            this.dSend.TabIndex = 19;
            this.dSend.EditValueChanged += new System.EventHandler(this.Send_EditValueChanged);
            // 
            // bLog
            // 
            this.bLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bLog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bLog.Location = new System.Drawing.Point(7, 24);
            this.bLog.Name = "bLog";
            this.bLog.Size = new System.Drawing.Size(29, 20);
            this.bLog.TabIndex = 23;
            this.bLog.Text = "Log";
            this.bLog.Click += new System.EventHandler(this.bLog_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.bLog);
            this.groupControl3.Location = new System.Drawing.Point(888, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(43, 68);
            this.groupControl3.TabIndex = 26;
            this.groupControl3.Text = "Log";
            // 
            // grLog
            // 
            this.grLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grLog.Controls.Add(this.tLog);
            this.grLog.Controls.Add(this.bCloseLog);
            this.grLog.Location = new System.Drawing.Point(625, 3);
            this.grLog.Name = "grLog";
            this.grLog.Size = new System.Drawing.Size(306, 514);
            this.grLog.TabIndex = 27;
            this.grLog.TabStop = true;
            this.grLog.Text = "Сообщения Системы";
            this.grLog.Visible = false;
            // 
            // tLog
            // 
            this.tLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLog.Location = new System.Drawing.Point(5, 50);
            this.tLog.Name = "tLog";
            this.tLog.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tLog.Properties.Appearance.Options.UseBackColor = true;
            this.tLog.Properties.ReadOnly = true;
            this.tLog.Size = new System.Drawing.Size(296, 459);
            this.tLog.TabIndex = 25;
            // 
            // bCloseLog
            // 
            this.bCloseLog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.bCloseLog.Location = new System.Drawing.Point(5, 24);
            this.bCloseLog.Name = "bCloseLog";
            this.bCloseLog.Size = new System.Drawing.Size(62, 20);
            this.bCloseLog.TabIndex = 24;
            this.bCloseLog.Text = "Закрыть";
            this.bCloseLog.Click += new System.EventHandler(this.bCloseLog_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "lv_status_code";
            this.gridColumn1.FieldName = "lv_status_code";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ord_ID";
            this.gridColumn3.FieldName = "ord_ID";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Терминал";
            this.gridColumn4.FieldName = "TerminalNo";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Рег Статус";
            this.gridColumn5.FieldName = "dpd_status";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "error_msg";
            this.gridColumn6.FieldName = "error_msg";
            this.gridColumn6.Name = "gridColumn6";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "printed";
            this.gridColumn7.FieldName = "printed";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "dpd_id";
            this.gridColumn8.FieldName = "dpd_id";
            this.gridColumn8.Name = "gridColumn8";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Дата Отгрузки";
            this.gridColumn9.DisplayFormat.FormatString = "dd.MM.yyyy";
            this.gridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn9.FieldName = "ship_date";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 7;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Мест";
            this.gridColumn10.FieldName = "BoxQty";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 8;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Вес Заказа";
            this.gridColumn11.DisplayFormat.FormatString = "#,##0.000";
            this.gridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn11.FieldName = "TotalWeight";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 9;
            // 
            // showInfo
            // 
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(208, 22);
            this.showInfo.Text = "Доп Инфо";
            // 
            // DPD_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grLog);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.tStatus);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.gridControl1);
            this.Name = "DPD_Control";
            this.Size = new System.Drawing.Size(934, 520);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.cMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSend.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grLog)).EndInit();
            this.grLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tLog.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton bRefill;
        private DevExpress.XtraEditors.LabelControl tStatus;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip cMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ShipBoxItem;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderCode;
        private DevExpress.XtraGrid.Columns.GridColumn colInputDate;
        private DevExpress.XtraGrid.Columns.GridColumn collvOrderStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colReceiverName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dStart;
        private DevExpress.XtraEditors.DateEdit dEnd;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ToolStripMenuItem EditAddressItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dSend;
        private DevExpress.XtraEditors.SimpleButton bLog;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl grLog;
        private DevExpress.XtraEditors.MemoEdit tLog;
        private DevExpress.XtraEditors.SimpleButton bCloseLog;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.ToolStripMenuItem showInfo;
    }
}
