
namespace Presentacion
{
    partial class FormRegistrarseDocente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRegistroD = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtConfirmacion = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.LinkIniciar = new System.Windows.Forms.LinkLabel();
            this.btnEspañol = new System.Windows.Forms.Button();
            this.btnIngles = new System.Windows.Forms.Button();
            this.lblExito = new System.Windows.Forms.Label();
            this.lblErrorRegistro = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOcultar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 323);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.logo_large2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(388, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 1);
            this.panel2.TabIndex = 30;
            // 
            // lblRegistroD
            // 
            this.lblRegistroD.AutoSize = true;
            this.lblRegistroD.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroD.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegistroD.Location = new System.Drawing.Point(392, 10);
            this.lblRegistroD.Name = "lblRegistroD";
            this.lblRegistroD.Size = new System.Drawing.Size(302, 24);
            this.lblRegistroD.TabIndex = 29;
            this.lblRegistroD.Text = "ÁREA DE REGISTRO DOCENTE";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Location = new System.Drawing.Point(292, 197);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(225, 1);
            this.panel10.TabIndex = 60;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtContraseña.Location = new System.Drawing.Point(290, 178);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(226, 20);
            this.txtContraseña.TabIndex = 8;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(522, 197);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(225, 1);
            this.panel9.TabIndex = 58;
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtConfirmacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmacion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacion.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtConfirmacion.Location = new System.Drawing.Point(521, 178);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.Size = new System.Drawing.Size(226, 20);
            this.txtConfirmacion.TabIndex = 9;
            this.txtConfirmacion.Text = "CONFIRMAR CONTRASEÑA";
            this.txtConfirmacion.Enter += new System.EventHandler(this.txtConfirmacion_Enter);
            this.txtConfirmacion.Leave += new System.EventHandler(this.txtConfirmacion_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(292, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 1);
            this.panel3.TabIndex = 56;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombre.Location = new System.Drawing.Point(291, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(226, 20);
            this.txtNombre.TabIndex = 33;
            this.txtNombre.Text = "NOMBRE";
            this.txtNombre.Enter += new System.EventHandler(this.txtNombre_Enter);
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(521, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 1);
            this.panel4.TabIndex = 54;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtApellido.Location = new System.Drawing.Point(520, 60);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(226, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Text = "APELLIDO";
            this.txtApellido.Enter += new System.EventHandler(this.txtApellido_Enter);
            this.txtApellido.Leave += new System.EventHandler(this.txtApellido_Leave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(521, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 1);
            this.panel8.TabIndex = 53;
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtNombreUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUser.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtNombreUser.Location = new System.Drawing.Point(520, 141);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(226, 20);
            this.txtNombreUser.TabIndex = 7;
            this.txtNombreUser.Text = "NOMBRE USUARIO";
            this.txtNombreUser.Enter += new System.EventHandler(this.txtNombreUser_Enter);
            this.txtNombreUser.Leave += new System.EventHandler(this.txtNombreUser_Leave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(291, 160);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(225, 1);
            this.panel7.TabIndex = 52;
            // 
            // txtMateria
            // 
            this.txtMateria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtMateria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMateria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMateria.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMateria.Location = new System.Drawing.Point(290, 141);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(226, 20);
            this.txtMateria.TabIndex = 6;
            this.txtMateria.Text = "MATERIA";
            this.txtMateria.Enter += new System.EventHandler(this.txtMateria_Enter);
            this.txtMateria.Leave += new System.EventHandler(this.txtMateria_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(521, 123);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 1);
            this.panel6.TabIndex = 51;
            // 
            // txtGrupo
            // 
            this.txtGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtGrupo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtGrupo.Location = new System.Drawing.Point(520, 104);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(226, 20);
            this.txtGrupo.TabIndex = 5;
            this.txtGrupo.Text = "GRUPO";
            this.txtGrupo.Enter += new System.EventHandler(this.txtGrupo_Enter);
            this.txtGrupo.Leave += new System.EventHandler(this.txtGrupo_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Location = new System.Drawing.Point(291, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(225, 1);
            this.panel5.TabIndex = 50;
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtCedula.Location = new System.Drawing.Point(290, 104);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(226, 20);
            this.txtCedula.TabIndex = 4;
            this.txtCedula.Text = "CEDULA";
            this.txtCedula.Enter += new System.EventHandler(this.txtCedula_Enter);
            this.txtCedula.Leave += new System.EventHandler(this.txtCedula_Leave);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrarse.Location = new System.Drawing.Point(292, 254);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(457, 40);
            this.btnRegistrarse.TabIndex = 10;
            this.btnRegistrarse.Text = "REGISTRARSE";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuenta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCuenta.Location = new System.Drawing.Point(369, 297);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(232, 17);
            this.lblCuenta.TabIndex = 11;
            this.lblCuenta.Text = "¿Ya tienes una cuenta? Presiona aqui:";
            // 
            // LinkIniciar
            // 
            this.LinkIniciar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinkIniciar.AutoSize = true;
            this.LinkIniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkIniciar.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LinkIniciar.LinkColor = System.Drawing.Color.DimGray;
            this.LinkIniciar.Location = new System.Drawing.Point(598, 297);
            this.LinkIniciar.Name = "LinkIniciar";
            this.LinkIniciar.Size = new System.Drawing.Size(85, 17);
            this.LinkIniciar.TabIndex = 0;
            this.LinkIniciar.TabStop = true;
            this.LinkIniciar.Text = "Iniciar Sesion";
            this.LinkIniciar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkIniciar_LinkClicked);
            // 
            // btnEspañol
            // 
            this.btnEspañol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEspañol.FlatAppearance.BorderSize = 0;
            this.btnEspañol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnEspañol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEspañol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspañol.ForeColor = System.Drawing.Color.LightGray;
            this.btnEspañol.Location = new System.Drawing.Point(745, 302);
            this.btnEspañol.Name = "btnEspañol";
            this.btnEspañol.Size = new System.Drawing.Size(38, 21);
            this.btnEspañol.TabIndex = 64;
            this.btnEspañol.Text = "ES";
            this.btnEspañol.UseVisualStyleBackColor = false;
            this.btnEspañol.Click += new System.EventHandler(this.btnEspañol_Click);
            // 
            // btnIngles
            // 
            this.btnIngles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnIngles.FlatAppearance.BorderSize = 0;
            this.btnIngles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnIngles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIngles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngles.ForeColor = System.Drawing.Color.LightGray;
            this.btnIngles.Location = new System.Drawing.Point(701, 302);
            this.btnIngles.Name = "btnIngles";
            this.btnIngles.Size = new System.Drawing.Size(38, 21);
            this.btnIngles.TabIndex = 65;
            this.btnIngles.Text = "EN";
            this.btnIngles.UseVisualStyleBackColor = false;
            this.btnIngles.Click += new System.EventHandler(this.btnIngles_Click);
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExito.ForeColor = System.Drawing.Color.DarkGray;
            this.lblExito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExito.Location = new System.Drawing.Point(289, 223);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(116, 16);
            this.lblExito.TabIndex = 1;
            this.lblExito.Text = "Mensaje de exito";
            this.lblExito.Visible = false;
            // 
            // lblErrorRegistro
            // 
            this.lblErrorRegistro.AutoSize = true;
            this.lblErrorRegistro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorRegistro.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorRegistro.Image = global::Presentacion.Properties.Resources.info1;
            this.lblErrorRegistro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorRegistro.Location = new System.Drawing.Point(289, 207);
            this.lblErrorRegistro.Name = "lblErrorRegistro";
            this.lblErrorRegistro.Size = new System.Drawing.Size(116, 16);
            this.lblErrorRegistro.TabIndex = 0;
            this.lblErrorRegistro.Text = "Mensaje de error";
            this.lblErrorRegistro.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = global::Presentacion.Properties.Resources._60577;
            this.btnVolver.Location = new System.Drawing.Point(726, 0);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(15, 15);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 68;
            this.btnVolver.TabStop = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::Presentacion.Properties.Resources.Minimize_Icon;
            this.btnMinimizar.Location = new System.Drawing.Point(747, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(15, 15);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 67;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.Close_Icon;
            this.btnCerrar.Location = new System.Drawing.Point(768, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 15);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 66;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Presentacion.Properties.Resources.Group_1;
            this.pictureBox3.Location = new System.Drawing.Point(480, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 13);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxOcultar
            // 
            this.pictureBoxOcultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxOcultar.Image = global::Presentacion.Properties.Resources.verpass;
            this.pictureBoxOcultar.Location = new System.Drawing.Point(480, 182);
            this.pictureBoxOcultar.Name = "pictureBoxOcultar";
            this.pictureBoxOcultar.Size = new System.Drawing.Size(35, 13);
            this.pictureBoxOcultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOcultar.TabIndex = 70;
            this.pictureBoxOcultar.TabStop = false;
            this.pictureBoxOcultar.Click += new System.EventHandler(this.pictureBoxOcultar_Click);
            // 
            // FormRegistrarseDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(783, 323);
            this.Controls.Add(this.pictureBoxOcultar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblExito);
            this.Controls.Add(this.lblErrorRegistro);
            this.Controls.Add(this.btnEspañol);
            this.Controls.Add(this.btnIngles);
            this.Controls.Add(this.lblCuenta);
            this.Controls.Add(this.LinkIniciar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRegistroD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarseDocente";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarseDocente";
            this.Enter += new System.EventHandler(this.FormRegistrarseDocente_Enter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormRegistrarseDocente_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOcultar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRegistroD;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtConfirmacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.LinkLabel LinkIniciar;
        private System.Windows.Forms.Button btnEspañol;
        private System.Windows.Forms.Button btnIngles;
        private System.Windows.Forms.Label lblExito;
        private System.Windows.Forms.Label lblErrorRegistro;
        private System.Windows.Forms.PictureBox btnVolver;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxOcultar;
    }
}