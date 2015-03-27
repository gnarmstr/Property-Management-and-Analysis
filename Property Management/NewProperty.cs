using System;
using System.Windows.Forms;
using Common.Resources;
using Common.Resources.Properties;
using System.Drawing;

namespace Property_Management_and_Analysis
{
	public partial class NewProperty : Form
	{
		#region Initialisation
		public NewProperty()
		{
			if (ActiveForm != null)
				Location = new Point(ActiveForm.Location.X + 100, ActiveForm.Location.Y + 100);
			InitializeComponent();
			pictureBoxClose.BackgroundImage = Resources.Close;
			buttonMainTitle.BackgroundImage = Resources.button_Blue_Small;
			buttonFees.BackgroundImage = Resources.button_Blue_Small;
			BackgroundImage = Resources.Background_Blue;
			BackgroundImageLayout = ImageLayout.Stretch;
		}

		private void NewProperty_Load(object sender, EventArgs e)
		{
			pictureBoxOK.Image = Tools.GetIcon(Resources.Ok, 40);
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
			GlobalVar.PropertyAddress.Add(textBoxPropertyAddress.Text);
			GlobalVar.PurchasePrice.Add(textBoxPurchasePrice.Text);
			Close();
		}

		private void pictureBoxClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion

		private void buttonFees_Click(object sender, EventArgs e)
		{
			var fees = new Fees();
			fees.ShowDialog();
		}

		
	}
}
