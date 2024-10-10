namespace Abdullah_Hassan_Abdoh_Hassan_Lab6
{
    partial class Form5
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
            this.closed = new System.Windows.Forms.Button();
            this.choseImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.daysName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closed
            // 
            this.closed.BackColor = System.Drawing.Color.Gray;
            this.closed.Location = new System.Drawing.Point(29, 197);
            this.closed.Name = "closed";
            this.closed.Size = new System.Drawing.Size(170, 50);
            this.closed.TabIndex = 7;
            this.closed.Text = "Stop";
            this.closed.UseVisualStyleBackColor = false;
            this.closed.Click += new System.EventHandler(this.closed_Click_1);
            // 
            // choseImage
            // 
            this.choseImage.BackColor = System.Drawing.Color.Gray;
            this.choseImage.Location = new System.Drawing.Point(240, 197);
            this.choseImage.Name = "choseImage";
            this.choseImage.Size = new System.Drawing.Size(170, 50);
            this.choseImage.TabIndex = 6;
            this.choseImage.Text = "Start";
            this.choseImage.UseVisualStyleBackColor = false;
            this.choseImage.Click += new System.EventHandler(this.choseImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 52);
            this.label1.TabIndex = 8;
            this.label1.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 52);
            this.label2.TabIndex = 9;
            this.label2.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 52);
            this.label3.TabIndex = 10;
            this.label3.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 52);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(231, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 52);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daysName
            // 
            this.daysName.AutoSize = true;
            this.daysName.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysName.Location = new System.Drawing.Point(361, 78);
            this.daysName.Name = "daysName";
            this.daysName.Size = new System.Drawing.Size(0, 52);
            this.daysName.TabIndex = 13;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(575, 302);
            this.Controls.Add(this.daysName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closed);
            this.Controls.Add(this.choseImage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closed;
        private System.Windows.Forms.Button choseImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label daysName;
    }
}