using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Gym
{
    public partial class frm_login : Form
    {
        
        frm_register registrar = new frm_register();
        bool comprueba_abierto = false;
        public frm_login()
        {
            InitializeComponent();
        }

        private void frm_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (comprueba_abierto == false)
            {
                Application.Exit();
            }
            else {
                registrar.login_cerrado = false;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }


        #region MouseEnter/Leave
        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
        #endregion

        private void lbl_register_Click(object sender, EventArgs e)
        {
            frm_register registrar = new frm_register();
            registrar.Show();
            comprueba_abierto = true;
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            registrar.login_cerrado = true;
            
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           principal programa = new principal();
            programa.Visible = true;
            this.Hide();
        }
    }
}
