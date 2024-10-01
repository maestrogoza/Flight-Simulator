using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.label1.ForeColor = Color.DarkOrange;
            this.label2.ForeColor = Color.DarkOrange;
            this.label3.ForeColor = Color.DarkOrange;
            this.label4.ForeColor = Color.DarkOrange;
            this.label5.ForeColor = Color.DarkOrange;
            this.label6.ForeColor = Color.DarkOrange;

            this.id.ForeColor = Color.White;
            this.comp.ForeColor = Color.White;
            this.vel.ForeColor = Color.White;
            this.origen.ForeColor = Color.White;
            this.destino.ForeColor = Color.White;
            this.posicion.ForeColor = Color.White;
        }
        string[] parametros;
        public void mostrarvuelo(string vuelo)
        {
            parametros = vuelo.Split(' ');
            
            label1.Text = parametros[0];
            iden = parametros[0];
            label2.Text = parametros[1];
            label3.Text = parametros[6];
            label4.Text = ("(" + parametros[2] + ";" + parametros[3] + " )");
            label5.Text = ("(" + parametros[4] + ";" + parametros[5] + " )");
            label6.Text = ("(" + parametros[7] + ";" + parametros[8] + " )");
        }
        string iden;
        public void SetRetardo()
        {

        }

        private void SetRetardo(object sender, EventArgs e)
        {
            double retardo = Convert.ToDouble(textbox1.Text);

            
        }
    }
}
