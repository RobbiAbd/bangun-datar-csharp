namespace BangunDatar.Views
{
    partial class CircleForm
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
            this.btnHitung = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textJariJari = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHitung
            // 
            this.btnHitung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnHitung.FlatAppearance.BorderSize = 0;
            this.btnHitung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHitung.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHitung.ForeColor = System.Drawing.Color.White;
            this.btnHitung.Location = new System.Drawing.Point(100, 127);
            this.btnHitung.Margin = new System.Windows.Forms.Padding(4);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(117, 32);
            this.btnHitung.TabIndex = 27;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = false;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(183, 79);
            this.labelHasil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(14, 16);
            this.labelHasil.TabIndex = 26;
            this.labelHasil.Text = "?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Luas:";
            // 
            // textJariJari
            // 
            this.textJariJari.Location = new System.Drawing.Point(101, 13);
            this.textJariJari.Margin = new System.Windows.Forms.Padding(4);
            this.textJariJari.Name = "textJariJari";
            this.textJariJari.Size = new System.Drawing.Size(116, 20);
            this.textJariJari.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Jari-Jari";
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textJariJari);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CircleForm";
            this.Text = "SquareForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textJariJari;
        private System.Windows.Forms.Label label1;
    }
}