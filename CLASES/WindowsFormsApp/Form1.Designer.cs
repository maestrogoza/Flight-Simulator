
namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.botonCargar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.botonguardarlista = new System.Windows.Forms.Button();
            this.botoncargarsector = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.botonplanos = new System.Windows.Forms.Button();
            this.ciclo = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ciclotiempo = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vuelos_sec = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ocup_sec = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.capacity_sec = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.id_sec = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // botonCargar
            // 
            this.botonCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCargar.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCargar.Location = new System.Drawing.Point(89, 221);
            this.botonCargar.Name = "botonCargar";
            this.botonCargar.Size = new System.Drawing.Size(182, 47);
            this.botonCargar.TabIndex = 0;
            this.botonCargar.Tag = "";
            this.botonCargar.Text = "CARGAR VUELOS";
            this.botonCargar.UseVisualStyleBackColor = true;
            this.botonCargar.Click += new System.EventHandler(this.botonCargar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Brandish", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(440, 30);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(639, 67);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Tag = "04";
            this.labelTitulo.Text = "DREAM.SKY SIMULATOR";
            // 
            // botonSalir
            // 
            this.botonSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonSalir.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.Location = new System.Drawing.Point(90, 433);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(182, 47);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "CERRAR";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonguardarlista
            // 
            this.botonguardarlista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonguardarlista.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonguardarlista.Location = new System.Drawing.Point(90, 327);
            this.botonguardarlista.Name = "botonguardarlista";
            this.botonguardarlista.Size = new System.Drawing.Size(182, 47);
            this.botonguardarlista.TabIndex = 3;
            this.botonguardarlista.Text = "GUARDAR VUELOS";
            this.botonguardarlista.UseVisualStyleBackColor = true;
            this.botonguardarlista.Click += new System.EventHandler(this.botonguardarlista_Click);
            // 
            // botoncargarsector
            // 
            this.botoncargarsector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botoncargarsector.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botoncargarsector.Location = new System.Drawing.Point(89, 274);
            this.botoncargarsector.Name = "botoncargarsector";
            this.botoncargarsector.Size = new System.Drawing.Size(182, 47);
            this.botoncargarsector.TabIndex = 4;
            this.botoncargarsector.Text = "CARGAR SECTOR";
            this.botoncargarsector.UseVisualStyleBackColor = true;
            this.botoncargarsector.Click += new System.EventHandler(this.botoncargarsector_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(23, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1526, 702);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            //this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 0;
            // 
            // botonplanos
            // 
            this.botonplanos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonplanos.Font = new System.Drawing.Font("Agency FB", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonplanos.Location = new System.Drawing.Point(90, 380);
            this.botonplanos.Name = "botonplanos";
            this.botonplanos.Size = new System.Drawing.Size(182, 47);
            this.botonplanos.TabIndex = 7;
            this.botonplanos.Text = "PLAN DE VUELOS";
            this.botonplanos.UseVisualStyleBackColor = true;
            this.botonplanos.Click += new System.EventHandler(this.botonplanos_Click);
            // 
            // ciclo
            // 
            this.ciclo.Tick += new System.EventHandler(this.ciclo_Tick);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(38, 824);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "START";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(181, 824);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 603);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "TIEMPO DE CICLO (min)";
            // 
            // ciclotiempo
            // 
            this.ciclotiempo.Location = new System.Drawing.Point(238, 603);
            this.ciclotiempo.Name = "ciclotiempo";
            this.ciclotiempo.Size = new System.Drawing.Size(79, 22);
            this.ciclotiempo.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(41, 634);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "AVANZAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(183, 634);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 35);
            this.button5.TabIndex = 13;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 754);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "TIEMPO DE CICLO (min)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 751);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 22);
            this.textBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 789);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "TIEMPO TOTAL (min)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(238, 789);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(79, 22);
            this.textBox2.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(38, 865);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 35);
            this.button6.TabIndex = 18;
            this.button6.Text = "REANUDAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(181, 865);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 35);
            this.button7.TabIndex = 19;
            this.button7.Text = "RESET";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(70, 706);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "AUTOMÁTICA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 553);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "CICLO A CICLO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 675);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1118, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "_____________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1118, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "_____________________________";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Brandish", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(39, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(262, 39);
            this.label9.TabIndex = 27;
            this.label9.Tag = "04";
            this.label9.Text = "MENÚ PRINCIPAL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Brandish", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(23, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(300, 39);
            this.label10.TabIndex = 28;
            this.label10.Tag = "04";
            this.label10.Text = "MENÚ SIMULACIÓN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(295, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "____________________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 526);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 16);
            this.label12.TabIndex = 30;
            this.label12.Text = "________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 768);
            this.label13.TabIndex = 31;
            this.label13.Text = "|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|" +
    "\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n|\r\n\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(419, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1576, 753);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(145, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vuelos_sec);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.ocup_sec);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.capacity_sec);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.id_sec);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Font = new System.Drawing.Font("Brandish", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1550, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 118);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMACIÓN SECTOR";
            // 
            // vuelos_sec
            // 
            this.vuelos_sec.AutoSize = true;
            this.vuelos_sec.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vuelos_sec.Location = new System.Drawing.Point(92, 61);
            this.vuelos_sec.Name = "vuelos_sec";
            this.vuelos_sec.Size = new System.Drawing.Size(0, 24);
            this.vuelos_sec.TabIndex = 42;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 24);
            this.label20.TabIndex = 41;
            this.label20.Text = "VUELOS:";
            // 
            // ocup_sec
            // 
            this.ocup_sec.AutoSize = true;
            this.ocup_sec.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocup_sec.Location = new System.Drawing.Point(392, 26);
            this.ocup_sec.Name = "ocup_sec";
            this.ocup_sec.Size = new System.Drawing.Size(0, 24);
            this.ocup_sec.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(297, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 24);
            this.label19.TabIndex = 39;
            this.label19.Text = "OCUPACIÓN:";
            // 
            // capacity_sec
            // 
            this.capacity_sec.AutoSize = true;
            this.capacity_sec.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_sec.Location = new System.Drawing.Point(244, 26);
            this.capacity_sec.Name = "capacity_sec";
            this.capacity_sec.Size = new System.Drawing.Size(0, 24);
            this.capacity_sec.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(151, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 24);
            this.label18.TabIndex = 37;
            this.label18.Text = "CAPACIDAD:";
            // 
            // id_sec
            // 
            this.id_sec.AutoSize = true;
            this.id_sec.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_sec.Location = new System.Drawing.Point(57, 26);
            this.id_sec.Name = "id_sec";
            this.id_sec.Size = new System.Drawing.Size(0, 24);
            this.id_sec.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(24, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 24);
            this.label17.TabIndex = 35;
            this.label17.Text = "ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Agency FB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 21);
            this.label15.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 976);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ciclotiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.botonplanos);
            this.Controls.Add(this.botoncargarsector);
            this.Controls.Add(this.botonguardarlista);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.botonCargar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Simulador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button botonCargar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Button botonguardarlista;
        private System.Windows.Forms.Button botoncargarsector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botonplanos;
        private System.Windows.Forms.Timer ciclo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ciclotiempo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label capacity_sec;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label id_sec;
        private System.Windows.Forms.Label vuelos_sec;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label ocup_sec;
        private System.Windows.Forms.Label label19;
    }
}

