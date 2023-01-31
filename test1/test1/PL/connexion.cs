using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test1.BL;

namespace test1
{
    public partial class connexion : Form
    {
        public connexion()
        {
            InitializeComponent();
           
        }

        //Vérification des champs//

        string testobligatoire()
        {
            if (textBox1.Text == "Admin" || textBox1.Text == "Nom d'utilisateur") //Si le texte est vide ou inccorect//
            {
                return "Veuillez entrer le nom d'utilisateur";
            }
            if (textBox2.Text == "Admin" || textBox2.Text == "Mot de passe")
            {
                return "Veuillez entrer le mot de passe";
            }
            //Si l'utilisateur à entré son nom et son mot de passe//
            return null;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                MessageBox.Show("Connexion réussi");
            }
            else
            {
                MessageBox.Show(testobligatoire(), "Tous les champs sont obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fermeture de la fenêtre//
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nom d'utilisateur")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mot de passe")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';    
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Nom d'utilisateur";
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "Mot de passe";
                    textBox2.UseSystemPasswordChar = true;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
