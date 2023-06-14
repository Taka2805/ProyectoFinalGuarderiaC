namespace ProyectoFinal
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.tdir = new System.Windows.Forms.TextBox();
            this.grillaninos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tnomprof = new System.Windows.Forms.TextBox();
            this.tidprof = new System.Windows.Forms.TextBox();
            this.brevprof = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tesp = new System.Windows.Forms.TextBox();
            this.grillaserv = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tesp2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tcost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tmat = new System.Windows.Forms.TextBox();
            this.tidprof2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tidser = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tfin = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaninos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaserv)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 369);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 39);
            this.button2.TabIndex = 41;
            this.button2.Text = "Registrar Profesional";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tdir
            // 
            this.tdir.Location = new System.Drawing.Point(190, 313);
            this.tdir.Name = "tdir";
            this.tdir.Size = new System.Drawing.Size(260, 22);
            this.tdir.TabIndex = 40;
            // 
            // grillaninos
            // 
            this.grillaninos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaninos.Location = new System.Drawing.Point(626, 138);
            this.grillaninos.Name = "grillaninos";
            this.grillaninos.RowHeadersWidth = 51;
            this.grillaninos.RowTemplate.Height = 24;
            this.grillaninos.Size = new System.Drawing.Size(584, 254);
            this.grillaninos.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "Registrar un nuevo profesional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Especialidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre del Profesional:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "ID Profesional:";
            // 
            // tnomprof
            // 
            this.tnomprof.Location = new System.Drawing.Point(190, 208);
            this.tnomprof.Name = "tnomprof";
            this.tnomprof.Size = new System.Drawing.Size(260, 22);
            this.tnomprof.TabIndex = 29;
            // 
            // tidprof
            // 
            this.tidprof.Location = new System.Drawing.Point(190, 153);
            this.tidprof.Name = "tidprof";
            this.tidprof.Size = new System.Drawing.Size(260, 22);
            this.tidprof.TabIndex = 28;
            this.tidprof.Text = "500-000-XX";
            // 
            // brevprof
            // 
            this.brevprof.Location = new System.Drawing.Point(870, 66);
            this.brevprof.Name = "brevprof";
            this.brevprof.Size = new System.Drawing.Size(148, 49);
            this.brevprof.TabIndex = 27;
            this.brevprof.Text = "Revisar Profesionales Existentes";
            this.brevprof.UseVisualStyleBackColor = true;
            this.brevprof.Click += new System.EventHandler(this.brevprof_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "¿Qué quiere hacer?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Reigistrar Profesional";
            // 
            // tesp
            // 
            this.tesp.Location = new System.Drawing.Point(190, 266);
            this.tesp.Name = "tesp";
            this.tesp.Size = new System.Drawing.Size(260, 22);
            this.tesp.TabIndex = 45;
            // 
            // grillaserv
            // 
            this.grillaserv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaserv.Location = new System.Drawing.Point(626, 445);
            this.grillaserv.Name = "grillaserv";
            this.grillaserv.RowHeadersWidth = 51;
            this.grillaserv.RowTemplate.Height = 24;
            this.grillaserv.Size = new System.Drawing.Size(584, 254);
            this.grillaserv.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Registrar Servicio";
            // 
            // tesp2
            // 
            this.tesp2.Location = new System.Drawing.Point(225, 596);
            this.tesp2.Name = "tesp2";
            this.tesp2.Size = new System.Drawing.Size(260, 22);
            this.tesp2.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 39);
            this.button1.TabIndex = 55;
            this.button1.Text = "Registrar Servicio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tcost
            // 
            this.tcost.Location = new System.Drawing.Point(225, 660);
            this.tcost.Name = "tcost";
            this.tcost.Size = new System.Drawing.Size(260, 22);
            this.tcost.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Inicio del Servicio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 599);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 16);
            this.label10.TabIndex = 52;
            this.label10.Text = "Especialidad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 564);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "Número de Matrícula del Niño:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 532);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "ID Profesional:";
            // 
            // tmat
            // 
            this.tmat.Location = new System.Drawing.Point(225, 558);
            this.tmat.Name = "tmat";
            this.tmat.Size = new System.Drawing.Size(260, 22);
            this.tmat.TabIndex = 49;
            // 
            // tidprof2
            // 
            this.tidprof2.Location = new System.Drawing.Point(225, 526);
            this.tidprof2.Name = "tidprof2";
            this.tidprof2.Size = new System.Drawing.Size(260, 22);
            this.tidprof2.TabIndex = 48;
            this.tidprof2.Text = "500-000-XX";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "ID Servicio:";
            // 
            // tidser
            // 
            this.tidser.Location = new System.Drawing.Point(225, 489);
            this.tidser.Name = "tidser";
            this.tidser.Size = new System.Drawing.Size(260, 22);
            this.tidser.TabIndex = 57;
            this.tidser.Text = "0X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 666);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 59;
            this.label14.Text = "Costo del Servicio:";
            // 
            // tfin
            // 
            this.tfin.Location = new System.Drawing.Point(225, 633);
            this.tfin.Name = "tfin";
            this.tfin.Size = new System.Drawing.Size(260, 22);
            this.tfin.TabIndex = 60;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(861, 705);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 39);
            this.button3.TabIndex = 61;
            this.button3.Text = "Mostrar Profesionales";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(456, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 39);
            this.button4.TabIndex = 62;
            this.button4.Text = "Gestionar Pagos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1245, 479);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tfin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tidser);
            this.Controls.Add(this.tesp2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tcost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tmat);
            this.Controls.Add(this.tidprof2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grillaserv);
            this.Controls.Add(this.tesp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tdir);
            this.Controls.Add(this.grillaninos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tnomprof);
            this.Controls.Add(this.tidprof);
            this.Controls.Add(this.brevprof);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Registro Profesionales";
            ((System.ComponentModel.ISupportInitialize)(this.grillaninos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tdir;
        private System.Windows.Forms.DataGridView grillaninos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tnomprof;
        private System.Windows.Forms.TextBox tidprof;
        private System.Windows.Forms.Button brevprof;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tesp;
        private System.Windows.Forms.DataGridView grillaserv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tesp2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tcost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tmat;
        private System.Windows.Forms.TextBox tidprof2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tidser;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker tfin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}