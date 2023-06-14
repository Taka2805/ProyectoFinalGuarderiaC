namespace ProyectoFinal
{
    partial class Form5
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
            this.grillaninos = new System.Windows.Forms.DataGridView();
            this.grillagrandes = new System.Windows.Forms.DataGridView();
            this.bninos = new System.Windows.Forms.Button();
            this.bencar = new System.Windows.Forms.Button();
            this.grillarel = new System.Windows.Forms.DataGridView();
            this.brel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmat = new System.Windows.Forms.TextBox();
            this.tci = new System.Windows.Forms.TextBox();
            this.tpar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaninos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillagrandes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillarel)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaninos
            // 
            this.grillaninos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaninos.Location = new System.Drawing.Point(12, 12);
            this.grillaninos.Name = "grillaninos";
            this.grillaninos.Size = new System.Drawing.Size(479, 208);
            this.grillaninos.TabIndex = 0;
            this.grillaninos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaninos_CellContentClick);
            // 
            // grillagrandes
            // 
            this.grillagrandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillagrandes.Location = new System.Drawing.Point(638, 12);
            this.grillagrandes.Name = "grillagrandes";
            this.grillagrandes.Size = new System.Drawing.Size(479, 208);
            this.grillagrandes.TabIndex = 1;
            // 
            // bninos
            // 
            this.bninos.Location = new System.Drawing.Point(174, 226);
            this.bninos.Name = "bninos";
            this.bninos.Size = new System.Drawing.Size(111, 23);
            this.bninos.TabIndex = 2;
            this.bninos.Text = "Mostrar niños";
            this.bninos.UseVisualStyleBackColor = true;
            this.bninos.Click += new System.EventHandler(this.bninos_Click);
            // 
            // bencar
            // 
            this.bencar.Location = new System.Drawing.Point(838, 226);
            this.bencar.Name = "bencar";
            this.bencar.Size = new System.Drawing.Size(111, 23);
            this.bencar.TabIndex = 3;
            this.bencar.Text = "Mostrar Encargados";
            this.bencar.UseVisualStyleBackColor = true;
            this.bencar.Click += new System.EventHandler(this.bencar_Click);
            // 
            // grillarel
            // 
            this.grillarel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillarel.Location = new System.Drawing.Point(342, 236);
            this.grillarel.Name = "grillarel";
            this.grillarel.Size = new System.Drawing.Size(479, 208);
            this.grillarel.TabIndex = 4;
            // 
            // brel
            // 
            this.brel.Location = new System.Drawing.Point(536, 450);
            this.brel.Name = "brel";
            this.brel.Size = new System.Drawing.Size(111, 23);
            this.brel.TabIndex = 5;
            this.brel.Text = "Mostrar Relaciones";
            this.brel.UseVisualStyleBackColor = true;
            this.brel.Click += new System.EventHandler(this.brel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Matrícula Niño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "CI Encargado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Parentezco:";
            // 
            // tmat
            // 
            this.tmat.Location = new System.Drawing.Point(119, 279);
            this.tmat.Name = "tmat";
            this.tmat.Size = new System.Drawing.Size(166, 20);
            this.tmat.TabIndex = 9;
            this.tmat.Text = "000-000-XX";
            // 
            // tci
            // 
            this.tci.Location = new System.Drawing.Point(119, 321);
            this.tci.Name = "tci";
            this.tci.Size = new System.Drawing.Size(166, 20);
            this.tci.TabIndex = 10;
            this.tci.Text = "100-XXX";
            // 
            // tpar
            // 
            this.tpar.Location = new System.Drawing.Point(119, 355);
            this.tpar.Name = "tpar";
            this.tpar.Size = new System.Drawing.Size(166, 20);
            this.tpar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insertar Relaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 490);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tpar);
            this.Controls.Add(this.tci);
            this.Controls.Add(this.tmat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.brel);
            this.Controls.Add(this.grillarel);
            this.Controls.Add(this.bencar);
            this.Controls.Add(this.bninos);
            this.Controls.Add(this.grillagrandes);
            this.Controls.Add(this.grillaninos);
            this.Name = "Form5";
            this.Text = "Relaciones";
            ((System.ComponentModel.ISupportInitialize)(this.grillaninos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillagrandes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillarel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaninos;
        private System.Windows.Forms.DataGridView grillagrandes;
        private System.Windows.Forms.Button bninos;
        private System.Windows.Forms.Button bencar;
        private System.Windows.Forms.DataGridView grillarel;
        private System.Windows.Forms.Button brel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tmat;
        private System.Windows.Forms.TextBox tci;
        private System.Windows.Forms.TextBox tpar;
        private System.Windows.Forms.Button button1;
    }
}