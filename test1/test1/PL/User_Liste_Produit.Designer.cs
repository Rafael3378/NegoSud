namespace test1.PL
{
    partial class User_Liste_Produit
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millésime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Famille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_unitaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_carton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seuil_alerte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 20);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(670, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 49);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Rechercher..";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.panel3.Location = new System.Drawing.Point(0, 421);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1381, 20);
            this.panel3.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Réference",
            "Produit",
            "Millésime",
            "Famille",
            "Prix (U)",
            "Prix (C)"});
            this.comboBox1.Location = new System.Drawing.Point(361, 25);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 44);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reference,
            this.produit,
            this.millésime,
            this.Famille,
            this.prix_unitaire,
            this.prix_carton,
            this.quantite,
            this.seuil_alerte,
            this.selection});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1381, 286);
            this.dataGridView1.TabIndex = 4;
            // 
            // reference
            // 
            this.reference.HeaderText = "Référence";
            this.reference.MinimumWidth = 6;
            this.reference.Name = "reference";
            this.reference.ReadOnly = true;
            // 
            // produit
            // 
            this.produit.HeaderText = "Produit";
            this.produit.MinimumWidth = 6;
            this.produit.Name = "produit";
            this.produit.ReadOnly = true;
            // 
            // millésime
            // 
            this.millésime.HeaderText = "Millésime";
            this.millésime.MinimumWidth = 6;
            this.millésime.Name = "millésime";
            this.millésime.ReadOnly = true;
            // 
            // Famille
            // 
            this.Famille.HeaderText = "Famille";
            this.Famille.MinimumWidth = 6;
            this.Famille.Name = "Famille";
            this.Famille.ReadOnly = true;
            // 
            // prix_unitaire
            // 
            this.prix_unitaire.HeaderText = "Prix (U)";
            this.prix_unitaire.MinimumWidth = 6;
            this.prix_unitaire.Name = "prix_unitaire";
            this.prix_unitaire.ReadOnly = true;
            // 
            // prix_carton
            // 
            this.prix_carton.HeaderText = "Prix (C)";
            this.prix_carton.MinimumWidth = 6;
            this.prix_carton.Name = "prix_carton";
            this.prix_carton.ReadOnly = true;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantité";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            // 
            // seuil_alerte
            // 
            this.seuil_alerte.HeaderText = "Alerte";
            this.seuil_alerte.MinimumWidth = 6;
            this.seuil_alerte.Name = "seuil_alerte";
            // 
            // selection
            // 
            this.selection.HeaderText = "Sélectionner";
            this.selection.MinimumWidth = 6;
            this.selection.Name = "selection";
            // 
            // User_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "User_Liste_Produit";
            this.Size = new System.Drawing.Size(1382, 844);
            this.Load += new System.EventHandler(this.User_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel2;
        private TextBox textBox1;
        private Panel panel3;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn reference;
        private DataGridViewTextBoxColumn produit;
        private DataGridViewTextBoxColumn millésime;
        private DataGridViewTextBoxColumn Famille;
        private DataGridViewTextBoxColumn prix_unitaire;
        private DataGridViewTextBoxColumn prix_carton;
        private DataGridViewTextBoxColumn quantite;
        private DataGridViewTextBoxColumn seuil_alerte;
        private DataGridViewCheckBoxColumn selection;
    }
}
