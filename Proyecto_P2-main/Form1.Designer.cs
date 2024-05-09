
namespace persona_herencia
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.validar = new System.Windows.Forms.Button();
            this.btn_radio_docente = new System.Windows.Forms.RadioButton();
            this.btn_radio_alumno = new System.Windows.Forms.RadioButton();
            this.btn_radio_empleado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.txt_sueldo = new System.Windows.Forms.TextBox();
            this.txt_carrera_puesto = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.txt_fecha_nacimiento = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.validar);
            this.groupBox1.Controls.Add(this.btn_radio_docente);
            this.groupBox1.Controls.Add(this.btn_radio_alumno);
            this.groupBox1.Controls.Add(this.btn_radio_empleado);
            this.groupBox1.Location = new System.Drawing.Point(197, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // validar
            // 
            this.validar.Location = new System.Drawing.Point(7, 90);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(95, 43);
            this.validar.TabIndex = 3;
            this.validar.Text = "VALIDAR";
            this.validar.UseVisualStyleBackColor = true;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // btn_radio_docente
            // 
            this.btn_radio_docente.AutoSize = true;
            this.btn_radio_docente.Location = new System.Drawing.Point(7, 66);
            this.btn_radio_docente.Name = "btn_radio_docente";
            this.btn_radio_docente.Size = new System.Drawing.Size(102, 17);
            this.btn_radio_docente.TabIndex = 2;
            this.btn_radio_docente.TabStop = true;
            this.btn_radio_docente.Text = "Soy un Docente";
            this.btn_radio_docente.UseVisualStyleBackColor = true;
            // 
            // btn_radio_alumno
            // 
            this.btn_radio_alumno.AutoSize = true;
            this.btn_radio_alumno.Location = new System.Drawing.Point(7, 43);
            this.btn_radio_alumno.Name = "btn_radio_alumno";
            this.btn_radio_alumno.Size = new System.Drawing.Size(95, 17);
            this.btn_radio_alumno.TabIndex = 1;
            this.btn_radio_alumno.TabStop = true;
            this.btn_radio_alumno.Text = "Soy un alumno";
            this.btn_radio_alumno.UseVisualStyleBackColor = true;
            // 
            // btn_radio_empleado
            // 
            this.btn_radio_empleado.AutoSize = true;
            this.btn_radio_empleado.Location = new System.Drawing.Point(7, 20);
            this.btn_radio_empleado.Name = "btn_radio_empleado";
            this.btn_radio_empleado.Size = new System.Drawing.Size(107, 17);
            this.btn_radio_empleado.TabIndex = 0;
            this.btn_radio_empleado.TabStop = true;
            this.btn_radio_empleado.Text = "Soy un empleado";
            this.btn_radio_empleado.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Salir);
            this.groupBox2.Controls.Add(this.limpiar);
            this.groupBox2.Controls.Add(this.guardar);
            this.groupBox2.Controls.Add(this.txt_sueldo);
            this.groupBox2.Controls.Add(this.txt_carrera_puesto);
            this.groupBox2.Controls.Add(this.txt_matricula);
            this.groupBox2.Controls.Add(this.txt_edad);
            this.groupBox2.Controls.Add(this.txt_fecha_nacimiento);
            this.groupBox2.Controls.Add(this.txt_nombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(211, 180);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(95, 43);
            this.Salir.TabIndex = 13;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(110, 180);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(95, 43);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(9, 180);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(95, 43);
            this.guardar.TabIndex = 4;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // txt_sueldo
            // 
            this.txt_sueldo.Location = new System.Drawing.Point(176, 153);
            this.txt_sueldo.Name = "txt_sueldo";
            this.txt_sueldo.Size = new System.Drawing.Size(100, 20);
            this.txt_sueldo.TabIndex = 11;
            // 
            // txt_carrera_puesto
            // 
            this.txt_carrera_puesto.Location = new System.Drawing.Point(176, 127);
            this.txt_carrera_puesto.Name = "txt_carrera_puesto";
            this.txt_carrera_puesto.Size = new System.Drawing.Size(100, 20);
            this.txt_carrera_puesto.TabIndex = 10;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(176, 101);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 9;
            // 
            // txt_edad
            // 
            this.txt_edad.Location = new System.Drawing.Point(176, 75);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(100, 20);
            this.txt_edad.TabIndex = 8;
            // 
            // txt_fecha_nacimiento
            // 
            this.txt_fecha_nacimiento.Location = new System.Drawing.Point(176, 49);
            this.txt_fecha_nacimiento.Name = "txt_fecha_nacimiento";
            this.txt_fecha_nacimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_nacimiento.TabIndex = 7;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(176, 17);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SUELDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CARRERA/PUESTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI / MATRICULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "PERSONA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.RadioButton btn_radio_docente;
        private System.Windows.Forms.RadioButton btn_radio_alumno;
        private System.Windows.Forms.RadioButton btn_radio_empleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox txt_sueldo;
        private System.Windows.Forms.TextBox txt_carrera_puesto;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_edad;
        private System.Windows.Forms.TextBox txt_fecha_nacimiento;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

