namespace ProyectoFinal
{
    partial class Form6
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
            this.grillacom = new System.Windows.Forms.DataGridView();
            this.bcom = new System.Windows.Forms.Button();
            this.grillaalergia = new System.Windows.Forms.DataGridView();
            this.baler = new System.Windows.Forms.Button();
            this.bregaler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ttaler = new System.Windows.Forms.TextBox();
            this.tmat = new System.Windows.Forms.TextBox();
            this.tidin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillacom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaalergia)).BeginInit();
            this.SuspendLayout();
            // 
            // grillacom
            // 
            this.grillacom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillacom.Location = new System.Drawing.Point(12, 21);
            this.grillacom.Name = "grillacom";
            this.grillacom.Size = new System.Drawing.Size(295, 194);
            this.grillacom.TabIndex = 0;
            // 
            // bcom
            // 
            this.bcom.Location = new System.Drawing.Point(12, 221);
            this.bcom.Name = "bcom";
            this.bcom.Size = new System.Drawing.Size(125, 39);
            this.bcom.TabIndex = 1;
            this.bcom.Text = "Mostrar ingredientes que producen alergias";
            this.bcom.UseVisualStyleBackColor = true;
            this.bcom.Click += new System.EventHandler(this.bcom_Click);
            // 
            // grillaalergia
            // 
            this.grillaalergia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaalergia.Location = new System.Drawing.Point(400, 21);
            this.grillaalergia.Name = "grillaalergia";
            this.grillaalergia.Size = new System.Drawing.Size(295, 194);
            this.grillaalergia.TabIndex = 2;
            // 
            // baler
            // 
            this.baler.Location = new System.Drawing.Point(489, 221);
            this.baler.Name = "baler";
            this.baler.Size = new System.Drawing.Size(125, 39);
            this.baler.TabIndex = 3;
            this.baler.Text = "Mostrar Alergias de cada niño";
            this.baler.UseVisualStyleBackColor = true;
            this.baler.Click += new System.EventHandler(this.baler_Click);
            // 
            // bregaler
            // 
            this.bregaler.Location = new System.Drawing.Point(12, 397);
            this.bregaler.Name = "bregaler";
            this.bregaler.Size = new System.Drawing.Size(125, 23);
            this.bregaler.TabIndex = 4;
            this.bregaler.Text = "Registrar nueva alergia";
            this.bregaler.UseVisualStyleBackColor = true;
            this.bregaler.Click += new System.EventHandler(this.bregaler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tipo de Alergia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Niño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Ingrediente:";
            // 
            // ttaler
            // 
            this.ttaler.Location = new System.Drawing.Point(99, 282);
            this.ttaler.Name = "ttaler";
            this.ttaler.Size = new System.Drawing.Size(153, 20);
            this.ttaler.TabIndex = 8;
            // 
            // tmat
            // 
            this.tmat.Location = new System.Drawing.Point(99, 318);
            this.tmat.Name = "tmat";
            this.tmat.Size = new System.Drawing.Size(153, 20);
            this.tmat.TabIndex = 9;
            this.tmat.Text = "000-000-XX";
            // 
            // tidin
            // 
            this.tidin.Location = new System.Drawing.Point(99, 358);
            this.tidin.Name = "tidin";
            this.tidin.Size = new System.Drawing.Size(153, 20);
            this.tidin.TabIndex = 10;
            this.tidin.Text = "000XX";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tidin);
            this.Controls.Add(this.tmat);
            this.Controls.Add(this.ttaler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bregaler);
            this.Controls.Add(this.baler);
            this.Controls.Add(this.grillaalergia);
            this.Controls.Add(this.bcom);
            this.Controls.Add(this.grillacom);
            this.Name = "Form6";
            this.Text = "Alergias";
            ((System.ComponentModel.ISupportInitialize)(this.grillacom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaalergia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillacom;
        private System.Windows.Forms.Button bcom;
        private System.Windows.Forms.DataGridView grillaalergia;
        private System.Windows.Forms.Button baler;
        private System.Windows.Forms.Button bregaler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ttaler;
        private System.Windows.Forms.TextBox tmat;
        private System.Windows.Forms.TextBox tidin;
    }
}