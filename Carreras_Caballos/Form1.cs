using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreras_Caballos
{
    public partial class Form1 : Form
    {
        /*Posicion de los elemento*/
        private int posx1;
        private int posy1;
        private int posx2;
        private int posy2;
        private int posx3;
        private int posy3;
        private int posx4;
        private int posy4;
        //Tamaño de la imagen
        private int ancho;
        private int alto;
        /*Indica el cambio que tendra el elemento*/
        private int vel1;
        private int vel2;
        private int vel3;
        private int vel4;
        //Se crean los hilos
        Thread hilo;
        Thread hilo2;
        Thread hilo3;
        Thread hilo4;
        //Variable para saber si gano algunos de los caballos 
        private String finCaballo;
        //Suma total del saldo del jugador
        double saldoTotal;
        double saldoApostar;
        String caballoApuesta;
        Boolean estadoHilo = true;

        Random r = new Random();

        Random rand1 = new Random();
        Random rand2 = new Random();
        Random rand3 = new Random();
        Random rand4 = new Random();

        //CONSTRUCTOR
        public Form1()
        {
            InitializeComponent();
            comboBoxCaballo.SelectedIndex = 0;
            posx1 = 0;
            posy1 = 30;
            posx2 = 0;
            posy2 = 110;
            posx3 = 0;
            posy3 = 190;
            posx4 = 0;
            posy4 = 260;
            ancho = 70;
            alto = 50;
        }

        public void estadoComponentesPanel()
        {
            labelTotal.Visible = false;
            labelSaldoTotal.Visible = false;
            labelApuesta.Visible = false;
            textBoxApuesta.Visible = false;
            labelSelectCaballo.Visible = false;
            comboBoxCaballo.Visible = false;
            botonIniciar.Visible = false;

            labelBase.Visible = true;
            comboBoxBase.Visible = true;
        }

        /*Evento del Metodo que es invocado al seleccionar un item del comboBoxBase, 
         * activa los demas componentes faltantes de la vista.*/
        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            saldoTotal = Convert.ToDouble(comboBoxBase.SelectedItem);
            labelSaldoTotal.Text = "$" + Convert.ToString(saldoTotal);
            //Se desactivan los dos componentes, comboBoxBase y labelBase.
            labelBase.Visible = false;
            comboBoxBase.Visible = false;
            //Se activan el resto de componentes de la vista.
            labelTotal.Visible = true;
            labelSaldoTotal.Visible = true;
            labelApuesta.Visible = true;
            textBoxApuesta.Visible = true;
            labelSelectCaballo.Visible = true;
            comboBoxCaballo.Visible = true;
            botonIniciar.Visible = true;
        }

        /*Evento del metodo para iniciar juego*/
        private void botonIniciar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBoxApuesta.Text) || comboBoxCaballo.SelectedIndex == 0))
            {
                //Apuesta del jugador
                saldoApostar = Convert.ToDouble(textBoxApuesta.Text);
                //Caballo que escogio el jugador
                caballoApuesta = comboBoxCaballo.SelectedItem.ToString();

                if (saldoApostar <= saldoTotal)
                {
                    estadoHilo = true;
                    iniciarHilos(true);
                }
                else
                {
                    MessageBox.Show("El saldo apostar supera tu saldo total", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxApuesta.Text = " ";
                }
            }
            else
            {
                MessageBox.Show("Debe completar la informacion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void repintar()
        {
            while (estadoHilo)
            {
                vel1 = rand1.Next(r.Next(30));

                if (panelCarrera.Width > posx1 + ancho)
                {
                    posx1 = posx1 + vel1; 
                }
                else
                {
                    estadoHilo = false;
                    finCaballo = "Caballo 1";
                    calificarCarrera(finCaballo);
                }
                //Repinta la interfaz 
                panelCarrera.Invalidate();
                //Duerme el hilo
                Thread.Sleep(100);
            }
        }

        public void repintar2()
        {
            while (estadoHilo)
            {
                vel2 = rand2.Next(r.Next(30));

                if (panelCarrera.Width > posx2 + ancho)
                {
                    posx2 = posx2 + vel2;
                }
                else
                {
                    estadoHilo = false;
                    finCaballo = "Caballo 2";
                    calificarCarrera(finCaballo);  
                }
                //Repinta la interfaz 
                panelCarrera.Invalidate();
                //Duerme el hilo
                Thread.Sleep(100);
            }
        }

        public void repintar3()
        {
            while (estadoHilo)
            {
                vel3 = rand3.Next(r.Next(30));

                if (panelCarrera.Width > posx3 + ancho)
                {
                    posx3 = posx3 + vel3;
                }
                else
                {
                    estadoHilo = false;
                    finCaballo = "Caballo 3";
                    calificarCarrera(finCaballo);
                }
                //Repinta la interfaz 
                panelCarrera.Invalidate();
                //Duerme el hilo
                Thread.Sleep(100);
            }
        }

        public void repintar4()
        {
            while (estadoHilo)
            {
                vel4 = rand4.Next(r.Next(30));
                if (panelCarrera.Width > posx4 + ancho)
                {
                    posx4 = posx4 + vel4;
                }
                else
                {
                    estadoHilo = false;
                    finCaballo = "Caballo 4";
                    calificarCarrera(finCaballo);
                }
                //Repinta la interfaz 
                panelCarrera.Invalidate();
                //Duerme el hilo
                Thread.Sleep(100);
            }
        }

        private void iniciarHilos(Boolean estado)
        {
            if (estado == true)
            {
                hilo = new Thread(repintar);
                hilo.Start();

                hilo2 = new Thread(repintar2);
                hilo2.Start();

                hilo3 = new Thread(repintar3);
                hilo3.Start();

                hilo4 = new Thread(repintar4);
                hilo4.Start();
            }
        }

        public void calificarCarrera(String caballo)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (caballo.Equals(caballoApuesta))
            {
                MessageBox.Show("SU CABALLO HA GANADO", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                saldoTotal = saldoTotal + saldoApostar;
                labelSaldoTotal.Text = "$"+saldoTotal+"";
                reiniciarCaballos();
            }
            else
            {
                MessageBox.Show("SU CABALLO HA PERDIDO", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                saldoTotal = saldoTotal - saldoApostar;
                labelSaldoTotal.Text = "$" + saldoTotal + "";
                if (saldoTotal == 0) 
                {
                    MessageBox.Show("SE HA QUEDADO SIN SALDO PARA JUGAR, CARGA MAS SALDO A TU JUEGO", null, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    estadoComponentesPanel();
                }
                reiniciarCaballos();
                
            }
        }

        public void reiniciarCaballos()
        {
            CheckForIllegalCrossThreadCalls = false;
            comboBoxCaballo.SelectedIndex = 0;
            textBoxApuesta.Text = " ";
            posx1 = 0;
            posy1 = 30;
            posx2 = 0;
            posy2 = 110;
            posx3 = 0;
            posy3 = 190;
            posx4 = 0;
            posy4 = 260;
            //Repinta la interfaz 
            panelCarrera.Invalidate();
        }

        private void panelCarrera_Paint(object sender, PaintEventArgs e)
        {
            /*Recordar cambiar la propiedad de la imagen a cambiar si es posterior para 
             * que pueda refrescar la imagen, sin esto no la pinta*/
            e.Graphics.DrawImage(new Bitmap("horse.png"), posx1, posy1, ancho, alto);
            e.Graphics.DrawImage(new Bitmap("horse.png"), posx2, posy2, ancho, alto);
            e.Graphics.DrawImage(new Bitmap("horse.png"), posx3, posy3, ancho, alto);
            e.Graphics.DrawImage(new Bitmap("horse.png"), posx4, posy4, ancho, alto);
        }

        private void textBoxApuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        } 
    }
}
