namespace Capa_Presentacion
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.moverformulario = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pgblogin = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnverificar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 355);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 83);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(0, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 83);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.label3.Location = new System.Drawing.Point(483, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 38);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOGIN";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontraseña.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.txtcontraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.txtcontraseña.Location = new System.Drawing.Point(441, 178);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(211, 19);
            this.txtcontraseña.TabIndex = 12;
            this.txtcontraseña.Text = "PASSWORD";
            this.txtcontraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcontraseña.Click += new System.EventHandler(this.txtcontraseña_Click);
            this.txtcontraseña.TextChanged += new System.EventHandler(this.txtcontraseña_TextChanged_1);
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.txtusuario.Location = new System.Drawing.Point(441, 108);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(211, 19);
            this.txtusuario.TabIndex = 11;
            this.txtusuario.Text = "USER";
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtusuario.Click += new System.EventHandler(this.txtusuario_Click);
            // 
            // moverformulario
            // 
            this.moverformulario.Fixed = true;
            this.moverformulario.Horizontal = true;
            this.moverformulario.TargetControl = this;
            this.moverformulario.Vertical = true;
            // 
            // pgblogin
            // 
            this.pgblogin.BackColor = System.Drawing.Color.Blue;
            this.pgblogin.Location = new System.Drawing.Point(338, 286);
            this.pgblogin.Name = "pgblogin";
            this.pgblogin.Size = new System.Drawing.Size(532, 23);
            this.pgblogin.Step = 5;
            this.pgblogin.TabIndex = 19;
            this.pgblogin.UseWaitCursor = true;
            this.pgblogin.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Capa_Presentacion.Properties.Resources.minimizar1;
            this.pictureBox3.Location = new System.Drawing.Point(820, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Capa_Presentacion.Properties.Resources.salir;
            this.pictureBox2.Location = new System.Drawing.Point(852, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnverificar
            // 
            this.btnverificar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnverificar.AllowDrop = true;
            this.btnverificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.btnverificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnverificar.BorderRadius = 7;
            this.btnverificar.ButtonText = "VERIFICAR";
            this.btnverificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverificar.DisabledColor = System.Drawing.Color.Gray;
            this.btnverificar.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnverificar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnverificar.Iconimage")));
            this.btnverificar.Iconimage_right = null;
            this.btnverificar.Iconimage_right_Selected = null;
            this.btnverificar.Iconimage_Selected = null;
            this.btnverificar.IconMarginLeft = 0;
            this.btnverificar.IconMarginRight = 0;
            this.btnverificar.IconRightVisible = true;
            this.btnverificar.IconRightZoom = 0D;
            this.btnverificar.IconVisible = true;
            this.btnverificar.IconZoom = 60D;
            this.btnverificar.IsTab = false;
            this.btnverificar.Location = new System.Drawing.Point(697, 123);
            this.btnverificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(124)))));
            this.btnverificar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnverificar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnverificar.selected = false;
            this.btnverificar.Size = new System.Drawing.Size(154, 61);
            this.btnverificar.TabIndex = 15;
            this.btnverificar.Text = "VERIFICAR";
            this.btnverificar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnverificar.Textcolor = System.Drawing.Color.AntiqueWhite;
            this.btnverificar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverificar.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(884, 355);
            this.Controls.Add(this.pgblogin);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(92)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.TextBox txtusuario;
        private Bunifu.Framework.UI.BunifuFlatButton btnverificar;
        private Bunifu.Framework.UI.BunifuDragControl moverformulario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ProgressBar pgblogin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}