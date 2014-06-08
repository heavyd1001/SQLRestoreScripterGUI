using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using SQLRestoreScripterGUI;


namespace SQLRestoreScripter
{
    public class BackupFile
    {
		public string Name { get; set; }
		public string Path { get; set; }
		public DateTime LastModified { get; set; }
		public long Size { get; set; }
        public string DatabaseName { get; set; }
		public string FileExtension { get; set; }
		public bool IsTargetRestorepoint { get; set; }
		
		public BackupFile(FileInfo file)
        {
            Name = file.Name;
            Path = file.DirectoryName;
            LastModified = file.LastWriteTime;
            Size = file.Length;
            DatabaseName = Regex.Split(Name, "_backup_")[0];
            FileExtension = file.Extension.ToString();
        }
    }
	public class FullBackupFile : BackupFile
	{
		public bool DBIsMoving { get; set; }
		public bool LogIsMoving { get; set; }
 		public DirectoryInfo DBTarget { get; set; }
		public DirectoryInfo LogTarget { get; set; }

		public FullBackupFile(FileInfo file) : base(file) { }

		public override string ToString()
		{
			StringBuilder strFull = new StringBuilder();
			strFull.AppendFormat("RESTORE DATABASE \"{0}\"\r\n", this.DatabaseName);
			strFull.AppendFormat("	FROM DISK = \'{0}\\{1}\'\r\n", this.Path, this.Name);
			strFull.AppendFormat("	WITH FILE = 1");
			
			if (IsTargetRestorepoint == true)
				strFull.AppendFormat(", RECOVERY");
			else
				strFull.AppendFormat(", NORECOVERY");

			if (DBIsMoving == true)
				strFull.AppendFormat(", MOVE \'{0}\' TO \'{1}\\{2}.mdf\'", DatabaseName, DBTarget.ToString(), DatabaseName);

			if (LogIsMoving == true)
				strFull.AppendFormat(", MOVE \'{0}_log\' TO \'{1}\\{2}.LDF\'", DatabaseName, DBTarget.ToString(), DatabaseName);


			strFull.AppendLine(";");
			return strFull.ToString();
		}
	}
	public class DiffBackupFile : BackupFile
	{
		public DiffBackupFile(FileInfo file) : base(file) { }

		public override string ToString()
		{
			return "this is a Diff Backup File";
		}
	}
	public class LogBackupFile : BackupFile
	{
		public LogBackupFile(FileInfo file) : base(file) { }

		public override string ToString()
		{
			StringBuilder strLog = new StringBuilder();
			strLog.AppendLine(string.Format("RESTORE LOG \"{0}\"", this.DatabaseName));
			strLog.AppendLine(string.Format("	FROM DISK = \'{0}\\{1}\'", this.Path, this.Name));
			strLog.AppendLine("	WITH FILE = 1,");
			if (IsTargetRestorepoint == true)
				strLog.AppendLine("		RECOVERY;");
			else
				strLog.AppendLine("		NORECOVERY;");

			return strLog.ToString();
		}
	}
}