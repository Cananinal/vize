namespace lıste
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(61, 168);
            button1.Name = "button1";
            button1.Size = new Size(199, 107);
            button1.TabIndex = 0;
            button1.Text = "PAZARTESİ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.ForeColor = SystemColors.Highlight;
            button2.Location = new Point(288, 168);
            button2.Name = "button2";
            button2.Size = new Size(204, 107);
            button2.TabIndex = 1;
            button2.Text = "SALI";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.ForeColor = SystemColors.HotTrack;
            button3.Location = new Point(513, 168);
            button3.Name = "button3";
            button3.Size = new Size(194, 107);
            button3.TabIndex = 2;
            button3.Text = "ÇARŞAMBA";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Info;
            button4.ForeColor = SystemColors.HotTrack;
            button4.Location = new Point(178, 294);
            button4.Name = "button4";
            button4.Size = new Size(199, 113);
            button4.TabIndex = 3;
            button4.Text = "PERŞEMBE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.Info;
            button5.ForeColor = SystemColors.HotTrack;
            button5.Location = new Point(416, 294);
            button5.Name = "button5";
            button5.Size = new Size(200, 113);
            button5.TabIndex = 4;
            button5.Text = "CUMA";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(118, 35);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(582, 70);
            label1.TabIndex = 5;
            label1.Text = "OSTİM TEKNİK ÜNİVERSİTESİ YEMEKHANESİ \r\n           KALORİ HESAP UYGULAMASI";
            label1.TextAlign = ContentAlignment.BottomLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}