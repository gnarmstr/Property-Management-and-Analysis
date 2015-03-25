﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Property_Management_and_Analysis
{
	class FormDrag
	{

		public static void formDrag_MouseDown(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				GlobalVar.dragging = true;
				GlobalVar.offsetX = e.X;
				GlobalVar.offsetY = e.Y;
			}
		}

		public static void formDrag_MouseUp(MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				GlobalVar.dragging = false;
			}
		}

	}
}
