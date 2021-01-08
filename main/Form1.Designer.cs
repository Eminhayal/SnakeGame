
namespace main
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.game = new System.Windows.Forms.PictureBox();
            this.score_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer_score = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKişileriKaydet = new System.Windows.Forms.TextBox();
            this.btnSkorlarıGörüntüle = new System.Windows.Forms.Button();
            this.btnKişiyikaydet = new System.Windows.Forms.Button();
            this.btnYardım = new System.Windows.Forms.Button();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.bilgiPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kolayRdb = new System.Windows.Forms.RadioButton();
            this.zorRdb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.game)).BeginInit();
            this.bilgiPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // game
            // 
            this.game.AccessibleDescription = "";
            this.game.BackColor = System.Drawing.Color.GhostWhite;
            this.game.Location = new System.Drawing.Point(91, 78);
            this.game.Name = "game";
            this.game.Size = new System.Drawing.Size(500, 500);
            this.game.TabIndex = 0;
            this.game.TabStop = false;
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.score_label.Location = new System.Drawing.Point(556, 35);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(42, 20);
            this.score_label.TabIndex = 1;
            this.score_label.Text = "Skor";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timer_label.Location = new System.Drawing.Point(166, 30);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(51, 20);
            this.timer_label.TabIndex = 2;
            this.timer_label.Text = "label1";
            // 
            // timer_score
            // 
            this.timer_score.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Yilan Oyunu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(491, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puan:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(43, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Geçen Süre:";
            // 
            // txtKişileriKaydet
            // 
            this.txtKişileriKaydet.Location = new System.Drawing.Point(231, 626);
            this.txtKişileriKaydet.Name = "txtKişileriKaydet";
            this.txtKişileriKaydet.Size = new System.Drawing.Size(113, 20);
            this.txtKişileriKaydet.TabIndex = 13;
            this.txtKişileriKaydet.TabStop = false;
            // 
            // btnSkorlarıGörüntüle
            // 
            this.btnSkorlarıGörüntüle.Location = new System.Drawing.Point(560, 653);
            this.btnSkorlarıGörüntüle.Name = "btnSkorlarıGörüntüle";
            this.btnSkorlarıGörüntüle.Size = new System.Drawing.Size(116, 20);
            this.btnSkorlarıGörüntüle.TabIndex = 12;
            this.btnSkorlarıGörüntüle.TabStop = false;
            this.btnSkorlarıGörüntüle.Text = "Skorları Görüntüle";
            this.btnSkorlarıGörüntüle.UseVisualStyleBackColor = true;
            this.btnSkorlarıGörüntüle.Click += new System.EventHandler(this.btnSkorlarıGörüntüle_Click);
            // 
            // btnKişiyikaydet
            // 
            this.btnKişiyikaydet.Location = new System.Drawing.Point(350, 626);
            this.btnKişiyikaydet.Name = "btnKişiyikaydet";
            this.btnKişiyikaydet.Size = new System.Drawing.Size(113, 20);
            this.btnKişiyikaydet.TabIndex = 11;
            this.btnKişiyikaydet.TabStop = false;
            this.btnKişiyikaydet.Text = "Kişiyi Kaydet";
            this.btnKişiyikaydet.UseVisualStyleBackColor = true;
            this.btnKişiyikaydet.Click += new System.EventHandler(this.btnKişiyikaydet_Click);
            // 
            // btnYardım
            // 
            this.btnYardım.Location = new System.Drawing.Point(27, 653);
            this.btnYardım.Name = "btnYardım";
            this.btnYardım.Size = new System.Drawing.Size(115, 20);
            this.btnYardım.TabIndex = 10;
            this.btnYardım.TabStop = false;
            this.btnYardım.Text = "Yardım";
            this.btnYardım.UseVisualStyleBackColor = true;
            this.btnYardım.Click += new System.EventHandler(this.btnYardım_Click);
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // bilgiPanel
            // 
            this.bilgiPanel.BackColor = System.Drawing.Color.Lavender;
            this.bilgiPanel.Controls.Add(this.label5);
            this.bilgiPanel.Location = new System.Drawing.Point(91, 78);
            this.bilgiPanel.Name = "bilgiPanel";
            this.bilgiPanel.Size = new System.Drawing.Size(500, 500);
            this.bilgiPanel.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(355, 199);
            this.label5.TabIndex = 0;
            this.label5.Text = "Başlamak için [B] tuşuna , durdurmak için [D] tuşuna basınız.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // kolayRdb
            // 
            this.kolayRdb.AutoSize = true;
            this.kolayRdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.kolayRdb.Location = new System.Drawing.Point(293, 584);
            this.kolayRdb.Name = "kolayRdb";
            this.kolayRdb.Size = new System.Drawing.Size(51, 17);
            this.kolayRdb.TabIndex = 16;
            this.kolayRdb.TabStop = true;
            this.kolayRdb.Text = "Kolay";
            this.kolayRdb.UseVisualStyleBackColor = true;
            // 
            // zorRdb
            // 
            this.zorRdb.AutoSize = true;
            this.zorRdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.zorRdb.Location = new System.Drawing.Point(350, 584);
            this.zorRdb.Name = "zorRdb";
            this.zorRdb.Size = new System.Drawing.Size(41, 17);
            this.zorRdb.TabIndex = 17;
            this.zorRdb.TabStop = true;
            this.zorRdb.Text = "Zor";
            this.zorRdb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(700, 682);
            this.Controls.Add(this.zorRdb);
            this.Controls.Add(this.kolayRdb);
            this.Controls.Add(this.bilgiPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKişileriKaydet);
            this.Controls.Add(this.btnSkorlarıGörüntüle);
            this.Controls.Add(this.btnKişiyikaydet);
            this.Controls.Add(this.btnYardım);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.game);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.game)).EndInit();
            this.bilgiPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox game;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Timer timer_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKişileriKaydet;
        private System.Windows.Forms.Button btnSkorlarıGörüntüle;
        private System.Windows.Forms.Button btnKişiyikaydet;
        private System.Windows.Forms.Button btnYardım;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Panel bilgiPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton kolayRdb;
        private System.Windows.Forms.RadioButton zorRdb;
    }
}

