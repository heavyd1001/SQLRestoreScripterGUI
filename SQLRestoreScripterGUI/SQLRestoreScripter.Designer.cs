namespace SQLRestoreScripterGUI
{
	partial class SQLRestoreScripter
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.chkMovingLogs = new System.Windows.Forms.CheckBox();
			this.btnMovingLogs = new System.Windows.Forms.Button();
			this.btnMovingDBs = new System.Windows.Forms.Button();
			this.txtMovingLogPath = new System.Windows.Forms.TextBox();
			this.txtMovingDBPath = new System.Windows.Forms.TextBox();
			this.chkMovingDBs = new System.Windows.Forms.CheckBox();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnLog = new System.Windows.Forms.Button();
			this.btnDiff = new System.Windows.Forms.Button();
			this.btnFull = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtLogBackupPath = new System.Windows.Forms.TextBox();
			this.txtDiffBackupPath = new System.Windows.Forms.TextBox();
			this.txtFullBackupPath = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.menuStrip1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(784, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 425);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(784, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// textBox4
			// 
			this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox4.Location = new System.Drawing.Point(403, 3);
			this.textBox4.Multiline = true;
			this.textBox4.Name = "textBox4";
			this.tableLayoutPanel1.SetRowSpan(this.textBox4, 2);
			this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox4.Size = new System.Drawing.Size(378, 395);
			this.textBox4.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.chkMovingLogs);
			this.groupBox1.Controls.Add(this.btnMovingLogs);
			this.groupBox1.Controls.Add(this.btnMovingDBs);
			this.groupBox1.Controls.Add(this.txtMovingLogPath);
			this.groupBox1.Controls.Add(this.txtMovingDBPath);
			this.groupBox1.Controls.Add(this.chkMovingDBs);
			this.groupBox1.Controls.Add(this.btnGenerate);
			this.groupBox1.Controls.Add(this.btnLog);
			this.groupBox1.Controls.Add(this.btnDiff);
			this.groupBox1.Controls.Add(this.btnFull);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtLogBackupPath);
			this.groupBox1.Controls.Add(this.txtDiffBackupPath);
			this.groupBox1.Controls.Add(this.txtFullBackupPath);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(394, 149);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Backup Paths";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(328, 20);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 49);
			this.button1.TabIndex = 18;
			this.button1.Text = "Select DBs";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// chkMovingLogs
			// 
			this.chkMovingLogs.AutoSize = true;
			this.chkMovingLogs.Location = new System.Drawing.Point(9, 126);
			this.chkMovingLogs.Name = "chkMovingLogs";
			this.chkMovingLogs.Size = new System.Drawing.Size(87, 17);
			this.chkMovingLogs.TabIndex = 17;
			this.chkMovingLogs.Text = "Moving Logs";
			this.chkMovingLogs.UseVisualStyleBackColor = true;
			this.chkMovingLogs.CheckedChanged += new System.EventHandler(this.chkMovingLogs_CheckedChanged);
			// 
			// btnMovingLogs
			// 
			this.btnMovingLogs.Enabled = false;
			this.btnMovingLogs.Location = new System.Drawing.Point(297, 122);
			this.btnMovingLogs.Name = "btnMovingLogs";
			this.btnMovingLogs.Size = new System.Drawing.Size(24, 23);
			this.btnMovingLogs.TabIndex = 16;
			this.btnMovingLogs.Text = "...";
			this.btnMovingLogs.UseVisualStyleBackColor = true;
			this.btnMovingLogs.Click += new System.EventHandler(this.btnMovingLogs_Click);
			// 
			// btnMovingDBs
			// 
			this.btnMovingDBs.Enabled = false;
			this.btnMovingDBs.Location = new System.Drawing.Point(297, 96);
			this.btnMovingDBs.Name = "btnMovingDBs";
			this.btnMovingDBs.Size = new System.Drawing.Size(24, 23);
			this.btnMovingDBs.TabIndex = 15;
			this.btnMovingDBs.Text = "...";
			this.btnMovingDBs.UseVisualStyleBackColor = true;
			this.btnMovingDBs.Click += new System.EventHandler(this.btnMovingDBs_Click);
			// 
			// txtMovingLogPath
			// 
			this.txtMovingLogPath.Enabled = false;
			this.txtMovingLogPath.Location = new System.Drawing.Point(100, 124);
			this.txtMovingLogPath.Name = "txtMovingLogPath";
			this.txtMovingLogPath.Size = new System.Drawing.Size(191, 20);
			this.txtMovingLogPath.TabIndex = 12;
			this.txtMovingLogPath.TextChanged += new System.EventHandler(this.txtMovingLogPath_TextChanged);
			// 
			// txtMovingDBPath
			// 
			this.txtMovingDBPath.Enabled = false;
			this.txtMovingDBPath.Location = new System.Drawing.Point(100, 98);
			this.txtMovingDBPath.Name = "txtMovingDBPath";
			this.txtMovingDBPath.Size = new System.Drawing.Size(191, 20);
			this.txtMovingDBPath.TabIndex = 11;
			this.txtMovingDBPath.TextChanged += new System.EventHandler(this.txtMovingDBPath_TextChanged);
			// 
			// chkMovingDBs
			// 
			this.chkMovingDBs.AutoSize = true;
			this.chkMovingDBs.Location = new System.Drawing.Point(9, 102);
			this.chkMovingDBs.Name = "chkMovingDBs";
			this.chkMovingDBs.Size = new System.Drawing.Size(84, 17);
			this.chkMovingDBs.TabIndex = 10;
			this.chkMovingDBs.Text = "Moving DBs";
			this.chkMovingDBs.UseVisualStyleBackColor = true;
			this.chkMovingDBs.CheckedChanged += new System.EventHandler(this.chkMovingDBs_CheckedChanged);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(327, 75);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(61, 69);
			this.btnGenerate.TabIndex = 9;
			this.btnGenerate.Text = "Generate Script";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// btnLog
			// 
			this.btnLog.Location = new System.Drawing.Point(297, 70);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(24, 23);
			this.btnLog.TabIndex = 8;
			this.btnLog.Text = "...";
			this.btnLog.UseVisualStyleBackColor = true;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// btnDiff
			// 
			this.btnDiff.Location = new System.Drawing.Point(297, 44);
			this.btnDiff.Name = "btnDiff";
			this.btnDiff.Size = new System.Drawing.Size(24, 23);
			this.btnDiff.TabIndex = 7;
			this.btnDiff.Text = "...";
			this.btnDiff.UseVisualStyleBackColor = true;
			// 
			// btnFull
			// 
			this.btnFull.Location = new System.Drawing.Point(297, 18);
			this.btnFull.Name = "btnFull";
			this.btnFull.Size = new System.Drawing.Size(24, 23);
			this.btnFull.TabIndex = 6;
			this.btnFull.Text = "...";
			this.btnFull.UseVisualStyleBackColor = true;
			this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Log Backup Path";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Diff Backup Path";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Full Backup Path";
			// 
			// txtLogBackupPath
			// 
			this.txtLogBackupPath.Location = new System.Drawing.Point(100, 72);
			this.txtLogBackupPath.Name = "txtLogBackupPath";
			this.txtLogBackupPath.Size = new System.Drawing.Size(191, 20);
			this.txtLogBackupPath.TabIndex = 2;
			this.txtLogBackupPath.TextChanged += new System.EventHandler(this.txtLogPath_TextChanged);
			// 
			// txtDiffBackupPath
			// 
			this.txtDiffBackupPath.Location = new System.Drawing.Point(100, 46);
			this.txtDiffBackupPath.Name = "txtDiffBackupPath";
			this.txtDiffBackupPath.Size = new System.Drawing.Size(191, 20);
			this.txtDiffBackupPath.TabIndex = 1;
			// 
			// txtFullBackupPath
			// 
			this.txtFullBackupPath.Location = new System.Drawing.Point(100, 20);
			this.txtFullBackupPath.Name = "txtFullBackupPath";
			this.txtFullBackupPath.Size = new System.Drawing.Size(191, 20);
			this.txtFullBackupPath.TabIndex = 0;
			this.txtFullBackupPath.TextChanged += new System.EventHandler(this.txtFullPath_TextChanged);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 401);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.CheckBoxes = true;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 158);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(394, 240);
			this.treeView1.TabIndex = 1;
			this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
			// 
			// SQLRestoreScripter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 447);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(800, 400);
			this.Name = "SQLRestoreScripter";
			this.Text = "SQL Restore Scripter";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkMovingLogs;
		private System.Windows.Forms.Button btnMovingLogs;
		private System.Windows.Forms.Button btnMovingDBs;
		private System.Windows.Forms.TextBox txtMovingLogPath;
		private System.Windows.Forms.TextBox txtMovingDBPath;
		private System.Windows.Forms.CheckBox chkMovingDBs;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Button btnDiff;
		private System.Windows.Forms.Button btnFull;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLogBackupPath;
		private System.Windows.Forms.TextBox txtDiffBackupPath;
		private System.Windows.Forms.TextBox txtFullBackupPath;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button1;
	}
}

