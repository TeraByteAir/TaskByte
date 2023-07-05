namespace TaskByte
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.Header = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.Header.Controls.Add(this.panel3);
            this.Header.Controls.Add(this.panel1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(979, 53);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(253, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 287);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(797, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 53);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(63, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 53);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Maximize_Click);
            this.button2.MouseLeave += new System.EventHandler(this.Maximize_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.Maximize_MouseHover);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(125, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Close");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close_Click);
            this.button1.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.Minimize.Location = new System.Drawing.Point(3, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(53, 53);
            this.Minimize.TabIndex = 0;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(128)))));
            this.Title.Font = new System.Drawing.Font("Vipnagorgialla Rg", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(207, 36);
            this.Title.TabIndex = 2;
            this.Title.Text = "TaskByte";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Font = new System.Drawing.Font("Vipnagorgialla Rg", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthCalendar1.Location = new System.Drawing.Point(-6, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Teal;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.monthCalendar1.TodayDate = new System.DateTime(((long)(0)));
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.Silver;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 44);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel4.Location = new System.Drawing.Point(413, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 224);
            this.panel4.TabIndex = 3;
            // 
            // MainFrm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(979, 581);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.Text = "TaskByte";
            this.Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

