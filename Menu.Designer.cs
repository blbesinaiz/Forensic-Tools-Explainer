namespace Forensics_Software_Usage
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Welcome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Computer = new System.Windows.Forms.Button();
            this.Network = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Button();
            this.Mobile = new System.Windows.Forms.Button();
            this.Digital = new System.Windows.Forms.Button();
            this.Multi = new System.Windows.Forms.Button();
            this.Miscellenous = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(622, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Welcome
            // 
            this.Welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Welcome.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(172, 12);
            this.Welcome.Name = "Welcome";
            this.Welcome.ReadOnly = true;
            this.Welcome.Size = new System.Drawing.Size(444, 28);
            this.Welcome.TabIndex = 1;
            this.Welcome.TabStop = false;
            this.Welcome.Text = "Welcome to the Virtual Forensics Lab";
            this.Welcome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Welcome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(248, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(297, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "How would you like to analyze?";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Computer
            // 
            this.Computer.Location = new System.Drawing.Point(64, 206);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(106, 46);
            this.Computer.TabIndex = 3;
            this.Computer.TabStop = false;
            this.Computer.Text = "Computer Forensics";
            this.Computer.UseVisualStyleBackColor = true;
            this.Computer.Click += new System.EventHandler(this.Computer_Click);
            // 
            // Network
            // 
            this.Network.Location = new System.Drawing.Point(248, 206);
            this.Network.Name = "Network";
            this.Network.Size = new System.Drawing.Size(106, 46);
            this.Network.TabIndex = 4;
            this.Network.TabStop = false;
            this.Network.Text = "Network Forensics";
            this.Network.UseVisualStyleBackColor = true;
            this.Network.Click += new System.EventHandler(this.button1_Click);
            // 
            // Memory
            // 
            this.Memory.Location = new System.Drawing.Point(439, 206);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(106, 46);
            this.Memory.TabIndex = 5;
            this.Memory.TabStop = false;
            this.Memory.Text = "Memory Forensics";
            this.Memory.UseVisualStyleBackColor = true;
            this.Memory.Click += new System.EventHandler(this.Memory_Click);
            // 
            // Mobile
            // 
            this.Mobile.Location = new System.Drawing.Point(617, 206);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(106, 46);
            this.Mobile.TabIndex = 6;
            this.Mobile.TabStop = false;
            this.Mobile.Text = "Mobile Forensics";
            this.Mobile.UseVisualStyleBackColor = true;
            this.Mobile.Click += new System.EventHandler(this.Mobile_Click);
            // 
            // Digital
            // 
            this.Digital.Location = new System.Drawing.Point(130, 331);
            this.Digital.Name = "Digital";
            this.Digital.Size = new System.Drawing.Size(122, 46);
            this.Digital.TabIndex = 7;
            this.Digital.TabStop = false;
            this.Digital.Text = "Steganography";
            this.Digital.UseVisualStyleBackColor = true;
            this.Digital.Click += new System.EventHandler(this.Digital_Click);
            // 
            // Multi
            // 
            this.Multi.Location = new System.Drawing.Point(334, 331);
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(106, 46);
            this.Multi.TabIndex = 8;
            this.Multi.TabStop = false;
            this.Multi.Text = "Multi-Purpose Tools";
            this.Multi.UseVisualStyleBackColor = true;
            this.Multi.Click += new System.EventHandler(this.Multi_Click);
            // 
            // Miscellenous
            // 
            this.Miscellenous.Location = new System.Drawing.Point(527, 331);
            this.Miscellenous.Name = "Miscellenous";
            this.Miscellenous.Size = new System.Drawing.Size(106, 46);
            this.Miscellenous.TabIndex = 9;
            this.Miscellenous.TabStop = false;
            this.Miscellenous.Text = "Miscellanous Tools";
            this.Miscellenous.UseVisualStyleBackColor = true;
            this.Miscellenous.Click += new System.EventHandler(this.Miscellenous_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Miscellenous);
            this.Controls.Add(this.Multi);
            this.Controls.Add(this.Digital);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Network);
            this.Controls.Add(this.Computer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Virtual Forensics Lab";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Welcome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Computer;
        private System.Windows.Forms.Button Network;
        private System.Windows.Forms.Button Memory;
        private System.Windows.Forms.Button Mobile;
        private System.Windows.Forms.Button Digital;
        private System.Windows.Forms.Button Multi;
        private System.Windows.Forms.Button Miscellenous;
    }
}

