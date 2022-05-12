namespace JAdijasok
{
    partial class FrmUj
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
            this.gbUjSzemely = new System.Windows.Forms.GroupBox();
            this.btnUjSzemely = new System.Windows.Forms.Button();
            this.tbFoglalkozas = new System.Windows.Forms.TextBox();
            this.tbSzemelyNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUjDij = new System.Windows.Forms.GroupBox();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.btnUjDij = new System.Windows.Forms.Button();
            this.tbSzemelyNev2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbUjSzemely.SuspendLayout();
            this.gbUjDij.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUjSzemely
            // 
            this.gbUjSzemely.BackColor = System.Drawing.Color.IndianRed;
            this.gbUjSzemely.Controls.Add(this.btnUjSzemely);
            this.gbUjSzemely.Controls.Add(this.tbFoglalkozas);
            this.gbUjSzemely.Controls.Add(this.tbSzemelyNev);
            this.gbUjSzemely.Controls.Add(this.label2);
            this.gbUjSzemely.Controls.Add(this.label1);
            this.gbUjSzemely.Location = new System.Drawing.Point(12, 12);
            this.gbUjSzemely.Name = "gbUjSzemely";
            this.gbUjSzemely.Size = new System.Drawing.Size(560, 246);
            this.gbUjSzemely.TabIndex = 0;
            this.gbUjSzemely.TabStop = false;
            this.gbUjSzemely.Text = "Új személy felvétele";
            // 
            // btnUjSzemely
            // 
            this.btnUjSzemely.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUjSzemely.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjSzemely.Location = new System.Drawing.Point(120, 177);
            this.btnUjSzemely.Name = "btnUjSzemely";
            this.btnUjSzemely.Size = new System.Drawing.Size(312, 52);
            this.btnUjSzemely.TabIndex = 4;
            this.btnUjSzemely.Text = "Új személy";
            this.btnUjSzemely.UseVisualStyleBackColor = true;
            this.btnUjSzemely.Click += new System.EventHandler(this.BtnUjSzemely_Click);
            // 
            // tbFoglalkozas
            // 
            this.tbFoglalkozas.Location = new System.Drawing.Point(166, 130);
            this.tbFoglalkozas.Name = "tbFoglalkozas";
            this.tbFoglalkozas.Size = new System.Drawing.Size(307, 26);
            this.tbFoglalkozas.TabIndex = 3;
            // 
            // tbSzemelyNev
            // 
            this.tbSzemelyNev.Location = new System.Drawing.Point(166, 73);
            this.tbSzemelyNev.Name = "tbSzemelyNev";
            this.tbSzemelyNev.Size = new System.Drawing.Size(307, 26);
            this.tbSzemelyNev.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Foglalkozások:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // gbUjDij
            // 
            this.gbUjDij.BackColor = System.Drawing.Color.IndianRed;
            this.gbUjDij.Controls.Add(this.nud);
            this.gbUjDij.Controls.Add(this.btnUjDij);
            this.gbUjDij.Controls.Add(this.tbSzemelyNev2);
            this.gbUjDij.Controls.Add(this.label3);
            this.gbUjDij.Controls.Add(this.label4);
            this.gbUjDij.Location = new System.Drawing.Point(12, 277);
            this.gbUjDij.Name = "gbUjDij";
            this.gbUjDij.Size = new System.Drawing.Size(560, 172);
            this.gbUjDij.TabIndex = 1;
            this.gbUjDij.TabStop = false;
            this.gbUjDij.Text = "Új díj kiosztálsa";
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(408, 54);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(87, 26);
            this.nud.TabIndex = 5;
            // 
            // btnUjDij
            // 
            this.btnUjDij.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUjDij.ForeColor = System.Drawing.Color.Firebrick;
            this.btnUjDij.Location = new System.Drawing.Point(120, 99);
            this.btnUjDij.Name = "btnUjDij";
            this.btnUjDij.Size = new System.Drawing.Size(312, 52);
            this.btnUjDij.TabIndex = 4;
            this.btnUjDij.Text = "Új József Attila Díj";
            this.btnUjDij.UseVisualStyleBackColor = true;
            this.btnUjDij.Click += new System.EventHandler(this.BtnUjDij_Click);
            // 
            // tbSzemelyNev2
            // 
            this.tbSzemelyNev2.Location = new System.Drawing.Point(69, 53);
            this.tbSzemelyNev2.Name = "tbSzemelyNev2";
            this.tbSzemelyNev2.Size = new System.Drawing.Size(277, 26);
            this.tbSzemelyNev2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(368, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Év:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Név:";
            // 
            // FrmUj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.gbUjDij);
            this.Controls.Add(this.gbUjSzemely);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUj";
            this.Text = "Új adatok felvétele";
            this.gbUjSzemely.ResumeLayout(false);
            this.gbUjSzemely.PerformLayout();
            this.gbUjDij.ResumeLayout(false);
            this.gbUjDij.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUjSzemely;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUjSzemely;
        private System.Windows.Forms.TextBox tbFoglalkozas;
        private System.Windows.Forms.TextBox tbSzemelyNev;
        private System.Windows.Forms.GroupBox gbUjDij;
        private System.Windows.Forms.Button btnUjDij;
        private System.Windows.Forms.TextBox tbSzemelyNev2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud;
    }
}