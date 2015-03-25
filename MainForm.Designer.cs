namespace Property_Management_and_Analysis
{
	partial class MainForm
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SaveAll = new System.Windows.Forms.PictureBox();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.buttonPrint = new System.Windows.Forms.Button();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.buttonMainTitle = new System.Windows.Forms.Button();
			this.panelMainPoints = new System.Windows.Forms.Panel();
			this.buttonLifeStyle = new System.Windows.Forms.Button();
			this.buttonInstructions = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.SaveAll)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.panelMainPoints.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 8000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// SaveAll
			// 
			this.SaveAll.BackColor = System.Drawing.Color.Transparent;
			this.SaveAll.Location = new System.Drawing.Point(858, 1147);
			this.SaveAll.Name = "SaveAll";
			this.SaveAll.Size = new System.Drawing.Size(200, 40);
			this.SaveAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.SaveAll.TabIndex = 70;
			this.SaveAll.TabStop = false;
			this.SaveAll.Tag = "20";
			this.toolTip1.SetToolTip(this.SaveAll, "This will Save all settings and lists. ");
			this.SaveAll.Click += new System.EventHandler(this.SaveAll_Click);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// buttonPrint
			// 
			this.buttonPrint.Location = new System.Drawing.Point(713, 1135);
			this.buttonPrint.Name = "buttonPrint";
			this.buttonPrint.Size = new System.Drawing.Size(84, 60);
			this.buttonPrint.TabIndex = 83;
			this.buttonPrint.Text = "Print Summary";
			this.buttonPrint.UseVisualStyleBackColor = true;
			this.buttonPrint.Visible = false;
			this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
			// 
			// pictureBoxClose
			// 
			this.pictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBoxClose.Location = new System.Drawing.Point(1035, 12);
			this.pictureBoxClose.Name = "pictureBoxClose";
			this.pictureBoxClose.Size = new System.Drawing.Size(43, 43);
			this.pictureBoxClose.TabIndex = 86;
			this.pictureBoxClose.TabStop = false;
			this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
			// 
			// buttonMainTitle
			// 
			this.buttonMainTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonMainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMainTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonMainTitle.Location = new System.Drawing.Point(8, 12);
			this.buttonMainTitle.Name = "buttonMainTitle";
			this.buttonMainTitle.Size = new System.Drawing.Size(1021, 43);
			this.buttonMainTitle.TabIndex = 88;
			this.buttonMainTitle.Text = "Ver 0.1              PROPERTY MANAGEMENT AND ANALYSIS - By Geoff Armstrong       " +
    "                  ";
			this.buttonMainTitle.UseVisualStyleBackColor = true;
			this.buttonMainTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseDown);
			this.buttonMainTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseMove);
			this.buttonMainTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMainTitle_MouseUp);
			// 
			// panelMainPoints
			// 
			this.panelMainPoints.BackColor = System.Drawing.Color.Transparent;
			this.panelMainPoints.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panelMainPoints.Controls.Add(this.buttonLifeStyle);
			this.panelMainPoints.Location = new System.Drawing.Point(8, 101);
			this.panelMainPoints.Name = "panelMainPoints";
			this.panelMainPoints.Size = new System.Drawing.Size(1070, 674);
			this.panelMainPoints.TabIndex = 83;
			// 
			// buttonLifeStyle
			// 
			this.buttonLifeStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonLifeStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonLifeStyle.Location = new System.Drawing.Point(17, 606);
			this.buttonLifeStyle.Name = "buttonLifeStyle";
			this.buttonLifeStyle.Size = new System.Drawing.Size(337, 44);
			this.buttonLifeStyle.TabIndex = 89;
			this.buttonLifeStyle.Text = "Click to complete Life Style Assessment";
			this.buttonLifeStyle.UseVisualStyleBackColor = true;
			// 
			// buttonInstructions
			// 
			this.buttonInstructions.BackColor = System.Drawing.Color.Transparent;
			this.buttonInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonInstructions.Location = new System.Drawing.Point(606, 60);
			this.buttonInstructions.Name = "buttonInstructions";
			this.buttonInstructions.Size = new System.Drawing.Size(149, 34);
			this.buttonInstructions.TabIndex = 91;
			this.buttonInstructions.Text = "Instructions";
			this.buttonInstructions.UseVisualStyleBackColor = false;
			this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(1090, 1200);
			this.Controls.Add(this.buttonInstructions);
			this.Controls.Add(this.panelMainPoints);
			this.Controls.Add(this.buttonMainTitle);
			this.Controls.Add(this.pictureBoxClose);
			this.Controls.Add(this.buttonPrint);
			this.Controls.Add(this.SaveAll);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Location = new System.Drawing.Point(300, 50);
			this.MaximumSize = new System.Drawing.Size(1090, 1200);
			this.MinimumSize = new System.Drawing.Size(1090, 1200);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Ver 1.2                             DVA Compensation Calulator - by Geoff Armstro" +
    "ng                 ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.SaveAll)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.panelMainPoints.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox SaveAll;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Button buttonPrint;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Button buttonMainTitle;
		private System.Windows.Forms.Panel panelMainPoints;
		private System.Windows.Forms.Button buttonLifeStyle;
		private System.Windows.Forms.Button buttonInstructions;
	}
}

