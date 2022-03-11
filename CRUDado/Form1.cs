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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        //método cuando el control esta activo, en este caso un TextBox
        private void txt_Enter(object sender, EventArgs e)
        {
            //hace la invocación
            TextBox txt = sender as TextBox;
            //Iteramos el panel en busca de controles
            foreach (Control ctrl in pContainer.Controls)
            {
                //si es un pictureBox y tiene el nombre "pb" + el tag del Text
                if (ctrl is PictureBox &&
                    ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    //cambia el color
                    ctrl.BackColor = Color.FromArgb(79, 129, 189);
                }
                // ñp mismo que con el picturebox
                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.FromArgb(79, 129, 189);
                }
            }
        }
        //método cuando el control NO esta activo, en este caso un TextBox
        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            foreach (Control ctrl in pContainer.Controls)
            {
                if (ctrl is PictureBox &&
                     ctrl.Name == "pb" + txt.Tag.ToString())
                {
                    ctrl.BackColor = Color.Black;
                }
                if (ctrl is Label && ctrl.Name == "lbl" + txt.Tag.ToString())
                {
                    ctrl.ForeColor = Color.Black;
                }
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Método para mostrar una "notificación"
        private void Noty(string pMsg)
        {
            //Atributo tipo color 
            Color verde = Color.FromArgb(92, 184, 92),
                rojo = Color.FromArgb(217, 83, 79),
                info = Color.FromArgb(66, 139, 202);
            //Objeto del form Notificacion, para mostrarlo
            Notificacion n = new Notificacion();
            //dependiendo el mensaje que reciba,
            //muestra mensaje y color
            if (pMsg == "guardar")
            {
                n = new Notificacion("Registro guardado", verde, 1);
            }
            else if (pMsg == "editar")
            {
                n = new Notificacion("Registro actualizado", verde, 1);
            }
            else if (pMsg == "eliminar")
            {
                n = new Notificacion("Registro eliminado", rojo, 3);
            }
            else if (pMsg == "info")
            {
                n = new Notificacion("Seleccione regitro", info, 2);
            }
            //Le cambie su ubicación y se muestra.
            n.Location = new Point(360, 440);
            n.ShowDialog();
        }
        #endregion
        CEntidad entidad = new CEntidad();
        CDatos datos = new CDatos();
        private int Id;
        private void SelectPersona()
        {
            DataSet ds = datos.selectPersona();
            dgvEjemplo.DataSource = ds;
            dgvEjemplo.DataMember = "Persona";
        }
        private void CargarDatos()
        {
            entidad.Id = Id;
            entidad.Nombre = txtNom.Text;
            entidad.Apellido = txtApellido.Text;
            entidad.Correo = txtCorreo.Text;
        }
        private void Limpiar()
        {
            Id = 0;
            txtNom.Text = string.Empty;
            txtNom.Focus();
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            SelectPersona();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            datos.CRUDPersona(entidad, "C");
            Noty("guardar");
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                Noty("info");
            }
            else
            {
                CargarDatos();
                datos.CRUDPersona(entidad, "U");
                Noty("editar");
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                Noty("info");
            }
            else
            {
                //Form MsgBox para preguntar si autorizo eliminación
                DialogResult dg = new DialogResult();
                MsgBox ms = new MsgBox("question", "Desea eliminar?\nse eliminará permanentemente");
                dg = ms.ShowDialog();
                if(ms.DialogResult == DialogResult.OK) 
                {
                    CargarDatos();
                    datos.CRUDPersona(entidad, "D");
                    Noty("eliminar");
                    Limpiar();
                }
                else
                {
                    txtNom.Focus();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectPersona();
            //Clase para dar formato y color al datagrid
            DGVColor.Formato(dgvEjemplo, 1);
        }

        private void dgvEjemplo_DoubleClick(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(dgvEjemplo.CurrentRow.Cells
                ["Id"].Value.ToString());
            txtNom.Text = dgvEjemplo.CurrentRow.Cells
                ["Nombre"].Value.ToString();
            txtApellido.Text = dgvEjemplo.CurrentRow.Cells
                ["Apellido"].Value.ToString();
            txtCorreo.Text = dgvEjemplo.CurrentRow.Cells
                ["Correo"].Value.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
