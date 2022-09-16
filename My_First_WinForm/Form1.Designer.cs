namespace My_First_WinForm
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
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.btn_stop2 = new System.Windows.Forms.Button();
            this.btn_start2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.Location = new System.Drawing.Point(81, 89);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(128, 31);
            this.lbl_timer.TabIndex = 0;
            this.lbl_timer.Text = "00:00:00";
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(181, 158);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 33);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(25, 158);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 33);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.Purple;
            this.lbl_time.Location = new System.Drawing.Point(432, 89);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(128, 31);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "00:00:00";
            // 
            // btn_stop2
            // 
            this.btn_stop2.Location = new System.Drawing.Point(529, 158);
            this.btn_stop2.Name = "btn_stop2";
            this.btn_stop2.Size = new System.Drawing.Size(75, 40);
            this.btn_stop2.TabIndex = 4;
            this.btn_stop2.Text = "توقف";
            this.btn_stop2.UseVisualStyleBackColor = true;
            this.btn_stop2.Click += new System.EventHandler(this.btn_stop2_Click);
            // 
            // btn_start2
            // 
            this.btn_start2.Location = new System.Drawing.Point(389, 158);
            this.btn_start2.Name = "btn_start2";
            this.btn_start2.Size = new System.Drawing.Size(75, 40);
            this.btn_start2.TabIndex = 5;
            this.btn_start2.Text = "شروع";
            this.btn_start2.UseVisualStyleBackColor = true;
            this.btn_start2.Click += new System.EventHandler(this.btn_start2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 328);
            this.Controls.Add(this.btn_start2);
            this.Controls.Add(this.btn_stop2);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_timer);
            this.Name = "Form1";
            this.Text = "Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Button btn_stop2;
        private System.Windows.Forms.Button btn_start2;
        private System.Windows.Forms.Timer timer2;
    }
}

