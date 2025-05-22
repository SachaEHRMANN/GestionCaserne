namespace SAE_A21D21_pompiers1
{
    partial class Frm_Engin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCaserne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPremier = new System.Windows.Forms.Button();
            this.btnDerriere = new System.Windows.Forms.Button();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.btnDernier = new System.Windows.Forms.Button();
            this.userControl11 = new UC_EtatEngin.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboCaserne);
            this.panel1.Location = new System.Drawing.Point(228, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 117);
            this.panel1.TabIndex = 1;
            // 
            // cboCaserne
            // 
            this.cboCaserne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaserne.FormattingEnabled = true;
            this.cboCaserne.Location = new System.Drawing.Point(301, 54);
            this.cboCaserne.Name = "cboCaserne";
            this.cboCaserne.Size = new System.Drawing.Size(486, 24);
            this.cboCaserne.TabIndex = 0;
            this.cboCaserne.SelectedIndexChanged += new System.EventHandler(this.cboCaserne_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(0)))), ((int)(((byte)(4)))));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choix de la caserne";
            // 
            // btnPremier
            // 
            this.btnPremier.Location = new System.Drawing.Point(307, 668);
            this.btnPremier.Name = "btnPremier";
            this.btnPremier.Size = new System.Drawing.Size(89, 78);
            this.btnPremier.TabIndex = 3;
            this.btnPremier.Text = "button1";
            this.btnPremier.UseVisualStyleBackColor = true;
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);
            // 
            // btnDerriere
            // 
            this.btnDerriere.Location = new System.Drawing.Point(431, 668);
            this.btnDerriere.Name = "btnDerriere";
            this.btnDerriere.Size = new System.Drawing.Size(89, 78);
            this.btnDerriere.TabIndex = 4;
            this.btnDerriere.Text = "button2";
            this.btnDerriere.UseVisualStyleBackColor = true;
            this.btnDerriere.Click += new System.EventHandler(this.btnDerriere_Click);
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(634, 668);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(89, 78);
            this.btnSuivant.TabIndex = 5;
            this.btnSuivant.Text = "button3";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // btnDernier
            // 
            this.btnDernier.Location = new System.Drawing.Point(792, 668);
            this.btnDernier.Name = "btnDernier";
            this.btnDernier.Size = new System.Drawing.Size(89, 78);
            this.btnDernier.TabIndex = 6;
            this.btnDernier.Text = "button4";
            this.btnDernier.UseVisualStyleBackColor = true;
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);
            // 
            // userControl11
            // 
            this.userControl11.Ds = null;
            this.userControl11.Location = new System.Drawing.Point(228, 178);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(800, 450);
            this.userControl11.TabIndex = 2;
            // 
            // Frm_Engin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SAE_A21D21_pompiers1.Properties.Resources.Engins_SDIS04;
            this.ClientSize = new System.Drawing.Size(1521, 776);
            this.Controls.Add(this.btnDernier);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.btnDerriere);
            this.Controls.Add(this.btnPremier);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Engin";
            this.Text = "Frm_Engin";
            this.Load += new System.EventHandler(this.Frm_Engin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCaserne;
        private UC_EtatEngin.UserControl1 userControl11;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnDerriere;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
    }
}