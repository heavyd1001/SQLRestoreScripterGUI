using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SQLRestoreScripter
{
	public enum backupType
	{
		full,
		diff,
		log
	}

    public class MaintenancePlan
    {
        private string _fullBKPath;
        private string _diffBKPath;
        private string _logBKPath;

        private BackupFolder _fullBKFolder;
		private BackupFolder _logBKFolder;

        public MaintenancePlan()
        {
            _fullBKPath = null;
            _diffBKPath = null;
            _logBKPath = null;

            _fullBKFolder = null;
			_logBKFolder = null;
        }

        public string FullBKPath
        {
            get { return _fullBKPath; }
            set
            {
                if (Directory.Exists(value))
                { 
                    _fullBKPath = value;
                    _fullBKFolder = new BackupFolder(_fullBKPath, backupType.full);
                }
                else { return; }
            }
        }
		public string LogBKPath
		{
			get { return _logBKPath; }
			set
			{
				if (Directory.Exists(value))
				{
					_logBKPath = value;
					_logBKFolder = new BackupFolder(_logBKPath, backupType.log);
				}
				else { return; }
			}
		}

        public BackupFolder FullBKFolder
        {
            get { return _fullBKFolder; }
        }
		public BackupFolder LogBKFolder
		{
			get { return _logBKFolder; }
		}

		
		/// <summary>
		/// Returns Distict databases listed in Full backup directory
		/// </summary>
		public List<string> DBs()
        {
            List<string> DBs;
            DBs =  _fullBKFolder.Files.Select(x => x.DatabaseName).Distinct().ToList();
            return DBs;
        }

		/// <summary>
		/// Returns dates for full backups
		/// </summary>
        public List<DateTime> GetDates()
        {
            List<DateTime> dates;
            dates = FullBKFolder.Files.Select(x => x.LastModified.Date).Distinct().ToList();
            return dates;
        }
		public List<DateTime> GetDates(string dB)
		{
			List<DateTime> dates;
			dates = FullBKFolder.Files.Where(x => x.DatabaseName == dB).Select(x => x.LastModified.Date).Distinct().ToList();
			return dates;
		}

		/// <summary>
		/// Returns log times
		/// </summary>
		public List<DateTime> GetLogTimes(string dB,DateTime date)
		{
			List<DateTime> times;
			times = LogBKFolder.Files.Where(x => x.DatabaseName == dB).Where(x=>x.LastModified.Date == date).Select(x => x.LastModified).Distinct().ToList();
			return times;
		}

        public List<string> FileNames()
        {
            List<string> fileNames;
            fileNames = FullBKFolder.Files.Select(x => x.Name).ToList();
            return fileNames;
        }
		
		public DateTime LatestDate(string dB)
		{
			DateTime restorePoint;
			restorePoint = _fullBKFolder.Files.Where(x => x.DatabaseName == dB).Select(x => x.LastModified.Date).Max();
			return restorePoint;
		}

		public BackupFile GetFullBackupFile(string dB,DateTime date)
		{
			BackupFile file = null;
			file = _fullBKFolder.Files.Where(x => x.DatabaseName == dB).Where(x => x.LastModified == date).Single();
			return file;
		}
    }
}
