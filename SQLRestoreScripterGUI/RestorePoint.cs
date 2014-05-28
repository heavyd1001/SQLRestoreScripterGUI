using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLRestoreScripter
{
    public class RestorePoint
    {

        public RestorePoint()
			: this("", default(DateTime), default(DateTime)) { }
        public RestorePoint(string database)
			: this(database, default(DateTime), default(DateTime)) { }
        public RestorePoint(string database,DateTime date, DateTime time)
        {
            Database = database;
            Date = date;
            Time = time;
        }

		public List<BackupFile> BackupSet { get; set; }
		public string Database { get; set; }
		public DateTime Date { get; set; }
		public DateTime Time { get; set; }
		public bool IsRestorePoint { get; set; }

    }
}

