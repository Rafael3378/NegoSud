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
    public partial class User_produit : UserControl
    {
        
            private static User_produit Userclient;

            public static User_produit Instance
            {
                get
                {
                    if (Userclient == null)
                    {
                        Userclient = new User_produit();
                    }
                    return Userclient;
                }
            }
            public User_produit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void User_produit_Load(object sender, EventArgs e)
        {

        }
    }
}
