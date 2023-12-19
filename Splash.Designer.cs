namespace Book
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Myprogress = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.Precentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Shop management system";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 190);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Myprogress
            // 
            this.Myprogress.AllowAnimations = false;
            this.Myprogress.Animation = 0;
            this.Myprogress.AnimationSpeed = 220;
            this.Myprogress.AnimationStep = 10;
            this.Myprogress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Myprogress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Myprogress.BackgroundImage")));
            this.Myprogress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Myprogress.BorderRadius = 9;
            this.Myprogress.BorderThickness = 1;
            this.Myprogress.Location = new System.Drawing.Point(2, 281);
            this.Myprogress.Maximum = 100;
            this.Myprogress.MaximumValue = 100;
            this.Myprogress.Minimum = 0;
            this.Myprogress.MinimumValue = 0;
            this.Myprogress.Name = "Myprogress";
            this.Myprogress.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Myprogress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.Myprogress.ProgressColorLeft = System.Drawing.Color.DarkSlateGray;
            this.Myprogress.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.Myprogress.Size = new System.Drawing.Size(596, 13);
            this.Myprogress.TabIndex = 2;
            this.Myprogress.Value = 50;
            this.Myprogress.ValueByTransition = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(12, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loading...";
            // 
            // Precentage
            // 
            this.Precentage.AutoSize = true;
            this.Precentage.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.Precentage.ForeColor = System.Drawing.Color.DarkCyan;
            this.Precentage.Location = new System.Drawing.Point(103, 257);
            this.Precentage.Name = "Precentage";
            this.Precentage.Size = new System.Drawing.Size(22, 21);
            this.Precentage.TabIndex = 4;
            this.Precentage.Text = "%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 299);
            this.Controls.Add(this.Precentage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Myprogress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuProgressBar Myprogress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Precentage;
        private System.Windows.Forms.Timer timer1;
    }
}

