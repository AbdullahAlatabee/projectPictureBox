namespace Abdullah_Hassan_Abdoh_Hassan_Lab6
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closed = new System.Windows.Forms.Button();
            this.choseImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(238, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 320);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // closed
            // 
            this.closed.BackColor = System.Drawing.Color.Gray;
            this.closed.Location = new System.Drawing.Point(238, 430);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(170, 50);
            this.closed.TabIndex = 5;
            this.closed.Text = "خروج";
            this.closed.UseVisualStyleBackColor = false;
            this.closed.Click += new System.EventHandler(this.closed_Click);
            // 
            // choseImage
            // 
            this.choseImage.BackColor = System.Drawing.Color.Gray;
            this.choseImage.Location = new System.Drawing.Point(559, 440);
            this.choseImage.Name = "choseImage";
            this.choseImage.Size = new System.Drawing.Size(170, 50);
            this.choseImage.TabIndex = 4;
            this.choseImage.Text = "رسم";
            this.choseImage.UseVisualStyleBackColor = false;
            this.choseImage.Click += new System.EventHandler(this.choseImage_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(962, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.choseImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closed;
        private System.Windows.Forms.Button choseImage;
    }
}