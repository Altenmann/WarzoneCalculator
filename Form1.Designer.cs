namespace WarzoneCalculator
{
	partial class CalculatorForm
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
			this.TopBar = new System.Windows.Forms.Panel();
			this.CloseLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxAttack = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.AttackButton = new System.Windows.Forms.Button();
			this.AttackResult = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.OffensiveRate = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.AttackCommanderCheck = new System.Windows.Forms.CheckBox();
			this.AttackArmies = new System.Windows.Forms.NumericUpDown();
			this.groupBoxDefend = new System.Windows.Forms.GroupBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.DefendButton = new System.Windows.Forms.Button();
			this.DefenseResult = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.DefensiveRate = new System.Windows.Forms.NumericUpDown();
			this.panel6 = new System.Windows.Forms.Panel();
			this.DefendCommanderCheck = new System.Windows.Forms.CheckBox();
			this.DefenseArmies = new System.Windows.Forms.NumericUpDown();
			this.groupBoxExtra = new System.Windows.Forms.GroupBox();
			this.TitleLabel = new System.Windows.Forms.Label();
			this.PreviewPanel = new System.Windows.Forms.Panel();
			this.AttackPreviewPanel = new System.Windows.Forms.Panel();
			this.DefensePreviewPanel = new System.Windows.Forms.Panel();
			this.PreviewAttackAmount = new System.Windows.Forms.Label();
			this.PreviewDefendAmount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.LossPanel = new System.Windows.Forms.Panel();
			this.AttackLoss = new System.Windows.Forms.Label();
			this.DefendLoss = new System.Windows.Forms.Label();
			this.OutcomePanel = new System.Windows.Forms.Panel();
			this.CommanderAttackPreview = new System.Windows.Forms.CheckBox();
			this.CommanderDefendPreview = new System.Windows.Forms.CheckBox();
			this.OutcomeAttackAmount = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.CommanderAttackOutcome = new System.Windows.Forms.CheckBox();
			this.OutcomeDefendAmount = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.CommanderDefendOutcome = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TopBar.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBoxAttack.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OffensiveRate)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AttackArmies)).BeginInit();
			this.groupBoxDefend.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DefensiveRate)).BeginInit();
			this.panel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DefenseArmies)).BeginInit();
			this.groupBoxExtra.SuspendLayout();
			this.PreviewPanel.SuspendLayout();
			this.AttackPreviewPanel.SuspendLayout();
			this.DefensePreviewPanel.SuspendLayout();
			this.LossPanel.SuspendLayout();
			this.OutcomePanel.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// TopBar
			// 
			this.TopBar.BackColor = System.Drawing.Color.Black;
			this.TopBar.Controls.Add(this.TitleLabel);
			this.TopBar.Controls.Add(this.CloseLabel);
			this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopBar.Location = new System.Drawing.Point(0, 0);
			this.TopBar.Margin = new System.Windows.Forms.Padding(0);
			this.TopBar.Name = "TopBar";
			this.TopBar.Size = new System.Drawing.Size(635, 21);
			this.TopBar.TabIndex = 0;
			this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
			this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
			this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
			// 
			// CloseLabel
			// 
			this.CloseLabel.BackColor = System.Drawing.Color.Transparent;
			this.CloseLabel.Dock = System.Windows.Forms.DockStyle.Right;
			this.CloseLabel.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseLabel.ForeColor = System.Drawing.Color.Red;
			this.CloseLabel.Location = new System.Drawing.Point(614, 0);
			this.CloseLabel.Margin = new System.Windows.Forms.Padding(0);
			this.CloseLabel.Name = "CloseLabel";
			this.CloseLabel.Size = new System.Drawing.Size(21, 21);
			this.CloseLabel.TabIndex = 0;
			this.CloseLabel.Text = "x";
			this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CloseLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CloseLabel_MouseUp);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
			this.tableLayoutPanel1.Controls.Add(this.groupBoxAttack, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxDefend, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBoxExtra, 2, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 21);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 165);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// groupBoxAttack
			// 
			this.groupBoxAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
			this.groupBoxAttack.Controls.Add(this.panel3);
			this.groupBoxAttack.Controls.Add(this.panel2);
			this.groupBoxAttack.Controls.Add(this.panel1);
			this.groupBoxAttack.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxAttack.ForeColor = System.Drawing.Color.White;
			this.groupBoxAttack.Location = new System.Drawing.Point(3, 3);
			this.groupBoxAttack.Name = "groupBoxAttack";
			this.groupBoxAttack.Padding = new System.Windows.Forms.Padding(8);
			this.groupBoxAttack.Size = new System.Drawing.Size(205, 159);
			this.groupBoxAttack.TabIndex = 0;
			this.groupBoxAttack.TabStop = false;
			this.groupBoxAttack.Text = "Attack";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(0)))), ((int)(((byte)(18)))));
			this.panel3.Controls.Add(this.AttackButton);
			this.panel3.Controls.Add(this.AttackResult);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(8, 103);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(189, 40);
			this.panel3.TabIndex = 5;
			// 
			// AttackButton
			// 
			this.AttackButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.AttackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AttackButton.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttackButton.Location = new System.Drawing.Point(5, 5);
			this.AttackButton.Name = "AttackButton";
			this.AttackButton.Size = new System.Drawing.Size(76, 30);
			this.AttackButton.TabIndex = 3;
			this.AttackButton.Text = "Attack";
			this.AttackButton.UseVisualStyleBackColor = true;
			this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
			// 
			// AttackResult
			// 
			this.AttackResult.BackColor = System.Drawing.Color.White;
			this.AttackResult.Dock = System.Windows.Forms.DockStyle.Right;
			this.AttackResult.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttackResult.ForeColor = System.Drawing.Color.Black;
			this.AttackResult.Location = new System.Drawing.Point(87, 5);
			this.AttackResult.Name = "AttackResult";
			this.AttackResult.Size = new System.Drawing.Size(97, 30);
			this.AttackResult.TabIndex = 2;
			this.AttackResult.Text = "0";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(26)))));
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.OffensiveRate);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(8, 63);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(5);
			this.panel2.Size = new System.Drawing.Size(189, 40);
			this.panel2.TabIndex = 4;
			// 
			// OffensiveRate
			// 
			this.OffensiveRate.BackColor = System.Drawing.Color.White;
			this.OffensiveRate.DecimalPlaces = 2;
			this.OffensiveRate.Dock = System.Windows.Forms.DockStyle.Right;
			this.OffensiveRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OffensiveRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.OffensiveRate.Location = new System.Drawing.Point(87, 5);
			this.OffensiveRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.OffensiveRate.Name = "OffensiveRate";
			this.OffensiveRate.Size = new System.Drawing.Size(97, 31);
			this.OffensiveRate.TabIndex = 1;
			this.OffensiveRate.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
			this.OffensiveRate.ValueChanged += new System.EventHandler(this.OffensiveRate_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
			this.panel1.Controls.Add(this.AttackCommanderCheck);
			this.panel1.Controls.Add(this.AttackArmies);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 23);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(5);
			this.panel1.Size = new System.Drawing.Size(189, 40);
			this.panel1.TabIndex = 3;
			// 
			// AttackCommanderCheck
			// 
			this.AttackCommanderCheck.Dock = System.Windows.Forms.DockStyle.Left;
			this.AttackCommanderCheck.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttackCommanderCheck.Location = new System.Drawing.Point(5, 5);
			this.AttackCommanderCheck.Name = "AttackCommanderCheck";
			this.AttackCommanderCheck.Size = new System.Drawing.Size(76, 30);
			this.AttackCommanderCheck.TabIndex = 1;
			this.AttackCommanderCheck.Text = "Com";
			this.AttackCommanderCheck.UseVisualStyleBackColor = true;
			this.AttackCommanderCheck.CheckedChanged += new System.EventHandler(this.AttackCommanderCheck_CheckedChanged);
			// 
			// AttackArmies
			// 
			this.AttackArmies.BackColor = System.Drawing.Color.White;
			this.AttackArmies.Dock = System.Windows.Forms.DockStyle.Right;
			this.AttackArmies.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttackArmies.Location = new System.Drawing.Point(87, 5);
			this.AttackArmies.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.AttackArmies.Name = "AttackArmies";
			this.AttackArmies.Size = new System.Drawing.Size(97, 31);
			this.AttackArmies.TabIndex = 0;
			this.AttackArmies.ValueChanged += new System.EventHandler(this.AttackArmies_ValueChanged);
			// 
			// groupBoxDefend
			// 
			this.groupBoxDefend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(0)))), ((int)(((byte)(36)))));
			this.groupBoxDefend.Controls.Add(this.panel4);
			this.groupBoxDefend.Controls.Add(this.panel5);
			this.groupBoxDefend.Controls.Add(this.panel6);
			this.groupBoxDefend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxDefend.ForeColor = System.Drawing.Color.White;
			this.groupBoxDefend.Location = new System.Drawing.Point(214, 3);
			this.groupBoxDefend.Name = "groupBoxDefend";
			this.groupBoxDefend.Padding = new System.Windows.Forms.Padding(8);
			this.groupBoxDefend.Size = new System.Drawing.Size(205, 159);
			this.groupBoxDefend.TabIndex = 1;
			this.groupBoxDefend.TabStop = false;
			this.groupBoxDefend.Text = "Defend";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(0)))), ((int)(((byte)(70)))));
			this.panel4.Controls.Add(this.DefendButton);
			this.panel4.Controls.Add(this.DefenseResult);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(8, 103);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(5);
			this.panel4.Size = new System.Drawing.Size(189, 40);
			this.panel4.TabIndex = 8;
			// 
			// DefendButton
			// 
			this.DefendButton.Dock = System.Windows.Forms.DockStyle.Left;
			this.DefendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DefendButton.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefendButton.Location = new System.Drawing.Point(5, 5);
			this.DefendButton.Name = "DefendButton";
			this.DefendButton.Size = new System.Drawing.Size(76, 30);
			this.DefendButton.TabIndex = 4;
			this.DefendButton.Text = "Defend";
			this.DefendButton.UseVisualStyleBackColor = true;
			this.DefendButton.Click += new System.EventHandler(this.DefendButton_Click);
			// 
			// DefenseResult
			// 
			this.DefenseResult.BackColor = System.Drawing.Color.White;
			this.DefenseResult.Dock = System.Windows.Forms.DockStyle.Right;
			this.DefenseResult.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefenseResult.ForeColor = System.Drawing.Color.Black;
			this.DefenseResult.Location = new System.Drawing.Point(87, 5);
			this.DefenseResult.Name = "DefenseResult";
			this.DefenseResult.Size = new System.Drawing.Size(97, 30);
			this.DefenseResult.TabIndex = 2;
			this.DefenseResult.Text = "0";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.DefensiveRate);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(8, 63);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(5);
			this.panel5.Size = new System.Drawing.Size(189, 40);
			this.panel5.TabIndex = 7;
			// 
			// DefensiveRate
			// 
			this.DefensiveRate.BackColor = System.Drawing.Color.White;
			this.DefensiveRate.DecimalPlaces = 2;
			this.DefensiveRate.Dock = System.Windows.Forms.DockStyle.Right;
			this.DefensiveRate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefensiveRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.DefensiveRate.Location = new System.Drawing.Point(87, 5);
			this.DefensiveRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.DefensiveRate.Name = "DefensiveRate";
			this.DefensiveRate.Size = new System.Drawing.Size(97, 31);
			this.DefensiveRate.TabIndex = 1;
			this.DefensiveRate.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
			this.DefensiveRate.ValueChanged += new System.EventHandler(this.DefensiveRate_ValueChanged);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
			this.panel6.Controls.Add(this.DefendCommanderCheck);
			this.panel6.Controls.Add(this.DefenseArmies);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(8, 23);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(5);
			this.panel6.Size = new System.Drawing.Size(189, 40);
			this.panel6.TabIndex = 6;
			// 
			// DefendCommanderCheck
			// 
			this.DefendCommanderCheck.Dock = System.Windows.Forms.DockStyle.Left;
			this.DefendCommanderCheck.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefendCommanderCheck.Location = new System.Drawing.Point(5, 5);
			this.DefendCommanderCheck.Name = "DefendCommanderCheck";
			this.DefendCommanderCheck.Size = new System.Drawing.Size(76, 30);
			this.DefendCommanderCheck.TabIndex = 2;
			this.DefendCommanderCheck.Text = "Com";
			this.DefendCommanderCheck.UseVisualStyleBackColor = true;
			this.DefendCommanderCheck.CheckedChanged += new System.EventHandler(this.DefendCommanderCheck_CheckedChanged);
			// 
			// DefenseArmies
			// 
			this.DefenseArmies.BackColor = System.Drawing.Color.White;
			this.DefenseArmies.Dock = System.Windows.Forms.DockStyle.Right;
			this.DefenseArmies.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefenseArmies.Location = new System.Drawing.Point(87, 5);
			this.DefenseArmies.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.DefenseArmies.Name = "DefenseArmies";
			this.DefenseArmies.Size = new System.Drawing.Size(97, 31);
			this.DefenseArmies.TabIndex = 0;
			this.DefenseArmies.ValueChanged += new System.EventHandler(this.DefenseArmies_ValueChanged);
			// 
			// groupBoxExtra
			// 
			this.groupBoxExtra.Controls.Add(this.OutcomePanel);
			this.groupBoxExtra.Controls.Add(this.LossPanel);
			this.groupBoxExtra.Controls.Add(this.PreviewPanel);
			this.groupBoxExtra.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxExtra.ForeColor = System.Drawing.Color.White;
			this.groupBoxExtra.Location = new System.Drawing.Point(425, 3);
			this.groupBoxExtra.Name = "groupBoxExtra";
			this.groupBoxExtra.Padding = new System.Windows.Forms.Padding(8);
			this.groupBoxExtra.Size = new System.Drawing.Size(207, 159);
			this.groupBoxExtra.TabIndex = 2;
			this.groupBoxExtra.TabStop = false;
			this.groupBoxExtra.Text = "Outcome";
			// 
			// TitleLabel
			// 
			this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
			this.TitleLabel.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TitleLabel.ForeColor = System.Drawing.Color.White;
			this.TitleLabel.Location = new System.Drawing.Point(0, 0);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(611, 21);
			this.TitleLabel.TabIndex = 1;
			this.TitleLabel.Text = "Warzone Calculator";
			this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TitleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
			this.TitleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
			this.TitleLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
			// 
			// PreviewPanel
			// 
			this.PreviewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PreviewPanel.Controls.Add(this.label3);
			this.PreviewPanel.Controls.Add(this.PreviewDefendAmount);
			this.PreviewPanel.Controls.Add(this.PreviewAttackAmount);
			this.PreviewPanel.Controls.Add(this.DefensePreviewPanel);
			this.PreviewPanel.Controls.Add(this.AttackPreviewPanel);
			this.PreviewPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.PreviewPanel.Location = new System.Drawing.Point(8, 23);
			this.PreviewPanel.Name = "PreviewPanel";
			this.PreviewPanel.Padding = new System.Windows.Forms.Padding(5);
			this.PreviewPanel.Size = new System.Drawing.Size(191, 40);
			this.PreviewPanel.TabIndex = 0;
			// 
			// AttackPreviewPanel
			// 
			this.AttackPreviewPanel.BackColor = System.Drawing.Color.DarkRed;
			this.AttackPreviewPanel.Controls.Add(this.CommanderAttackPreview);
			this.AttackPreviewPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.AttackPreviewPanel.Location = new System.Drawing.Point(5, 5);
			this.AttackPreviewPanel.Name = "AttackPreviewPanel";
			this.AttackPreviewPanel.Padding = new System.Windows.Forms.Padding(7);
			this.AttackPreviewPanel.Size = new System.Drawing.Size(30, 30);
			this.AttackPreviewPanel.TabIndex = 0;
			// 
			// DefensePreviewPanel
			// 
			this.DefensePreviewPanel.BackColor = System.Drawing.Color.DarkBlue;
			this.DefensePreviewPanel.Controls.Add(this.CommanderDefendPreview);
			this.DefensePreviewPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.DefensePreviewPanel.Location = new System.Drawing.Point(156, 5);
			this.DefensePreviewPanel.Name = "DefensePreviewPanel";
			this.DefensePreviewPanel.Padding = new System.Windows.Forms.Padding(7);
			this.DefensePreviewPanel.Size = new System.Drawing.Size(30, 30);
			this.DefensePreviewPanel.TabIndex = 1;
			// 
			// PreviewAttackAmount
			// 
			this.PreviewAttackAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.PreviewAttackAmount.Dock = System.Windows.Forms.DockStyle.Left;
			this.PreviewAttackAmount.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreviewAttackAmount.Location = new System.Drawing.Point(35, 5);
			this.PreviewAttackAmount.Name = "PreviewAttackAmount";
			this.PreviewAttackAmount.Size = new System.Drawing.Size(44, 30);
			this.PreviewAttackAmount.TabIndex = 2;
			this.PreviewAttackAmount.Text = "0";
			this.PreviewAttackAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// PreviewDefendAmount
			// 
			this.PreviewDefendAmount.Dock = System.Windows.Forms.DockStyle.Right;
			this.PreviewDefendAmount.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PreviewDefendAmount.Location = new System.Drawing.Point(112, 5);
			this.PreviewDefendAmount.Name = "PreviewDefendAmount";
			this.PreviewDefendAmount.Size = new System.Drawing.Size(44, 30);
			this.PreviewDefendAmount.TabIndex = 3;
			this.PreviewDefendAmount.Text = "0";
			this.PreviewDefendAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(79, 5);
			this.label3.Margin = new System.Windows.Forms.Padding(0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 30);
			this.label3.TabIndex = 4;
			this.label3.Text = "▻";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// LossPanel
			// 
			this.LossPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.LossPanel.Controls.Add(this.DefendLoss);
			this.LossPanel.Controls.Add(this.AttackLoss);
			this.LossPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.LossPanel.Location = new System.Drawing.Point(8, 63);
			this.LossPanel.Name = "LossPanel";
			this.LossPanel.Padding = new System.Windows.Forms.Padding(5);
			this.LossPanel.Size = new System.Drawing.Size(191, 40);
			this.LossPanel.TabIndex = 1;
			// 
			// AttackLoss
			// 
			this.AttackLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
			this.AttackLoss.Dock = System.Windows.Forms.DockStyle.Left;
			this.AttackLoss.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttackLoss.Location = new System.Drawing.Point(5, 5);
			this.AttackLoss.Name = "AttackLoss";
			this.AttackLoss.Size = new System.Drawing.Size(74, 30);
			this.AttackLoss.TabIndex = 0;
			this.AttackLoss.Text = "-0";
			this.AttackLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DefendLoss
			// 
			this.DefendLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(64)))));
			this.DefendLoss.Dock = System.Windows.Forms.DockStyle.Right;
			this.DefendLoss.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DefendLoss.Location = new System.Drawing.Point(115, 5);
			this.DefendLoss.Name = "DefendLoss";
			this.DefendLoss.Size = new System.Drawing.Size(71, 30);
			this.DefendLoss.TabIndex = 1;
			this.DefendLoss.Text = "-0";
			this.DefendLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// OutcomePanel
			// 
			this.OutcomePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.OutcomePanel.Controls.Add(this.OutcomeDefendAmount);
			this.OutcomePanel.Controls.Add(this.panel8);
			this.OutcomePanel.Controls.Add(this.OutcomeAttackAmount);
			this.OutcomePanel.Controls.Add(this.panel7);
			this.OutcomePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.OutcomePanel.Location = new System.Drawing.Point(8, 103);
			this.OutcomePanel.Margin = new System.Windows.Forms.Padding(0);
			this.OutcomePanel.Name = "OutcomePanel";
			this.OutcomePanel.Padding = new System.Windows.Forms.Padding(5);
			this.OutcomePanel.Size = new System.Drawing.Size(191, 40);
			this.OutcomePanel.TabIndex = 2;
			// 
			// CommanderAttackPreview
			// 
			this.CommanderAttackPreview.AutoSize = true;
			this.CommanderAttackPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommanderAttackPreview.ForeColor = System.Drawing.Color.White;
			this.CommanderAttackPreview.Location = new System.Drawing.Point(7, 7);
			this.CommanderAttackPreview.Name = "CommanderAttackPreview";
			this.CommanderAttackPreview.Size = new System.Drawing.Size(16, 16);
			this.CommanderAttackPreview.TabIndex = 0;
			this.CommanderAttackPreview.UseVisualStyleBackColor = true;
			// 
			// CommanderDefendPreview
			// 
			this.CommanderDefendPreview.AutoSize = true;
			this.CommanderDefendPreview.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommanderDefendPreview.Location = new System.Drawing.Point(7, 7);
			this.CommanderDefendPreview.Name = "CommanderDefendPreview";
			this.CommanderDefendPreview.Size = new System.Drawing.Size(16, 16);
			this.CommanderDefendPreview.TabIndex = 1;
			this.CommanderDefendPreview.UseVisualStyleBackColor = true;
			// 
			// OutcomeAttackAmount
			// 
			this.OutcomeAttackAmount.Dock = System.Windows.Forms.DockStyle.Left;
			this.OutcomeAttackAmount.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutcomeAttackAmount.Location = new System.Drawing.Point(35, 5);
			this.OutcomeAttackAmount.Name = "OutcomeAttackAmount";
			this.OutcomeAttackAmount.Size = new System.Drawing.Size(44, 30);
			this.OutcomeAttackAmount.TabIndex = 4;
			this.OutcomeAttackAmount.Text = "0";
			this.OutcomeAttackAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.DarkRed;
			this.panel7.Controls.Add(this.CommanderAttackOutcome);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel7.Location = new System.Drawing.Point(5, 5);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(7);
			this.panel7.Size = new System.Drawing.Size(30, 30);
			this.panel7.TabIndex = 3;
			// 
			// CommanderAttackOutcome
			// 
			this.CommanderAttackOutcome.AutoSize = true;
			this.CommanderAttackOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommanderAttackOutcome.ForeColor = System.Drawing.Color.White;
			this.CommanderAttackOutcome.Location = new System.Drawing.Point(7, 7);
			this.CommanderAttackOutcome.Name = "CommanderAttackOutcome";
			this.CommanderAttackOutcome.Size = new System.Drawing.Size(16, 16);
			this.CommanderAttackOutcome.TabIndex = 0;
			this.CommanderAttackOutcome.UseVisualStyleBackColor = true;
			// 
			// OutcomeDefendAmount
			// 
			this.OutcomeDefendAmount.Dock = System.Windows.Forms.DockStyle.Right;
			this.OutcomeDefendAmount.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutcomeDefendAmount.Location = new System.Drawing.Point(112, 5);
			this.OutcomeDefendAmount.Name = "OutcomeDefendAmount";
			this.OutcomeDefendAmount.Size = new System.Drawing.Size(44, 30);
			this.OutcomeDefendAmount.TabIndex = 6;
			this.OutcomeDefendAmount.Text = "0";
			this.OutcomeDefendAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.DarkBlue;
			this.panel8.Controls.Add(this.CommanderDefendOutcome);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel8.Location = new System.Drawing.Point(156, 5);
			this.panel8.Name = "panel8";
			this.panel8.Padding = new System.Windows.Forms.Padding(7);
			this.panel8.Size = new System.Drawing.Size(30, 30);
			this.panel8.TabIndex = 5;
			// 
			// CommanderDefendOutcome
			// 
			this.CommanderDefendOutcome.AutoSize = true;
			this.CommanderDefendOutcome.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CommanderDefendOutcome.Location = new System.Drawing.Point(7, 7);
			this.CommanderDefendOutcome.Name = "CommanderDefendOutcome";
			this.CommanderDefendOutcome.Size = new System.Drawing.Size(16, 16);
			this.CommanderDefendOutcome.TabIndex = 1;
			this.CommanderDefendOutcome.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Off Rate";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(5, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Def Rate";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(0)))), ((int)(((byte)(9)))));
			this.ClientSize = new System.Drawing.Size(635, 186);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.TopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CalculatorForm";
			this.TopMost = true;
			this.TopBar.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.groupBoxAttack.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.OffensiveRate)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.AttackArmies)).EndInit();
			this.groupBoxDefend.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DefensiveRate)).EndInit();
			this.panel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DefenseArmies)).EndInit();
			this.groupBoxExtra.ResumeLayout(false);
			this.PreviewPanel.ResumeLayout(false);
			this.AttackPreviewPanel.ResumeLayout(false);
			this.AttackPreviewPanel.PerformLayout();
			this.DefensePreviewPanel.ResumeLayout(false);
			this.DefensePreviewPanel.PerformLayout();
			this.LossPanel.ResumeLayout(false);
			this.OutcomePanel.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel TopBar;
		private System.Windows.Forms.Label CloseLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBoxAttack;
		private System.Windows.Forms.GroupBox groupBoxDefend;
		private System.Windows.Forms.GroupBox groupBoxExtra;
		private System.Windows.Forms.NumericUpDown AttackArmies;
		private System.Windows.Forms.Label AttackResult;
		private System.Windows.Forms.NumericUpDown OffensiveRate;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label DefenseResult;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.NumericUpDown DefensiveRate;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.NumericUpDown DefenseArmies;
		private System.Windows.Forms.Button AttackButton;
		private System.Windows.Forms.Button DefendButton;
		private System.Windows.Forms.CheckBox AttackCommanderCheck;
		private System.Windows.Forms.CheckBox DefendCommanderCheck;
		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.Panel PreviewPanel;
		private System.Windows.Forms.Panel AttackPreviewPanel;
		private System.Windows.Forms.Panel DefensePreviewPanel;
		private System.Windows.Forms.Label PreviewDefendAmount;
		private System.Windows.Forms.Label PreviewAttackAmount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel LossPanel;
		private System.Windows.Forms.Label DefendLoss;
		private System.Windows.Forms.Label AttackLoss;
		private System.Windows.Forms.Panel OutcomePanel;
		private System.Windows.Forms.CheckBox CommanderAttackPreview;
		private System.Windows.Forms.CheckBox CommanderDefendPreview;
		private System.Windows.Forms.Label OutcomeDefendAmount;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.CheckBox CommanderDefendOutcome;
		private System.Windows.Forms.Label OutcomeAttackAmount;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.CheckBox CommanderAttackOutcome;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

