#region Using

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Common.Resources;
using Common.Resources.Properties;
using GemBox.Spreadsheet;

#endregion

namespace Property_Management_and_Analysis
{
	public partial class MainForm : Form
	{
		#region Initialization

		public MainForm()
		{
			InitializeComponent();
			Settings();
			getLifeStyleWar();
			getLifeStylePeace();
			getActuaryTable();
			getCombinedValue();
			getLimbsAgeAdjust();
			LoadData();
			UpdateAll();
			GlobalVar.startup = false;
		}

		#endregion

		#region Used to allow graphgic refresh and draw before display to stop flickering
		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | 0x2000000;
				return cp;
			}
		}
		#endregion

		#region Settings

		private void Settings()
		{
			MinimumSize = new Size(725, 790);
			MaximumSize = new Size(725, 790);
			GlobalVar.SettingsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				"Property Management and Analysis");
			SaveAll.Image = Tools.ResizeImage(Resources.Save, 130, 30);
			GlobalVar.ExcelData = new[]
			{
				GlobalVar.LifeStyleWar, GlobalVar.LifeStylePeace, GlobalVar.ActuaryTable, GlobalVar.CombineValue,
				GlobalVar.LimbsAgeAdjust
			};
			
			GlobalVar.startup = true;

			panelMainPoints.BackgroundImage = Resources.Bones_Blue_Small;
			BackgroundImage = Resources.MainBackground_Green_Small1;
			BackgroundImageLayout = ImageLayout.Stretch;
			buttonInstructions.BackgroundImage = Resources.button_Blue_Small;
			buttonLifeStyle.BackgroundImage = Resources.Button_Green;
			pictureBoxClose.BackgroundImage = Resources.Close;
			buttonMainTitle.BackgroundImage = Resources.button_Blue_Small;

			GlobalVar.DisclaimerCheck = false;

		}

		#endregion

		#region Load Data

		private void LoadData()
		{
			var profile = new XmlProfileSettings();

			#region Profiles
			GlobalVar.FirstTimeStart = profile.GetSetting(XmlProfileSettings.SettingType.Profiles, "FirstTimeStart", true);
			#endregion
	
		}

		#endregion

		#region Main Form Load
		private void MainForm_Load(object sender, EventArgs e)
		{
			var disclaimer = new Disclaimer();
			disclaimer.ShowDialog();
			if (GlobalVar.DisclaimerCheck == false)
			{
				SaveMessage.SaveClose = 2;
				Application.Exit();
			}
			if (GlobalVar.FirstTimeStart)
			{
				var firstTime = new FirstTime();
				firstTime.ShowDialog();
				GlobalVar.FirstTimeStart = false;
			}
		}
		#endregion

		#region Get Excel Data Tables

		private void getLifeStyleWar()
		{
			var columns = 21;
			var sheet = 0;
			var excelData = 0;
			importExcel(columns, sheet, excelData);
		}

		private void getLifeStylePeace()
		{
			var columns = 8;
			var sheet = 1;
			var excelData = 1;
			importExcel(columns, sheet, excelData);
		}

		private void getActuaryTable()
		{
			var columns = 8;
			var sheet = 2;
			var excelData = 2;
			importExcel(columns, sheet, excelData);
		}

		private void getCombinedValue()
		{
			var columns = 100;
			var sheet = 3;
			var excelData = 3;
			importExcel(columns, sheet, excelData);
		}

		private void getLimbsAgeAdjust()
		{
			var columns = 7;
			var sheet = 4;
			var excelData = 4;
			importExcel(columns, sheet, excelData);
		}

		private void importExcel(int columns, int sheet, int excelData)
		{
			SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
			ExcelFile ef = ExcelFile.Load(GlobalVar.SettingsPath + @"\DVA_Tables.xls");
			DataTable dataTable = new DataTable();
			// Depending on the format of the input file, you need to change this:
			var i = 0;
			do
			{
				dataTable.Columns.Add("Column" + i, typeof (string));
				i++;
			} while (i < columns);
			// Select the first worksheet from the file.

			ExcelWorksheet ws = ef.Worksheets[sheet];
			ExtractToDataTableOptions options = new ExtractToDataTableOptions(0, 0, 100);
			options.ExtractDataOptions = ExtractDataOptions.StopAtFirstEmptyRow;
			options.ExcelCellToDataTableCellConverting += (sender, e) =>
			{
				if (!e.IsDataTableValueValid)
				{
					// GemBox.Spreadsheet doesn't automatically convert numbers to strings in ExtractToDataTable() method because of culture issues; 

					// someone would expect the number 12.4 as "12.4" and someone else as "12,4".
					e.DataTableValue = e.ExcelCell.Value == null ? null : e.ExcelCell.Value.ToString();
					e.Action = ExtractDataEventAction.Continue;
				}
			};
			// Extract the data from the worksheet to the DataTable.
			// Data is extracted starting at first row and first column.

			ws.ExtractToDataTable(dataTable, options);
			// Write DataTable content
			GlobalVar.ExcelData[excelData] = new MultiDimDictList<int, object>();
			i = 0;
			int ii;
			foreach (DataRow row in dataTable.Rows)
			{
				ii = 0;
				do
				{
					GlobalVar.ExcelData[excelData].Add(i, row[ii]);
					ii++;
				} while (ii < columns);
				i++;
			}
		}

		public class MultiDimDictList<K, T> : Dictionary<K, List<T>>
		{
			public void Add(K key, T addObject)
			{
				if (!ContainsKey(key)) Add(key, new List<T>());
				base[key].Add(addObject);
			}
		}

		#endregion

		#region Update All

		private void UpdateAll()
		{
			
	//			textBoxLumpSumPayout.Text = (Math.Round(Convert.ToDecimal(GlobalVar.ExcelData[2][0][sex])*Convert.ToDecimal(textBoxWeeklyPayout.Text), 2)).ToString();
			
		}
		#endregion

		#region Print Summary Page

		private void buttonPrint_Click(object sender, EventArgs e)
		{
			var printSummary = new PrintSummary();
			printSummary.ShowDialog();
		}

		#endregion

		#region Drag Main Form around

		private void buttonMainTitle_MouseDown(object sender, MouseEventArgs e)
		{
			FormDrag.formDrag_MouseDown(e);
		}

		private void buttonMainTitle_MouseMove(object sender, MouseEventArgs e)
		{
			if (GlobalVar.dragging)
			{
				Left = e.X + Left - GlobalVar.offsetX;
				Top = e.Y + Top - GlobalVar.offsetY;
			}
		}

		private void buttonMainTitle_MouseUp(object sender, MouseEventArgs e)
		{
			FormDrag.formDrag_MouseUp(e);
		}

		#endregion

		#region Instructions
		private void buttonInstructions_Click(object sender, EventArgs e)
		{

			var instructions = new Instructions();
			instructions.ShowDialog();
		}
		#endregion

		#region Close Application
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
				e.Cancel = false;
				switch (SaveMessage.SaveClose)
				{
					case 0:
						e.Cancel = true;
						break;
					case 1:
						Save();
						break;
					case 2:
						break;
				}
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			var saveMessage = new SaveMessage();
			saveMessage.ShowDialog();
			Close();
		}

		#endregion

		#region Save Data
		private void Save()
		{
			var profile = new XmlProfileSettings();

			#region Profiles
			profile.PutSetting(XmlProfileSettings.SettingType.Profiles, "FirstTimeStart", GlobalVar.FirstTimeStart);
			#endregion

			var okMessage = new OkMessage();
			okMessage.ShowDialog();
		}

		private void SaveAll_Click(object sender, EventArgs e)
		{
			Save();
		}
		#endregion

	}
}
