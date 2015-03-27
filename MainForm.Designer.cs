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
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.pictureBoxClose = new System.Windows.Forms.PictureBox();
			this.buttonMainTitle = new System.Windows.Forms.Button();
			this.panelMainPoints = new System.Windows.Forms.Panel();
			this.buttonInstructions = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.MainMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 8000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
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
			this.panelMainPoints.Location = new System.Drawing.Point(8, 208);
			this.panelMainPoints.Name = "panelMainPoints";
			this.panelMainPoints.Size = new System.Drawing.Size(1070, 567);
			this.panelMainPoints.TabIndex = 83;
			// 
			// buttonInstructions
			// 
			this.buttonInstructions.BackColor = System.Drawing.Color.Transparent;
			this.buttonInstructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.buttonInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonInstructions.Location = new System.Drawing.Point(200, 154);
			this.buttonInstructions.Name = "buttonInstructions";
			this.buttonInstructions.Size = new System.Drawing.Size(149, 34);
			this.buttonInstructions.TabIndex = 91;
			this.buttonInstructions.Text = "Instructions";
			this.buttonInstructions.UseVisualStyleBackColor = false;
			this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenu});
			this.menuStrip1.Location = new System.Drawing.Point(12, 64);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(200, 36);
			this.menuStrip1.TabIndex = 92;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MainMenu
			// 
			this.MainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.printToolStripMenuItem,
            this.closeToolStripMenuItem});
			this.MainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.MainMenu.Name = "MainMenu";
			this.MainMenu.Size = new System.Drawing.Size(54, 32);
			this.MainMenu.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// printToolStripMenuItem
			// 
			this.printToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
			this.printToolStripMenuItem.Text = "Print";
			// 
			// closeToolStripMenuItem
			// 
			this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
			this.closeToolStripMenuItem.Size = new System.Drawing.Size(198, 32);
			this.closeToolStripMenuItem.Text = "Close";
			this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
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
			this.Controls.Add(this.menuStrip1);
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
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.PictureBox pictureBoxClose;
		private System.Windows.Forms.Button buttonMainTitle;
		private System.Windows.Forms.Panel panelMainPoints;
		private System.Windows.Forms.Button buttonInstructions;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem MainMenu;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
	}
}

