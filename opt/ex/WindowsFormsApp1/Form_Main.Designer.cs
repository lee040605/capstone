namespace WindowsFormsApp1
{
    partial class Form_Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.TSM_Main_Files = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_ModuleSave = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Print = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Exit = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Edit = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Copy = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_TrayNo = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Config = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_System = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_UserSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Admin = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_AdminReset = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Control = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Start = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Pause = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Resume = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Tools = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_ScheduleEditor = new System.Windows.Forms.ToolStripMenuItem();
      this.TSM_Main_Analyzer = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tsb_Start = new System.Windows.Forms.ToolStripButton();
      this.tsb_Stop = new System.Windows.Forms.ToolStripButton();
      this.tsb_Pause = new System.Windows.Forms.ToolStripButton();
      this.tsb_Resume = new System.Windows.Forms.ToolStripButton();
      this.tsb_NextStep = new System.Windows.Forms.ToolStripButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tabControl2 = new System.Windows.Forms.TabControl();
      this.tabPage_State = new System.Windows.Forms.TabPage();
      this.dgv_State1 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage_Volt = new System.Windows.Forms.TabPage();
      this.tabPage_Details = new System.Windows.Forms.TabPage();
      this.lbl_Channel = new System.Windows.Forms.Label();
      this.lbl_SelectedChannel = new System.Windows.Forms.Label();
      this.lbl_Module = new System.Windows.Forms.Label();
      this.lbl_SelectedModule = new System.Windows.Forms.Label();
      this.btn_All = new System.Windows.Forms.Button();
      this.lbl_ChannelInfo = new System.Windows.Forms.Label();
      this.dgv_Module1 = new System.Windows.Forms.DataGridView();
      this.lbl_ModuleInfo = new System.Windows.Forms.Label();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.dgv_Voltage1 = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tabControl2.SuspendLayout();
      this.tabPage_State.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_State1)).BeginInit();
      this.tabPage_Volt.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Module1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Voltage1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_Files,
            this.TSM_Main_Edit,
            this.TSM_Main_Config,
            this.TSM_Main_Control,
            this.TSM_Main_Tools});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1904, 36);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // TSM_Main_Files
      // 
      this.TSM_Main_Files.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_ModuleSave,
            this.TSM_Main_Print,
            this.TSM_Main_Exit});
      this.TSM_Main_Files.Name = "TSM_Main_Files";
      this.TSM_Main_Files.Size = new System.Drawing.Size(74, 30);
      this.TSM_Main_Files.Text = "File(F)";
      this.TSM_Main_Files.Click += new System.EventHandler(this.fileFToolStripMenuItem_Click);
      // 
      // TSM_Main_ModuleSave
      // 
      this.TSM_Main_ModuleSave.Name = "TSM_Main_ModuleSave";
      this.TSM_Main_ModuleSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.TSM_Main_ModuleSave.Size = new System.Drawing.Size(274, 34);
      this.TSM_Main_ModuleSave.Text = "상태저장(&S) ";
      this.TSM_Main_ModuleSave.Click += new System.EventHandler(this.TSM_Main_ModuleSave_Click);
      // 
      // TSM_Main_Print
      // 
      this.TSM_Main_Print.Name = "TSM_Main_Print";
      this.TSM_Main_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.TSM_Main_Print.Size = new System.Drawing.Size(274, 34);
      this.TSM_Main_Print.Text = "인쇄(&P)";
      this.TSM_Main_Print.Click += new System.EventHandler(this.TSM_Main_Print_Click);
      // 
      // TSM_Main_Exit
      // 
      this.TSM_Main_Exit.Name = "TSM_Main_Exit";
      this.TSM_Main_Exit.Size = new System.Drawing.Size(274, 34);
      this.TSM_Main_Exit.Text = "종료(&X)";
      this.TSM_Main_Exit.Click += new System.EventHandler(this.TSM_Main_Exit_Click);
      // 
      // TSM_Main_Edit
      // 
      this.TSM_Main_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_Copy,
            this.TSM_Main_SelectAll,
            this.TSM_Main_TrayNo});
      this.TSM_Main_Edit.Name = "TSM_Main_Edit";
      this.TSM_Main_Edit.Size = new System.Drawing.Size(77, 30);
      this.TSM_Main_Edit.Text = "Edit(&E)";
      this.TSM_Main_Edit.Click += new System.EventHandler(this.editEToolStripMenuItem_Click);
      // 
      // TSM_Main_Copy
      // 
      this.TSM_Main_Copy.Name = "TSM_Main_Copy";
      this.TSM_Main_Copy.Size = new System.Drawing.Size(287, 34);
      this.TSM_Main_Copy.Text = "복사(&C)";
      this.TSM_Main_Copy.Click += new System.EventHandler(this.TSM_Main_Copy_Click);
      // 
      // TSM_Main_SelectAll
      // 
      this.TSM_Main_SelectAll.Name = "TSM_Main_SelectAll";
      this.TSM_Main_SelectAll.Size = new System.Drawing.Size(287, 34);
      this.TSM_Main_SelectAll.Text = "전체 선택(&A)";
      this.TSM_Main_SelectAll.Click += new System.EventHandler(this.TSM_Main_SelectAll_Click);
      // 
      // TSM_Main_TrayNo
      // 
      this.TSM_Main_TrayNo.Name = "TSM_Main_TrayNo";
      this.TSM_Main_TrayNo.Size = new System.Drawing.Size(287, 34);
      this.TSM_Main_TrayNo.Text = "Tray(Pack)번호입력(&T)";
      this.TSM_Main_TrayNo.Click += new System.EventHandler(this.TSM_Main_TrayNo_Click);
      // 
      // TSM_Main_Config
      // 
      this.TSM_Main_Config.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_System,
            this.TSM_Main_UserSettings,
            this.TSM_Main_Admin,
            this.TSM_Main_AdminReset});
      this.TSM_Main_Config.Name = "TSM_Main_Config";
      this.TSM_Main_Config.Size = new System.Drawing.Size(84, 30);
      this.TSM_Main_Config.Text = "설정(S)";
      // 
      // TSM_Main_System
      // 
      this.TSM_Main_System.Name = "TSM_Main_System";
      this.TSM_Main_System.Size = new System.Drawing.Size(270, 34);
      this.TSM_Main_System.Text = "시스템 설정(&S)";
      // 
      // TSM_Main_UserSettings
      // 
      this.TSM_Main_UserSettings.Name = "TSM_Main_UserSettings";
      this.TSM_Main_UserSettings.Size = new System.Drawing.Size(270, 34);
      this.TSM_Main_UserSettings.Text = "사용자 설정(&O)";
      // 
      // TSM_Main_Admin
      // 
      this.TSM_Main_Admin.Name = "TSM_Main_Admin";
      this.TSM_Main_Admin.Size = new System.Drawing.Size(270, 34);
      this.TSM_Main_Admin.Text = "관리자 계정 설정";
      // 
      // TSM_Main_AdminReset
      // 
      this.TSM_Main_AdminReset.Name = "TSM_Main_AdminReset";
      this.TSM_Main_AdminReset.Size = new System.Drawing.Size(270, 34);
      this.TSM_Main_AdminReset.Text = "관리자 계정 초기화";
      // 
      // TSM_Main_Control
      // 
      this.TSM_Main_Control.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_Start,
            this.TSM_Main_Pause,
            this.TSM_Main_Resume});
      this.TSM_Main_Control.Name = "TSM_Main_Control";
      this.TSM_Main_Control.Size = new System.Drawing.Size(127, 30);
      this.TSM_Main_Control.Text = "제어 명령(&C)";
      // 
      // TSM_Main_Start
      // 
      this.TSM_Main_Start.Name = "TSM_Main_Start";
      this.TSM_Main_Start.Size = new System.Drawing.Size(213, 34);
      this.TSM_Main_Start.Text = "작업 시작(&R)";
      // 
      // TSM_Main_Pause
      // 
      this.TSM_Main_Pause.Name = "TSM_Main_Pause";
      this.TSM_Main_Pause.Size = new System.Drawing.Size(213, 34);
      this.TSM_Main_Pause.Text = "작업 멈춤(&P)";
      // 
      // TSM_Main_Resume
      // 
      this.TSM_Main_Resume.Name = "TSM_Main_Resume";
      this.TSM_Main_Resume.Size = new System.Drawing.Size(213, 34);
      this.TSM_Main_Resume.Text = "작업 계속(&C)";
      // 
      // TSM_Main_Tools
      // 
      this.TSM_Main_Tools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSM_Main_ScheduleEditor,
            this.TSM_Main_Analyzer});
      this.TSM_Main_Tools.Name = "TSM_Main_Tools";
      this.TSM_Main_Tools.Size = new System.Drawing.Size(84, 30);
      this.TSM_Main_Tools.Text = "도구(&T)";
      // 
      // TSM_Main_ScheduleEditor
      // 
      this.TSM_Main_ScheduleEditor.Name = "TSM_Main_ScheduleEditor";
      this.TSM_Main_ScheduleEditor.Size = new System.Drawing.Size(255, 34);
      this.TSM_Main_ScheduleEditor.Text = "ScheduleEditor(&S)";
      this.TSM_Main_ScheduleEditor.Click += new System.EventHandler(this.TSM_Main_ScheduleEditor_Click);
      // 
      // TSM_Main_Analyzer
      // 
      this.TSM_Main_Analyzer.Name = "TSM_Main_Analyzer";
      this.TSM_Main_Analyzer.Size = new System.Drawing.Size(255, 34);
      this.TSM_Main_Analyzer.Text = "Analyzer(&A)";
      // 
      // toolStrip1
      // 
      this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Start,
            this.tsb_Stop,
            this.tsb_Pause,
            this.tsb_Resume,
            this.tsb_NextStep});
      this.toolStrip1.Location = new System.Drawing.Point(0, 36);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1904, 38);
      this.toolStrip1.TabIndex = 5;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tsb_Start
      // 
      this.tsb_Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_Start.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Start.Image")));
      this.tsb_Start.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_Start.Name = "tsb_Start";
      this.tsb_Start.Size = new System.Drawing.Size(34, 33);
      this.tsb_Start.Text = "Step 완료 후 종료";
      this.tsb_Start.ToolTipText = "Step 완료 후 종료";
      this.tsb_Start.Click += new System.EventHandler(this.tsb_Start_Click);
      // 
      // tsb_Stop
      // 
      this.tsb_Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_Stop.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Stop.Image")));
      this.tsb_Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_Stop.Name = "tsb_Stop";
      this.tsb_Stop.Size = new System.Drawing.Size(34, 33);
      this.tsb_Stop.Text = "즉시 종료";
      this.tsb_Stop.ToolTipText = "즉시 종료";
      this.tsb_Stop.Click += new System.EventHandler(this.tsb_Stop_Click);
      // 
      // tsb_Pause
      // 
      this.tsb_Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_Pause.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Pause.Image")));
      this.tsb_Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_Pause.Name = "tsb_Pause";
      this.tsb_Pause.Size = new System.Drawing.Size(34, 33);
      this.tsb_Pause.Text = "일시정지";
      // 
      // tsb_Resume
      // 
      this.tsb_Resume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_Resume.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Resume.Image")));
      this.tsb_Resume.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_Resume.Name = "tsb_Resume";
      this.tsb_Resume.Size = new System.Drawing.Size(34, 33);
      this.tsb_Resume.Text = "작업 재개";
      this.tsb_Resume.ToolTipText = "작업 재개";
      // 
      // tsb_NextStep
      // 
      this.tsb_NextStep.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_NextStep.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NextStep.Image")));
      this.tsb_NextStep.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_NextStep.Name = "tsb_NextStep";
      this.tsb_NextStep.Size = new System.Drawing.Size(34, 33);
      this.tsb_NextStep.Text = "다음 스텝";
      this.tsb_NextStep.ToolTipText = "다음 스텝";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.Controls.Add(this.tabControl2);
      this.panel1.Controls.Add(this.lbl_Channel);
      this.panel1.Controls.Add(this.lbl_SelectedChannel);
      this.panel1.Controls.Add(this.lbl_Module);
      this.panel1.Controls.Add(this.lbl_SelectedModule);
      this.panel1.Controls.Add(this.btn_All);
      this.panel1.Controls.Add(this.lbl_ChannelInfo);
      this.panel1.Controls.Add(this.dgv_Module1);
      this.panel1.Controls.Add(this.lbl_ModuleInfo);
      this.panel1.Location = new System.Drawing.Point(12, 118);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1880, 876);
      this.panel1.TabIndex = 2;
      // 
      // tabControl2
      // 
      this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl2.Controls.Add(this.tabPage_State);
      this.tabControl2.Controls.Add(this.tabPage_Volt);
      this.tabControl2.Controls.Add(this.tabPage_Details);
      this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
      this.tabControl2.ItemSize = new System.Drawing.Size(100, 25);
      this.tabControl2.Location = new System.Drawing.Point(29, 255);
      this.tabControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabControl2.Name = "tabControl2";
      this.tabControl2.SelectedIndex = 0;
      this.tabControl2.Size = new System.Drawing.Size(1821, 613);
      this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tabControl2.TabIndex = 4;
      // 
      // tabPage_State
      // 
      this.tabPage_State.Controls.Add(this.dgv_State1);
      this.tabPage_State.Location = new System.Drawing.Point(4, 29);
      this.tabPage_State.Name = "tabPage_State";
      this.tabPage_State.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage_State.Size = new System.Drawing.Size(1813, 580);
      this.tabPage_State.TabIndex = 0;
      this.tabPage_State.Text = "상태";
      this.tabPage_State.UseVisualStyleBackColor = true;
      // 
      // dgv_State1
      // 
      this.dgv_State1.AllowUserToAddRows = false;
      this.dgv_State1.AllowUserToDeleteRows = false;
      this.dgv_State1.AllowUserToResizeRows = false;
      this.dgv_State1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv_State1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dgv_State1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_State1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv_State1.ColumnHeadersHeight = 100;
      this.dgv_State1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
      this.dgv_State1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
      this.dgv_State1.Location = new System.Drawing.Point(20, 24);
      this.dgv_State1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dgv_State1.Name = "dgv_State1";
      this.dgv_State1.ReadOnly = true;
      this.dgv_State1.RowHeadersVisible = false;
      this.dgv_State1.RowHeadersWidth = 51;
      this.dgv_State1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_State1.RowTemplate.Height = 28;
      this.dgv_State1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
      this.dgv_State1.Size = new System.Drawing.Size(1802, 556);
      this.dgv_State1.TabIndex = 2;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.Frozen = true;
      this.dataGridViewTextBoxColumn2.HeaderText = "상태";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn2.Width = 200;
      // 
      // dataGridViewTextBoxColumn15
      // 
      this.dataGridViewTextBoxColumn15.HeaderText = "A";
      this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
      this.dataGridViewTextBoxColumn15.ReadOnly = true;
      this.dataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn15.Width = 200;
      // 
      // dataGridViewTextBoxColumn16
      // 
      this.dataGridViewTextBoxColumn16.HeaderText = "B";
      this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
      this.dataGridViewTextBoxColumn16.ReadOnly = true;
      this.dataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn16.Width = 200;
      // 
      // dataGridViewTextBoxColumn17
      // 
      this.dataGridViewTextBoxColumn17.HeaderText = "C";
      this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
      this.dataGridViewTextBoxColumn17.ReadOnly = true;
      this.dataGridViewTextBoxColumn17.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn17.Width = 200;
      // 
      // tabPage_Volt
      // 
      this.tabPage_Volt.Controls.Add(this.dgv_Voltage1);
      this.tabPage_Volt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
      this.tabPage_Volt.Location = new System.Drawing.Point(4, 29);
      this.tabPage_Volt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage_Volt.Name = "tabPage_Volt";
      this.tabPage_Volt.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage_Volt.Size = new System.Drawing.Size(1813, 580);
      this.tabPage_Volt.TabIndex = 1;
      this.tabPage_Volt.Text = "전압";
      this.tabPage_Volt.UseVisualStyleBackColor = true;
      // 
      // tabPage_Details
      // 
      this.tabPage_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
      this.tabPage_Details.Location = new System.Drawing.Point(4, 29);
      this.tabPage_Details.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage_Details.Name = "tabPage_Details";
      this.tabPage_Details.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.tabPage_Details.Size = new System.Drawing.Size(1813, 580);
      this.tabPage_Details.TabIndex = 2;
      this.tabPage_Details.Text = "상세 보기";
      this.tabPage_Details.UseVisualStyleBackColor = true;
      // 
      // lbl_Channel
      // 
      this.lbl_Channel.BackColor = System.Drawing.SystemColors.Window;
      this.lbl_Channel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_Channel.Location = new System.Drawing.Point(550, 214);
      this.lbl_Channel.Name = "lbl_Channel";
      this.lbl_Channel.Size = new System.Drawing.Size(1312, 29);
      this.lbl_Channel.TabIndex = 2;
      this.lbl_Channel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_SelectedChannel
      // 
      this.lbl_SelectedChannel.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lbl_SelectedChannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_SelectedChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl_SelectedChannel.Location = new System.Drawing.Point(419, 214);
      this.lbl_SelectedChannel.Name = "lbl_SelectedChannel";
      this.lbl_SelectedChannel.Size = new System.Drawing.Size(131, 29);
      this.lbl_SelectedChannel.TabIndex = 2;
      this.lbl_SelectedChannel.Text = "  선택 Channel";
      this.lbl_SelectedChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl_Module
      // 
      this.lbl_Module.BackColor = System.Drawing.SystemColors.Window;
      this.lbl_Module.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_Module.Location = new System.Drawing.Point(308, 214);
      this.lbl_Module.Name = "lbl_Module";
      this.lbl_Module.Size = new System.Drawing.Size(109, 29);
      this.lbl_Module.TabIndex = 2;
      this.lbl_Module.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl_SelectedModule
      // 
      this.lbl_SelectedModule.BackColor = System.Drawing.SystemColors.ControlDark;
      this.lbl_SelectedModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lbl_SelectedModule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl_SelectedModule.Location = new System.Drawing.Point(177, 214);
      this.lbl_SelectedModule.Name = "lbl_SelectedModule";
      this.lbl_SelectedModule.Size = new System.Drawing.Size(131, 29);
      this.lbl_SelectedModule.TabIndex = 2;
      this.lbl_SelectedModule.Text = " 선택 Module";
      this.lbl_SelectedModule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btn_All
      // 
      this.btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
      this.btn_All.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btn_All.Location = new System.Drawing.Point(29, 214);
      this.btn_All.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btn_All.Name = "btn_All";
      this.btn_All.Size = new System.Drawing.Size(145, 29);
      this.btn_All.TabIndex = 3;
      this.btn_All.Text = "전체 보기";
      this.btn_All.UseVisualStyleBackColor = true;
      // 
      // lbl_ChannelInfo
      // 
      this.lbl_ChannelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_ChannelInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl_ChannelInfo.Location = new System.Drawing.Point(41, 175);
      this.lbl_ChannelInfo.Name = "lbl_ChannelInfo";
      this.lbl_ChannelInfo.Size = new System.Drawing.Size(124, 29);
      this.lbl_ChannelInfo.TabIndex = 2;
      this.lbl_ChannelInfo.Text = "Channel 정보";
      this.lbl_ChannelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // dgv_Module1
      // 
      this.dgv_Module1.AllowUserToAddRows = false;
      this.dgv_Module1.AllowUserToDeleteRows = false;
      this.dgv_Module1.AllowUserToResizeColumns = false;
      this.dgv_Module1.AllowUserToResizeRows = false;
      this.dgv_Module1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv_Module1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.dgv_Module1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
      this.dgv_Module1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Module1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
      this.dgv_Module1.Location = new System.Drawing.Point(31, 40);
      this.dgv_Module1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.dgv_Module1.MultiSelect = false;
      this.dgv_Module1.Name = "dgv_Module1";
      this.dgv_Module1.ReadOnly = true;
      this.dgv_Module1.RowHeadersVisible = false;
      this.dgv_Module1.RowHeadersWidth = 51;
      this.dgv_Module1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.dgv_Module1.RowTemplate.Height = 28;
      this.dgv_Module1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Module1.Size = new System.Drawing.Size(1821, 121);
      this.dgv_Module1.TabIndex = 1;
      this.dgv_Module1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // lbl_ModuleInfo
      // 
      this.lbl_ModuleInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.lbl_ModuleInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lbl_ModuleInfo.Location = new System.Drawing.Point(32, 7);
      this.lbl_ModuleInfo.Name = "lbl_ModuleInfo";
      this.lbl_ModuleInfo.Size = new System.Drawing.Size(124, 30);
      this.lbl_ModuleInfo.TabIndex = 2;
      this.lbl_ModuleInfo.Text = "Module 정보";
      this.lbl_ModuleInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lbl_ModuleInfo.Click += new System.EventHandler(this.label1_Click);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
      // 
      // dgv_Voltage1
      // 
      this.dgv_Voltage1.AllowUserToAddRows = false;
      this.dgv_Voltage1.AllowUserToDeleteRows = false;
      this.dgv_Voltage1.AllowUserToResizeRows = false;
      this.dgv_Voltage1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Voltage1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
      this.dgv_Voltage1.Location = new System.Drawing.Point(22, 22);
      this.dgv_Voltage1.Name = "dgv_Voltage1";
      this.dgv_Voltage1.RowHeadersWidth = 62;
      this.dgv_Voltage1.RowTemplate.Height = 28;
      this.dgv_Voltage1.Size = new System.Drawing.Size(1167, 526);
      this.dgv_Voltage1.TabIndex = 0;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.Frozen = true;
      this.dataGridViewTextBoxColumn8.HeaderText = "V";
      this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn8.Width = 200;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.HeaderText = "A";
      this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn10.Width = 200;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.HeaderText = "B";
      this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn11.Width = 200;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.HeaderText = "C";
      this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.dataGridViewTextBoxColumn12.Width = 200;
      // 
      // Column1
      // 
      this.Column1.HeaderText = "모듈";
      this.Column1.MinimumWidth = 6;
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column1.Width = 200;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "연결상태";
      this.Column2.MinimumWidth = 6;
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column2.Width = 200;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "연결 시간";
      this.Column3.MinimumWidth = 6;
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column3.Width = 200;
      // 
      // Column4
      // 
      this.Column4.HeaderText = "전체 채널 수";
      this.Column4.MinimumWidth = 6;
      this.Column4.Name = "Column4";
      this.Column4.ReadOnly = true;
      this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column4.Width = 150;
      // 
      // Column5
      // 
      this.Column5.HeaderText = "대기 채널 수";
      this.Column5.MinimumWidth = 6;
      this.Column5.Name = "Column5";
      this.Column5.ReadOnly = true;
      this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column5.Width = 150;
      // 
      // Column6
      // 
      this.Column6.HeaderText = "작업 채널 수";
      this.Column6.MinimumWidth = 6;
      this.Column6.Name = "Column6";
      this.Column6.ReadOnly = true;
      this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column6.Width = 150;
      // 
      // Column7
      // 
      this.Column7.HeaderText = "접속횟수";
      this.Column7.MinimumWidth = 6;
      this.Column7.Name = "Column7";
      this.Column7.ReadOnly = true;
      this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column7.Width = 150;
      // 
      // Column8
      // 
      this.Column8.HeaderText = "IP";
      this.Column8.MinimumWidth = 6;
      this.Column8.Name = "Column8";
      this.Column8.ReadOnly = true;
      this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column8.Width = 320;
      // 
      // Column9
      // 
      this.Column9.HeaderText = "Spec";
      this.Column9.MinimumWidth = 6;
      this.Column9.Name = "Column9";
      this.Column9.ReadOnly = true;
      this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
      this.Column9.Width = 320;
      // 
      // Form_Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1904, 1007);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form_Main";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form_Main_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.tabControl2.ResumeLayout(false);
      this.tabPage_State.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_State1)).EndInit();
      this.tabPage_Volt.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Module1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Voltage1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Files;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Edit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_ModuleSave;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Print;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Exit;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Config;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Copy;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_SelectAll;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_TrayNo;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_System;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_UserSettings;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Admin;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_AdminReset;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Control;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Tools;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_ScheduleEditor;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Analyzer;


        //추가
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView dgv_Module;

        private System.Windows.Forms.DataGridView dgv_Channel;
        private System.Windows.Forms.DataGridView dgv_State;
        private System.Windows.Forms.DataGridView dgv_Voltage;
        private System.Windows.Forms.DataGridView dgv_Current;
        private System.Windows.Forms.DataGridView dgv_Capacity;
        private System.Windows.Forms.DataGridView dgv_TestName;
        private System.Windows.Forms.DataGridViewImageColumn dgv_Channel_Parallel;
        private System.Windows.Forms.DataGridViewImageColumn dgv_Channel_ModeImage;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Start;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Pause;
        private System.Windows.Forms.ToolStripMenuItem TSM_Main_Resume;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_Start;
        private System.Windows.Forms.ToolStripButton tsb_Stop;
        private System.Windows.Forms.ToolStripButton tsb_Pause;
        private System.Windows.Forms.ToolStripButton tsb_Resume;
        private System.Windows.Forms.ToolStripButton tsb_NextStep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_ModuleInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.DataGridView dgv_Module1;
        private System.Windows.Forms.Label lbl_ChannelInfo;
        private System.Windows.Forms.Button btn_All;
        private System.Windows.Forms.Label lbl_SelectedModule;
        private System.Windows.Forms.Label lbl_Channel;
        private System.Windows.Forms.Label lbl_SelectedChannel;
        private System.Windows.Forms.Label lbl_Module;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage_State;
        private System.Windows.Forms.TabPage tabPage_Volt;
        private System.Windows.Forms.TabPage tabPage_Details;
        private System.Windows.Forms.DataGridView dgv_State1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    private System.Windows.Forms.DataGridView dgv_Voltage1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
  }
}

