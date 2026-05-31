namespace WindowsFormsApp3.Forms
{
    partial class Controller
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labelindicator1 = new System.Windows.Forms.Label();
            this.labelindicator2 = new System.Windows.Forms.Label();
            this.labelindicator3 = new System.Windows.Forms.Label();
            this.labelindicator4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MidnightBlue;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(797, 54);
            this.label2.TabIndex = 2;
            this.label2.Text = "        HOSPITAL MANAGMENT SYSTEM      ";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.WhatsApp_Image_2026_05_12_at_11_10_28_AM;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(364, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 560);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(62, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controller";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(51, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add New Patient Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(51, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(261, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Diagnosis Info";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(51, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "History Of Patient";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(51, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(261, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Doctor Information";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(101, 532);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 53);
            this.button5.TabIndex = 7;
            this.button5.Text = "EXIT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labelindicator1
            // 
            this.labelindicator1.AutoSize = true;
            this.labelindicator1.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator1.Location = new System.Drawing.Point(-6, 223);
            this.labelindicator1.Name = "labelindicator1";
            this.labelindicator1.Size = new System.Drawing.Size(56, 50);
            this.labelindicator1.TabIndex = 8;
            this.labelindicator1.Text = ">>";
            // 
            // labelindicator2
            // 
            this.labelindicator2.AutoSize = true;
            this.labelindicator2.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator2.Location = new System.Drawing.Point(-6, 300);
            this.labelindicator2.Name = "labelindicator2";
            this.labelindicator2.Size = new System.Drawing.Size(56, 50);
            this.labelindicator2.TabIndex = 9;
            this.labelindicator2.Text = ">>";
            // 
            // labelindicator3
            // 
            this.labelindicator3.AutoSize = true;
            this.labelindicator3.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator3.Location = new System.Drawing.Point(-6, 374);
            this.labelindicator3.Name = "labelindicator3";
            this.labelindicator3.Size = new System.Drawing.Size(56, 50);
            this.labelindicator3.TabIndex = 10;
            this.labelindicator3.Text = ">>";
            // 
            // labelindicator4
            // 
            this.labelindicator4.AutoSize = true;
            this.labelindicator4.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator4.Location = new System.Drawing.Point(-6, 450);
            this.labelindicator4.Name = "labelindicator4";
            this.labelindicator4.Size = new System.Drawing.Size(56, 50);
            this.labelindicator4.TabIndex = 11;
            this.labelindicator4.Text = ">>";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 619);
            this.Controls.Add(this.labelindicator4);
            this.Controls.Add(this.labelindicator3);
            this.Controls.Add(this.labelindicator2);
            this.Controls.Add(this.labelindicator1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Controller";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Controller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labelindicator1;
        private System.Windows.Forms.Label labelindicator2;
        private System.Windows.Forms.Label labelindicator3;
        private System.Windows.Forms.Label labelindicator4;
    }
}