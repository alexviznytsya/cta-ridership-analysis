namespace CTA_Analysis
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.top10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalRidership = new System.Windows.Forms.TextBox();
            this.averageRidership = new System.Windows.Forms.TextBox();
            this.percentageRidership = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.holiday = new System.Windows.Forms.TextBox();
            this.saturday = new System.Windows.Forms.TextBox();
            this.weekday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TextBox();
            this.handicap = new System.Windows.Forms.TextBox();
            this.direction = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.stationNames = new System.Windows.Forms.ListBox();
            this.stationStopNames = new System.Windows.Forms.ListBox();
            this.lineNames = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numOfStations = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.top10ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1094, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // top10ToolStripMenuItem
            // 
            this.top10ToolStripMenuItem.Name = "top10ToolStripMenuItem";
            this.top10ToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.top10ToolStripMenuItem.Text = "Top-10";
            this.top10ToolStripMenuItem.Click += new System.EventHandler(this.top10ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F);
            this.label1.Location = new System.Drawing.Point(412, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Ridership:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F);
            this.label2.Location = new System.Drawing.Point(412, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Avg. Ridership:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.Location = new System.Drawing.Point(412, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "% Ridership";
            // 
            // totalRidership
            // 
            this.totalRidership.Location = new System.Drawing.Point(535, 36);
            this.totalRidership.Name = "totalRidership";
            this.totalRidership.Size = new System.Drawing.Size(220, 27);
            this.totalRidership.TabIndex = 6;
            // 
            // averageRidership
            // 
            this.averageRidership.Location = new System.Drawing.Point(535, 74);
            this.averageRidership.Name = "averageRidership";
            this.averageRidership.Size = new System.Drawing.Size(220, 27);
            this.averageRidership.TabIndex = 7;
            // 
            // percentageRidership
            // 
            this.percentageRidership.Location = new System.Drawing.Point(535, 112);
            this.percentageRidership.Name = "percentageRidership";
            this.percentageRidership.Size = new System.Drawing.Size(220, 27);
            this.percentageRidership.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F);
            this.label4.Location = new System.Drawing.Point(412, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stop at this station:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F);
            this.label5.Location = new System.Drawing.Point(768, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Weekday:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F);
            this.label6.Location = new System.Drawing.Point(768, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saturday:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F);
            this.label7.Location = new System.Drawing.Point(765, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Sun/Holiday:";
            // 
            // holiday
            // 
            this.holiday.Location = new System.Drawing.Point(864, 112);
            this.holiday.Name = "holiday";
            this.holiday.Size = new System.Drawing.Size(220, 27);
            this.holiday.TabIndex = 14;
            // 
            // saturday
            // 
            this.saturday.Location = new System.Drawing.Point(864, 74);
            this.saturday.Name = "saturday";
            this.saturday.Size = new System.Drawing.Size(220, 27);
            this.saturday.TabIndex = 15;
            // 
            // weekday
            // 
            this.weekday.Location = new System.Drawing.Point(864, 36);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(220, 27);
            this.weekday.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F);
            this.label9.Location = new System.Drawing.Point(765, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Handicap accessible?";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F);
            this.label10.Location = new System.Drawing.Point(765, 232);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "Direction of travel:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F);
            this.label11.Location = new System.Drawing.Point(765, 262);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Location:";
            // 
            // location
            // 
            this.location.Location = new System.Drawing.Point(766, 286);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(318, 27);
            this.location.TabIndex = 21;
            // 
            // handicap
            // 
            this.handicap.Location = new System.Drawing.Point(922, 191);
            this.handicap.Name = "handicap";
            this.handicap.Size = new System.Drawing.Size(162, 27);
            this.handicap.TabIndex = 22;
            // 
            // direction
            // 
            this.direction.Location = new System.Drawing.Point(922, 229);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(162, 27);
            this.direction.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F);
            this.label12.Location = new System.Drawing.Point(765, 322);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Lines:";
            // 
            // stationNames
            // 
            this.stationNames.FormattingEnabled = true;
            this.stationNames.HorizontalScrollbar = true;
            this.stationNames.ItemHeight = 19;
            this.stationNames.Location = new System.Drawing.Point(12, 39);
            this.stationNames.Name = "stationNames";
            this.stationNames.Size = new System.Drawing.Size(393, 498);
            this.stationNames.TabIndex = 26;
            this.stationNames.SelectedIndexChanged += new System.EventHandler(this.stationNames_SelectedIndexChanged);
            // 
            // stationStopNames
            // 
            this.stationStopNames.FormattingEnabled = true;
            this.stationStopNames.HorizontalScrollbar = true;
            this.stationStopNames.ItemHeight = 19;
            this.stationStopNames.Location = new System.Drawing.Point(416, 191);
            this.stationStopNames.Name = "stationStopNames";
            this.stationStopNames.Size = new System.Drawing.Size(339, 346);
            this.stationStopNames.TabIndex = 27;
            this.stationStopNames.SelectedIndexChanged += new System.EventHandler(this.stationStopNames_SelectedIndexChanged);
            // 
            // lineNames
            // 
            this.lineNames.FormattingEnabled = true;
            this.lineNames.HorizontalScrollbar = true;
            this.lineNames.ItemHeight = 19;
            this.lineNames.Location = new System.Drawing.Point(766, 343);
            this.lineNames.Name = "lineNames";
            this.lineNames.Size = new System.Drawing.Size(315, 194);
            this.lineNames.TabIndex = 28;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.numOfStations});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1094, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel1.Text = "Number of Stations: ";
            // 
            // numOfStations
            // 
            this.numOfStations.BackColor = System.Drawing.Color.Transparent;
            this.numOfStations.Name = "numOfStations";
            this.numOfStations.Size = new System.Drawing.Size(13, 17);
            this.numOfStations.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1094, 570);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lineNames);
            this.Controls.Add(this.stationStopNames);
            this.Controls.Add(this.stationNames);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.handicap);
            this.Controls.Add(this.location);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.saturday);
            this.Controls.Add(this.holiday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.percentageRidership);
            this.Controls.Add(this.averageRidership);
            this.Controls.Add(this.totalRidership);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTA Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem top10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox totalRidership;
        private System.Windows.Forms.TextBox averageRidership;
        private System.Windows.Forms.TextBox percentageRidership;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox holiday;
        private System.Windows.Forms.TextBox saturday;
        private System.Windows.Forms.TextBox weekday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox handicap;
        private System.Windows.Forms.TextBox direction;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox stationNames;
        private System.Windows.Forms.ListBox stationStopNames;
        private System.Windows.Forms.ListBox lineNames;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel numOfStations;
    }
}

