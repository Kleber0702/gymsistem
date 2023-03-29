namespace System_Gym
{
    partial class pass_adm
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.check = new Guna.UI2.WinForms.Guna2Button();
            this.user_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.pass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check
            // 
            this.check.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.check.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.check.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.check.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.check.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(60, 154);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(180, 45);
            this.check.TabIndex = 0;
            this.check.Text = "Confirmar";
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // user_txt
            // 
            this.user_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_txt.DefaultText = "";
            this.user_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.user_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.user_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.user_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.user_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user_txt.Location = new System.Drawing.Point(35, 45);
            this.user_txt.Name = "user_txt";
            this.user_txt.PasswordChar = '\0';
            this.user_txt.PlaceholderText = "";
            this.user_txt.SelectedText = "";
            this.user_txt.Size = new System.Drawing.Size(220, 36);
            this.user_txt.TabIndex = 1;
            // 
            // pass_txt
            // 
            this.pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass_txt.DefaultText = "";
            this.pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pass_txt.Location = new System.Drawing.Point(35, 104);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '\0';
            this.pass_txt.PlaceholderText = "";
            this.pass_txt.SelectedText = "";
            this.pass_txt.Size = new System.Drawing.Size(220, 36);
            this.pass_txt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(318, 26);
            this.guna2Panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comprobación de seguridad";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.FillColor = System.Drawing.Color.Black;
            this.guna2Panel2.Location = new System.Drawing.Point(308, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(10, 179);
            this.guna2Panel2.TabIndex = 7;
            // 
            // pass_adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.check);
            this.Name = "pass_adm";
            this.Size = new System.Drawing.Size(313, 199);
            this.Load += new System.EventHandler(this.pass_adm_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button check;
        private Guna.UI2.WinForms.Guna2TextBox user_txt;
        private Guna.UI2.WinForms.Guna2TextBox pass_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}
