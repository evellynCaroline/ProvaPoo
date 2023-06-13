using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

            for (int i = 0; i == gaba.Length; i++)
            {
                if (txt_questao1.Text == "A")
                {
                    lb_totalR.Text = gaba[i];
                } 
                else if (txt_questao2.Text == "B")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao3.Text == "D")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao4.Text == "E")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao5.Text == "C")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao6.Text == "A")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao7.Text == "A")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao8.Text == "D")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao9.Text == "E")
                {
                    lb_totalR.Text = gaba[i];

                }
                else if (txt_questao10.Text == "B")
                {
                    lb_totalR.Text = gaba[i];


                }

            }

                lb_totalR.Text = gaba[];

                
        }

       
    }
}
