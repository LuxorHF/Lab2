
namespace ip_kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_1bit = new System.Windows.Forms.TextBox();
            this.tb_2bit = new System.Windows.Forms.TextBox();
            this.tb_3bit = new System.Windows.Forms.TextBox();
            this.tb_4bit = new System.Windows.Forms.TextBox();
            this.network = new System.Windows.Forms.Label();
            this.broadcast = new System.Windows.Forms.Label();
            this.fullmask = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_mask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Hosts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_1bit
            // 
            this.tb_1bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_1bit.Location = new System.Drawing.Point(27, 36);
            this.tb_1bit.Name = "tb_1bit";
            this.tb_1bit.Size = new System.Drawing.Size(100, 68);
            this.tb_1bit.TabIndex = 0;
            // 
            // tb_2bit
            // 
            this.tb_2bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_2bit.Location = new System.Drawing.Point(144, 36);
            this.tb_2bit.Name = "tb_2bit";
            this.tb_2bit.Size = new System.Drawing.Size(100, 68);
            this.tb_2bit.TabIndex = 1;
            // 
            // tb_3bit
            // 
            this.tb_3bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_3bit.Location = new System.Drawing.Point(268, 36);
            this.tb_3bit.Name = "tb_3bit";
            this.tb_3bit.Size = new System.Drawing.Size(100, 68);
            this.tb_3bit.TabIndex = 2;
            // 
            // tb_4bit
            // 
            this.tb_4bit.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_4bit.Location = new System.Drawing.Point(389, 36);
            this.tb_4bit.Name = "tb_4bit";
            this.tb_4bit.Size = new System.Drawing.Size(100, 68);
            this.tb_4bit.TabIndex = 3;
            // 
            // network
            // 
            this.network.AutoSize = true;
            this.network.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.network.Location = new System.Drawing.Point(195, 121);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(173, 63);
            this.network.TabIndex = 4;
            this.network.Text = "label1";
            // 
            // broadcast
            // 
            this.broadcast.AutoSize = true;
            this.broadcast.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.broadcast.Location = new System.Drawing.Point(195, 224);
            this.broadcast.Name = "broadcast";
            this.broadcast.Size = new System.Drawing.Size(173, 63);
            this.broadcast.TabIndex = 5;
            this.broadcast.Text = "label2";
            // 
            // fullmask
            // 
            this.fullmask.AutoSize = true;
            this.fullmask.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullmask.Location = new System.Drawing.Point(195, 318);
            this.fullmask.Name = "fullmask";
            this.fullmask.Size = new System.Drawing.Size(173, 63);
            this.fullmask.TabIndex = 6;
            this.fullmask.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(644, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_mask
            // 
            this.tb_mask.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_mask.Location = new System.Drawing.Point(514, 36);
            this.tb_mask.Name = "tb_mask";
            this.tb_mask.Size = new System.Drawing.Size(100, 68);
            this.tb_mask.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(116, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 63);
            this.label1.TabIndex = 9;
            this.label1.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(238, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 63);
            this.label2.TabIndex = 10;
            this.label2.Text = ".";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(359, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 63);
            this.label3.TabIndex = 11;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(483, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 63);
            this.label4.TabIndex = 12;
            this.label4.Text = "/";
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(644, 128);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(144, 63);
            this.bClear.TabIndex = 13;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(33, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 46);
            this.label5.TabIndex = 14;
            this.label5.Text = "network:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-3, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 46);
            this.label6.TabIndex = 15;
            this.label6.Text = "broadcast:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(78, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 46);
            this.label7.TabIndex = 16;
            this.label7.Text = "mask:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(78, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 46);
            this.label8.TabIndex = 17;
            this.label8.Text = "hosts:";
            // 
            // Hosts
            // 
            this.Hosts.AutoSize = true;
            this.Hosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hosts.Location = new System.Drawing.Point(195, 383);
            this.Hosts.Name = "Hosts";
            this.Hosts.Size = new System.Drawing.Size(173, 63);
            this.Hosts.TabIndex = 18;
            this.Hosts.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Hosts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.tb_mask);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fullmask);
            this.Controls.Add(this.broadcast);
            this.Controls.Add(this.network);
            this.Controls.Add(this.tb_4bit);
            this.Controls.Add(this.tb_3bit);
            this.Controls.Add(this.tb_2bit);
            this.Controls.Add(this.tb_1bit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "IP calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_1bit;
        private System.Windows.Forms.TextBox tb_2bit;
        private System.Windows.Forms.TextBox tb_3bit;
        private System.Windows.Forms.TextBox tb_4bit;
        private System.Windows.Forms.Label network;
        private System.Windows.Forms.Label broadcast;
        private System.Windows.Forms.Label fullmask;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_mask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Hosts;
    }
}

