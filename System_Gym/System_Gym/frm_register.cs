using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Gym
{
    public partial class frm_register : Form
    {

        bool ctrl_open = false;
        public bool login_cerrado = false;
        public frm_register()
        {
            InitializeComponent();
        }

        pass_adm uc_new = new pass_adm();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            
            if (ctrl_open == false) {
                ctrl_open = true;
                Controls.Add(uc_new);
                uc_new.Location = new Point(59, 141);
                pnl_hide.Visible = true;
                pnl_hide.BringToFront();
                uc_new.BringToFront();
                uc_new.Visible = true;
                
            }else if(ctrl_open == true)
            {
                pnl_hide.Visible = true;
                pnl_hide.BringToFront();
                uc_new.Visible = true;
                uc_new.BringToFront();
                
                
                
            }
            //uc_new.Location = new Point(59, 141);
            
        }
        
        
        private void frm_register_Load(object sender, EventArgs e)
        {

        }

        private void frm_register_Click(object sender, EventArgs e)
        {
            if (ctrl_open == true)
            {
                uc_new.Visible = false;
                pnl_hide.Visible = false;
            }
        }
        private void pnl_hide_Click(object sender, EventArgs e)
        {
            if (ctrl_open == true) {
                uc_new.Visible = false;
                pnl_hide.Visible = false;
            }
        }

        private void frm_register_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login_cerrado == true)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void frm_register_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (login_cerrado == false)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
