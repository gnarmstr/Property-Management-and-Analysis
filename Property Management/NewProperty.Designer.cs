namespace Property_Management_and_Analysis
{
	partial class NewProperty
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pictureBoxOK = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.buttonMainTitle = new System.Windows.Forms.Button();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.textBoxPropertyAddress = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPurchasePrice = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonFees = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxOK
			// 
			this.pictureBoxOK.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxOK.Location = new System.Drawing.Point(758, 658);
			this.pictureBoxOK.Name = "pictureBoxOK";
			this.pictureBoxOK.Size = new System.Drawing.Size(80, 80);
			this.pictureBoxOK.TabIndex = 14;
			this.pictureBoxOK.TabStop = false;
			this.pictureBoxOK.Tag = "7";
			this.pictureBoxOK.Click += new System.EventHandler(this.pictureBoxOK_Click);
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 10000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// buttonMainTitle
			// 
			this.buttonMainTitle.BackColor = System.Drawing.Color.Transparent;
			this.buttonMainTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainTitle.Location = new System.Drawing.Point(12, 12);
			this.buttonMainTitle.Name = "buttonMainTitle";
			this.buttonMainTitle.Size = new System.Drawing.Size(788, 31);
			this.buttonMainTitle.TabIndex = 90;
			this.buttonMainTitle.Text = "NEW PROPERTY DETAILS";
			this.buttonMainTitle.UseVisualStyleBackColor = false;
			this.buttonMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseDown);
			this.buttonMainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseMove);
			this.buttonMainTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseUp);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxClose.Location = new System.Drawing.Point(806, 12);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(32, 31);
			this.pictureBoxClose.TabIndex = 89;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// textBoxPropertyAddress
			// 
			this.textBoxPropertyAddress.Location = new System.Drawing.Point(191, 86);
			this.textBoxPropertyAddress.Name = "textBoxPropertyAddress";
			this.textBoxPropertyAddress.Size = new System.Drawing.Size(609, 26);
			this.textBoxPropertyAddress.TabIndex = 91;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(12, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 20);
			this.label1.TabIndex = 92;
			this.label1.Text = "Address";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(12, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 93;
			this.label2.Text = "Purchase Price";
			// 
			// textBoxPurchasePrice
			// 
			this.textBoxPurchasePrice.Location = new System.Drawing.Point(191, 144);
			this.textBoxPurchasePrice.Name = "textBoxPurchasePrice";
			this.textBoxPurchasePrice.Size = new System.Drawing.Size(135, 26);
			this.textBoxPurchasePrice.TabIndex = 94;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(191, 206);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(135, 26);
			this.textBox1.TabIndex = 95;
			// 
			// buttonFees
			// 
			this.buttonFees.BackColor = System.Drawing.Color.Transparent;
			this.buttonFees.Location = new System.Drawing.Point(16, 202);
			this.buttonFees.Name = "buttonFees";
			this.buttonFees.Size = new System.Drawing.Size(111, 34);
			this.buttonFees.TabIndex = 96;
			this.buttonFees.Text = "Fees";
			this.buttonFees.UseVisualStyleBackColor = false;
			this.buttonFees.Click += new System.EventHandler(this.buttonFees_Click);
			// 
			// NewProperty
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(850, 750);
			this.Controls.Add(this.buttonFees);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.textBoxPurchasePrice);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPropertyAddress);
			this.Controls.Add(this.buttonMainTitle);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.pictureBoxOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(850, 750);
			this.MinimumSize = new System.Drawing.Size(850, 750);
			this.Name = "NewProperty";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Cervical  Spine Movement";
			this.Load += new System.EventHandler(this.NewProperty_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxOK;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonMainTitle;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.TextBox textBoxPropertyAddress;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPurchasePrice;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonFees;
	}
}