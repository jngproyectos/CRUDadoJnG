using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDado
{
    public partial class Notificacion : Form
    {
        public Notificacion()
        {
            InitializeComponent();
        }
        //Sobrecargamos el contrustor con parametros
        public Notificacion(string pMensaje, Color pColor, int tipo)
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;//se pondrá el string que recibe en el label
            lblMensaje.ForeColor = pColor;//Cambia el color de letra
            pTop.BackColor = pColor;//Cambia el color del panel
            //Si el tipo es 1 muestra la imagen success y oculta las otras dos
            if (tipo == 1)//success
            {
                pbInfo.Visible = false;
                pbDel.Visible = false;
            }
            else if(tipo == 2)//INfo
            {
                pbSuc.Visible = false;
                pbDel.Visible = false;
            }
            else if(tipo == 3)//Delete
            {
                pbSuc.Visible = false;
                pbInfo.Visible = false;
            }
        }
        //Evento del timer
        private int conteo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;//aumentando
            if (conteo == 30)//cuando conteo llegue a 30, 3 seg. la notificación se
                this.Close();//cierra
        }
        //Evento load del form
        private void Notificacion_Load(object sender, EventArgs e)
        {
            timer1.Start();//iniciamos el timer
        }
        //Evento cuando se esta cerrando el form
        private void Notificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;//detenemos el timer
        }
    }
}
