namespace Hanoi_C_hash
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Title = new System.Windows.Forms.Label();
            this.Check_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.계산시간_show = new System.Windows.Forms.Label();
            this.움직이는횟수_show = new System.Windows.Forms.Label();
            this.G_List개수_show = new System.Windows.Forms.Label();
            this.Show_btn = new System.Windows.Forms.Button();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("문체부 제목 돋음체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(262, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 48);
            this.Title.TabIndex = 1;
            this.Title.Text = "Hanoi Tower";
            // 
            // Check_txt
            // 
            this.Check_txt.Location = new System.Drawing.Point(525, 39);
            this.Check_txt.Name = "Check_txt";
            this.Check_txt.Size = new System.Drawing.Size(72, 21);
            this.Check_txt.TabIndex = 2;
            this.Check_txt.TextChanged += new System.EventHandler(this.Check_txt_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(603, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 21);
            this.button1.TabIndex = 3;
            this.button1.Text = "시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "하노이탑의 수를 입력하세요";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(268, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "하노이탑 계산중입니다.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.Location = new System.Drawing.Point(268, 199);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(201, 20);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "계산시간";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "움직이는 횟수";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "G_List개수";
            // 
            // 계산시간_show
            // 
            this.계산시간_show.AutoSize = true;
            this.계산시간_show.Location = new System.Drawing.Point(591, 173);
            this.계산시간_show.Name = "계산시간_show";
            this.계산시간_show.Size = new System.Drawing.Size(11, 12);
            this.계산시간_show.TabIndex = 10;
            this.계산시간_show.Text = "0";
            this.계산시간_show.Click += new System.EventHandler(this.계산시간_show_Click);
            // 
            // 움직이는횟수_show
            // 
            this.움직이는횟수_show.AutoSize = true;
            this.움직이는횟수_show.Location = new System.Drawing.Point(591, 190);
            this.움직이는횟수_show.Name = "움직이는횟수_show";
            this.움직이는횟수_show.Size = new System.Drawing.Size(11, 12);
            this.움직이는횟수_show.TabIndex = 11;
            this.움직이는횟수_show.Text = "0";
            // 
            // G_List개수_show
            // 
            this.G_List개수_show.AutoSize = true;
            this.G_List개수_show.Location = new System.Drawing.Point(591, 207);
            this.G_List개수_show.Name = "G_List개수_show";
            this.G_List개수_show.Size = new System.Drawing.Size(11, 12);
            this.G_List개수_show.TabIndex = 12;
            this.G_List개수_show.Text = "0";
            // 
            // Show_btn
            // 
            this.Show_btn.Location = new System.Drawing.Point(426, 295);
            this.Show_btn.Name = "Show_btn";
            this.Show_btn.Size = new System.Drawing.Size(132, 33);
            this.Show_btn.TabIndex = 13;
            this.Show_btn.Text = "Show";
            this.Show_btn.UseVisualStyleBackColor = true;
            this.Show_btn.Click += new System.EventHandler(this.Show_btn_Click);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(215, 295);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(132, 33);
            this.Reset_btn.TabIndex = 14;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Show_btn);
            this.Controls.Add(this.G_List개수_show);
            this.Controls.Add(this.움직이는횟수_show);
            this.Controls.Add(this.계산시간_show);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Check_txt);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox Check_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label 계산시간_show;
        private System.Windows.Forms.Label 움직이는횟수_show;
        private System.Windows.Forms.Label G_List개수_show;
        private System.Windows.Forms.Button Show_btn;
        private System.Windows.Forms.Button Reset_btn;
    }
}

