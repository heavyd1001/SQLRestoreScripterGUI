using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

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
		public FullBackupFile(FileInfo file) : base(file) { }

		public override string ToString()
		{
			StringBuilder strFull = new StringBuilder();
			strFull.AppendLine(string.Format("RESTORE DATABASE \'{0}\'", this.DatabaseName));
			strFull.AppendLine(string.Format("	FROM DISK = \'{0}{1}\'", this.Path,this.Name));
			strFull.AppendLine("	WITH FILE = 0");
			strFull.AppendLine("		NORECOVERY;");

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
			StringBuilder strFull = new StringBuilder();
			strFull.AppendLine(string.Format("RESTORE LOG \'{0}\'", this.DatabaseName));
			strFull.AppendLine(string.Format("	FROM DISK = \'{0}{1}\'", this.Path, this.Name));
			strFull.AppendLine("	WITH FILE = 0");
			strFull.AppendLine("		NORECOVERY;");

			return strFull.ToString();
		}
	}
}