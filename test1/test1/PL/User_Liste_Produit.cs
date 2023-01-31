using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1.PL
{
    
    public partial class User_Liste_Produit : UserControl
    {
        private static User_Liste_Produit Userclient;
        
        public static User_Liste_Produit Instance
        {
            get
            {
                if (Userclient == null)
                {
                    Userclient= new User_Liste_Produit();
                }
                return Userclient;
            }
        }
      

        public User_Liste_Produit()
        {
            InitializeComponent();
        }

        private void User_Liste_Produit_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "123456789";
            dataGridView1.Rows[0].Cells[1].Value = "Chateau d'Eck";
            dataGridView1.Rows[0].Cells[2].Value = "2018";
            dataGridView1.Rows[0].Cells[3].Value = "Rouge";
            dataGridView1.Rows[0].Cells[4].Value = "15,75€";
            dataGridView1.Rows[0].Cells[5].Value = "89,95€";
            dataGridView1.Rows[0].Cells[6].Value = "350";
            dataGridView1.Rows[0].Cells[7].Value = "100";
            dataGridView1.Rows[1].Cells[0].Value = "987456123";
            dataGridView1.Rows[1].Cells[1].Value = "Domaine Solitude";
            dataGridView1.Rows[1].Cells[2].Value = "2020";
            dataGridView1.Rows[1].Cells[3].Value = "Rouge";
            dataGridView1.Rows[1].Cells[4].Value = "16,00€";
            dataGridView1.Rows[1].Cells[5].Value = "90,00€";
            dataGridView1.Rows[1].Cells[6].Value = "289";
            dataGridView1.Rows[1].Cells[7].Value = "100";
            dataGridView1.Rows[2].Cells[0].Value = "123456789";
            dataGridView1.Rows[2].Cells[1].Value = "Chateau Brown";
            dataGridView1.Rows[2].Cells[2].Value = "2017";
            dataGridView1.Rows[2].Cells[3].Value = "Rouge";
            dataGridView1.Rows[2].Cells[4].Value = "18,65€";
            dataGridView1.Rows[2].Cells[5].Value = "120€";
            dataGridView1.Rows[2].Cells[6].Value = "898";
            dataGridView1.Rows[2].Cells[7].Value = "100";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Rechercher..")
            {
                textBox1.Text = "";
                
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Rechercher..";
                

            }
        }
    }
}
