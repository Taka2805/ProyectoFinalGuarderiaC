namespace ProyectoFinal
{
    partial class Pagos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tidesp = new System.Windows.Forms.TextBox();
            this.tmes = new System.Windows.Forms.TextBox();
            this.taño = new System.Windows.Forms.TextBox();
            this.grillaSueldo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revisar Pagos al Especialista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Especialista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes (En números):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año:";
            // 
            // tidesp
            // 
            this.tidesp.Location = new System.Drawing.Point(104, 50);
            this.tidesp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tidesp.Name = "tidesp";
            this.tidesp.Size = new System.Drawing.Size(188, 20);
            this.tidesp.TabIndex = 4;
            this.tidesp.Text = "500-000-XX";
            this.tidesp.TextChanged += new System.EventHandler(this.tidesp_TextChanged);
            // 
            // tmes
            // 
            this.tmes.Location = new System.Drawing.Point(104, 86);
            this.tmes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tmes.Name = "tmes";
            this.tmes.Size = new System.Drawing.Size(188, 20);
            this.tmes.TabIndex = 5;
            // 
            // taño
            // 
            this.taño.Location = new System.Drawing.Point(104, 124);
            this.taño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.taño.Name = "taño";
            this.taño.Size = new System.Drawing.Size(188, 20);
            this.taño.TabIndex = 6;
            // 
            // grillaSueldo
            // 
            this.grillaSueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSueldo.Location = new System.Drawing.Point(312, 50);
            this.grillaSueldo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaSueldo.Name = "grillaSueldo";
            this.grillaSueldo.RowHeadersWidth = 51;
            this.grillaSueldo.RowTemplate.Height = 24;
            this.grillaSueldo.Size = new System.Drawing.Size(440, 297);
            this.grillaSueldo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 162);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 19);
            this.button1.TabIndex = 8;
            this.button1.Text = "Revisar Sueldo Especialista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 194);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 19);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reporte de Sueldo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grillaSueldo);
            this.Controls.Add(this.taño);
            this.Controls.Add(this.tmes);
            this.Controls.Add(this.tidesp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Pagos";
            this.Text = "Pagos";
            ((System.ComponentModel.ISupportInitialize)(this.grillaSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tidesp;
        private System.Windows.Forms.TextBox tmes;
        private System.Windows.Forms.TextBox taño;
        private System.Windows.Forms.DataGridView grillaSueldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}