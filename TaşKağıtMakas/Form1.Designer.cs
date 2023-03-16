namespace TaşKağıtMakas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnTas = new System.Windows.Forms.Button();
            this.btnKagit = new System.Windows.Forms.Button();
            this.btnMakas = new System.Windows.Forms.Button();
            this.btnTekrarBasla = new System.Windows.Forms.Button();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtGeri = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.geriSayimTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTas
            // 
            this.btnTas.Location = new System.Drawing.Point(109, 99);
            this.btnTas.Name = "btnTas";
            this.btnTas.Size = new System.Drawing.Size(94, 29);
            this.btnTas.TabIndex = 0;
            this.btnTas.Text = "Taş";
            this.btnTas.UseVisualStyleBackColor = true;
            this.btnTas.Click += new System.EventHandler(this.btnTas_Click);
            // 
            // btnKagit
            // 
            this.btnKagit.Location = new System.Drawing.Point(109, 175);
            this.btnKagit.Name = "btnKagit";
            this.btnKagit.Size = new System.Drawing.Size(94, 29);
            this.btnKagit.TabIndex = 1;
            this.btnKagit.Text = "Kağıt";
            this.btnKagit.UseVisualStyleBackColor = true;
            this.btnKagit.Click += new System.EventHandler(this.btnKagit_Click);
            // 
            // btnMakas
            // 
            this.btnMakas.Location = new System.Drawing.Point(109, 248);
            this.btnMakas.Name = "btnMakas";
            this.btnMakas.Size = new System.Drawing.Size(94, 29);
            this.btnMakas.TabIndex = 2;
            this.btnMakas.Text = "Makas";
            this.btnMakas.UseVisualStyleBackColor = true;
            this.btnMakas.Click += new System.EventHandler(this.btnMakas_Click);
            // 
            // btnTekrarBasla
            // 
            this.btnTekrarBasla.Location = new System.Drawing.Point(638, 393);
            this.btnTekrarBasla.Name = "btnTekrarBasla";
            this.btnTekrarBasla.Size = new System.Drawing.Size(133, 29);
            this.btnTekrarBasla.TabIndex = 3;
            this.btnTekrarBasla.Text = "Tekrar Başlat";
            this.btnTekrarBasla.UseVisualStyleBackColor = true;
            this.btnTekrarBasla.Click += new System.EventHandler(this.btnTekrarBasla_Click);
            // 
            // picCPU
            // 
            this.picCPU.Image = global::TaşKağıtMakas.Properties.Resources.qq;
            this.picCPU.Location = new System.Drawing.Point(605, 100);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(137, 178);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 4;
            this.picCPU.TabStop = false;
            this.picCPU.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::TaşKağıtMakas.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(287, 99);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(139, 178);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 5;
            this.picPlayer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Player";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(638, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "CPU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(442, 105);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(144, 23);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "PLayer:0 - CPU:0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGeri
            // 
            this.txtGeri.AutoSize = true;
            this.txtGeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtGeri.Location = new System.Drawing.Point(499, 175);
            this.txtGeri.Name = "txtGeri";
            this.txtGeri.Size = new System.Drawing.Size(24, 28);
            this.txtGeri.TabIndex = 9;
            this.txtGeri.Text = "5";
            this.txtGeri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRound.Location = new System.Drawing.Point(477, 269);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(90, 28);
            this.txtRound.TabIndex = 10;
            this.txtRound.Text = "Round:3";
            this.txtRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // geriSayimTimer
            // 
            this.geriSayimTimer.Interval = 1000;
            this.geriSayimTimer.Tick += new System.EventHandler(this.geriSayimTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtGeri);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.btnTekrarBasla);
            this.Controls.Add(this.btnMakas);
            this.Controls.Add(this.btnKagit);
            this.Controls.Add(this.btnTas);
            this.Name = "Form1";
            this.Text = "Taş Kağıt Makas Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnTas;
        private Button btnKagit;
        private Button btnMakas;
        private Button btnTekrarBasla;
        private PictureBox picCPU;
        private PictureBox picPlayer;
        private Label label1;
        private Label label2;
        private Label txtScore;
        private Label txtGeri;
        private Label txtRound;
        private System.Windows.Forms.Timer geriSayimTimer;
    }
}