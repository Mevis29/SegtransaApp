using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Backend.DAL;
using Backend.Entities;

namespace FrontEnd
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public IUsuariosDAL usuariosDal = new UsuariosImplDAL();
        CryptoEngine cryptoEngine = new CryptoEngine();
        public Usuarios user;
        int contadorIntentos = 0;

        private void showInfo(string Mensaje)
        {
            MessageBox.Show(Mensaje);
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            contadorIntentos = contadorIntentos + 1;
            int i = 0;
            int id = -1;
            string pass;
            if ((!string.IsNullOrEmpty(tbxUserId.Text) && !int.TryParse(tbxUserId.Text, out i)) || string.IsNullOrEmpty(tbxUserId.Text) || string.IsNullOrWhiteSpace(tbxUserId.Text))
            {
                showInfo("El campo de Id usuario vacio o con formato equivocado! \nPor favor ingrese unicamente numeros!");
                tbxUserId.Clear();
                if (contadorIntentos > 5)
                {
                    showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                    Close();
                }
            }
            else 
            {
                id = int.Parse(tbxUserId.Text);

                if (string.IsNullOrWhiteSpace(tbxPassword.Text) || string.IsNullOrEmpty(tbxPassword.Text))
                {
                    showInfo("El campo de Password se encuentra vacio! \nPor favor ingrese su Password!");
                    if (contadorIntentos > 5)
                    {
                        showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                        Close();
                    }
                }
                else
                {
                    pass = cryptoEngine.Encrypt(tbxPassword.Text);

                    /*user = usuariosDal.GetUsuario(id);*/
                    //showInfo("Password: " + tbxPassword.Text + " Encryptada: " + pass);
                    /*Validanado usuario*/
                    if (usuariosDal.isRealUser(id))
                    {
                        
                        if (usuariosDal.isValidPassword(pass, id))
                        {
                            /*Validado usuario y password se le da acceso a un menu de opciones de acuerdo a su roll, admin o cualquier otro*/
                            user = usuariosDal.GetUsuario(id);                            
                            /*showInfo("Bienvenido " + user.nombre);*/
                            frmMenuReporte mainMenu = new frmMenuReporte(user, this);
                            mainMenu.Show();
                            tbxUserId.Clear();
                            tbxPassword.Clear();
                            this.Hide();
                        }
                        else
                        {
                            tbxUserId.Clear();
                            tbxPassword.Clear();
                            showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                            if (contadorIntentos > 5)
                            {
                                showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                                Close();
                            }
                        }
                    }
                    else
                    {
                        tbxUserId.Clear();
                        tbxPassword.Clear();
                        showInfo("Los datos ingresados no son correctos! \nPor favor ingrese sus datos!");
                        if (contadorIntentos > 5)
                        {
                            showInfo("Alcanzo el numero maximo de Intentos! \nPor favor comuniquese con el departamento de Informatica!");
                            Close();
                        }
                    }
                }
            }
        }
    }
}
