﻿using System;
using System.Windows.Forms;
using Common.Resources;
using Common.Resources.Properties;
using System.Drawing;

namespace Property_Management_and_Analysis
{
	public partial class FirstTime : Form
	{
		public FirstTime()
		{
			Location = new Point(300,100);
			InitializeComponent();
			BackgroundImage = Resources.Button_Green;
			BackgroundImageLayout = ImageLayout.Stretch;
			panel1.BackgroundImage = Resources.Background_Blue;
		}

		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | 0x2000000;
				return cp;
			}
		}

		private void DomesticActivities_Load(object sender, EventArgs e)
		{
			pictureBoxYes.Image = Tools.GetIcon(Resources.Ok, 40);
		}

		private void pictureBoxYes_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
