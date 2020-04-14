namespace LoLSummTimer
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tfLabel = new System.Windows.Forms.Label();
            this.jfLabel = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.mfLabel = new System.Windows.Forms.Label();
            this.bfLabel = new System.Windows.Forms.Label();
            this.sfLabel = new System.Windows.Forms.Label();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.startGameTime = new System.Windows.Forms.Button();
            this.sfStart = new System.Windows.Forms.Button();
            this.bfStart = new System.Windows.Forms.Button();
            this.mfStart = new System.Windows.Forms.Button();
            this.jfStart = new System.Windows.Forms.Button();
            this.tfStart = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tfLabel
            // 
            this.tfLabel.BackColor = System.Drawing.Color.White;
            this.tfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tfLabel.Font = new System.Drawing.Font("Open Sans Extrabold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfLabel.Location = new System.Drawing.Point(74, 1);
            this.tfLabel.Name = "tfLabel";
            this.tfLabel.Size = new System.Drawing.Size(51, 24);
            this.tfLabel.TabIndex = 14;
            this.tfLabel.Text = "00:00";
            // 
            // jfLabel
            // 
            this.jfLabel.BackColor = System.Drawing.Color.White;
            this.jfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jfLabel.Font = new System.Drawing.Font("Open Sans Extrabold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jfLabel.Location = new System.Drawing.Point(74, 26);
            this.jfLabel.Name = "jfLabel";
            this.jfLabel.Size = new System.Drawing.Size(51, 24);
            this.jfLabel.TabIndex = 16;
            this.jfLabel.Text = "00:00";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // mfLabel
            // 
            this.mfLabel.BackColor = System.Drawing.Color.White;
            this.mfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mfLabel.Font = new System.Drawing.Font("Open Sans Extrabold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfLabel.Location = new System.Drawing.Point(74, 51);
            this.mfLabel.Name = "mfLabel";
            this.mfLabel.Size = new System.Drawing.Size(51, 24);
            this.mfLabel.TabIndex = 18;
            this.mfLabel.Text = "00:00";
            // 
            // bfLabel
            // 
            this.bfLabel.BackColor = System.Drawing.Color.White;
            this.bfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bfLabel.Font = new System.Drawing.Font("Open Sans Extrabold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfLabel.Location = new System.Drawing.Point(74, 76);
            this.bfLabel.Name = "bfLabel";
            this.bfLabel.Size = new System.Drawing.Size(51, 24);
            this.bfLabel.TabIndex = 20;
            this.bfLabel.Text = "00:00";
            // 
            // sfLabel
            // 
            this.sfLabel.BackColor = System.Drawing.Color.White;
            this.sfLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfLabel.Font = new System.Drawing.Font("Open Sans Extrabold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfLabel.Location = new System.Drawing.Point(74, 101);
            this.sfLabel.Name = "sfLabel";
            this.sfLabel.Size = new System.Drawing.Size(51, 24);
            this.sfLabel.TabIndex = 22;
            this.sfLabel.Text = "00:00";
            // 
            // timer7
            // 
            this.timer7.Enabled = true;
            this.timer7.Interval = 250;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // startGameTime
            // 
            this.startGameTime.BackColor = System.Drawing.Color.Transparent;
            this.startGameTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startGameTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.startGameTime.FlatAppearance.BorderSize = 0;
            this.startGameTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGameTime.Font = new System.Drawing.Font("Open Sans Extrabold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameTime.ForeColor = System.Drawing.Color.White;
            this.startGameTime.Location = new System.Drawing.Point(26, 122);
            this.startGameTime.Name = "startGameTime";
            this.startGameTime.Size = new System.Drawing.Size(79, 28);
            this.startGameTime.TabIndex = 13;
            this.startGameTime.Text = "Start at 10s";
            this.startGameTime.UseVisualStyleBackColor = false;
            // 
            // sfStart
            // 
            this.sfStart.BackColor = System.Drawing.Color.Transparent;
            this.sfStart.BackgroundImage = global::LoLSummTimer.Properties.Resources.imageedit_2_6330119471;
            this.sfStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sfStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfStart.FlatAppearance.BorderSize = 0;
            this.sfStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sfStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfStart.ForeColor = System.Drawing.Color.Green;
            this.sfStart.Location = new System.Drawing.Point(27, 101);
            this.sfStart.Name = "sfStart";
            this.sfStart.Size = new System.Drawing.Size(45, 24);
            this.sfStart.TabIndex = 21;
            this.sfStart.Text = "ON";
            this.sfStart.UseVisualStyleBackColor = false;
            // 
            // bfStart
            // 
            this.bfStart.BackColor = System.Drawing.Color.Transparent;
            this.bfStart.BackgroundImage = global::LoLSummTimer.Properties.Resources.imageedit_2_6330119471;
            this.bfStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bfStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.bfStart.FlatAppearance.BorderSize = 0;
            this.bfStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bfStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bfStart.ForeColor = System.Drawing.Color.Green;
            this.bfStart.Location = new System.Drawing.Point(27, 76);
            this.bfStart.Name = "bfStart";
            this.bfStart.Size = new System.Drawing.Size(45, 24);
            this.bfStart.TabIndex = 19;
            this.bfStart.Text = "ON";
            this.bfStart.UseVisualStyleBackColor = false;
            // 
            // mfStart
            // 
            this.mfStart.BackColor = System.Drawing.Color.Transparent;
            this.mfStart.BackgroundImage = global::LoLSummTimer.Properties.Resources.imageedit_2_6330119471;
            this.mfStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mfStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.mfStart.FlatAppearance.BorderSize = 0;
            this.mfStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mfStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfStart.ForeColor = System.Drawing.Color.Green;
            this.mfStart.Location = new System.Drawing.Point(27, 51);
            this.mfStart.Name = "mfStart";
            this.mfStart.Size = new System.Drawing.Size(45, 24);
            this.mfStart.TabIndex = 17;
            this.mfStart.Text = "ON";
            this.mfStart.UseVisualStyleBackColor = false;
            // 
            // jfStart
            // 
            this.jfStart.BackColor = System.Drawing.Color.Transparent;
            this.jfStart.BackgroundImage = global::LoLSummTimer.Properties.Resources.imageedit_2_6330119471;
            this.jfStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.jfStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.jfStart.FlatAppearance.BorderSize = 0;
            this.jfStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jfStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jfStart.ForeColor = System.Drawing.Color.Green;
            this.jfStart.Location = new System.Drawing.Point(27, 26);
            this.jfStart.Name = "jfStart";
            this.jfStart.Size = new System.Drawing.Size(45, 24);
            this.jfStart.TabIndex = 15;
            this.jfStart.Text = "ON";
            this.jfStart.UseVisualStyleBackColor = false;
            // 
            // tfStart
            // 
            this.tfStart.BackColor = System.Drawing.Color.Transparent;
            this.tfStart.BackgroundImage = global::LoLSummTimer.Properties.Resources.imageedit_2_6330119471;
            this.tfStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tfStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.tfStart.FlatAppearance.BorderSize = 0;
            this.tfStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tfStart.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tfStart.ForeColor = System.Drawing.Color.Green;
            this.tfStart.Location = new System.Drawing.Point(27, 1);
            this.tfStart.Name = "tfStart";
            this.tfStart.Size = new System.Drawing.Size(45, 24);
            this.tfStart.TabIndex = 12;
            this.tfStart.Text = "ON";
            this.tfStart.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox5.BackgroundImage = global::LoLSummTimer.Properties.Resources.support;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Location = new System.Drawing.Point(1, 101);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.DarkRed;
            this.pictureBox4.BackgroundImage = global::LoLSummTimer.Properties.Resources.BotLane_1;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(1, 76);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Teal;
            this.pictureBox3.BackgroundImage = global::LoLSummTimer.Properties.Resources.mid;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(1, 51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox2.BackgroundImage = global::LoLSummTimer.Properties.Resources.Jungle;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(1, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox1.BackgroundImage = global::LoLSummTimer.Properties.Resources.TopLane;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(126, 149);
            this.Controls.Add(this.sfLabel);
            this.Controls.Add(this.sfStart);
            this.Controls.Add(this.bfLabel);
            this.Controls.Add(this.bfStart);
            this.Controls.Add(this.mfLabel);
            this.Controls.Add(this.mfStart);
            this.Controls.Add(this.jfLabel);
            this.Controls.Add(this.jfStart);
            this.Controls.Add(this.tfLabel);
            this.Controls.Add(this.startGameTime);
            this.Controls.Add(this.tfStart);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(126, 149);
            this.MinimumSize = new System.Drawing.Size(126, 149);
            this.Name = "Form1";
            this.Text = "JJ\'s LoL Summ Timer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button tfStart;
        private System.Windows.Forms.Button startGameTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label tfLabel;
        private System.Windows.Forms.Button jfStart;
        private System.Windows.Forms.Label jfLabel;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button mfStart;
        private System.Windows.Forms.Label mfLabel;
        private System.Windows.Forms.Button bfStart;
        private System.Windows.Forms.Label bfLabel;
        private System.Windows.Forms.Button sfStart;
        private System.Windows.Forms.Label sfLabel;
        private System.Windows.Forms.Timer timer7;
    }
}

