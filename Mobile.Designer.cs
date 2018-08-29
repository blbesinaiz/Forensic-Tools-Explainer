namespace Forensics_Software_Usage
{
    partial class Mobile
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
            this.checkDatabase = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.but_menu = new System.Windows.Forms.Button();
            this.combo_Tools = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Tutorial = new System.Windows.Forms.TextBox();
            this.label_tutorial = new System.Windows.Forms.Label();
            this.txt_Launch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.Label();
            this.txt_Purpose = new System.Windows.Forms.TextBox();
            this.Purpose = new System.Windows.Forms.Label();
            this.txt_Tool = new System.Windows.Forms.TextBox();
            this.pic_Thumbnail = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // checkDatabase
            // 
            this.checkDatabase.AutoSize = true;
            this.checkDatabase.Location = new System.Drawing.Point(730, 491);
            this.checkDatabase.Name = "checkDatabase";
            this.checkDatabase.Size = new System.Drawing.Size(0, 17);
            this.checkDatabase.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.but_menu);
            this.splitContainer1.Panel1.Controls.Add(this.combo_Tools);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_Category);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Tutorial);
            this.splitContainer1.Panel2.Controls.Add(this.label_tutorial);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Launch);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Description);
            this.splitContainer1.Panel2.Controls.Add(this.Description);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Purpose);
            this.splitContainer1.Panel2.Controls.Add(this.Purpose);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Tool);
            this.splitContainer1.Panel2.Controls.Add(this.pic_Thumbnail);
            this.splitContainer1.Size = new System.Drawing.Size(861, 496);
            this.splitContainer1.SplitterDistance = 256;
            this.splitContainer1.TabIndex = 10;
            // 
            // but_menu
            // 
            this.but_menu.Location = new System.Drawing.Point(15, 452);
            this.but_menu.Name = "but_menu";
            this.but_menu.Size = new System.Drawing.Size(75, 23);
            this.but_menu.TabIndex = 4;
            this.but_menu.Text = "Menu";
            this.but_menu.UseVisualStyleBackColor = true;
            this.but_menu.Click += new System.EventHandler(this.but_menu_Click);
            // 
            // combo_Tools
            // 
            this.combo_Tools.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_Tools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Tools.FormattingEnabled = true;
            this.combo_Tools.Location = new System.Drawing.Point(13, 89);
            this.combo_Tools.Name = "combo_Tools";
            this.combo_Tools.Size = new System.Drawing.Size(240, 33);
            this.combo_Tools.TabIndex = 2;
            this.combo_Tools.SelectedIndexChanged += new System.EventHandler(this.combo_Tools_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tool";
            // 
            // txt_Category
            // 
            this.txt_Category.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Category.Location = new System.Drawing.Point(167, 134);
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.ReadOnly = true;
            this.txt_Category.Size = new System.Drawing.Size(145, 28);
            this.txt_Category.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // txt_Tutorial
            // 
            this.txt_Tutorial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tutorial.Location = new System.Drawing.Point(167, 424);
            this.txt_Tutorial.Multiline = true;
            this.txt_Tutorial.Name = "txt_Tutorial";
            this.txt_Tutorial.ReadOnly = true;
            this.txt_Tutorial.Size = new System.Drawing.Size(378, 52);
            this.txt_Tutorial.TabIndex = 9;
            // 
            // label_tutorial
            // 
            this.label_tutorial.AutoSize = true;
            this.label_tutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tutorial.Location = new System.Drawing.Point(17, 436);
            this.label_tutorial.Name = "label_tutorial";
            this.label_tutorial.Size = new System.Drawing.Size(77, 25);
            this.label_tutorial.TabIndex = 8;
            this.label_tutorial.Text = "Tutorial";
            // 
            // txt_Launch
            // 
            this.txt_Launch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Launch.Location = new System.Drawing.Point(167, 343);
            this.txt_Launch.Multiline = true;
            this.txt_Launch.Name = "txt_Launch";
            this.txt_Launch.ReadOnly = true;
            this.txt_Launch.Size = new System.Drawing.Size(378, 50);
            this.txt_Launch.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Launch";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Description.Location = new System.Drawing.Point(167, 213);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(378, 102);
            this.txt_Description.TabIndex = 5;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.Location = new System.Drawing.Point(13, 210);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(109, 25);
            this.Description.TabIndex = 4;
            this.Description.Text = "Description";
            // 
            // txt_Purpose
            // 
            this.txt_Purpose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Purpose.Location = new System.Drawing.Point(409, 131);
            this.txt_Purpose.Name = "txt_Purpose";
            this.txt_Purpose.ReadOnly = true;
            this.txt_Purpose.Size = new System.Drawing.Size(136, 28);
            this.txt_Purpose.TabIndex = 3;
            // 
            // Purpose
            // 
            this.Purpose.AutoSize = true;
            this.Purpose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purpose.Location = new System.Drawing.Point(318, 132);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(85, 25);
            this.Purpose.TabIndex = 2;
            this.Purpose.Text = "Purpose";
            // 
            // txt_Tool
            // 
            this.txt_Tool.BackColor = System.Drawing.SystemColors.Control;
            this.txt_Tool.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Tool.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tool.Location = new System.Drawing.Point(167, 36);
            this.txt_Tool.Name = "txt_Tool";
            this.txt_Tool.ReadOnly = true;
            this.txt_Tool.Size = new System.Drawing.Size(284, 31);
            this.txt_Tool.TabIndex = 1;
            // 
            // pic_Thumbnail
            // 
            this.pic_Thumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Thumbnail.Location = new System.Drawing.Point(18, 18);
            this.pic_Thumbnail.Name = "pic_Thumbnail";
            this.pic_Thumbnail.Size = new System.Drawing.Size(131, 95);
            this.pic_Thumbnail.TabIndex = 0;
            this.pic_Thumbnail.TabStop = false;
            // 
            // Mobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 536);
            this.Controls.Add(this.checkDatabase);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Mobile";
            this.Text = "Mobile";
            this.Load += new System.EventHandler(this.Mobile_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkDatabase;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button but_menu;
        private System.Windows.Forms.ComboBox combo_Tools;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Tutorial;
        private System.Windows.Forms.Label label_tutorial;
        private System.Windows.Forms.TextBox txt_Launch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.TextBox txt_Purpose;
        private System.Windows.Forms.Label Purpose;
        private System.Windows.Forms.TextBox txt_Tool;
        private System.Windows.Forms.PictureBox pic_Thumbnail;
    }
}