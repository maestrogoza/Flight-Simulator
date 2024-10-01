using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.dataGridView1.BackgroundColor = Color.White;
            this.label1.ForeColor = Color.DarkOrange;
            this.label2.ForeColor = Color.DarkOrange;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        public int GetNum(int i)
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.RowCount = i;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            return i;
        }
        public string PonerId(int i, string id)
        {
            dataGridView1.Rows[i].Cells[0].Value = "Identificador: " + id;
            return id;
        }
        public string PonerComp(int i, string comp)
        {
            dataGridView1.Rows[i].Cells[1].Value = "Compañía: " + comp;
            return comp;
        }
        public int PonerOr_x(int i, int or_x)
        {
            dataGridView1.Rows[i].Cells[2].Value = "Origen en x: " + or_x;
            return or_x;
        }
        public int PonerOr_y(int i, int or_y)
        {
            dataGridView1.Rows[i].Cells[3].Value = "Origen en y: " + or_y;
            return or_y;
        }
        public int PonerDes_x(int i, int De_x)
        {
            dataGridView1.Rows[i].Cells[4].Value = "Destino en x: " + De_x;
            return De_x;
        }
        public int PonerDes_y(int i, int De_y)
        {
            dataGridView1.Rows[i].Cells[5].Value = "Destino en y: " + De_y;
            return De_y;
        }
        public int PonerVel(int i, int vel)
        {
            dataGridView1.Rows[i].Cells[6].Value = "Velocidad : " + vel + " nudos";
            return vel;
        }
        public int PonerPx(int i, int Px)
        {
            dataGridView1.Rows[i].Cells[7].Value = "posición en x: " + Px;
            return Px;
        }
        public int PonerPy(int i, int Py)
        {
            dataGridView1.Rows[i].Cells[8].Value = "Posicion en y: " + Py;
            return Py;
        }
    }
}
