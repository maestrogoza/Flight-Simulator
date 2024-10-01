using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private VuelosList listaVuelos = new VuelosList();
        private Sector sector = new Sector(null,0);
        private VuelosLib Vulos = new VuelosLib(null, null, 0, 0, 0, 0, 0, 0, 0);

        private List<PictureBox> aircraft;
        private List<PictureBox> airport;

        private string rutaSeleccionada;
        private bool simulacionRun = false;
        private Sector SectorActual { get; set; }
        int contador = 0;
        int vuelosensector = 0;

        public Form1()
        {
            InitializeComponent();
            this.aircraft = new List<PictureBox>();
            this.airport = new List<PictureBox>();
            CargarPantalla();
            Aeropuertos();
        }
        private void CargarPantalla()
        {
            MessageBox.Show("Pantalla completa para mejor experiencia", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (contador == 0)
            {
                button6.Enabled = false;
            }
            
            //sets de colores

            this.BackColor = Color.Black;
            this.panel1.BackColor = Color.White;

            this.label1.ForeColor = Color.White;
            this.label2.ForeColor = Color.White;
            this.label3.ForeColor = Color.White;
            this.label4.ForeColor = Color.White;
            this.label5.ForeColor = Color.White;
            this.label14.ForeColor = Color.White;
            this.labelTitulo.ForeColor = Color.White;

            //label airpot names
            this.label16.BackColor = Color.White;
            this.label16.BorderStyle = BorderStyle.FixedSingle;
            this.label16.ForeColor = Color.DarkOrange;


            this.groupBox1.BackColor = Color.DarkOrange;
            this.groupBox2.BackColor = Color.DarkOrange;

            this.label6.ForeColor = Color.DarkOrange;
            this.label7.ForeColor = Color.DarkOrange;
            this.label8.ForeColor = Color.DarkOrange;
            this.label11.ForeColor = Color.DarkOrange;
            this.label12.ForeColor = Color.DarkOrange;
            this.label13.ForeColor = Color.DarkOrange;  //vertical
            
        }

        private void Aeropuertos()  //inserta todos los aeorpuertos deseados añadidos en el fichero airports
        {
            int i = 0;
            try
            {
                StreamReader R = new StreamReader("airports.txt");

                string line = R.ReadLine();
                line = R.ReadLine();

                while (line != null)
                {
                    string[] coords = line.Split(' ');
                    airport.Add(new PictureBox());
                    airport[i].Size = new Size(8, 8);
                    airport[i].Tag = i;
                    airport[i].BackColor = Color.Transparent;
                    airport[i].MouseEnter += new EventHandler(this.airport_MouseEnter);
                    airport[i].MouseLeave += new EventHandler(this.airport_MouseLeave);
                    airport[i].Location = new Point(Convert.ToInt32(coords[0]) - 4, Convert.ToInt32(coords[1]) - 4);
                    airport[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    Bitmap PUNTO = new Bitmap(@"avion\Redpoint.png");
                    airport[i].Image = (Image)PUNTO;
                    panel1.Controls.Add(airport[i]);

                    i++;
                    line = R.ReadLine();
                    line = R.ReadLine();
                }
                R.Close();
            }
            catch (Exception ex)
            {
                // Si el método lanza una excepción, muestra un MessageBox al usuario informando del error.
                MessageBox.Show("Error al cargar los aeropuertos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void airport_MouseLeave(object sender, EventArgs e)     //si el cursor NO esta encima del picurebox airport
        {
            label16.Location = new Point(1000, 1000);   //location 1000,1000 para no ser visible (estético)
        }

        private void airport_MouseEnter(object sender, EventArgs e)     //si el cursor Si esta encima del picturebox airport
        {
            PictureBox p = (PictureBox)sender;
            int iden = (int)p.Tag;

            StreamReader R = new StreamReader("airports.txt");
            string line = R.ReadLine();

            int c = 0;

            //get airport en el fitxer
            while (c < iden)
            {
                line = R.ReadLine();
                line = R.ReadLine();
                c++;
            }

            label16.Location = p.Location;
            label16.Text = line;
        }

        private void botonCargar_Click(object sender, EventArgs e)  //boton para cargar los vuelos
        {
            int i = 0;
            try
            {
                int anchoPanel = panel1.Width;
                int altoPanel = panel1.Height;

                openFileDialog1.ShowDialog();
                rutaSeleccionada = openFileDialog1.FileName;
                string[] nombrefichero = rutaSeleccionada.Split('\\');  //control para abrir solo vuelos
                string[] fichero = nombrefichero[nombrefichero.Length - 1].Split('.');
                if (fichero[1] == "v")
                {
                    string res = listaVuelos.Cargar(rutaSeleccionada);

                    panel1.Visible = true;
                    while (i < listaVuelos.GetNumVuelos())
                    {
                        VuelosLib vuelo = listaVuelos.GetVuelo(i);
                        int x = Convert.ToInt32(vuelo.GetOrigenX());
                        int y = Convert.ToInt32(vuelo.GetOrigenY());
                        if ((x >= 0 && x < anchoPanel + 20) && (y >= 0 && y < altoPanel + 20))  //detecta si esta dentro del panel1
                        {
                            PictureBox avion = new PictureBox();
                            avion.ClientSize = new Size(20, 20);
                            avion.Tag = i;
                            avion.BackColor = Color.Transparent;
                            avion.Click += new EventHandler(this.aircraft_Click);
                            avion.Location = new Point(x - avion.Width/2, y - avion.Width/2);
                            avion.SizeMode = PictureBoxSizeMode.StretchImage;
                            vuelo.SetDireccion(Direccion(vuelo));
                            Bitmap image = new Bitmap(@"avion\avion_" + vuelo.GetDireccion() + "_n.png");
                            avion.Image = (Image)image;
                            panel1.Controls.Add(avion);
                            aircraft.Add(avion);
                            i++;
                        }
                        else
                        {
                            MessageBox.Show("Uno o más aviones se encuentran fuera del espacio aéreo.", "Error");
                            res = "Error de posicionamiento de los aviones.\nVerifique el fichero de lista de vuelos.";
                            panel1.Controls.Clear();
                            break;
                        }
                    }
                    panel1.Refresh();
                    panel1.Invalidate();
                }
                else
                    MessageBox.Show("Error al cargar el fichero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Reset();
            }
            catch (Exception ex)
            {
                // Si el método "Cargar" lanza una excepción, muestra un MessageBox al usuario informando del error.
                MessageBox.Show("Error al cargar los vuelos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string Direccion(VuelosLib vuelo)    //determina la direccion del avion en el plano
        {
            if (vuelo.GetDestinoX() > vuelo.GetOrigenX())
            {
                if (vuelo.GetDestinoY() > vuelo.GetOrigenY()) return "se";
                else if (vuelo.GetDestinoY() < vuelo.GetOrigenY()) return "ne";
                else return "e";
            }
            else if (vuelo.GetDestinoX() < vuelo.GetOrigenX())
            {
                if (vuelo.GetDestinoY() > vuelo.GetOrigenY()) return "so";
                else if (vuelo.GetDestinoY() < vuelo.GetOrigenY()) return "no";
                else return "o";
            }
            else
            {
                if (vuelo.GetDestinoY() > vuelo.GetOrigenY()) return "s";
                else return "n";
            }
        }
        private void aircraft_Click(object sender, EventArgs e) //abre el form2 con la info del vuelo
        {
            PictureBox p = (PictureBox)sender;
            int i = (int)p.Tag;
            VuelosLib vuelo = listaVuelos.GetVuelo(i);
            string mvuelo = vuelo.Mostrar();
            Form2 f2 = new Form2();
            f2.Show();
            f2.mostrarvuelo(mvuelo);
        }
        private void botonSalir_Click(object sender, EventArgs e)   //boton CERRAR
        {
            this.Close();
        }
        private void botonguardarlista_Click(object sender, EventArgs e)    //boton guardar lista vuelos
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaSeleccionada = saveFileDialog1.FileName;

                int res = listaVuelos.Guardar(rutaSeleccionada);

                if (res != -1)
                {
                    MessageBox.Show("Guardado correctamente!");
                }
                else MessageBox.Show("Error al guardar el fichero");
            }
        }
        bool sectorcargado = false;
        bool clearPanel1 = false;
        private void botoncargarsector_Click(object sender, EventArgs e)    //boton cargar sector
        {
            openFileDialog1.ShowDialog();
            rutaSeleccionada = openFileDialog1.FileName;
            string[] nombrefichero = rutaSeleccionada.Split('\\');  //control para abrir solo sectores
            string[] fichero = nombrefichero[nombrefichero.Length - 1].Split('.');

            if (fichero[1] == "s")
            {
                try
                {
                    if (sectorcargado)   //resetea el panel1
                    {
                        this.sector.ClearList();
                    }
                    // Llama al método "Cargar" del objeto Sector y proporciona la ruta del archivo como argumento.
                    sector.Cargar(rutaSeleccionada);
                    sectorcargado = true;
                    panel1.Invalidate();
                    MessageBox.Show("Sector cargado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id_sec.Text = this.sector.GetIdentificador();   //escribe en el label id_sec el identificador del sector
                    capacity_sec.Text = Convert.ToString(this.sector.GetCapacidad());   //escribe en el label capacity_sec la capacidad del sector
                }

                catch (Exception ex)
                {
                    // Si el método "Cargar" lanza una excepción, muestra un MessageBox al usuario informando del error.
                    MessageBox.Show("Error al cargar el sector: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Error al cargar el fichero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int numpuntos = sector.GetNumPuntos();      //recull el numero de punts
            int i = 0;
            int j = 0;
            Punto[] COORDENADAS = sector.GetPuntos();     //recull les coordenades de tots els punts del sector
            
            if (sectorcargado)
            {
                if (vuelosensector > sector.GetCapacidad())  //ocupación mayor al 100%
                {
                    j = 0; i = 0;
                    System.Drawing.Graphics graphics = e.Graphics;
                    //Colour to draw the rectangle
                    Pen myPen = new Pen(Color.Red);
                    // Points that define the rectangle
                    Point[] polygonPoints = new Point[numpuntos];

                    while (j < numpuntos)   //asocia cada punt del poligon amb els del vector
                    {
                        polygonPoints[j] = new Point(COORDENADAS[i].getX(), COORDENADAS[i].getY());
                        i++;
                        j++;
                    }
                    //Draw the rectangle
                    graphics.DrawPolygon(myPen, polygonPoints);
                    myPen.Dispose();
                }
                if (vuelosensector == sector.GetCapacidad())  //ocupación al 100%
                {
                    j = 0; i = 0;
                    System.Drawing.Graphics graphics = e.Graphics;
                    //Colour to draw the rectangle
                    Pen myPen = new Pen(Color.Orange);
                    // Points that define the rectangle
                    Point[] polygonPoints = new Point[numpuntos];
                    while (j < numpuntos)   //asocia cada punt del poligon amb els del vector
                    {
                        polygonPoints[j] = new Point(COORDENADAS[i].getX(), COORDENADAS[i].getY());
                        i++;
                        j++;
                    }
                    //Draw the rectangle
                    graphics.DrawPolygon(myPen, polygonPoints);
                    myPen.Dispose();
                }
                if ((50 > sector.PorcentajeVuelos(vuelosensector)) && (vuelosensector > 0))   //ocupación entre 50% i 0%
                {
                    j = 0; i = 0;
                    System.Drawing.Graphics graphics = e.Graphics;
                    //Colour to draw the rectangle
                    Pen myPen = new Pen(Color.Yellow);
                    // Points that define the rectangle
                    Point[] polygonPoints = new Point[numpuntos];
                    while (j < numpuntos)   //asocia cada punt del poligon amb els del vector
                    {
                        polygonPoints[j] = new Point(COORDENADAS[i].getX(), COORDENADAS[i].getY());
                        i++;
                        j++;
                    }
                    //Draw the rectangle
                    graphics.DrawPolygon(myPen, polygonPoints);
                    myPen.Dispose();
                }
                if ((vuelosensector == 0))  //ocupación al 0%
                {
                    j = 0; i = 0;
                    System.Drawing.Graphics graphics = e.Graphics;
                    //Colour to draw the rectangle
                    Pen myPen = new Pen(Color.Green);
                    // Points that define the rectangle
                    Point[] polygonPoints = new Point[numpuntos];
                    while (j < numpuntos)   //asocia cada punt del poligon amb els del vector
                    {
                        polygonPoints[j] = new Point(COORDENADAS[i].getX(), COORDENADAS[i].getY());
                        i++;
                        j++;
                    }
                    //Draw the rectangle
                    graphics.DrawPolygon(myPen, polygonPoints);
                    myPen.Dispose();
                }
                VuelosLib vuelo;

                for (i = 0; i < listaVuelos.GetNumVuelos(); i++)
                {
                    vuelo = listaVuelos.GetVuelo(i);
                    System.Drawing.Graphics graphics = e.Graphics;

                    if (vuelo.GetVolando()) //cuando vuelan
                    {
                        Pen myPen = new Pen(Color.DarkOrange);
                        graphics.DrawLine(myPen, Convert.ToSingle(vuelo.GetOrigenX() + 4), Convert.ToSingle(vuelo.GetOrigenY() + 4), Convert.ToSingle(vuelo.GetPosicionX() + 10), Convert.ToSingle(vuelo.GetPosicionY() + 10));
                        myPen.Dispose();
                    }
                    //else   //cuando no vuelan
                    //{
                    //    Pen myPen = new Pen(Color.DarkOrange);
                    //    graphics.DrawLine(myPen, Convert.ToSingle(vuelo.GetOrigenX() + 4), Convert.ToSingle(vuelo.GetOrigenY() + 4), Convert.ToSingle(vuelo.GetDestinoX() + 4), Convert.ToSingle(vuelo.GetDestinoY() + 4));
                    //    myPen.Dispose();
                    //}
                }                
            }
        }

        int vuelosenAeropuerto = 0;
        public int VuelosSector()   //detecta en numero de vuelos dentro del sector
        {
            if (listaVuelos.GetNVolando(listaVuelos) > 0)
            {
                Punto[] COORDENADAS = sector.GetPuntos();     //recull les coordenades de tots els punts del sector
                List<VuelosLib> IDenSector = new List<VuelosLib>();
                bool encontrado = false;
                int cont = 0;
                int i = 0;
                double cap = Convert.ToDouble(this.sector.GetCapacidad());
                vuelosenAeropuerto = 0;
                while (i < listaVuelos.GetNumVuelos())
                {
                    VuelosLib vuelo = listaVuelos.GetVuelo(i);
                    encontrado = sector.polyCheck(new Punto(Convert.ToInt32(vuelo.GetPosicionX()), Convert.ToInt32(vuelo.GetPosicionY())), COORDENADAS);

                    if (encontrado == true)
                    {
                        cont++;
                        IDenSector.Add(vuelo);  //guarda els vuelos que estan dins el sector en la LIST
                    }
                    if (vuelo.GetVolando() == false)    //mira si els vuelos estan volant o a l'aeroport
                    {
                        vuelosenAeropuerto++;
                    }
                    i++;
                }
                string Txt = Convert.ToString((Convert.ToDouble(cont) / cap) * 100.0) + "%";    //en double para que no retorne 0 (en truncar)
                ocup_sec.Text = Txt;    //escriu el percentatge d'ocupació en el sector
                vuelos_sec.ResetText();
                i = 0;
                vuelosensector -= vuelosenAeropuerto;
                while (i < IDenSector.Count())    //escriu els ID dels vuelos en el sector dins el label vuelos_sec
                {
                    vuelos_sec.Text += IDenSector[i].GetIdentificador() + " ";
                    i++;
                }
                if (cont == 0)
                {
                    vuelos_sec.Text = null;
                }
                return cont;
            }
            else
            {
                vuelos_sec.Text = null;
                ocup_sec.Text = "0%";
                return 0;
            }
        }
        int k = 0;
        int retardo = 0;
        string iden = null;
        private void ciclo_Tick(object sender, EventArgs e)     //TICK del timer CICLO
        {
            Bitmap image = new Bitmap(@"avion\Greenpoint.png");
            VuelosLib vuelo;
            int ultimoAvion;
            int i,j;
            if (contador < Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox1.Text))
            {
                if (listaVuelos.GetNVolando(listaVuelos) > 0)
                {
                    for (i = 0; i < listaVuelos.GetNumVuelos(); i++)
                    {
                        vuelo = listaVuelos.GetVuelo(i);
                        int colisionado = ComprobarColisiones(vuelo, i);

                        if (colisionado > 0)    //comprueba si ha colisionado algun avion
                        {
                            vuelo.SetEstrellado(true);
                            vuelo.SetVolando(false);
                            vuelo.SetVisible(false);
                            vuelo.SetPosicionX(1000);
                            vuelo.SetPosicionY(1000);
                            VuelosLib vuelo2Accidente = listaVuelos.GetVuelo(colisionado);
                            vuelo2Accidente.SetEstrellado(true);
                            vuelo2Accidente.SetVolando(false);
                            vuelo2Accidente.SetVisible(false);
                            this.aircraft[colisionado].Location = new Point(1000, 1000);
                            vuelo2Accidente.SetPosicionX(1000);
                            vuelo2Accidente.SetPosicionY(1000);
                            panel1.Refresh();
                            ciclo.Stop();
                            MessageBox.Show("El avión " + vuelo.GetIdentificador() + " ha colisionado con el avión " + vuelo2Accidente.GetIdentificador());
                            ciclo.Start();
                        }
                        vuelo.HaLlegado(); //Comprobar si ha llegado al destino
                        if (vuelo.GetVolando() && vuelo.GetVisible()) //Si no ha llegado
                        {
                            vuelo.Avanzar(Convert.ToInt32(textBox1.Text));
                            this.aircraft[i].Location = new Point(Convert.ToInt32(vuelo.GetPosicionX()), Convert.ToInt32(vuelo.GetPosicionY()));
                            panel1.Invalidate();
                        }
                        else if (!vuelo.GetVolando() && vuelo.GetVisible()) //Si acaba de llegar
                        {
                            
                            for (j = 0; j < airport.Count; j++)     //dibuja el boton verde al llegar un avion
                            {
                                if (vuelo.GetDestinoX() == airport[j].Location.X && vuelo.GetDestinoY() == airport[j].Location.Y)
                                {
                                    airport[j].Image = image;
                                    panel1.Controls.Add(airport[j]);
                                    panel1.Invalidate();
                                }
                            }
                            vuelo.SetVolando(false);
                            vuelo.SetVisible(false);
                            this.aircraft[i].Location = new Point(1000,1000);
                            vuelo.SetPosicionX(1000);
                            vuelo.SetPosicionY(1000);
                            panel1.Refresh();
                            
                            ciclo.Stop();
                            MessageBox.Show("El avión " + vuelo.GetIdentificador() + " acaba de llegar a su destino");
                            ciclo.Start();
                        }
                        if (listaVuelos.GetNVolando(listaVuelos) == 0)  //si hay algun avion volando o no
                        {
                            for (int k = 0; k < listaVuelos.GetNumVuelos(); k++)
                            {
                                if (listaVuelos.GetVuelo(k).GetVolando())
                                {
                                    ultimoAvion = k+1;
                                    airport[ultimoAvion].Image = image;
                                    panel1.Controls.Add(airport[ultimoAvion]);
                                    panel1.Invalidate();
                                    break;
                                }
                            }
                            MessageBox.Show("Ningún avión volando.", "Información");
                            break;
                        }
                        vuelosensector = VuelosSector();
                    }
                    contador++;
                }
            }
            else
            {
                ciclo.Stop();
                MessageBox.Show("Simulación finalizada!", "Información del vuelo");
                button6.Enabled = false;
            }
            vuelosensector = VuelosSector();
            i = 0;
            if (listaVuelos.GetNVolando(listaVuelos) == 0)
            {
                while (i < listaVuelos.GetNumVuelos())
                {
                    vuelo = listaVuelos.GetVuelo(i);
                    for (j = 0; j < airport.Count; j++) //dibuja el boton verde al llegar el ULTIMO avion
                    {
                        if ((vuelo.GetDestinoX() == airport[j].Location.X) && (vuelo.GetPosicionY() == 1000) && (vuelo.GetEstrellado() == false))
                        {
                            airport[j].Image = image;
                            panel1.Controls.Add(airport[j]);
                            panel1.Invalidate();
                        }
                    }
                    i++;
                }
            }

            panel1.Invalidate();
        }

        private void botonplanos_Click(object sender, EventArgs e)  //abre el form3 con la lista de vuelos
        {
            try
            {
                int i = 0;
                int j = 0;
                Form3 f3 = new Form3();
                f3.Show();
                f3.GetNum(Convert.ToInt32(listaVuelos.GetNumVuelos()));
                while (i <= listaVuelos.GetNumVuelos()- 1)
                {
                    VuelosLib vuelo = listaVuelos.GetVuelo(i);
                    string res = Convert.ToString(vuelo.GetIdentificador());
                    string comp = Convert.ToString(vuelo.GetCompania());
                    int or_x = Convert.ToInt32(vuelo.GetOrigenX());
                    int or_y = Convert.ToInt32(vuelo.GetOrigenY());
                    int De_x = Convert.ToInt32(vuelo.GetDestinoX());
                    int De_y = Convert.ToInt32(vuelo.GetDestinoY());
                    int vel = Convert.ToInt32(vuelo.GetVelocidad());
                    int Px = Convert.ToInt32(vuelo.GetPosicionX());
                    int Py = Convert.ToInt32(vuelo.GetPosicionY());
                    f3.PonerId(j, res);
                    f3.PonerComp(j, comp);
                    f3.PonerOr_x(j, or_x);
                    f3.PonerOr_y(j, or_y);
                    f3.PonerDes_y(j, De_y);
                    f3.PonerDes_x(j, De_x);
                    f3.PonerVel(j, vel);
                    f3.PonerPx(j, Px);
                    f3.PonerPy(j, Py);
                    i++;
                    j++;
                }
            }
            catch (Exception)
            {
                // Si el método lanza una excepción, muestra un MessageBox al usuario informando del error.
                MessageBox.Show("Error al mostrar los vuelos: no se han cargado vuelos al simulador." , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)  //boton avanzar
        {
            if (ciclotiempo.Text!="")
            {
                try
                {
                    double ciclo = Convert.ToInt32(ciclotiempo.Text);
                    if (ciclo > 0)
                    {
                        for (int i = 0; i < listaVuelos.GetNumVuelos(); i++)
                        {
                            VuelosLib vuelo = listaVuelos.GetVuelo(i);
                            int colisionado = ComprobarColisiones(vuelo, i);
                            VuelosLib avionColisionado = listaVuelos.GetVuelo(colisionado);


                            if (colisionado > 0)    //comprueba si ha colisionado algun avion
                            {
                                MessageBox.Show("El avión " + vuelo.GetIdentificador() + " ha colisionado con el avión " + avionColisionado.GetIdentificador());
                            }
                            vuelo.HaLlegado(); //Comprobar si ha llegado al destino
                            if (vuelo.GetVolando()) //Si no ha llegado
                            {
                                vuelo.Avanzar(Convert.ToInt32(ciclotiempo.Text));
                                this.aircraft[i].Location = new Point(Convert.ToInt32(vuelo.GetPosicionX()), Convert.ToInt32(vuelo.GetPosicionY()));
                                panel1.Invalidate();
                            }
                            else if (!vuelo.GetVolando() && vuelo.GetVisible()) //Si acaba de llegar
                            {
                                MessageBox.Show("El avión " + vuelo.GetIdentificador() + " acaba de llegar a su destino");
                                vuelo.SetVolando(false);
                                vuelo.SetVisible(false);
                                this.aircraft[i].Location = new Point(1000, 1000);
                                vuelo.SetPosicionX(1000);
                                vuelo.SetPosicionY(1000);
                                panel1.Refresh();
                            }
                            vuelosensector = VuelosSector();
                        }
                        if (listaVuelos.GetNVolando(listaVuelos) == 0) MessageBox.Show("Ningún avión volando.","Información");
                    }
                    else MessageBox.Show("El \"Tiempo\" introducido debe ser mayor que cero.", "Error");
                }
                catch (Exception)
                {
                    MessageBox.Show("Formato de \"Tiempo\" no valido.\nIntroduzca un valor númerico entero del orden de los minutos.", "Error");
                }
            }
            else MessageBox.Show("Introduzca un valor de \"Tiempo de ciclo\" válido.", "Error");
        }
        public int ComprobarColisiones(VuelosLib vuelo1, int i) //funcion que comprueba si hay colisión entre aviones
        {
            if (vuelo1.GetVisible())
            {
                for (int j = 0; j < listaVuelos.GetNumVuelos(); j++)
                {
                    if (j == i) continue;
                    VuelosLib vuelo2 = listaVuelos.GetVuelo(j);
                    if (!vuelo2.GetVisible()) continue;
                    double x1, x2, y1, y2;
                    x1 = vuelo1.GetPosicionX();
                    y1 = vuelo1.GetPosicionY();
                    x2 = vuelo2.GetPosicionX();
                    y2 = vuelo2.GetPosicionY();
                    if (Math.Abs(x1 - x2) <= 10 && Math.Abs(y1 - y2) <= 10)
                    {
                        vuelo1.SetVisible(false);
                        vuelo1.SetVolando(false);
                        vuelo2.SetVisible(false);
                        vuelo2.SetVolando(false);
                        Bitmap image = new Bitmap(@"avion\skull.png");
                        aircraft[i].Image = (Image)image;
                        aircraft[j].Image = (Image)image;
                        aircraft[i].BackColor = Color.Transparent;
                        aircraft[j].BackColor = Color.Transparent;
                        return j;
                    }
                }
            }
            return -1;
        }

        private void button5_Click(object sender, EventArgs e)  //boton reset de la simulación ciclo a ciclo
        {
            /*
            this.Vulos.Reset(listaVuelos);
            int i = 0;
            contador = 0;
            while (i < listaVuelos.GetNumVuelos())
            {
                VuelosLib vuelo = listaVuelos.GetVuelo(i);
                this.aircraft[i].Location = new Point(Convert.ToInt32(vuelo.GetPosicionX()), Convert.ToInt32(vuelo.GetPosicionY()));
                vuelo.SetDireccion(Direccion(vuelo));
                Bitmap image = new Bitmap(@"avion\avion_" + vuelo.GetDireccion() + "_n.png");
                aircraft[i].Image = (Image)image;
                i++;
            }
            panel1.Invalidate();
            button6.Enabled = false;
            ciclotiempo.Text = "";
            */
            Reset();
        }

        private void button2_Click(object sender, EventArgs e)  //boton start sim automatica
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    if (contador <= 0)
                    {
                        //ciclo.Interval = Convert.ToInt32(textBox1.Text);
                        int tciclo = Convert.ToInt32(textBox1.Text);
                        int total = Convert.ToInt32(textBox2.Text);

                        if(tciclo>0 && total > 0)
                        {
                            ciclo.Interval = 1000;
                            ciclo.Start();
                            this.simulacionRun = true;
                            button6.Enabled = true;
                        }
                        else MessageBox.Show("El \"Tiempo\" introducido debe ser mayor que cero.", "Error");
                    }
                    else MessageBox.Show("Ya hay una simulación en curso.\nResetee la simulación actual para iniciar una nueva.", "Error");
                }
                catch (Exception)
                {
                    MessageBox.Show("Formato de \"Tiempo\" no valido.\nIntroduzca un valor númerico entero del orden de los minutos.", "Error");
                }
            }
            else MessageBox.Show("Introduzca valores de \"Tiempo\" válidos.", "Error");
        }

        private void button3_Click(object sender, EventArgs e)  //boton stop
        {
            if (contador == 0)
            {
                MessageBox.Show("La simulación no está en curso.\nPulse \"START\" para iniciarla.","Error");
            }
            ciclo.Stop();
            button6.Enabled = true;
            this.simulacionRun = false;
        }

        

        private void button6_Click(object sender, EventArgs e)  //boton reanudar
        {
            ciclo.Start();
            button6.Enabled = false;
            this.simulacionRun = true;
        }

        private void button7_Click(object sender, EventArgs e)  //boton reset
        {
            Reset();
        }

        public void Reset()     //funcion que resetea el timer
        {
            Bitmap punto = new Bitmap(@"avion\Redpoint.png");   //dibuja los aerpuertos en rojo al resetear
            for (int j = 0; j < airport.Count; j++)
            {
                airport[j].Image = punto;
                panel1.Controls.Add(airport[j]);
                panel1.Invalidate();
            }

            if (this.simulacionRun)
            {
                MessageBox.Show("Detén la simulación con el botón \"STOP\"para poder resetear con el botón \"RESET\".");
            }
            else    //devuelve los aviones a la posicion inicial (origen)
            {
                this.simulacionRun = false;
                this.Vulos.Reset(listaVuelos);
                contador = 0;
                int i = 0;
                while (i < listaVuelos.GetNumVuelos())
                {
                    VuelosLib vuelo = listaVuelos.GetVuelo(i);
                    this.aircraft[i].Location = new Point(Convert.ToInt32(vuelo.GetPosicionX()), Convert.ToInt32(vuelo.GetPosicionY()));
                    vuelo.SetDireccion(Direccion(vuelo));
                    Bitmap image = new Bitmap(@"avion\avion_" + vuelo.GetDireccion() + "_n.png");
                    aircraft[i].Image = (Image)image;
                    i++;
                }
                panel1.Invalidate();
                button6.Enabled = false;
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
        public void GetRetardo(double retard,string id)
        {
            retardo = Convert.ToInt32(retard);

            int i = 0;
            while (i < this.listaVuelos.GetNumVuelos())
            {
                VuelosLib vuelo = listaVuelos.GetVuelo(i);
                if (id == vuelo.GetIdentificador())
                {
                    vuelo.SetRetardo(retard);
                }
                i++;
            }
        }

        //private void panel1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    MessageBox.Show(e.X + " , " + e.Y);
        //}
    }
}

