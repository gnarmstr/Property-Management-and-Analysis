﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Property_Management_and_Analysis
{
	class GlobalVar
	{
		public static string SettingsPath;

		public static int MainFormLocxationX;

		public static int MainFormLocxationY;

		public static MainForm.MultiDimDictList<int, int> AgeAdjust = new MainForm.MultiDimDictList<int, int>();

		public static MainForm.MultiDimDictList<int, object> CombineValue = new MainForm.MultiDimDictList<int, object>();

		public static MainForm.MultiDimDictList<int, object> LifeStylePeace = new MainForm.MultiDimDictList<int, object>();

		public static MainForm.MultiDimDictList<int, object> LifeStyleWar = new MainForm.MultiDimDictList<int, object>();

		public static MainForm.MultiDimDictList<int, object> ActuaryTable = new MainForm.MultiDimDictList<int, object>();

		public static MainForm.MultiDimDictList<int, object> LimbsAgeAdjust = new MainForm.MultiDimDictList<int, object>();

		public static MainForm.MultiDimDictList<int, object>[] ExcelData;

		public static bool startup;

		public static bool FirstTimeStart;

		public static bool DisclaimerCheck;

		public static bool dragging;

		public static int offsetX;

		public static int offsetY;

		public static List<string> PropertyAddress = new List<string>();

		public static List<string> PurchasePrice = new List<string>();

		public static List<string> Description = new List<string>();

		public static List<string> Fees = new List<string>();


	}
}
