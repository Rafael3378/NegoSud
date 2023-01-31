using test1.PL;

namespace test1
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(200, 608);                        //Ouverture de l'appli avec le menu burger ouvert//
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 200)
            {
                panel1.Size = new Size(60, 608);                    //Ouverture et fermeture du menu burger
            }
            else
            { panel1.Size = new Size(200, 608); }
        }

        private void ButtnInventaire_Click(object sender, EventArgs e)
        {
            if (!PnlProduit.Controls.Contains(User_Liste_Produit.Instance))
            {
                PnlProduit.Controls.Add(User_Liste_Produit.Instance);           //Onglet Liste produit
                User_Liste_Produit.Instance.Dock= DockStyle.Fill;
                User_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                User_Liste_Produit.Instance.BringToFront();
            }
        }

        private void PnlProduit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtnEmploye_Click(object sender, EventArgs e)
        {
            connexion frmC = new connexion();
            frmC.ShowDialog();
        }

        private void ButtnCommande_Click(object sender, EventArgs e)
        {

        }

        private void ButtnAccueil_Click(object sender, EventArgs e)
        {
            if (!PnlProduit.Controls.Contains(User_produit.Instance))
            {
                PnlProduit.Controls.Add(User_produit.Instance);           //Onglet Liste produit
                User_produit.Instance.Dock = DockStyle.Fill;
                User_produit.Instance.BringToFront();
            }
            else
            {
                User_produit.Instance.BringToFront();
            }
        }
    }
    }