
namespace Presentacion
{
    partial class FormPerfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPerfilAdmin));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAltaAlumno = new System.Windows.Forms.Button();
            this.txtUsernameAlumnos = new System.Windows.Forms.TextBox();
            this.txtApellidoAlumnos = new System.Windows.Forms.TextBox();
            this.txtNombreAlumnos = new System.Windows.Forms.TextBox();
            this.txtCedulaAlumnos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAltaDocente = new System.Windows.Forms.Button();
            this.txtUsernameDocente = new System.Windows.Forms.TextBox();
            this.txtApellidoDocente = new System.Windows.Forms.TextBox();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.txtCedulaDocente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::Presentacion.Properties.Resources.Close;
            this.btnCerrar.Location = new System.Drawing.Point(3, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 16);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 50;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(905, 78);
            this.label1.TabIndex = 51;
            this.label1.Text = "ABM ALUMNOS Y DOCENTES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAltaAlumno);
            this.panel1.Controls.Add(this.txtUsernameAlumnos);
            this.panel1.Controls.Add(this.txtApellidoAlumnos);
            this.panel1.Controls.Add(this.txtNombreAlumnos);
            this.panel1.Controls.Add(this.txtCedulaAlumnos);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 224);
            this.panel1.TabIndex = 52;
            // 
            // btnAltaAlumno
            // 
            this.btnAltaAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAltaAlumno.FlatAppearance.BorderSize = 0;
            this.btnAltaAlumno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAltaAlumno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAltaAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAltaAlumno.Location = new System.Drawing.Point(158, 167);
            this.btnAltaAlumno.Name = "btnAltaAlumno";
            this.btnAltaAlumno.Size = new System.Drawing.Size(191, 37);
            this.btnAltaAlumno.TabIndex = 91;
            this.btnAltaAlumno.Text = "ALTA ALUMNO";
            this.btnAltaAlumno.UseVisualStyleBackColor = false;
            this.btnAltaAlumno.Click += new System.EventHandler(this.btnAltaAlumno_Click);
            // 
            // txtUsernameAlumnos
            // 
            this.txtUsernameAlumnos.Location = new System.Drawing.Point(160, 144);
            this.txtUsernameAlumnos.Name = "txtUsernameAlumnos";
            this.txtUsernameAlumnos.Size = new System.Drawing.Size(189, 20);
            this.txtUsernameAlumnos.TabIndex = 8;
            // 
            // txtApellidoAlumnos
            // 
            this.txtApellidoAlumnos.Location = new System.Drawing.Point(158, 114);
            this.txtApellidoAlumnos.Name = "txtApellidoAlumnos";
            this.txtApellidoAlumnos.Size = new System.Drawing.Size(189, 20);
            this.txtApellidoAlumnos.TabIndex = 7;
            // 
            // txtNombreAlumnos
            // 
            this.txtNombreAlumnos.Location = new System.Drawing.Point(158, 83);
            this.txtNombreAlumnos.Name = "txtNombreAlumnos";
            this.txtNombreAlumnos.Size = new System.Drawing.Size(189, 20);
            this.txtNombreAlumnos.TabIndex = 6;
            // 
            // txtCedulaAlumnos
            // 
            this.txtCedulaAlumnos.Location = new System.Drawing.Point(158, 49);
            this.txtCedulaAlumnos.Name = "txtCedulaAlumnos";
            this.txtCedulaAlumnos.Size = new System.Drawing.Size(189, 20);
            this.txtCedulaAlumnos.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre de usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ci:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "ALTA DE ALUMNOS";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAltaDocente);
            this.panel2.Controls.Add(this.txtUsernameDocente);
            this.panel2.Controls.Add(this.txtApellidoDocente);
            this.panel2.Controls.Add(this.txtNombreDocente);
            this.panel2.Controls.Add(this.txtCedulaDocente);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(410, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 224);
            this.panel2.TabIndex = 53;
            // 
            // btnAltaDocente
            // 
            this.btnAltaDocente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnAltaDocente.FlatAppearance.BorderSize = 0;
            this.btnAltaDocente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAltaDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAltaDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaDocente.ForeColor = System.Drawing.Color.White;
            this.btnAltaDocente.Location = new System.Drawing.Point(158, 165);
            this.btnAltaDocente.Name = "btnAltaDocente";
            this.btnAltaDocente.Size = new System.Drawing.Size(191, 37);
            this.btnAltaDocente.TabIndex = 92;
            this.btnAltaDocente.Text = "ALTA DOCENTE";
            this.btnAltaDocente.UseVisualStyleBackColor = false;
            this.btnAltaDocente.Click += new System.EventHandler(this.btnAltaDocente_Click);
            // 
            // txtUsernameDocente
            // 
            this.txtUsernameDocente.Location = new System.Drawing.Point(160, 144);
            this.txtUsernameDocente.Name = "txtUsernameDocente";
            this.txtUsernameDocente.Size = new System.Drawing.Size(189, 20);
            this.txtUsernameDocente.TabIndex = 8;
            // 
            // txtApellidoDocente
            // 
            this.txtApellidoDocente.Location = new System.Drawing.Point(160, 114);
            this.txtApellidoDocente.Name = "txtApellidoDocente";
            this.txtApellidoDocente.Size = new System.Drawing.Size(189, 20);
            this.txtApellidoDocente.TabIndex = 7;
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(160, 83);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.Size = new System.Drawing.Size(189, 20);
            this.txtNombreDocente.TabIndex = 6;
            // 
            // txtCedulaDocente
            // 
            this.txtCedulaDocente.Location = new System.Drawing.Point(160, 51);
            this.txtCedulaDocente.Name = "txtCedulaDocente";
            this.txtCedulaDocente.Size = new System.Drawing.Size(189, 20);
            this.txtCedulaDocente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre de usuario:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Apellido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ci:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 33);
            this.label11.TabIndex = 0;
            this.label11.Text = "ALTA DE DOCENTES";
            // 
            // FormPerfilAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(903, 487);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPerfilAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPerfilAdmin";
            this.Load += new System.EventHandler(this.FormPerfilAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsernameAlumnos;
        private System.Windows.Forms.TextBox txtApellidoAlumnos;
        private System.Windows.Forms.TextBox txtNombreAlumnos;
        private System.Windows.Forms.TextBox txtCedulaAlumnos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsernameDocente;
        private System.Windows.Forms.TextBox txtApellidoDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.TextBox txtCedulaDocente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button btnAltaAlumno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnAltaDocente;
    }
}