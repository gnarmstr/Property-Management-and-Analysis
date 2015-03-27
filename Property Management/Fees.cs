using System;
using System.Windows.Forms;
using Common.Resources;
using Common.Resources.Properties;
using System.Drawing;

namespace Property_Management_and_Analysis
{
	public partial class Fees : Form
	{
		#region Initialisation
		public Fees()
		{
			if (ActiveForm != null)
				Location = new Point(ActiveForm.Location.X + 100, ActiveForm.Location.Y + 100);
			InitializeComponent();
			pictureBoxClose.BackgroundImage = Resources.Close;
			buttonMainTitle.BackgroundImage = Resources.button_Blue_Small;
			pictureBoxAdd.BackgroundImage = Resources.add;
			pictureBoxDelete.BackgroundImage = Resources.delete;
			BackgroundImage = Resources.Background_Blue;
			BackgroundImageLayout = ImageLayout.Stretch;
		}

		private void NewProperty_Load(object sender, EventArgs e)
		{
			listViewFees.GridLines = true;
			listViewFees.Size = new Size(238, 373);
			listViewFees.Columns[0].Width = 150;
			listViewFees.Columns[1].Width = 80;
			pictureBoxOK.Image = Tools.GetIcon(Resources.Ok, 40);
			var i = 0;
			if (GlobalVar.Description.Count > 0)
			{
				do
				{
					listViewFees.Items.Add(new ListViewItem(new[] {GlobalVar.Description[i], "$" + GlobalVar.Fees[i]}));
					i++;
				} while (i < GlobalVar.Description.Count);
			}
		}

		#endregion

		#region Settings
		protected override CreateParams CreateParams
		{
			get
			{
				var cp = base.CreateParams;
				cp.ExStyle = cp.ExStyle | 0x2000000;
				return cp;
			}
		}

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

		#region Close

		private void pictureBoxOK_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		private void pictureBoxAdd_Click(object sender, EventArgs e)
		{
			listViewFees.Items.Add(new ListViewItem(new[] { textBoxDescription.Text, "$" + textBoxFee.Text }));
			GlobalVar.Description.Add(textBoxDescription.Text);
			GlobalVar.Fees.Add(textBoxFee.Text);
		}

		private void pictureBoxDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem eachItem in listViewFees.SelectedItems)
			{
				listViewFees.Items.Remove(eachItem);
			}
		}
		
	}
}
