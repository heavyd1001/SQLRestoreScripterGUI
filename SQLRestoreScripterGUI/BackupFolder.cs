using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SQLRestoreScripter
{
    public class BackupFolder
    {

        public BackupFolder(string path, backupType type)
        {
            Path = path;
            Type = type;
			
			Files = new List<BackupFile>();
            List<FileInfo> fileInfos = new List<FileInfo>();
            DirectoryInfo info = new DirectoryInfo(Path);

			// Converts .GetFiles() to a list
            fileInfos = info.GetFiles().Select(x => x).ToList();
            
			// Creates BackupFile objects
			foreach (FileInfo fileInfo in fileInfos)
            {
				switch (Type)
				{ 
					case backupType.full:
						FullBackupFile fullBackFile = new FullBackupFile(fileInfo);
						Files.Add(fullBackFile);
						break;
					case backupType.diff:
						DiffBackupFile diffBackFile = new DiffBackupFile(fileInfo);
						Files.Add(diffBackFile);
						break;
					case backupType.log:
						LogBackupFile logBackFile = new LogBackupFile(fileInfo);
						Files.Add(logBackFile);
						break;
			}
		}
        }

		// Properties
		public string Path { get; set; }
		public backupType Type { get; set; }
		public DirectoryInfo Info { get; set; }
		public List<BackupFile> Files { get; set; }
    }
}
