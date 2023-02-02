namespace test1
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuBurger = new System.Windows.Forms.Button();
            this.ButtnAccueil = new System.Windows.Forms.Button();
            this.ButtnInventaire = new System.Windows.Forms.Button();
            this.ButtnRepertoire = new System.Windows.Forms.Button();
            this.ButtnCommande = new System.Windows.Forms.Button();
            this.ButtnEmploye = new System.Windows.Forms.Button();
            this.PnlProduit = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.MenuBurger);
            this.panel1.Controls.Add(this.ButtnAccueil);
            this.panel1.Controls.Add(this.ButtnInventaire);
            this.panel1.Controls.Add(this.ButtnRepertoire);
            this.panel1.Controls.Add(this.ButtnCommande);
            this.panel1.Controls.Add(this.ButtnEmploye);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 811);
            this.panel1.TabIndex = 0;
            // 
            // MenuBurger
            // 
            this.MenuBurger.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.MenuBurger.FlatAppearance.BorderSize = 0;
            this.MenuBurger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBurger.Image = global::test1.Properties.Resources.burger;
            this.MenuBurger.Location = new System.Drawing.Point(3, 0);
            this.MenuBurger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuBurger.Name = "MenuBurger";
            this.MenuBurger.Size = new System.Drawing.Size(58, 69);
            this.MenuBurger.TabIndex = 6;
            this.MenuBurger.UseVisualStyleBackColor = true;
            this.MenuBurger.Click += new System.EventHandler(this.button7_Click);
            // 
            // ButtnAccueil
            // 
            this.ButtnAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnAccueil.FlatAppearance.BorderSize = 0;
            this.ButtnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtnAccueil.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtnAccueil.Image = global::test1.Properties.Resources.home1;
            this.ButtnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnAccueil.Location = new System.Drawing.Point(3, 112);
            this.ButtnAccueil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtnAccueil.Name = "ButtnAccueil";
            this.ButtnAccueil.Size = new System.Drawing.Size(202, 107);
            this.ButtnAccueil.TabIndex = 10;
            this.ButtnAccueil.Text = "         Accueil";
            this.ButtnAccueil.UseVisualStyleBackColor = true;
            this.ButtnAccueil.Click += new System.EventHandler(this.ButtnAccueil_Click);
            // 
            // ButtnInventaire
            // 
            this.ButtnInventaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnInventaire.FlatAppearance.BorderSize = 0;
            this.ButtnInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtnInventaire.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtnInventaire.Image = global::test1.Properties.Resources.stock;
            this.ButtnInventaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnInventaire.Location = new System.Drawing.Point(3, 209);
            this.ButtnInventaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtnInventaire.Name = "ButtnInventaire";
            this.ButtnInventaire.Size = new System.Drawing.Size(202, 107);
            this.ButtnInventaire.TabIndex = 8;
            this.ButtnInventaire.Text = "         Inventaire";
            this.ButtnInventaire.UseVisualStyleBackColor = true;
            this.ButtnInventaire.Click += new System.EventHandler(this.ButtnInventaire_Click);
            // 
            // ButtnRepertoire
            // 
            this.ButtnRepertoire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnRepertoire.FlatAppearance.BorderSize = 0;
            this.ButtnRepertoire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtnRepertoire.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtnRepertoire.Image = global::test1.Properties.Resources.repertoire;
            this.ButtnRepertoire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnRepertoire.Location = new System.Drawing.Point(3, 425);
            this.ButtnRepertoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtnRepertoire.Name = "ButtnRepertoire";
            this.ButtnRepertoire.Size = new System.Drawing.Size(202, 107);
            this.ButtnRepertoire.TabIndex = 6;
            this.ButtnRepertoire.Text = "       Répertoire";
            this.ButtnRepertoire.UseVisualStyleBackColor = true;
            // 
            // ButtnCommande
            // 
            this.ButtnCommande.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnCommande.FlatAppearance.BorderSize = 0;
            this.ButtnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtnCommande.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtnCommande.Image = global::test1.Properties.Resources.commande;
            this.ButtnCommande.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnCommande.Location = new System.Drawing.Point(3, 311);
            this.ButtnCommande.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtnCommande.Name = "ButtnCommande";
            this.ButtnCommande.Size = new System.Drawing.Size(202, 107);
            this.ButtnCommande.TabIndex = 9;
            this.ButtnCommande.Text = "          Commande";
            this.ButtnCommande.UseVisualStyleBackColor = true;
            this.ButtnCommande.Click += new System.EventHandler(this.ButtnCommande_Click);
            // 
            // ButtnEmploye
            // 
            this.ButtnEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtnEmploye.FlatAppearance.BorderSize = 0;
            this.ButtnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtnEmploye.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtnEmploye.Image = global::test1.Properties.Resources.user;
            this.ButtnEmploye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtnEmploye.Location = new System.Drawing.Point(3, 704);
            this.ButtnEmploye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtnEmploye.Name = "ButtnEmploye";
            this.ButtnEmploye.Size = new System.Drawing.Size(202, 107);
            this.ButtnEmploye.TabIndex = 1;
            this.ButtnEmploye.Text = "        Connexion";
            this.ButtnEmploye.UseVisualStyleBackColor = true;
            this.ButtnEmploye.Click += new System.EventHandler(this.ButtnEmploye_Click);
            // 
            // PnlProduit
            // 
            this.PnlProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlProduit.BackColor = System.Drawing.SystemColors.Control;
            this.PnlProduit.Location = new System.Drawing.Point(69, 0);
            this.PnlProduit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PnlProduit.Name = "PnlProduit";
            this.PnlProduit.Size = new System.Drawing.Size(1374, 811);
            this.PnlProduit.TabIndex = 7;
            this.PnlProduit.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlProduit_Paint);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 811);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlProduit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button ButtnInventaire;
        private Button ButtnRepertoire;
        private Button ButtnCommande;
        private Button ButtnEmploye;
        private Button ButtnAccueil;
        private Button MenuBurger;
        private Panel PnlProduit;
    }
}