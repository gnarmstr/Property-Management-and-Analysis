namespace Property_Management_and_Analysis
{
	partial class Fees
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
			this.listViewFees = new System.Windows.Forms.ListView();
			this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
			this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxFee = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Fee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
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
			this.buttonMainTitle.Text = "FEES";
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
			// listViewFees
			// 
			this.listViewFees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.Fee});
			this.listViewFees.Location = new System.Drawing.Point(12, 67);
			this.listViewFees.Name = "listViewFees";
			this.listViewFees.Size = new System.Drawing.Size(420, 373);
			this.listViewFees.TabIndex = 91;
			this.listViewFees.UseCompatibleStateImageBehavior = false;
			this.listViewFees.View = System.Windows.Forms.View.Details;
			// 
			// pictureBoxAdd
			// 
			this.pictureBoxAdd.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxAdd.Location = new System.Drawing.Point(779, 280);
			this.pictureBoxAdd.Name = "pictureBoxAdd";
			this.pictureBoxAdd.Size = new System.Drawing.Size(32, 31);
			this.pictureBoxAdd.TabIndex = 92;
			this.pictureBoxAdd.TabStop = false;
			this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
			// 
			// pictureBoxDelete
			// 
			this.pictureBoxDelete.BackColor = System.Drawing.Color.Transparent;
			this.pictureBoxDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxDelete.Location = new System.Drawing.Point(454, 67);
			this.pictureBoxDelete.Name = "pictureBoxDelete";
			this.pictureBoxDelete.Size = new System.Drawing.Size(32, 31);
			this.pictureBoxDelete.TabIndex = 93;
			this.pictureBoxDelete.TabStop = false;
			this.pictureBoxDelete.Click += new System.EventHandler(this.pictureBoxDelete_Click);
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(572, 285);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(184, 26);
			this.textBoxDescription.TabIndex = 96;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(465, 288);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 20);
			this.label2.TabIndex = 95;
			this.label2.Text = "Desrciption";
			// 
			// textBoxFee
			// 
			this.textBoxFee.Location = new System.Drawing.Point(572, 329);
			this.textBoxFee.Name = "textBoxFee";
			this.textBoxFee.Size = new System.Drawing.Size(184, 26);
			this.textBoxFee.TabIndex = 98;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(465, 332);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 20);
			this.label1.TabIndex = 97;
			this.label1.Text = "Fee";
			// 
			// Description
			// 
			this.Description.Text = "Description";
			this.Description.Width = 261;
			// 
			// Fee
			// 
			this.Fee.Text = "Fees";
			this.Fee.Width = 153;
			// 
			// Fees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(850, 750);
			this.Controls.Add(this.textBoxFee);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBoxDelete);
			this.Controls.Add(this.pictureBoxAdd);
			this.Controls.Add(this.listViewFees);
			this.Controls.Add(this.buttonMainTitle);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.pictureBoxOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximumSize = new System.Drawing.Size(850, 750);
			this.MinimumSize = new System.Drawing.Size(850, 750);
			this.Name = "Fees";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Cervical  Spine Movement";
			this.Load += new System.EventHandler(this.NewProperty_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxOK;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Button buttonMainTitle;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.PictureBox pictureBoxAdd;
		private System.Windows.Forms.PictureBox pictureBoxDelete;
		private System.Windows.Forms.TextBox textBoxDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxFee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader Description;
		private System.Windows.Forms.ColumnHeader Fee;
		public System.Windows.Forms.ListView listViewFees;
	}
}