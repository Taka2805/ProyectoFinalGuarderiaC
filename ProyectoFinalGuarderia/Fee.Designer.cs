namespace ProyectoFinal
{
    partial class Fee
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
            this.tmat = new System.Windows.Forms.TextBox();
            this.lmat = new System.Windows.Forms.Label();
            this.lmes = new System.Windows.Forms.Label();
            this.tmes = new System.Windows.Forms.TextBox();
            this.lyear = new System.Windows.Forms.Label();
            this.tyear = new System.Windows.Forms.TextBox();
            this.lmon = new System.Windows.Forms.Label();
            this.tmon = new System.Windows.Forms.TextBox();
            this.btar = new System.Windows.Forms.Button();
            this.btaresp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbfee = new System.Windows.Forms.ComboBox();
            this.lper = new System.Windows.Forms.Label();
            this.tper = new System.Windows.Forms.TextBox();
            this.btarcons = new System.Windows.Forms.Button();
            this.breptar = new System.Windows.Forms.Button();
            this.grillafee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillafee)).BeginInit();
            this.SuspendLayout();
            // 
            // tmat
            // 
            this.tmat.Location = new System.Drawing.Point(190, 83);
            this.tmat.Name = "tmat";
            this.tmat.Size = new System.Drawing.Size(230, 22);
            this.tmat.TabIndex = 0;
            this.tmat.Text = "000-000-XX";
            // 
            // lmat
            // 
            this.lmat.AutoSize = true;
            this.lmat.Location = new System.Drawing.Point(39, 86);
            this.lmat.Name = "lmat";
            this.lmat.Size = new System.Drawing.Size(114, 16);
            this.lmat.TabIndex = 1;
            this.lmat.Text = "Matrícula del niño:";
            // 
            // lmes
            // 
            this.lmes.AutoSize = true;
            this.lmes.Location = new System.Drawing.Point(39, 149);
            this.lmes.Name = "lmes";
            this.lmes.Size = new System.Drawing.Size(117, 16);
            this.lmes.TabIndex = 2;
            this.lmes.Text = "Mes (en números):";
            // 
            // tmes
            // 
            this.tmes.Location = new System.Drawing.Point(190, 146);
            this.tmes.Name = "tmes";
            this.tmes.Size = new System.Drawing.Size(230, 22);
            this.tmes.TabIndex = 3;
            // 
            // lyear
            // 
            this.lyear.AutoSize = true;
            this.lyear.Location = new System.Drawing.Point(39, 190);
            this.lyear.Name = "lyear";
            this.lyear.Size = new System.Drawing.Size(34, 16);
            this.lyear.TabIndex = 4;
            this.lyear.Text = "Año:";
            // 
            // tyear
            // 
            this.tyear.Location = new System.Drawing.Point(190, 187);
            this.tyear.Name = "tyear";
            this.tyear.Size = new System.Drawing.Size(230, 22);
            this.tyear.TabIndex = 5;
            // 
            // lmon
            // 
            this.lmon.AutoSize = true;
            this.lmon.Location = new System.Drawing.Point(39, 234);
            this.lmon.Name = "lmon";
            this.lmon.Size = new System.Drawing.Size(47, 16);
            this.lmon.TabIndex = 6;
            this.lmon.Text = "Monto:";
            this.lmon.Visible = false;
            // 
            // tmon
            // 
            this.tmon.Location = new System.Drawing.Point(190, 234);
            this.tmon.Name = "tmon";
            this.tmon.Size = new System.Drawing.Size(230, 22);
            this.tmon.TabIndex = 7;
            this.tmon.WordWrap = false;
            // 
            // btar
            // 
            this.btar.Location = new System.Drawing.Point(42, 282);
            this.btar.Name = "btar";
            this.btar.Size = new System.Drawing.Size(146, 23);
            this.btar.TabIndex = 8;
            this.btar.Text = "Revisar Tarifa Total";
            this.btar.UseVisualStyleBackColor = true;
            this.btar.Visible = false;
            this.btar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btaresp
            // 
            this.btaresp.Location = new System.Drawing.Point(227, 282);
            this.btaresp.Name = "btaresp";
            this.btaresp.Size = new System.Drawing.Size(193, 23);
            this.btaresp.TabIndex = 9;
            this.btaresp.Text = "Revisar Tarifa Especialista";
            this.btaresp.UseVisualStyleBackColor = true;
            this.btaresp.Visible = false;
            this.btaresp.Click += new System.EventHandler(this.btaresp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "¿Qué tarifa quiere ver?";
            // 
            // cbfee
            // 
            this.cbfee.FormattingEnabled = true;
            this.cbfee.Location = new System.Drawing.Point(190, 38);
            this.cbfee.Name = "cbfee";
            this.cbfee.Size = new System.Drawing.Size(208, 24);
            this.cbfee.TabIndex = 11;
            this.cbfee.SelectedIndexChanged += new System.EventHandler(this.cbfee_SelectedIndexChanged);
            // 
            // lper
            // 
            this.lper.AutoSize = true;
            this.lper.Location = new System.Drawing.Point(39, 118);
            this.lper.Name = "lper";
            this.lper.Size = new System.Drawing.Size(123, 16);
            this.lper.TabIndex = 12;
            this.lper.Text = "Periodo (Año-Mes):";
            // 
            // tper
            // 
            this.tper.Location = new System.Drawing.Point(190, 115);
            this.tper.Name = "tper";
            this.tper.Size = new System.Drawing.Size(230, 22);
            this.tper.TabIndex = 13;
            this.tper.Text = "XXXX-XX";
            // 
            // btarcons
            // 
            this.btarcons.Location = new System.Drawing.Point(42, 326);
            this.btarcons.Name = "btarcons";
            this.btarcons.Size = new System.Drawing.Size(166, 23);
            this.btarcons.TabIndex = 14;
            this.btarcons.Text = "Revisar Tarifa Consumo";
            this.btarcons.UseVisualStyleBackColor = true;
            this.btarcons.Visible = false;
            this.btarcons.Click += new System.EventHandler(this.btarcons_Click);
            // 
            // breptar
            // 
            this.breptar.Location = new System.Drawing.Point(227, 326);
            this.breptar.Name = "breptar";
            this.breptar.Size = new System.Drawing.Size(193, 23);
            this.breptar.TabIndex = 15;
            this.breptar.Text = "Reporte Tarifa";
            this.breptar.UseVisualStyleBackColor = true;
            this.breptar.Visible = false;
            this.breptar.Click += new System.EventHandler(this.breptar_Click);
            // 
            // grillafee
            // 
            this.grillafee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillafee.Location = new System.Drawing.Point(25, 382);
            this.grillafee.Name = "grillafee";
            this.grillafee.RowHeadersWidth = 51;
            this.grillafee.RowTemplate.Height = 24;
            this.grillafee.Size = new System.Drawing.Size(395, 150);
            this.grillafee.TabIndex = 16;
            // 
            // Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(474, 439);
            this.Controls.Add(this.grillafee);
            this.Controls.Add(this.breptar);
            this.Controls.Add(this.btarcons);
            this.Controls.Add(this.tper);
            this.Controls.Add(this.lper);
            this.Controls.Add(this.cbfee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btaresp);
            this.Controls.Add(this.btar);
            this.Controls.Add(this.tmon);
            this.Controls.Add(this.lmon);
            this.Controls.Add(this.tyear);
            this.Controls.Add(this.lyear);
            this.Controls.Add(this.tmes);
            this.Controls.Add(this.lmes);
            this.Controls.Add(this.lmat);
            this.Controls.Add(this.tmat);
            this.Name = "Fee";
            this.Text = "Tarifas";
            ((System.ComponentModel.ISupportInitialize)(this.grillafee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tmat;
        private System.Windows.Forms.Label lmat;
        private System.Windows.Forms.Label lmes;
        private System.Windows.Forms.TextBox tmes;
        private System.Windows.Forms.Label lyear;
        private System.Windows.Forms.TextBox tyear;
        private System.Windows.Forms.Label lmon;
        private System.Windows.Forms.TextBox tmon;
        private System.Windows.Forms.Button btar;
        private System.Windows.Forms.Button btaresp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbfee;
        private System.Windows.Forms.Label lper;
        private System.Windows.Forms.TextBox tper;
        private System.Windows.Forms.Button btarcons;
        private System.Windows.Forms.Button breptar;
        private System.Windows.Forms.DataGridView grillafee;
    }
}