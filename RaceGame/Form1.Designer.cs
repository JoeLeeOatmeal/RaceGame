namespace RaceGame
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.Tree1 = new System.Windows.Forms.PictureBox();
            this.Tree3 = new System.Windows.Forms.PictureBox();
            this.Tree4 = new System.Windows.Forms.PictureBox();
            this.Tree5 = new System.Windows.Forms.PictureBox();
            this.Tree2 = new System.Windows.Forms.PictureBox();
            this.enemy4 = new System.Windows.Forms.PictureBox();
            this.star = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox1.Location = new System.Drawing.Point(259, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox2.Location = new System.Drawing.Point(259, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 73);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox3.Location = new System.Drawing.Point(259, 231);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(10, 73);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox4.Location = new System.Drawing.Point(259, 351);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(10, 73);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox5.Location = new System.Drawing.Point(259, 470);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(10, 73);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Goldenrod;
            this.pictureBox6.Location = new System.Drawing.Point(259, 588);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 73);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // car
            // 
            this.car.Image = ((System.Drawing.Image)(resources.GetObject("car.Image")));
            this.car.Location = new System.Drawing.Point(245, 549);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(50, 75);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.car.TabIndex = 6;
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(275, 91);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(47, 78);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy1.TabIndex = 7;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(90, 271);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(48, 81);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy2.TabIndex = 8;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = ((System.Drawing.Image)(resources.GetObject("enemy3.Image")));
            this.enemy3.Location = new System.Drawing.Point(439, 344);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(50, 78);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy3.TabIndex = 9;
            this.enemy3.TabStop = false;
            // 
            // Tree1
            // 
            this.Tree1.Image = ((System.Drawing.Image)(resources.GetObject("Tree1.Image")));
            this.Tree1.Location = new System.Drawing.Point(1, 24);
            this.Tree1.Name = "Tree1";
            this.Tree1.Size = new System.Drawing.Size(40, 37);
            this.Tree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tree1.TabIndex = 10;
            this.Tree1.TabStop = false;
            // 
            // Tree3
            // 
            this.Tree3.Image = ((System.Drawing.Image)(resources.GetObject("Tree3.Image")));
            this.Tree3.Location = new System.Drawing.Point(1, 344);
            this.Tree3.Name = "Tree3";
            this.Tree3.Size = new System.Drawing.Size(40, 37);
            this.Tree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tree3.TabIndex = 11;
            this.Tree3.TabStop = false;
            // 
            // Tree4
            // 
            this.Tree4.Image = ((System.Drawing.Image)(resources.GetObject("Tree4.Image")));
            this.Tree4.Location = new System.Drawing.Point(1, 506);
            this.Tree4.Name = "Tree4";
            this.Tree4.Size = new System.Drawing.Size(40, 37);
            this.Tree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tree4.TabIndex = 12;
            this.Tree4.TabStop = false;
            // 
            // Tree5
            // 
            this.Tree5.Image = ((System.Drawing.Image)(resources.GetObject("Tree5.Image")));
            this.Tree5.Location = new System.Drawing.Point(1, 624);
            this.Tree5.Name = "Tree5";
            this.Tree5.Size = new System.Drawing.Size(40, 37);
            this.Tree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tree5.TabIndex = 13;
            this.Tree5.TabStop = false;
            // 
            // Tree2
            // 
            this.Tree2.Image = ((System.Drawing.Image)(resources.GetObject("Tree2.Image")));
            this.Tree2.Location = new System.Drawing.Point(1, 181);
            this.Tree2.Name = "Tree2";
            this.Tree2.Size = new System.Drawing.Size(40, 37);
            this.Tree2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tree2.TabIndex = 14;
            this.Tree2.TabStop = false;
            // 
            // enemy4
            // 
            this.enemy4.Image = ((System.Drawing.Image)(resources.GetObject("enemy4.Image")));
            this.enemy4.Location = new System.Drawing.Point(367, 231);
            this.enemy4.Name = "enemy4";
            this.enemy4.Size = new System.Drawing.Size(46, 41);
            this.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.enemy4.TabIndex = 15;
            this.enemy4.TabStop = false;
            // 
            // star
            // 
            this.star.Image = ((System.Drawing.Image)(resources.GetObject("star.Image")));
            this.star.Location = new System.Drawing.Point(201, 26);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(29, 22);
            this.star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.star.TabIndex = 16;
            this.star.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(457, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Score :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(556, 654);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tree5);
            this.Controls.Add(this.Tree4);
            this.Controls.Add(this.Tree3);
            this.Controls.Add(this.Tree2);
            this.Controls.Add(this.Tree1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.star);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Car Race";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tree2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox Tree1;
        private System.Windows.Forms.PictureBox Tree3;
        private System.Windows.Forms.PictureBox Tree4;
        private System.Windows.Forms.PictureBox Tree5;
        private System.Windows.Forms.PictureBox Tree2;
        private System.Windows.Forms.PictureBox enemy4;
        private System.Windows.Forms.PictureBox star;
        private System.Windows.Forms.Label label1;
    }
}

