
namespace App
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paczkomat1 = new System.Windows.Forms.ListBox();
            this.paczkomat2 = new System.Windows.Forms.ListBox();
            this.paczkomat3 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.ListBox();
            this.q2 = new System.Windows.Forms.ListBox();
            this.q3 = new System.Windows.Forms.ListBox();
            this.servedP1 = new System.Windows.Forms.ListBox();
            this.servedP2 = new System.Windows.Forms.ListBox();
            this.servedP3 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1314, 63);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1103, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "concurrent programming";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "ParcelLocker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // paczkomat1
            // 
            this.paczkomat1.BackColor = System.Drawing.Color.LemonChiffon;
            this.paczkomat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paczkomat1.FormattingEnabled = true;
            this.paczkomat1.ItemHeight = 21;
            this.paczkomat1.Location = new System.Drawing.Point(299, 162);
            this.paczkomat1.Name = "paczkomat1";
            this.paczkomat1.Size = new System.Drawing.Size(236, 254);
            this.paczkomat1.TabIndex = 4;
            // 
            // paczkomat2
            // 
            this.paczkomat2.BackColor = System.Drawing.Color.LemonChiffon;
            this.paczkomat2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paczkomat2.FormattingEnabled = true;
            this.paczkomat2.ItemHeight = 21;
            this.paczkomat2.Location = new System.Drawing.Point(655, 162);
            this.paczkomat2.Name = "paczkomat2";
            this.paczkomat2.Size = new System.Drawing.Size(240, 254);
            this.paczkomat2.TabIndex = 5;
            // 
            // paczkomat3
            // 
            this.paczkomat3.BackColor = System.Drawing.Color.LemonChiffon;
            this.paczkomat3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paczkomat3.FormattingEnabled = true;
            this.paczkomat3.ItemHeight = 21;
            this.paczkomat3.Location = new System.Drawing.Point(1040, 162);
            this.paczkomat3.Name = "paczkomat3";
            this.paczkomat3.Size = new System.Drawing.Size(240, 254);
            this.paczkomat3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.aboutBtn);
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.clearBtn);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.startBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 659);
            this.panel2.TabIndex = 7;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.aboutBtn.Location = new System.Drawing.Point(12, 413);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(196, 42);
            this.aboutBtn.TabIndex = 9;
            this.aboutBtn.Text = "about";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(12, 494);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(196, 42);
            this.exitBtn.TabIndex = 8;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearBtn.Location = new System.Drawing.Point(12, 204);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(196, 42);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopBtn.Location = new System.Drawing.Point(12, 125);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(196, 42);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.SystemColors.GrayText;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startBtn.Location = new System.Drawing.Point(12, 48);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(196, 42);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p1.Location = new System.Drawing.Point(295, 88);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(200, 33);
            this.p1.TabIndex = 8;
            this.p1.Text = "ParcelLocker1";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p2.Location = new System.Drawing.Point(651, 88);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(200, 33);
            this.p2.TabIndex = 9;
            this.p2.Text = "ParcelLocker2";
            // 
            // p3
            // 
            this.p3.AutoSize = true;
            this.p3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.p3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.p3.Location = new System.Drawing.Point(1036, 88);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(200, 33);
            this.p3.TabIndex = 10;
            this.p3.Text = "ParcelLocker3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 533);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Queue1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Queue1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Queue1";
            // 
            // q1
            // 
            this.q1.BackColor = System.Drawing.Color.Wheat;
            this.q1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.q1.FormattingEnabled = true;
            this.q1.ItemHeight = 21;
            this.q1.Location = new System.Drawing.Point(299, 557);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(236, 149);
            this.q1.TabIndex = 14;
            // 
            // q2
            // 
            this.q2.BackColor = System.Drawing.Color.Wheat;
            this.q2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.q2.FormattingEnabled = true;
            this.q2.ItemHeight = 21;
            this.q2.Location = new System.Drawing.Point(659, 557);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(236, 149);
            this.q2.TabIndex = 15;
            // 
            // q3
            // 
            this.q3.BackColor = System.Drawing.Color.Wheat;
            this.q3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.q3.FormattingEnabled = true;
            this.q3.ItemHeight = 21;
            this.q3.Location = new System.Drawing.Point(1044, 557);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(236, 149);
            this.q3.TabIndex = 16;
            // 
            // servedP1
            // 
            this.servedP1.BackColor = System.Drawing.Color.LawnGreen;
            this.servedP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servedP1.FormattingEnabled = true;
            this.servedP1.ItemHeight = 21;
            this.servedP1.Location = new System.Drawing.Point(299, 476);
            this.servedP1.Name = "servedP1";
            this.servedP1.Size = new System.Drawing.Size(236, 23);
            this.servedP1.TabIndex = 17;
            // 
            // servedP2
            // 
            this.servedP2.BackColor = System.Drawing.Color.LawnGreen;
            this.servedP2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servedP2.FormattingEnabled = true;
            this.servedP2.ItemHeight = 21;
            this.servedP2.Location = new System.Drawing.Point(659, 476);
            this.servedP2.Name = "servedP2";
            this.servedP2.Size = new System.Drawing.Size(236, 23);
            this.servedP2.TabIndex = 18;
            // 
            // servedP3
            // 
            this.servedP3.BackColor = System.Drawing.Color.LawnGreen;
            this.servedP3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.servedP3.FormattingEnabled = true;
            this.servedP3.ItemHeight = 21;
            this.servedP3.Location = new System.Drawing.Point(1044, 476);
            this.servedP3.Name = "servedP3";
            this.servedP3.Size = new System.Drawing.Size(236, 23);
            this.servedP3.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "served person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(655, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "served person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1040, 433);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 22;
            this.label8.Text = "served person";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1314, 722);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.servedP3);
            this.Controls.Add(this.servedP2);
            this.Controls.Add(this.servedP1);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.paczkomat3);
            this.Controls.Add(this.paczkomat2);
            this.Controls.Add(this.paczkomat1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParcelLocker";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox paczkomat1;
        private System.Windows.Forms.ListBox paczkomat2;
        private System.Windows.Forms.ListBox paczkomat3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox q1;
        private System.Windows.Forms.ListBox q2;
        private System.Windows.Forms.ListBox q3;
        private System.Windows.Forms.ListBox servedP1;
        private System.Windows.Forms.ListBox servedP2;
        private System.Windows.Forms.ListBox servedP3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

