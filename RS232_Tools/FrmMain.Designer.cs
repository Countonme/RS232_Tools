namespace RS232_Tools
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.uiGroupBox3 = new Sunny.UI.UIGroupBox();
            this.txtLog = new Sunny.UI.UIRichTextBox();
            this.SendArea = new Sunny.UI.UIGroupBox();
            this.btnSendByte = new Sunny.UI.UISymbolButton();
            this.btnSendString = new Sunny.UI.UISymbolButton();
            this.cbLF = new System.Windows.Forms.CheckBox();
            this.cbCR = new System.Windows.Forms.CheckBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.txtmessage = new Sunny.UI.UITextBox();
            this.btnClose = new Sunny.UI.UISymbolButton();
            this.btnOpen = new Sunny.UI.UISymbolButton();
            this.uiLedBulb1 = new Sunny.UI.UILedBulb();
            this.comboxDataBit = new Sunny.UI.UIComboBox();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.comboxHandshake = new Sunny.UI.UIComboBox();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.comboxStopBits = new Sunny.UI.UIComboBox();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.comParity = new Sunny.UI.UIComboBox();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.baudRate = new Sunny.UI.UIComboBox();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.cbComlist = new Sunny.UI.UIComboBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.uiGroupBox3.SuspendLayout();
            this.SendArea.SuspendLayout();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox3
            // 
            this.uiGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox3.Controls.Add(this.txtLog);
            this.uiGroupBox3.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiGroupBox3.Location = new System.Drawing.Point(4, 152);
            this.uiGroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox3.Name = "uiGroupBox3";
            this.uiGroupBox3.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox3.Size = new System.Drawing.Size(544, 294);
            this.uiGroupBox3.TabIndex = 1;
            this.uiGroupBox3.Text = "接收区";
            this.uiGroupBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.FillColor = System.Drawing.Color.White;
            this.txtLog.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLog.Location = new System.Drawing.Point(0, 32);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtLog.Name = "txtLog";
            this.txtLog.Padding = new System.Windows.Forms.Padding(2);
            this.txtLog.ShowText = false;
            this.txtLog.Size = new System.Drawing.Size(544, 262);
            this.txtLog.TabIndex = 0;
            this.txtLog.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SendArea
            // 
            this.SendArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendArea.Controls.Add(this.btnSendByte);
            this.SendArea.Controls.Add(this.btnSendString);
            this.SendArea.Controls.Add(this.cbLF);
            this.SendArea.Controls.Add(this.cbCR);
            this.SendArea.Controls.Add(this.uiLabel1);
            this.SendArea.Controls.Add(this.txtmessage);
            this.SendArea.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SendArea.Location = new System.Drawing.Point(4, 9);
            this.SendArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendArea.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendArea.Name = "SendArea";
            this.SendArea.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.SendArea.Size = new System.Drawing.Size(544, 133);
            this.SendArea.TabIndex = 0;
            this.SendArea.Text = "发送区";
            this.SendArea.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSendByte
            // 
            this.btnSendByte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendByte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendByte.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSendByte.Location = new System.Drawing.Point(381, 95);
            this.btnSendByte.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendByte.Name = "btnSendByte";
            this.btnSendByte.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSendByte.Size = new System.Drawing.Size(142, 35);
            this.btnSendByte.Style = Sunny.UI.UIStyle.Custom;
            this.btnSendByte.StyleCustomMode = true;
            this.btnSendByte.Symbol = 261912;
            this.btnSendByte.TabIndex = 83;
            this.btnSendByte.Text = "Send(Byte)";
            this.btnSendByte.TipsFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnSendString
            // 
            this.btnSendString.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendString.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendString.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnSendString.Location = new System.Drawing.Point(217, 95);
            this.btnSendString.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSendString.Name = "btnSendString";
            this.btnSendString.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSendString.Size = new System.Drawing.Size(123, 35);
            this.btnSendString.Style = Sunny.UI.UIStyle.Custom;
            this.btnSendString.StyleCustomMode = true;
            this.btnSendString.Symbol = 261912;
            this.btnSendString.TabIndex = 82;
            this.btnSendString.Text = "Send(String)";
            this.btnSendString.TipsFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // cbLF
            // 
            this.cbLF.AutoSize = true;
            this.cbLF.Location = new System.Drawing.Point(111, 86);
            this.cbLF.Name = "cbLF";
            this.cbLF.Size = new System.Drawing.Size(43, 20);
            this.cbLF.TabIndex = 12;
            this.cbLF.Text = "LF";
            this.cbLF.UseVisualStyleBackColor = true;
            // 
            // cbCR
            // 
            this.cbCR.AutoSize = true;
            this.cbCR.Location = new System.Drawing.Point(59, 86);
            this.cbCR.Name = "cbCR";
            this.cbCR.Size = new System.Drawing.Size(46, 20);
            this.cbCR.TabIndex = 11;
            this.cbCR.Text = "CR";
            this.cbCR.UseVisualStyleBackColor = true;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(3, 37);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(49, 17);
            this.uiLabel1.TabIndex = 10;
            this.uiLabel1.Text = "Msg:";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmessage
            // 
            this.txtmessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmessage.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtmessage.Location = new System.Drawing.Point(59, 32);
            this.txtmessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmessage.MinimumSize = new System.Drawing.Size(1, 16);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Padding = new System.Windows.Forms.Padding(5);
            this.txtmessage.ShowText = false;
            this.txtmessage.Size = new System.Drawing.Size(481, 29);
            this.txtmessage.TabIndex = 0;
            this.txtmessage.Text = "LON";
            this.txtmessage.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtmessage.Watermark = "";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnClose.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnClose.Location = new System.Drawing.Point(161, 276);
            this.btnClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnClose.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.Style = Sunny.UI.UIStyle.Custom;
            this.btnClose.StyleCustomMode = true;
            this.btnClose.Symbol = 361453;
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Close";
            this.btnClose.TipsFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Font = new System.Drawing.Font("SimSun", 12F);
            this.btnOpen.Location = new System.Drawing.Point(47, 276);
            this.btnOpen.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 35);
            this.btnOpen.Style = Sunny.UI.UIStyle.Custom;
            this.btnOpen.StyleCustomMode = true;
            this.btnOpen.TabIndex = 81;
            this.btnOpen.Text = "Open";
            this.btnOpen.TipsFont = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiLedBulb1
            // 
            this.uiLedBulb1.Color = System.Drawing.Color.Red;
            this.uiLedBulb1.Location = new System.Drawing.Point(229, 23);
            this.uiLedBulb1.Name = "uiLedBulb1";
            this.uiLedBulb1.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb1.TabIndex = 56;
            this.uiLedBulb1.Text = "uiLedBulb1";
            // 
            // comboxDataBit
            // 
            this.comboxDataBit.DataSource = null;
            this.comboxDataBit.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboxDataBit.FillColor = System.Drawing.Color.White;
            this.comboxDataBit.Font = new System.Drawing.Font("SimSun", 12F);
            this.comboxDataBit.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboxDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboxDataBit.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboxDataBit.Location = new System.Drawing.Point(101, 222);
            this.comboxDataBit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxDataBit.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboxDataBit.Name = "comboxDataBit";
            this.comboxDataBit.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboxDataBit.Size = new System.Drawing.Size(160, 23);
            this.comboxDataBit.SymbolSize = 24;
            this.comboxDataBit.TabIndex = 55;
            this.comboxDataBit.Text = "8";
            this.comboxDataBit.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboxDataBit.Watermark = "";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(10, 225);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(88, 17);
            this.uiLabel10.TabIndex = 54;
            this.uiLabel10.Text = "Data Bits:";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboxHandshake
            // 
            this.comboxHandshake.DataSource = null;
            this.comboxHandshake.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboxHandshake.FillColor = System.Drawing.Color.White;
            this.comboxHandshake.Font = new System.Drawing.Font("SimSun", 12F);
            this.comboxHandshake.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboxHandshake.Items.AddRange(new object[] {
            "None",
            "XOnXOff",
            "RequestToSend",
            "RequestToSendXOnXOff"});
            this.comboxHandshake.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboxHandshake.Location = new System.Drawing.Point(101, 190);
            this.comboxHandshake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxHandshake.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboxHandshake.Name = "comboxHandshake";
            this.comboxHandshake.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboxHandshake.Size = new System.Drawing.Size(160, 23);
            this.comboxHandshake.SymbolSize = 24;
            this.comboxHandshake.TabIndex = 21;
            this.comboxHandshake.Text = "None";
            this.comboxHandshake.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboxHandshake.Watermark = "";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(10, 193);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(88, 17);
            this.uiLabel9.TabIndex = 20;
            this.uiLabel9.Text = "Handshake:";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboxStopBits
            // 
            this.comboxStopBits.DataSource = null;
            this.comboxStopBits.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comboxStopBits.FillColor = System.Drawing.Color.White;
            this.comboxStopBits.Font = new System.Drawing.Font("SimSun", 12F);
            this.comboxStopBits.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comboxStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboxStopBits.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comboxStopBits.Location = new System.Drawing.Point(101, 157);
            this.comboxStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboxStopBits.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboxStopBits.Name = "comboxStopBits";
            this.comboxStopBits.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboxStopBits.Size = new System.Drawing.Size(160, 23);
            this.comboxStopBits.SymbolSize = 24;
            this.comboxStopBits.TabIndex = 19;
            this.comboxStopBits.Text = "1";
            this.comboxStopBits.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboxStopBits.Watermark = "";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(10, 161);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(88, 17);
            this.uiLabel8.TabIndex = 18;
            this.uiLabel8.Text = "StopBits:";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comParity
            // 
            this.comParity.DataSource = null;
            this.comParity.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.comParity.FillColor = System.Drawing.Color.White;
            this.comParity.Font = new System.Drawing.Font("SimSun", 12F);
            this.comParity.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.comParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comParity.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.comParity.Location = new System.Drawing.Point(101, 124);
            this.comParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comParity.MinimumSize = new System.Drawing.Size(63, 0);
            this.comParity.Name = "comParity";
            this.comParity.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comParity.Size = new System.Drawing.Size(160, 23);
            this.comParity.SymbolSize = 24;
            this.comParity.TabIndex = 17;
            this.comParity.Text = "None";
            this.comParity.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comParity.Watermark = "";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(10, 129);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(88, 17);
            this.uiLabel7.TabIndex = 16;
            this.uiLabel7.Text = "Parity:";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baudRate
            // 
            this.baudRate.DataSource = null;
            this.baudRate.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.baudRate.FillColor = System.Drawing.Color.White;
            this.baudRate.Font = new System.Drawing.Font("SimSun", 12F);
            this.baudRate.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.baudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRate.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.baudRate.Location = new System.Drawing.Point(101, 91);
            this.baudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudRate.MinimumSize = new System.Drawing.Size(63, 0);
            this.baudRate.Name = "baudRate";
            this.baudRate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.baudRate.Size = new System.Drawing.Size(160, 23);
            this.baudRate.SymbolSize = 24;
            this.baudRate.TabIndex = 15;
            this.baudRate.Text = "115200";
            this.baudRate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.baudRate.Watermark = "";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(10, 97);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(88, 17);
            this.uiLabel6.TabIndex = 14;
            this.uiLabel6.Text = "Baudrate:";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(10, 65);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(88, 17);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "Port:";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.btnClose);
            this.uiGroupBox1.Controls.Add(this.btnOpen);
            this.uiGroupBox1.Controls.Add(this.uiLedBulb1);
            this.uiGroupBox1.Controls.Add(this.comboxDataBit);
            this.uiGroupBox1.Controls.Add(this.uiLabel10);
            this.uiGroupBox1.Controls.Add(this.comboxHandshake);
            this.uiGroupBox1.Controls.Add(this.uiLabel9);
            this.uiGroupBox1.Controls.Add(this.comboxStopBits);
            this.uiGroupBox1.Controls.Add(this.uiLabel8);
            this.uiGroupBox1.Controls.Add(this.comParity);
            this.uiGroupBox1.Controls.Add(this.uiLabel7);
            this.uiGroupBox1.Controls.Add(this.baudRate);
            this.uiGroupBox1.Controls.Add(this.uiLabel6);
            this.uiGroupBox1.Controls.Add(this.cbComlist);
            this.uiGroupBox1.Controls.Add(this.uiLabel5);
            this.uiGroupBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiGroupBox1.Location = new System.Drawing.Point(4, 15);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.Size = new System.Drawing.Size(269, 436);
            this.uiGroupBox1.TabIndex = 4;
            this.uiGroupBox1.Text = "Serial Port Setting ";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbComlist
            // 
            this.cbComlist.DataSource = null;
            this.cbComlist.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.cbComlist.FillColor = System.Drawing.Color.White;
            this.cbComlist.Font = new System.Drawing.Font("SimSun", 12F);
            this.cbComlist.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.cbComlist.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.cbComlist.Location = new System.Drawing.Point(101, 63);
            this.cbComlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbComlist.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbComlist.Name = "cbComlist";
            this.cbComlist.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbComlist.Size = new System.Drawing.Size(160, 23);
            this.cbComlist.SymbolSize = 24;
            this.cbComlist.TabIndex = 13;
            this.cbComlist.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbComlist.Watermark = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 59);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.uiGroupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.uiGroupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.SendArea);
            this.splitContainer1.Size = new System.Drawing.Size(833, 447);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 6;
            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.rToolStripMenuItem.Text = "RefreshSserialPort";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 35);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(833, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "RS232 Testing Tools";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 565, 450);
            this.uiGroupBox3.ResumeLayout(false);
            this.SendArea.ResumeLayout(false);
            this.SendArea.PerformLayout();
            this.uiGroupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox3;
        private Sunny.UI.UIRichTextBox txtLog;
        private Sunny.UI.UIGroupBox SendArea;
        private Sunny.UI.UISymbolButton btnSendByte;
        private Sunny.UI.UISymbolButton btnSendString;
        private System.Windows.Forms.CheckBox cbLF;
        private System.Windows.Forms.CheckBox cbCR;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtmessage;
        private Sunny.UI.UISymbolButton btnClose;
        private Sunny.UI.UISymbolButton btnOpen;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UIComboBox comboxDataBit;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIComboBox comboxHandshake;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UIComboBox comboxStopBits;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UIComboBox comParity;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UIComboBox baudRate;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIComboBox cbComlist;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

