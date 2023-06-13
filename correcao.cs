using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaPoo
{
    public partial class correcao : Form
    {
        public correcao()
        {
            InitializeComponent();
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
           correcao correcao = new correcao();

                string[] gaba = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };

                for (int i = 0; i < gaba.Length; i++)
                {
                 
                        gaba[i] = "A";
                    
                }

                label3.Text = gaba[0];
        }

       
    }
}
