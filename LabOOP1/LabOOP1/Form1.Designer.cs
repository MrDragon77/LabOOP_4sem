namespace LabOOP1
{
    partial class form_Main
    {
        public static int label_ColorQueueMouse = 0;
        public static int label_ColorQueueTimer = 0;
        public static int pic_CatQueue = 0;
        public static int mouseLastX = 801;
        public static int mouseLastY = 601;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.btn_IncProgBar = new System.Windows.Forms.Button();
            this.btn_DecProgBar = new System.Windows.Forms.Button();
            this.progBar_IncDecByBtns = new System.Windows.Forms.ProgressBar();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.chkBox_blockTxtBox = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox_FavDates = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_DateChooser = new System.Windows.Forms.DateTimePicker();
            this.maskedTxtBox_Date = new System.Windows.Forms.MaskedTextBox();
            this.lb_DataExplainText = new System.Windows.Forms.Label();
            this.chkBox_ShowDate = new System.Windows.Forms.CheckBox();
            this.groupBox_Date = new System.Windows.Forms.GroupBox();
            this.radioBtn_setUpPic = new System.Windows.Forms.RadioButton();
            this.radioBtn_setDownPic = new System.Windows.Forms.RadioButton();
            this.label_ChngColors_Mouse = new System.Windows.Forms.Label();
            this.listBox_ChngColorsMouse = new System.Windows.Forms.ListBox();
            this.pic_RunningCat = new System.Windows.Forms.PictureBox();
            this.timer_forLabelChngColors_Timer = new System.Windows.Forms.Timer(this.components);
            this.label_ChngColors_Timer = new System.Windows.Forms.Label();
            this.listBox_ChngColorsTimer = new System.Windows.Forms.ListBox();
            this.notyficon_Meow = new System.Windows.Forms.NotifyIcon(this.components);
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.pic_Meow = new System.Windows.Forms.PictureBox();
            this.linkLabel_BigCat = new System.Windows.Forms.LinkLabel();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuItem_redBackGround = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_CatBackGroundFar = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuItem_DeleteText = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.MainMenu_CheckBox_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu_Cats_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCat1_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCat2_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Meow = new System.Windows.Forms.Label();
            this.checkedListBox_Menu = new System.Windows.Forms.CheckedListBox();
            this.richTextBox_AutoWrite = new System.Windows.Forms.RichTextBox();
            this.btn_AutoWrite_Ya = new System.Windows.Forms.Button();
            this.btn_AutoWrite_Idu = new System.Windows.Forms.Button();
            this.btn_AutoWrite_Domoj = new System.Windows.Forms.Button();
            this.label_FormWidth = new System.Windows.Forms.Label();
            this.groupBox_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RunningCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Meow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IncProgBar
            // 
            this.btn_IncProgBar.Location = new System.Drawing.Point(15, 39);
            this.btn_IncProgBar.Name = "btn_IncProgBar";
            this.btn_IncProgBar.Size = new System.Drawing.Size(94, 29);
            this.btn_IncProgBar.TabIndex = 0;
            this.btn_IncProgBar.Text = "Increase";
            this.btn_IncProgBar.UseVisualStyleBackColor = true;
            this.btn_IncProgBar.Click += new System.EventHandler(this.btn_IncProgBar_Click);
            // 
            // btn_DecProgBar
            // 
            this.btn_DecProgBar.Location = new System.Drawing.Point(115, 39);
            this.btn_DecProgBar.Name = "btn_DecProgBar";
            this.btn_DecProgBar.Size = new System.Drawing.Size(94, 29);
            this.btn_DecProgBar.TabIndex = 1;
            this.btn_DecProgBar.Text = "Decrease";
            this.btn_DecProgBar.UseVisualStyleBackColor = true;
            this.btn_DecProgBar.Click += new System.EventHandler(this.btn_DecProgBar_Click);
            // 
            // progBar_IncDecByBtns
            // 
            this.progBar_IncDecByBtns.Location = new System.Drawing.Point(15, 74);
            this.progBar_IncDecByBtns.Name = "progBar_IncDecByBtns";
            this.progBar_IncDecByBtns.Size = new System.Drawing.Size(194, 29);
            this.progBar_IncDecByBtns.TabIndex = 2;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(15, 157);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(194, 27);
            this.txtBox.TabIndex = 3;
            this.txtBox.Text = "Поле с текстом";
            // 
            // chkBox_blockTxtBox
            // 
            this.chkBox_blockTxtBox.AutoSize = true;
            this.chkBox_blockTxtBox.Location = new System.Drawing.Point(15, 190);
            this.chkBox_blockTxtBox.Name = "chkBox_blockTxtBox";
            this.chkBox_blockTxtBox.Size = new System.Drawing.Size(127, 24);
            this.chkBox_blockTxtBox.TabIndex = 4;
            this.chkBox_blockTxtBox.Text = "Block Text Box";
            this.toolTip.SetToolTip(this.chkBox_blockTxtBox, "Заблокировать изменение поля ввода выше");
            this.chkBox_blockTxtBox.UseVisualStyleBackColor = true;
            this.chkBox_blockTxtBox.CheckedChanged += new System.EventHandler(this.chkBox_blockTxtBox_CheckedChanged);
            // 
            // comboBox_FavDates
            // 
            this.comboBox_FavDates.FormattingEnabled = true;
            this.comboBox_FavDates.Items.AddRange(new object[] {
            "Мин Дата",
            "Макс Дата"});
            this.comboBox_FavDates.Location = new System.Drawing.Point(11, 54);
            this.comboBox_FavDates.Name = "comboBox_FavDates";
            this.comboBox_FavDates.Size = new System.Drawing.Size(151, 28);
            this.comboBox_FavDates.TabIndex = 8;
            this.comboBox_FavDates.Visible = false;
            this.comboBox_FavDates.SelectedIndexChanged += new System.EventHandler(this.comboBox_FavDates_SelectedIndexChanged);
            // 
            // dateTimePicker_DateChooser
            // 
            this.dateTimePicker_DateChooser.Location = new System.Drawing.Point(11, 121);
            this.dateTimePicker_DateChooser.Name = "dateTimePicker_DateChooser";
            this.dateTimePicker_DateChooser.Size = new System.Drawing.Size(201, 27);
            this.dateTimePicker_DateChooser.TabIndex = 9;
            this.dateTimePicker_DateChooser.Visible = false;
            // 
            // maskedTxtBox_Date
            // 
            this.maskedTxtBox_Date.Location = new System.Drawing.Point(11, 88);
            this.maskedTxtBox_Date.Mask = "00/00/0000";
            this.maskedTxtBox_Date.Name = "maskedTxtBox_Date";
            this.maskedTxtBox_Date.Size = new System.Drawing.Size(125, 27);
            this.maskedTxtBox_Date.TabIndex = 10;
            this.maskedTxtBox_Date.ValidatingType = typeof(System.DateTime);
            this.maskedTxtBox_Date.Visible = false;
            // 
            // lb_DataExplainText
            // 
            this.lb_DataExplainText.AutoSize = true;
            this.lb_DataExplainText.Location = new System.Drawing.Point(11, 31);
            this.lb_DataExplainText.Name = "lb_DataExplainText";
            this.lb_DataExplainText.Size = new System.Drawing.Size(79, 20);
            this.lb_DataExplainText.TabIndex = 11;
            this.lb_DataExplainText.Text = "Enter Date";
            // 
            // chkBox_ShowDate
            // 
            this.chkBox_ShowDate.AutoSize = true;
            this.chkBox_ShowDate.Location = new System.Drawing.Point(96, 27);
            this.chkBox_ShowDate.Name = "chkBox_ShowDate";
            this.chkBox_ShowDate.Size = new System.Drawing.Size(90, 24);
            this.chkBox_ShowDate.TabIndex = 12;
            this.chkBox_ShowDate.Text = "show me";
            this.chkBox_ShowDate.UseVisualStyleBackColor = true;
            this.chkBox_ShowDate.CheckedChanged += new System.EventHandler(this.chkBox_ShowDate_CheckedChanged);
            // 
            // groupBox_Date
            // 
            this.groupBox_Date.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox_Date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox_Date.Controls.Add(this.chkBox_ShowDate);
            this.groupBox_Date.Controls.Add(this.lb_DataExplainText);
            this.groupBox_Date.Controls.Add(this.maskedTxtBox_Date);
            this.groupBox_Date.Controls.Add(this.dateTimePicker_DateChooser);
            this.groupBox_Date.Controls.Add(this.comboBox_FavDates);
            this.groupBox_Date.Location = new System.Drawing.Point(231, 39);
            this.groupBox_Date.Name = "groupBox_Date";
            this.groupBox_Date.Size = new System.Drawing.Size(227, 157);
            this.groupBox_Date.TabIndex = 13;
            this.groupBox_Date.TabStop = false;
            this.groupBox_Date.Text = "Date Group Box";
            // 
            // radioBtn_setUpPic
            // 
            this.radioBtn_setUpPic.AutoSize = true;
            this.radioBtn_setUpPic.Location = new System.Drawing.Point(483, 39);
            this.radioBtn_setUpPic.Name = "radioBtn_setUpPic";
            this.radioBtn_setUpPic.Size = new System.Drawing.Size(156, 24);
            this.radioBtn_setUpPic.TabIndex = 14;
            this.radioBtn_setUpPic.Text = "Картинка на фоне";
            this.radioBtn_setUpPic.UseVisualStyleBackColor = true;
            this.radioBtn_setUpPic.CheckedChanged += new System.EventHandler(this.radioBtn_setUpPic_CheckedChanged);
            // 
            // radioBtn_setDownPic
            // 
            this.radioBtn_setDownPic.AutoSize = true;
            this.radioBtn_setDownPic.Checked = true;
            this.radioBtn_setDownPic.Location = new System.Drawing.Point(483, 66);
            this.radioBtn_setDownPic.Name = "radioBtn_setDownPic";
            this.radioBtn_setDownPic.Size = new System.Drawing.Size(145, 24);
            this.radioBtn_setDownPic.TabIndex = 15;
            this.radioBtn_setDownPic.TabStop = true;
            this.radioBtn_setDownPic.Text = "Убрать картинку";
            this.radioBtn_setDownPic.UseVisualStyleBackColor = true;
            this.radioBtn_setDownPic.CheckedChanged += new System.EventHandler(this.radioBtn_setDownPic_CheckedChanged);
            // 
            // label_ChngColors_Mouse
            // 
            this.label_ChngColors_Mouse.AutoSize = true;
            this.label_ChngColors_Mouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_ChngColors_Mouse.Location = new System.Drawing.Point(514, 108);
            this.label_ChngColors_Mouse.Name = "label_ChngColors_Mouse";
            this.label_ChngColors_Mouse.Size = new System.Drawing.Size(195, 20);
            this.label_ChngColors_Mouse.TabIndex = 16;
            this.label_ChngColors_Mouse.Text = "I change my color by mouse";
            this.label_ChngColors_Mouse.Paint += new System.Windows.Forms.PaintEventHandler(this.label_ChngColors_Mouse_Paint);
            this.label_ChngColors_Mouse.MouseEnter += new System.EventHandler(this.label_ChngColors_MouseEnter);
            // 
            // listBox_ChngColorsMouse
            // 
            this.listBox_ChngColorsMouse.FormattingEnabled = true;
            this.listBox_ChngColorsMouse.ItemHeight = 20;
            this.listBox_ChngColorsMouse.Items.AddRange(new object[] {
            "1",
            "1",
            "1"});
            this.listBox_ChngColorsMouse.Location = new System.Drawing.Point(514, 148);
            this.listBox_ChngColorsMouse.Name = "listBox_ChngColorsMouse";
            this.listBox_ChngColorsMouse.Size = new System.Drawing.Size(150, 64);
            this.listBox_ChngColorsMouse.TabIndex = 17;
            // 
            // pic_RunningCat
            // 
            this.pic_RunningCat.Image = global::LabOOP1.Properties.Resources.running_cat;
            this.pic_RunningCat.Location = new System.Drawing.Point(305, 360);
            this.pic_RunningCat.Name = "pic_RunningCat";
            this.pic_RunningCat.Size = new System.Drawing.Size(72, 72);
            this.pic_RunningCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_RunningCat.TabIndex = 18;
            this.pic_RunningCat.TabStop = false;
            this.pic_RunningCat.Click += new System.EventHandler(this.pic_RunningCat_Click);
            // 
            // timer_forLabelChngColors_Timer
            // 
            this.timer_forLabelChngColors_Timer.Enabled = true;
            this.timer_forLabelChngColors_Timer.Tick += new System.EventHandler(this.label_ChngColors_MouseEnter);
            // 
            // label_ChngColors_Timer
            // 
            this.label_ChngColors_Timer.AutoSize = true;
            this.label_ChngColors_Timer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_ChngColors_Timer.Location = new System.Drawing.Point(514, 252);
            this.label_ChngColors_Timer.Name = "label_ChngColors_Timer";
            this.label_ChngColors_Timer.Size = new System.Drawing.Size(217, 20);
            this.label_ChngColors_Timer.TabIndex = 19;
            this.label_ChngColors_Timer.Text = "And I change my color by timer";
            this.label_ChngColors_Timer.Paint += new System.Windows.Forms.PaintEventHandler(this.label_ChngColors_Timer_Paint);
            // 
            // listBox_ChngColorsTimer
            // 
            this.listBox_ChngColorsTimer.FormattingEnabled = true;
            this.listBox_ChngColorsTimer.ItemHeight = 20;
            this.listBox_ChngColorsTimer.Items.AddRange(new object[] {
            "1",
            "1",
            "1"});
            this.listBox_ChngColorsTimer.Location = new System.Drawing.Point(514, 288);
            this.listBox_ChngColorsTimer.Name = "listBox_ChngColorsTimer";
            this.listBox_ChngColorsTimer.Size = new System.Drawing.Size(150, 64);
            this.listBox_ChngColorsTimer.TabIndex = 20;
            // 
            // notyficon_Meow
            // 
            this.notyficon_Meow.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notyficon_Meow.BalloonTipText = "мяу!!!";
            this.notyficon_Meow.BalloonTipTitle = "Мяу?";
            this.notyficon_Meow.Icon = ((System.Drawing.Icon)(resources.GetObject("notyficon_Meow.Icon")));
            this.notyficon_Meow.Text = "МЯУ";
            this.notyficon_Meow.Visible = true;
            this.notyficon_Meow.Click += new System.EventHandler(this.notyficon_Meow_Click);
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Y.Location = new System.Drawing.Point(465, 403);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_Y.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(55, 27);
            this.numericUpDown_Y.TabIndex = 21;
            this.numericUpDown_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown_Y.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown_Y.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_Y.ValueChanged += new System.EventHandler(this.numericUpDown_Y_ValueChanged);
            // 
            // pic_Meow
            // 
            this.pic_Meow.Image = global::LabOOP1.Properties.Resources.meow;
            this.pic_Meow.Location = new System.Drawing.Point(538, 403);
            this.pic_Meow.Name = "pic_Meow";
            this.pic_Meow.Size = new System.Drawing.Size(50, 50);
            this.pic_Meow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Meow.TabIndex = 22;
            this.pic_Meow.TabStop = false;
            this.pic_Meow.Click += new System.EventHandler(this.pic_Meow_Click);
            this.pic_Meow.Resize += new System.EventHandler(this.pic_Meow_Resize);
            // 
            // linkLabel_BigCat
            // 
            this.linkLabel_BigCat.AutoSize = true;
            this.linkLabel_BigCat.Location = new System.Drawing.Point(15, 127);
            this.linkLabel_BigCat.Name = "linkLabel_BigCat";
            this.linkLabel_BigCat.Size = new System.Drawing.Size(80, 20);
            this.linkLabel_BigCat.TabIndex = 23;
            this.linkLabel_BigCat.TabStop = true;
            this.linkLabel_BigCat.Text = "Don\'t Click";
            this.linkLabel_BigCat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_BigCat_LinkClicked);
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_X.Location = new System.Drawing.Point(538, 360);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_X.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown_X.Size = new System.Drawing.Size(57, 27);
            this.numericUpDown_X.TabIndex = 24;
            this.numericUpDown_X.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_X.ValueChanged += new System.EventHandler(this.numericUpDown_X_ValueChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuItem_redBackGround,
            this.contextMenuItem_CatBackGroundFar,
            this.contextMenuItem_DeleteText});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(180, 76);
            // 
            // contextMenuItem_redBackGround
            // 
            this.contextMenuItem_redBackGround.Name = "contextMenuItem_redBackGround";
            this.contextMenuItem_redBackGround.Size = new System.Drawing.Size(179, 24);
            this.contextMenuItem_redBackGround.Text = "Красный фон";
            this.contextMenuItem_redBackGround.Click += new System.EventHandler(this.contextMenuItem_redBackGround_Click);
            // 
            // contextMenuItem_CatBackGroundFar
            // 
            this.contextMenuItem_CatBackGroundFar.Name = "contextMenuItem_CatBackGroundFar";
            this.contextMenuItem_CatBackGroundFar.Size = new System.Drawing.Size(179, 24);
            this.contextMenuItem_CatBackGroundFar.Text = "Котик на фоне";
            this.contextMenuItem_CatBackGroundFar.Click += new System.EventHandler(this.contextMenuItem_CatBackGroundFar_Click);
            // 
            // contextMenuItem_DeleteText
            // 
            this.contextMenuItem_DeleteText.Name = "contextMenuItem_DeleteText";
            this.contextMenuItem_DeleteText.Size = new System.Drawing.Size(179, 24);
            this.contextMenuItem_DeleteText.Text = "Удалить текст";
            this.contextMenuItem_DeleteText.Click += new System.EventHandler(this.richTextBox_AutoWrite_Click);
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu_CheckBox_ToolStripMenuItem,
            this.MainMenu_Cats_ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(782, 28);
            this.menu.TabIndex = 26;
            this.menu.Text = "menuStrip1";
            // 
            // MainMenu_CheckBox_ToolStripMenuItem
            // 
            this.MainMenu_CheckBox_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstToolStripMenuItem,
            this.secondToolStripMenuItem,
            this.thirdToolStripMenuItem});
            this.MainMenu_CheckBox_ToolStripMenuItem.Name = "MainMenu_CheckBox_ToolStripMenuItem";
            this.MainMenu_CheckBox_ToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.MainMenu_CheckBox_ToolStripMenuItem.Text = "Менюшка чекбоксов";
            // 
            // firstToolStripMenuItem
            // 
            this.firstToolStripMenuItem.CheckOnClick = true;
            this.firstToolStripMenuItem.Name = "firstToolStripMenuItem";
            this.firstToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.firstToolStripMenuItem.Text = "Первый";
            this.firstToolStripMenuItem.CheckedChanged += new System.EventHandler(this.firstToolStripMenuItem_CheckedChanged);
            // 
            // secondToolStripMenuItem
            // 
            this.secondToolStripMenuItem.CheckOnClick = true;
            this.secondToolStripMenuItem.Name = "secondToolStripMenuItem";
            this.secondToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.secondToolStripMenuItem.Text = "Второй";
            this.secondToolStripMenuItem.CheckedChanged += new System.EventHandler(this.secondToolStripMenuItem_CheckedChanged);
            // 
            // thirdToolStripMenuItem
            // 
            this.thirdToolStripMenuItem.CheckOnClick = true;
            this.thirdToolStripMenuItem.Name = "thirdToolStripMenuItem";
            this.thirdToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.thirdToolStripMenuItem.Text = "Третий";
            this.thirdToolStripMenuItem.CheckedChanged += new System.EventHandler(this.thirdToolStripMenuItem_CheckedChanged);
            // 
            // MainMenu_Cats_ToolStripMenuItem
            // 
            this.MainMenu_Cats_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCat1_ToolStripMenuItem,
            this.MenuCat2_ToolStripMenuItem});
            this.MainMenu_Cats_ToolStripMenuItem.Name = "MainMenu_Cats_ToolStripMenuItem";
            this.MainMenu_Cats_ToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.MainMenu_Cats_ToolStripMenuItem.Text = "Ещё одна менюшка с котиками";
            // 
            // MenuCat1_ToolStripMenuItem
            // 
            this.MenuCat1_ToolStripMenuItem.Name = "MenuCat1_ToolStripMenuItem";
            this.MenuCat1_ToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.MenuCat1_ToolStripMenuItem.Text = "Пушистый и лохаматый";
            this.MenuCat1_ToolStripMenuItem.Click += new System.EventHandler(this.MenuCat_ToolStripMenuItem_Click);
            // 
            // MenuCat2_ToolStripMenuItem
            // 
            this.MenuCat2_ToolStripMenuItem.Name = "MenuCat2_ToolStripMenuItem";
            this.MenuCat2_ToolStripMenuItem.Size = new System.Drawing.Size(258, 26);
            this.MenuCat2_ToolStripMenuItem.Text = "Страшный";
            this.MenuCat2_ToolStripMenuItem.Click += new System.EventHandler(this.MenuCat2_ToolStripMenuItem_Click);
            // 
            // label_Meow
            // 
            this.label_Meow.AutoSize = true;
            this.label_Meow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Meow.Location = new System.Drawing.Point(465, 367);
            this.label_Meow.Name = "label_Meow";
            this.label_Meow.Size = new System.Drawing.Size(54, 20);
            this.label_Meow.TabIndex = 27;
            this.label_Meow.Text = "Meow!";
            this.label_Meow.Click += new System.EventHandler(this.pic_Meow_Click);
            // 
            // checkedListBox_Menu
            // 
            this.checkedListBox_Menu.CheckOnClick = true;
            this.checkedListBox_Menu.ForeColor = System.Drawing.Color.Red;
            this.checkedListBox_Menu.FormattingEnabled = true;
            this.checkedListBox_Menu.Items.AddRange(new object[] {
            "Первый чекбокс",
            "Второй",
            "Крайний"});
            this.checkedListBox_Menu.Location = new System.Drawing.Point(342, 221);
            this.checkedListBox_Menu.Name = "checkedListBox_Menu";
            this.checkedListBox_Menu.Size = new System.Drawing.Size(149, 70);
            this.checkedListBox_Menu.TabIndex = 28;
            this.checkedListBox_Menu.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Menu_SelectedIndexChanged);
            // 
            // richTextBox_AutoWrite
            // 
            this.richTextBox_AutoWrite.ContextMenuStrip = this.contextMenu;
            this.richTextBox_AutoWrite.Location = new System.Drawing.Point(17, 421);
            this.richTextBox_AutoWrite.Name = "richTextBox_AutoWrite";
            this.richTextBox_AutoWrite.ReadOnly = true;
            this.richTextBox_AutoWrite.Size = new System.Drawing.Size(202, 120);
            this.richTextBox_AutoWrite.TabIndex = 29;
            this.richTextBox_AutoWrite.Text = "";
            this.richTextBox_AutoWrite.Click += new System.EventHandler(this.richTextBox_AutoWrite_Click);
            this.richTextBox_AutoWrite.TextChanged += new System.EventHandler(this.richTextBox_AutoWrite_TextChanged);
            // 
            // btn_AutoWrite_Ya
            // 
            this.btn_AutoWrite_Ya.Location = new System.Drawing.Point(12, 376);
            this.btn_AutoWrite_Ya.Name = "btn_AutoWrite_Ya";
            this.btn_AutoWrite_Ya.Size = new System.Drawing.Size(62, 29);
            this.btn_AutoWrite_Ya.TabIndex = 30;
            this.btn_AutoWrite_Ya.Text = "Я";
            this.btn_AutoWrite_Ya.UseVisualStyleBackColor = true;
            this.btn_AutoWrite_Ya.Click += new System.EventHandler(this.btn_AutoWrite_Ya_Click);
            // 
            // btn_AutoWrite_Idu
            // 
            this.btn_AutoWrite_Idu.Location = new System.Drawing.Point(80, 376);
            this.btn_AutoWrite_Idu.Name = "btn_AutoWrite_Idu";
            this.btn_AutoWrite_Idu.Size = new System.Drawing.Size(62, 29);
            this.btn_AutoWrite_Idu.TabIndex = 31;
            this.btn_AutoWrite_Idu.Text = "Иду";
            this.btn_AutoWrite_Idu.UseVisualStyleBackColor = true;
            this.btn_AutoWrite_Idu.Click += new System.EventHandler(this.btn_AutoWrite_Idu_Click);
            // 
            // btn_AutoWrite_Domoj
            // 
            this.btn_AutoWrite_Domoj.Location = new System.Drawing.Point(148, 376);
            this.btn_AutoWrite_Domoj.Name = "btn_AutoWrite_Domoj";
            this.btn_AutoWrite_Domoj.Size = new System.Drawing.Size(71, 29);
            this.btn_AutoWrite_Domoj.TabIndex = 32;
            this.btn_AutoWrite_Domoj.Text = "Домой";
            this.btn_AutoWrite_Domoj.UseVisualStyleBackColor = true;
            this.btn_AutoWrite_Domoj.Click += new System.EventHandler(this.btn_AutoWrite_Domoj_Click);
            // 
            // label_FormWidth
            // 
            this.label_FormWidth.AutoSize = true;
            this.label_FormWidth.Location = new System.Drawing.Point(147, 270);
            this.label_FormWidth.Name = "label_FormWidth";
            this.label_FormWidth.Size = new System.Drawing.Size(50, 20);
            this.label_FormWidth.TabIndex = 33;
            this.label_FormWidth.Text = "label1";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label_FormWidth);
            this.Controls.Add(this.btn_AutoWrite_Domoj);
            this.Controls.Add(this.btn_AutoWrite_Idu);
            this.Controls.Add(this.btn_AutoWrite_Ya);
            this.Controls.Add(this.richTextBox_AutoWrite);
            this.Controls.Add(this.checkedListBox_Menu);
            this.Controls.Add(this.label_Meow);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.numericUpDown_X);
            this.Controls.Add(this.linkLabel_BigCat);
            this.Controls.Add(this.pic_Meow);
            this.Controls.Add(this.numericUpDown_Y);
            this.Controls.Add(this.listBox_ChngColorsTimer);
            this.Controls.Add(this.label_ChngColors_Timer);
            this.Controls.Add(this.pic_RunningCat);
            this.Controls.Add(this.listBox_ChngColorsMouse);
            this.Controls.Add(this.label_ChngColors_Mouse);
            this.Controls.Add(this.radioBtn_setDownPic);
            this.Controls.Add(this.radioBtn_setUpPic);
            this.Controls.Add(this.groupBox_Date);
            this.Controls.Add(this.chkBox_blockTxtBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.progBar_IncDecByBtns);
            this.Controls.Add(this.btn_DecProgBar);
            this.Controls.Add(this.btn_IncProgBar);
            this.MainMenuStrip = this.menu;
            this.Name = "form_Main";
            this.Text = "LabOOP1";
            this.SizeChanged += new System.EventHandler(this.form_Main_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_Main_MouseMove);
            this.groupBox_Date.ResumeLayout(false);
            this.groupBox_Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RunningCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Meow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_IncProgBar;
        private Button btn_DecProgBar;
        private ProgressBar progBar_IncDecByBtns;
        private CheckBox chkBox_blockTxtBox;
        protected internal TextBox txtBox;
        private ToolTip toolTip;
        private ComboBox comboBox_FavDates;
        private DateTimePicker dateTimePicker_DateChooser;
        private MaskedTextBox maskedTxtBox_Date;
        private Label lb_DataExplainText;
        private CheckBox chkBox_ShowDate;
        private GroupBox groupBox_Date;
        private RadioButton radioBtn_setUpPic;
        private RadioButton radioBtn_setDownPic;
        private Label label_ChngColors_Mouse;
        private ListBox listBox_ChngColorsMouse;
        private PictureBox pic_RunningCat;
        private System.Windows.Forms.Timer timer_forLabelChngColors_Timer;
        private Label label_ChngColors_Timer;
        private ListBox listBox_ChngColorsTimer;
        private NotifyIcon notyficon_Meow;
        private NumericUpDown numericUpDown_Y;
        private PictureBox pic_Meow;
        private LinkLabel linkLabel_BigCat;
        private NumericUpDown numericUpDown_X;
        private ContextMenuStrip contextMenu;
        private MenuStrip menu;
        private ToolStripMenuItem MainMenu_CheckBox_ToolStripMenuItem;
        private ToolStripMenuItem MainMenu_Cats_ToolStripMenuItem;
        private Label label_Meow;
        private ToolStripMenuItem firstToolStripMenuItem;
        private ToolStripMenuItem secondToolStripMenuItem;
        private ToolStripMenuItem thirdToolStripMenuItem;
        private CheckedListBox checkedListBox_Menu;
        private ToolStripMenuItem MenuCat1_ToolStripMenuItem;
        private ToolStripMenuItem MenuCat2_ToolStripMenuItem;
        private RichTextBox richTextBox_AutoWrite;
        private Button btn_AutoWrite_Ya;
        private Button btn_AutoWrite_Idu;
        private Button btn_AutoWrite_Domoj;
        private ToolStripMenuItem contextMenuItem_redBackGround;
        private ToolStripMenuItem contextMenuItem_CatBackGroundFar;
        private ToolStripMenuItem contextMenuItem_DeleteText;
        private Label label_FormWidth;
    }
}