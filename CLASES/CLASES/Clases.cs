using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{

    public class Punto
    {
        int x;
        int y;

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int getX() 
        { 
            return x; 
        }
        public int getY() 
        { 
            return y; 
        }
    }
    public class Sector
    {
        /*Els vertex dels sectors s'associen començant pel que es situa el més a dalt possible (i secundariamenta el més a l'esquerra 
        possible) i el segueixen la resta en sentit horari*/

        private string identificador; //Código que identifica un sector
        private int capacidad; //La capacidad de cada sector
        List<int> coords;

        public Sector(string identificador, int capacidad)
        {
            this.identificador = identificador;
            this.capacidad = capacidad;
            this.coords = new List<int>();
        }
        public int GetNumPuntos()   //retorna el num de punts que te el sector (poligonal)
        {
            int i = 0;
            int contador = 0;
            while (i < coords.Count)
            {
                contador++;
                i= i + 2;    //suma 2 (2 coordenades per punt)
            }
            return contador;
        }
        public void ClearList()
        {
            this.coords.Clear();
        }
        public string GetIdentificador()
        {
            return this.identificador;
        }
        public void SetIdentificador(string identificador)
        {
            this.identificador = identificador;
        }
        public int GetCapacidad()
        {
            return this.capacidad;
        }
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }

        public Punto[] GetPuntos()    //guarda las coordenadas almacenadas en la LIST coords en un vector de puntos
        {
            Punto[] pnt = new Punto[GetNumPuntos()];   //vector amb totes les coordenades del sector
            int i = 0;
            int j = 0;
            while (j < GetNumPuntos())    // j < num puntos
            {
                pnt[j] = new Punto(coords[i], coords[i + 1]);
                i = i + 2;
                j++;
            }

            return pnt;
        }

        //funció extreta de https://codereview.stackexchange.com/questions/108857/point-inside-polygon-check
        public bool polyCheck(Punto v, Punto[] p)
        {
            int j = p.Length - 1;
            bool c = false;
            for (int i = 0; i < p.Length; j = i++) 
                c ^= p[i].getY() > v.getY() ^ p[j].getY() > v.getY() && v.getX() < (p[j].getX() - p[i].getX()) * (v.getY() - p[i].getY()) / (p[j].getY() - p[i].getY()) + p[i].getX();
            return c;
        }

        public void Mostrar()
        {
            Console.WriteLine("Sector con identificador {0}", this.identificador);
            Console.WriteLine("Sector con capacidad de {0}", this.capacidad);
        }
        public void Cargar(string rutaSeleccionada)
        {
            StreamReader file;
            string line;

            int i;
            try
            {
                file = new StreamReader(rutaSeleccionada);  //llegar al sector seleccionado   
                line = file.ReadLine();

                string[] datos = line.Split(' ');
                         
                this.identificador = datos[0];
                this.capacidad = Convert.ToInt32(datos[1]);

                i = 2;
                while (i < datos.Length)
                {
                    this.coords.Add(Convert.ToInt32(datos[i]));
                    i++;
                }

                file.Close();
            }
            catch (FileNotFoundException)
            {

            }
        }

        public int PorcentajeVuelos(int vuelosdentro)
        {
            int porcentaje;

            porcentaje = (vuelosdentro / this.GetCapacidad()) * 100;

            return porcentaje;
        }
    }

    

    public class VuelosLib
    {
        // Atributos clase Vuelo
        private string identificador;
        private string compania;
        private double origen_x;    // en mn (millas náuticas)
        private double origen_y;    // en mn (millas náuticas)
        private double destino_x;   // en mn (millas náuticas)
        private double destino_y;   // en mn (millas náuticas)
        private double velocidad;   // en nudos
        private double posicion_x;  // en mn (millas náuticas)
        private double posicion_y;  // en mn (millas náuticas)
        private string direccion;
        private double retardo;
        private int tag;
        private bool estrellado;
        private bool volando;
        private bool visible;

        // Constructor con parámetros de la clase Vuelo
        public VuelosLib(string identificador, string compania, double origen_x, double origen_y, double destino_x, double destino_y, double velocidad, double posicion_x, double posicion_y)
        {
            this.identificador = identificador;
            this.compania = compania;
            this.origen_x = origen_x;
            this.origen_y = origen_y;
            this.destino_x = destino_x;
            this.destino_y = destino_y;
            this.velocidad = velocidad;
            this.posicion_x = posicion_x;
            this.posicion_y = posicion_y;
            this.retardo = 0;
            this.estrellado = false;
            this.volando = true;
            this.visible = true;
        }
        // Métodos Getters y Setters de los atributos de la clase Vuelo
        public string GetIdentificador()
        {
            return this.identificador;
        }
        public void SetIdentificador(string identificador)
        {
            this.identificador = identificador;
        }
        public string GetCompania()
        {
            return this.compania;
        }
        public void SetCompania(string compania)
        {
            this.compania = compania;
        }
        public double GetOrigenX()
        {
            return this.origen_x;
        }
        public void SetOrigenX(double origen_x)
        {
            this.origen_x = origen_x;
        }
        public double GetOrigenY()
        {
            return this.origen_y;
        }
        public void SetOrigenY(double origen_y)
        {
            this.origen_y = origen_y;
        }
        public double GetDestinoX()
        {
            return this.destino_x;
        }
        public void SetDestinoX(double destino_x)
        {
            this.destino_x = destino_x;
        }
        public double GetDestinoY()
        {
            return this.destino_y;
        }
        public void SetDestinoY(double destino_y)
        {
            this.destino_y = destino_y;
        }
        public double GetVelocidad()
        {
            return this.velocidad;
        }
        public void SetVelocidad(double velocidad)
        {
            this.velocidad = velocidad;
        }
        public double GetPosicionX()
        {
            return this.posicion_x;
        }
        public void SetPosicionX(double posicion_x)
        {
            this.posicion_x = posicion_x;
        }
        public double GetPosicionY()
        {
            return this.posicion_y;
        }
        public void SetPosicionY(double posicion_y)
        {
            this.posicion_y = posicion_y;
        }
        public bool GetVolando()
        {
            return this.volando;
        }
        public void SetVolando(bool volando)
        {
            this.volando = volando;
        }
        public double GetRetardo()
        {
            return this.retardo;
        }
        public void SetRetardo(double retardo)
        {
            this.retardo = retardo;
        }
        public double GetTag()
        {
            return this.tag;
        }
        public void SetTag(int tag)
        {
            this.tag = tag;
        }
        public string GetDireccion()
        {
            return this.direccion;
        }
        public void SetDireccion(string direccion)
        {
             this.direccion=direccion;
        }
        public void SetVisible(bool visible)
        {
            this.visible = visible;
        }
        public bool GetVisible()
        {
            return this.visible;
        }
        public void SetEstrellado(bool estrellado)
        {
            this.estrellado = estrellado;
        }
        public bool GetEstrellado()
        {
            return this.estrellado;
        }


        // Métodos propios de la clase Vuelo
        public void Avanzar(double tc) // lo queremos en minutos
        {
            double tiempo = tc / 60;
            double L = Math.Sqrt(Math.Pow(this.destino_x - this.posicion_x, 2) + Math.Pow(this.destino_y - this.posicion_y, 2));

            this.posicion_x += Convert.ToInt32((this.velocidad * 1.852 * tiempo * (this.destino_x - this.posicion_x )) / L);
            this.posicion_y += Convert.ToInt32((this.velocidad * 1.852 * tiempo * (this.destino_y - this.posicion_y )) / L);

        }
        public string Mostrar()
        {
            string res = (this.identificador + " " + this.compania + " "+ this.origen_x + " " + this.origen_y + " " + this.destino_x + " " + this.destino_y + " " + this.velocidad + " " + this.posicion_x + " " + this.posicion_y);
            return res;
        }
        public void HaLlegado()
        {
            if ((this.GetDireccion()=="e" || this.GetDireccion() == "ne" || this.GetDireccion() == "se") && this.GetPosicionX()>=this.GetDestinoX()) this.SetVolando(false);
            else if ((this.GetDireccion() == "o" || this.GetDireccion() == "no" || this.GetDireccion() == "so")&& this.GetPosicionX()<=this.GetDestinoX()) this.SetVolando(false);
            else if (this.GetDireccion() == "n" && this.GetPosicionY()<=this.GetDestinoY()) this.SetVolando(false);
            else if (this.GetDireccion() == "s" && this.GetPosicionY() >= this.GetDestinoY()) this.SetVolando(false);
        }

        public void Reset(VuelosList vuelos)
        {            
            for (int i = 0; i < vuelos.GetNumVuelos(); i++)
            {
                VuelosLib vuelo = vuelos.GetVuelo(i);
                vuelo.SetPosicionX(vuelo.GetOrigenX());
                vuelo.SetPosicionY(vuelo.GetOrigenY());
                vuelo.SetVisible(true);
                vuelo.SetVolando(true);
                vuelo.HaLlegado();
            }
        }
    }
    public class VuelosList
    {
        private const int MAX_VUELOS = 200;
        private VuelosLib[] vuelos;
        private int numVuelos;
        private string texto;

        public VuelosList() //constructor per defecte
        {
            this.vuelos = new VuelosLib[MAX_VUELOS];
            int i = 0;
            while (i < MAX_VUELOS)
            {
                this.vuelos[i] = new VuelosLib(null, null, 0, 0, 0, 0, 0, 0, 0);
                i++;
            }
        }
        public int GetNumVuelos()
        {
            return this.numVuelos;
        }
        public void SetNumVuelos(int numvuelos)
        {
            this.numVuelos = numvuelos;
        }
        public int GetNVolando(VuelosList lista)
        {
            int cont = 0;
            for (int i = 0; i < lista.GetNumVuelos(); i++)
            {
                VuelosLib vuelo = lista.GetVuelo(i);
                if (vuelo.GetVolando()) cont++;
            }
            return cont;
        }
        public VuelosLib GetVuelo(int k)
        {
            if ((k < 0) || (k > this.numVuelos))
                return null;
            else
                return this.vuelos[k];
        }
        public void Modificar(int This, int For)
        {
            this.vuelos[This] = this.vuelos[For];
            this.vuelos[For] = null;
        }
        public void Swap(int This, int For)
        {
            VuelosLib[] local = new VuelosLib[1];

            local[0] = this.vuelos[This];

            this.vuelos[This] = this.vuelos[For];
            this.vuelos[For] = local[0];
        }
        public void Mostrar()
        {
            int i = 0;
            for (i = 0; i < this.numVuelos; i++)
            {
                Console.WriteLine(this.vuelos[i]);
            }
        }        
        public string Cargar(string rutaSeleccionada)
        {
            string text="";
            string line;
            int i = 0;
            try
            {
                StreamReader file = new StreamReader(rutaSeleccionada);
                line = file.ReadLine();

                string [] datos;

                while (line != null && line != "")
                {
                    datos = line.Split(' ');
                    this.vuelos[i].SetIdentificador(datos[0]);
                    this.vuelos[i].SetCompania(datos[1]);
                    this.vuelos[i].SetOrigenX(Convert.ToDouble(datos[2]));
                    this.vuelos[i].SetOrigenY(Convert.ToDouble(datos[3]));
                    this.vuelos[i].SetDestinoX(Convert.ToDouble(datos[4]));
                    this.vuelos[i].SetDestinoY(Convert.ToDouble(datos[5]));
                    this.vuelos[i].SetVelocidad(Convert.ToDouble(datos[6]));
                    this.vuelos[i].SetPosicionX(Convert.ToDouble(datos[7]));
                    this.vuelos[i].SetPosicionY(Convert.ToDouble(datos[8]));
                    this.vuelos[i].SetTag(i);

                    i++;

                    text+= line + "\n";
                    line = file.ReadLine();
                }

                this.texto = text;
                this.numVuelos = i;
                file.Close();

                return texto;
            }
            catch (FileNotFoundException)
            {
                return null;
            }
        }
        public int Guardar(string file_name)
        {
            try
            {
                StreamWriter fichero = new StreamWriter(file_name + ".txt");
                fichero.WriteLine(this.texto);
                fichero.Close();
                return 1;
            }
            catch (FileNotFoundException)
            {
                return -1;
            }
        }

    }
}


