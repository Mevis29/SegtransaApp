namespace FrontEnd
{
    partial class frmUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lbllistaUser = new System.Windows.Forms.Label();
            this.lstUsuarios = new System.Windows.Forms.ListBox();
            this.btnModifyUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(532, 332);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 24);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(67, 278);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(110, 36);
            this.btnAddUser.TabIndex = 8;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lbllistaUser
            // 
            this.lbllistaUser.AutoSize = true;
            this.lbllistaUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllistaUser.Location = new System.Drawing.Point(35, 25);
            this.lbllistaUser.Name = "lbllistaUser";
            this.lbllistaUser.Size = new System.Drawing.Size(179, 25);
            this.lbllistaUser.TabIndex = 9;
            this.lbllistaUser.Text = "Lista de Usuarios";
            // 
            // lstUsuarios
            // 
            this.lstUsuarios.FormattingEnabled = true;
            this.lstUsuarios.Location = new System.Drawing.Point(40, 68);
            this.lstUsuarios.Name = "lstUsuarios";
            this.lstUsuarios.Size = new System.Drawing.Size(495, 186);
            this.lstUsuarios.TabIndex = 10;
            // 
            // btnModifyUser
            // 
            this.btnModifyUser.Location = new System.Drawing.Point(225, 278);
            this.btnModifyUser.Name = "btnModifyUser";
            this.btnModifyUser.Size = new System.Drawing.Size(110, 36);
            this.btnModifyUser.TabIndex = 11;
            this.btnModifyUser.Text = "Modificar Usuario";
            this.btnModifyUser.UseVisualStyleBackColor = true;
            this.btnModifyUser.Click += new System.EventHandler(this.btnModifyUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(383, 278);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(110, 36);
            this.btnDeleteUser.TabIndex = 12;
            this.btnDeleteUser.Text = "Eliminar Usuario";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnModifyUser);
            this.Controls.Add(this.lstUsuarios);
            this.Controls.Add(this.lbllistaUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label lbllistaUser;
        private System.Windows.Forms.ListBox lstUsuarios;
        private System.Windows.Forms.Button btnModifyUser;
        private System.Windows.Forms.Button btnDeleteUser;
    }
}