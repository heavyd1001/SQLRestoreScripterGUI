﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLRestoreScripter;
using System.IO;
namespace SQLRestoreScripterGUI
{
	class Restore
	{
		string _targetDBFolder;
		string _targetLogFolder;

		public List<RestorePoint> RestorePoints { get; set; }
		public bool IsMoving { get; set; }
		public string TargetDBFolder
		{
			get { return _targetDBFolder; }
			set
			{
				if (!Directory.Exists(value))
					return;
				else
					_targetLogFolder = value;
			}

		}
		public string TargetLogFolder
		{
			get { return _targetLogFolder; }
			set
			{
				if (!Directory.Exists(value))
					return;
				else
					_targetDBFolder = value;
			}
		}
		
		public Restore()
			: this(new List<BackupFile>()) {}
		public Restore(List<BackupFile> dBs)
		{
			RestorePoints = new List<RestorePoint>();
			foreach (BackupFile dB in dBs)
			{
				//RestorePoints.Add(new RestorePoint(dB));
			}
		}

		public List<string> BackupChain(string dB, DateTime restorePoint)
		{
			List<string> backupChain = new List<string>();



			return backupChain;
		}



	}
}
