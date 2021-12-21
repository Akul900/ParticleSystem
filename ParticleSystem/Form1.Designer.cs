namespace ParticleSystem
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
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbGraviton = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbParticlesPerTick = new System.Windows.Forms.TrackBar();
            this.lblParticlesPerTick = new System.Windows.Forms.Label();
            this.lblParticlesCount = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLife = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.picDisplay.Location = new System.Drawing.Point(30, 30);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(885, 590);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(964, 30);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(216, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(1068, 11);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(0, 16);
            this.lblDirection.TabIndex = 2;
            // 
            // tbGraviton
            // 
            this.tbGraviton.Location = new System.Drawing.Point(964, 525);
            this.tbGraviton.Maximum = 100;
            this.tbGraviton.Name = "tbGraviton";
            this.tbGraviton.Size = new System.Drawing.Size(216, 56);
            this.tbGraviton.TabIndex = 3;
            this.tbGraviton.Scroll += new System.EventHandler(this.tbGraviton_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(965, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(972, 506);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Гравитон";
            // 
            // tbParticlesPerTick
            // 
            this.tbParticlesPerTick.Location = new System.Drawing.Point(968, 204);
            this.tbParticlesPerTick.Maximum = 20;
            this.tbParticlesPerTick.Name = "tbParticlesPerTick";
            this.tbParticlesPerTick.Size = new System.Drawing.Size(216, 56);
            this.tbParticlesPerTick.TabIndex = 6;
            this.tbParticlesPerTick.Scroll += new System.EventHandler(this.tbParticlesPerTick_Scroll);
            // 
            // lblParticlesPerTick
            // 
            this.lblParticlesPerTick.AutoSize = true;
            this.lblParticlesPerTick.Location = new System.Drawing.Point(965, 169);
            this.lblParticlesPerTick.Name = "lblParticlesPerTick";
            this.lblParticlesPerTick.Size = new System.Drawing.Size(136, 16);
            this.lblParticlesPerTick.TabIndex = 7;
            this.lblParticlesPerTick.Text = "Кол-во частиц в тик";
            // 
            // lblParticlesCount
            // 
            this.lblParticlesCount.AutoSize = true;
            this.lblParticlesCount.Location = new System.Drawing.Point(965, 263);
            this.lblParticlesCount.Name = "lblParticlesCount";
            this.lblParticlesCount.Size = new System.Drawing.Size(0, 16);
            this.lblParticlesCount.TabIndex = 8;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(964, 343);
            this.tbSpreading.Maximum = 300;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(216, 56);
            this.tbSpreading.TabIndex = 9;
            this.tbSpreading.Scroll += new System.EventHandler(this.tbSpreading_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(965, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Распределение";
            // 
            // tbLife
            // 
            this.tbLife.Location = new System.Drawing.Point(964, 448);
            this.tbLife.Maximum = 100;
            this.tbLife.Minimum = 25;
            this.tbLife.Name = "tbLife";
            this.tbLife.Size = new System.Drawing.Size(216, 56);
            this.tbLife.TabIndex = 11;
            this.tbLife.Value = 25;
            this.tbLife.Scroll += new System.EventHandler(this.tbLife_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(965, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Продолжительность жизни";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(968, 110);
            this.tbSpeed.Maximum = 20;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSpeed.Size = new System.Drawing.Size(216, 56);
            this.tbSpeed.TabIndex = 13;
            this.tbSpeed.Value = 1;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(965, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Скорость";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 654);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLife);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lblParticlesCount);
            this.Controls.Add(this.lblParticlesPerTick);
            this.Controls.Add(this.tbParticlesPerTick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGraviton);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGraviton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbParticlesPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbGraviton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbParticlesPerTick;
        private System.Windows.Forms.Label lblParticlesPerTick;
        private System.Windows.Forms.Label lblParticlesCount;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbLife;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label label5;
    }
}

