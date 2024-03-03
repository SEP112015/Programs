using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CreateUser creando = new CreateUser();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            CreateUser creando = new CreateUser();
            creando.Conectar();

        }

        private void Desconectando_Click(object sender, EventArgs e)
        {
            creando.Desconectar();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {

            creando.Insertar(Convert.ToInt32(txt_id.Text),
      txt_nombreinsert.Text, txt_apellido.Text, txt_sexo.Text, txt_fechanacimiento.Text, txt_usuario.Text, txt_CorreoElectronico.Text,
      txt_Contraseña.Text, txt_Telefono.Text, txt_Dirección.Text);


            txt_id.Text = "";
            txt_nombreinsert.Text = "";
            txt_apellido.Text = "";
            txt_sexo.Text = "";
            txt_fechanacimiento.Text = "";
            txt_usuario.Text = "";
            txt_CorreoElectronico.Text = "";
            txt_Contraseña.Text = "";
            txt_Telefono.Text = "";
            txt_Dirección.Text = "";


        }

        private void txt_visa_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
