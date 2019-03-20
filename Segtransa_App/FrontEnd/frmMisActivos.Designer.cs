namespace FrontEnd
{
    partial class frmMisActivos
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
            this.lvMisActivos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(602, 450);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 36);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Atras";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvMisActivos
            // 
            this.lvMisActivos.AllowColumnReorder = true;
            this.lvMisActivos.GridLines = true;
            this.lvMisActivos.HoverSelection = true;
            this.lvMisActivos.Location = new System.Drawing.Point(13, 13);
            this.lvMisActivos.Name = "lvMisActivos";
            this.lvMisActivos.Size = new System.Drawing.Size(674, 406);
            this.lvMisActivos.TabIndex = 8;
            this.lvMisActivos.UseCompatibleStateImageBehavior = false;
            this.lvMisActivos.View = System.Windows.Forms.View.Details;
            // 
            // frmMisActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 515);
            this.Controls.Add(this.lvMisActivos);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMisActivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MisActivos";
            this.Load += new System.EventHandler(this.frmMisActivos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvMisActivos;
    }
}