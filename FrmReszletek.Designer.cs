namespace JAdijasok
{
    partial class FrmReszletek
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
            this.tbNev = new System.Windows.Forms.TextBox();
            this.lbFoglalkozas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDatumok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fő foglalkozásai:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbNev
            // 
            this.tbNev.BackColor = System.Drawing.Color.IndianRed;
            this.tbNev.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tbNev.Location = new System.Drawing.Point(16, 64);
            this.tbNev.Name = "tbNev";
            this.tbNev.ReadOnly = true;
            this.tbNev.Size = new System.Drawing.Size(456, 19);
            this.tbNev.TabIndex = 2;
            this.tbNev.Text = "##NEV##";
            this.tbNev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbFoglalkozas
            // 
            this.lbFoglalkozas.BackColor = System.Drawing.Color.Firebrick;
            this.lbFoglalkozas.FormattingEnabled = true;
            this.lbFoglalkozas.ItemHeight = 20;
            this.lbFoglalkozas.Location = new System.Drawing.Point(12, 162);
            this.lbFoglalkozas.Name = "lbFoglalkozas";
            this.lbFoglalkozas.Size = new System.Drawing.Size(460, 124);
            this.lbFoglalkozas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "A díjat elnyerte:";
            // 
            // tbDatumok
            // 
            this.tbDatumok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDatumok.BackColor = System.Drawing.Color.IndianRed;
            this.tbDatumok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDatumok.Location = new System.Drawing.Point(161, 313);
            this.tbDatumok.Name = "tbDatumok";
            this.tbDatumok.Size = new System.Drawing.Size(311, 19);
            this.tbDatumok.TabIndex = 7;
            this.tbDatumok.Text = "##DATUMOK##";
            // 
            // FrmReszletek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tbDatumok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFoglalkozas);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReszletek";
            this.Text = "FrmReszletek";
            this.Load += new System.EventHandler(this.FrmReszletek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.ListBox lbFoglalkozas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDatumok;
    }
}