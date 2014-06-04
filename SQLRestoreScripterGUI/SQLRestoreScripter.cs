using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SQLRestoreScripter;
using RikTheVeggie;

namespace SQLRestoreScripterGUI
{

	public partial class SQLRestoreScripter : Form
	{
		public SQLRestoreScripter()
		{
			InitializeComponent();
		}

		MaintenancePlan maintPlan = new MaintenancePlan();
		Restore restore = new Restore();

		private void btnFull_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();

			if (result == DialogResult.OK)
			{
				txtFullBackupPath.Text = fbd.SelectedPath;
			}
		}
		private void btnLog_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();

			if (result == DialogResult.OK)
			{
				txtLogBackupPath.Text = fbd.SelectedPath;
			}
		}
		private void txtFullPath_TextChanged(object sender, EventArgs e)
		{

			TextBox txtSender = (TextBox)sender;

			if (!Directory.Exists(txtSender.Text))
			{
				treeView1.Nodes.Clear();
				return;
			}

			else
			{
				maintPlan.FullBKPath = txtSender.Text;
				//PopulateTreeview(maintPlan);
			}

		}
		private void txtLogPath_TextChanged(object sender, EventArgs e)
		{

			TextBox txtSender = (TextBox)sender;

			if (!Directory.Exists(txtSender.Text))
			{
				treeView1.Nodes.Clear();
				return;
			}

			else
			{
				maintPlan.LogBKPath = txtSender.Text;
				//PopulateTreeview(maintPlan);
			}

		}

		private void chkMovingDBs_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox chkSender = (CheckBox)sender;
			restore.IsMoving = chkSender.Checked;

			if (restore.IsMoving == true && txtMovingDBPath.Enabled == false)
			{
				txtMovingDBPath.Enabled = true;
				btnMovingDBs.Enabled = true;
			}
			else if (restore.IsMoving == false && txtMovingDBPath.Enabled == true)
			{
				txtMovingDBPath.Enabled = false;
				btnMovingDBs.Enabled = false;
			}

		}
		private void chkMovingLogs_CheckedChanged(object sender, EventArgs e)
		{
			CheckBox chkSender = (CheckBox)sender;
			restore.IsMoving = chkSender.Checked;

			if (restore.IsMoving == true && txtMovingLogPath.Enabled == false)
			{
				txtMovingLogPath.Enabled = true;
				btnMovingLogs.Enabled = true;
			}
			else if (restore.IsMoving == false && txtMovingLogPath.Enabled == true)
			{
				txtMovingLogPath.Enabled = false;
				btnMovingLogs.Enabled = false;
			}
		}

		private void btnMovingDBs_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();

			if (result == DialogResult.OK)
			{
				txtMovingDBPath.Text = fbd.SelectedPath;
			}
		}
		private void btnMovingLogs_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();

			if (result == DialogResult.OK)
			{
				txtMovingLogPath.Text = fbd.SelectedPath;
			}
		}
		private void txtMovingDBPath_TextChanged(object sender, EventArgs e)
		{
			TextBox txtSender = (TextBox)sender;
			restore.TargetDBFolder = txtSender.Text;

		}
		private void txtMovingLogPath_TextChanged(object sender, EventArgs e)
		{
			TextBox txtSender = (TextBox)sender;
			restore.TargetLogFolder = txtSender.Text;
		}

		private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
		{

			if(e.Action != TreeViewAction.Unknown)
			{
				bool isChecked = e.Node.Checked;

				switch (e.Node.Level)
				{
					case 0:
							this.UnCheckRestorepoints(e.Node);
							this.CheckLastRestorePoint(e.Node, e.Node.Checked);
							break;
					case 1:
							this.UnCheckRestorepoints(e.Node.Parent);
							this.CheckParentNode(e.Node, isChecked);
							break;
					case 2:
							this.UnCheckRestorepoints(e.Node.Parent.Parent);
							this.CheckParentNode(e.Node, isChecked);
							this.CheckParentNode(e.Node.Parent, isChecked);
							break;
				}
			}
		}

		private void UnCheckRestorepoints(TreeNode treeNode)
		{
			foreach (TreeNode node in treeNode.Nodes)
			{
				node.Checked = false;
				if (node.Nodes.Count > 0)
				{
					UnCheckRestorepoints(node);
				}
			}
		}
		private void CheckParentNode(TreeNode treeNode, bool isChecked)
		{
			treeNode.Checked = isChecked;
			treeNode.Parent.Checked = isChecked;
		}
		private void CheckLastRestorePoint(TreeNode treeNode, bool isChecked)
		{
			treeNode.Nodes[treeNode.Nodes.Count - 1].Checked = isChecked;
			if (treeNode.Nodes[treeNode.Nodes.Count - 1].Nodes.Count <= 0)
				return;
			treeNode.Nodes[treeNode.Nodes.Count - 1].Nodes[treeNode.Nodes[treeNode.Nodes.Count - 1].Nodes.Count - 1].Checked = isChecked;
		}

		public void PopulateTreeview(MaintenancePlan maintPlan)
		{
			int db = 0;
			int dateindex = 0;
			treeView1.Nodes.Clear();
				foreach (string dB in maintPlan.DBs())
				{

					treeView1.Nodes.Add(dB);
					foreach (DateTime date in maintPlan.GetDates(dB))
					{
						treeView1.Nodes[db].Nodes.Add(date.ToString("d"));
						treeView1.Nodes[db].LastNode.Tag = maintPlan.GetFullBackupFile(dB, date);


						if (maintPlan.LogBKFolder != null)
						{
							foreach (DateTime time in maintPlan.GetLogTimes(dB,date))
							{
								treeView1.Nodes[db].Nodes[dateindex].Nodes.Add(time.ToString("hh:mm tt"));
								treeView1.Nodes[db].Nodes[dateindex].LastNode.Tag = maintPlan.GetLogBackupFile(dB, time);
							}
							dateindex++;
						}

					}
					dateindex = 0;
					db++;
				}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			List<BackupFile> files = new List<BackupFile>();
			foreach (TreeNode node in treeView1.Nodes)
			{
				if (node.Checked == false)
					continue;

				foreach (TreeNode subNode in node.Nodes)
				{
					if (subNode.Checked == false)
						continue;

					files.Add((BackupFile)subNode.Tag);

					foreach (TreeNode subSubNode in subNode.Nodes)
					{
						if (subSubNode.Checked == true)
							continue;
						
						files.Add((BackupFile)subSubNode.Tag);

					}
				}
				
			}

			StringBuilder strScript = new StringBuilder();
			
			foreach (BackupFile file in files)
			{
				strScript.AppendLine(file.ToString());
			}

			textBox4.Text = strScript.ToString();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			PopulateTreeview(maintPlan);
		}


	}
}
