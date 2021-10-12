using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActaConstitutiva
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        protected List<Control> textboxes = new List<Control>();
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            textboxes.Add(textBox9);
            textboxes.Add(textBox10);
            textboxes.Add(textBox11);
            textboxes.Add(textBox12);
            textboxes.Add(textBox13);
            textboxes.Add(textBox14);
            textboxes.Add(textBox15);
            textboxes.Add(textBox16);
            textboxes.Add(textBox17);
            textboxes.Add(textBox18);
            textboxes.Add(textBox19);
            textboxes.Add(textBox20);

            foreach (Control c in textboxes)
            {

                if (c.Text == "")
                {
                    c.Text = "0";
                }
            }

            frm3.label3.Text = textBox1.Text;
            frm3.label5.Text = Cantidad.Text;
            frm3.label13.Text = textBox3.Text;
            frm3.label14.Text = textBox4.Text;
            frm3.label15.Text = textBox5.Text;
            frm3.label16.Text = textBox6.Text;
            frm3.label17.Text = textBox7.Text;
            frm3.label18.Text = textBox8.Text;
            //val Capital Suscrito
            frm3.label19.Text = textBox9.Text;
            frm3.label21.Text = textBox10.Text;
            frm3.label23.Text = textBox11.Text;
            frm3.label24.Text = textBox12.Text;
            frm3.label25.Text = textBox13.Text;
            frm3.label26.Text = textBox14.Text;
            //capital exhibido
            frm3.label31.Text = textBox15.Text;
            frm3.label32.Text = textBox16.Text;
            frm3.label33.Text = textBox17.Text;
            frm3.label34.Text = textBox18.Text;
            frm3.label35.Text = textBox19.Text;
            frm3.label36.Text = textBox20.Text;
            //importe capital suscrito
            double porcentajea = (Convert.ToDouble(textBox9.Text) / (double) 100);
            frm3.label20.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajea)).ToString();
            double porcentajeb = (Convert.ToDouble(textBox10.Text) / (double)100);
            frm3.label22.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajeb)).ToString();
            double porcentajec = (Convert.ToDouble(textBox11.Text) / (double)100);
            frm3.label27.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajec)).ToString();
            double porcentajed = (Convert.ToDouble(textBox12.Text) / (double)100);
            frm3.label28.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajed)).ToString();
            double porcentajee = (Convert.ToDouble(textBox13.Text) / (double)100);
            frm3.label29.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajee)).ToString();
            double porcentajef = (Convert.ToDouble(textBox14.Text) / (double)100);
            frm3.label30.Text = (Convert.ToDouble(Cantidad.Text) * Convert.ToDouble(porcentajef)).ToString();
            //suma totales
            frm3.label49.Text = (Convert.ToDouble(frm3.label20.Text) + Convert.ToDouble(frm3.label22.Text) + Convert.ToDouble(frm3.label27.Text) + Convert.ToDouble(frm3.label28.Text) + Convert.ToDouble(frm3.label29.Text) + Convert.ToDouble(frm3.label30.Text)).ToString();

            //importe cap exhibido
            double pea = (Convert.ToDouble(textBox15.Text) / (double)100);
            frm3.label37.Text = (Convert.ToDouble(frm3.label20.Text) * Convert.ToDouble(pea)).ToString();
            double peb = (Convert.ToDouble(textBox16.Text) / (double)100);
            frm3.label38.Text = (Convert.ToDouble(frm3.label22.Text) * Convert.ToDouble(peb)).ToString();
            double pec = (Convert.ToDouble(textBox17.Text) / (double)100);
            frm3.label39.Text = (Convert.ToDouble(frm3.label27.Text) * Convert.ToDouble(pec)).ToString();
            double ped = (Convert.ToDouble(textBox18.Text) / (double)100);
            frm3.label40.Text = (Convert.ToDouble(frm3.label28.Text) * Convert.ToDouble(ped)).ToString();
            double pee = (Convert.ToDouble(textBox19.Text) / (double)100);
            frm3.label41.Text = (Convert.ToDouble(frm3.label29.Text) * Convert.ToDouble(pee)).ToString();
            double pef = (Convert.ToDouble(textBox20.Text) / (double)100);
            frm3.label42.Text = (Convert.ToDouble(frm3.label30.Text) * Convert.ToDouble(pef)).ToString();
            //suma totales
            frm3.label50.Text = (Convert.ToDouble(frm3.label37.Text) + Convert.ToDouble(frm3.label38.Text) + Convert.ToDouble(frm3.label39.Text) + Convert.ToDouble(frm3.label40.Text) + Convert.ToDouble(frm3.label41.Text) + Convert.ToDouble(frm3.label42.Text)).ToString();

            //importe cap. pendiente x exhibido
            frm3.label43.Text = (Convert.ToDouble(frm3.label20.Text) - Convert.ToDouble(frm3.label37.Text)).ToString();
            frm3.label44.Text = (Convert.ToDouble(frm3.label22.Text) - Convert.ToDouble(frm3.label38.Text)).ToString();
            frm3.label45.Text = (Convert.ToDouble(frm3.label27.Text) - Convert.ToDouble(frm3.label39.Text)).ToString();
            frm3.label46.Text = (Convert.ToDouble(frm3.label28.Text) - Convert.ToDouble(frm3.label40.Text)).ToString();
            frm3.label47.Text = (Convert.ToDouble(frm3.label29.Text) - Convert.ToDouble(frm3.label41.Text)).ToString();
            frm3.label48.Text = (Convert.ToDouble(frm3.label30.Text) - Convert.ToDouble(frm3.label42.Text)).ToString();
            //suma totales
            frm3.label51.Text = (Convert.ToDouble(frm3.label43.Text) + Convert.ToDouble(frm3.label44.Text) + Convert.ToDouble(frm3.label45.Text) + Convert.ToDouble(frm3.label46.Text) + Convert.ToDouble(frm3.label47.Text) + Convert.ToDouble(frm3.label48.Text)).ToString();
            //TOTAL
            frm3.label53.Text = (Convert.ToDouble(frm3.label50.Text) + Convert.ToDouble(frm3.label51.Text)).ToString();
            frm3.Show();
        }
    }
}
