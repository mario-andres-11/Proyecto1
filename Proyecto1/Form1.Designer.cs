namespace Proyecto1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lerrores = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.laciertos = new System.Windows.Forms.Label();
            this.lnivel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lturno = new System.Windows.Forms.Label();
            this.btnClasificacion = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.trespuesta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lnum2 = new System.Windows.Forms.Label();
            this.lop = new System.Windows.Forms.Label();
            this.lnum1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Juego Numeros de Mario Villalobos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.lerrores);
            this.panel1.Controls.Add(this.btnReiniciar);
            this.panel1.Controls.Add(this.laciertos);
            this.panel1.Controls.Add(this.lnivel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lturno);
            this.panel1.Controls.Add(this.btnClasificacion);
            this.panel1.Controls.Add(this.btnAceptar);
            this.panel1.Controls.Add(this.trespuesta);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lnum2);
            this.panel1.Controls.Add(this.lop);
            this.panel1.Controls.Add(this.lnum1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 367);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lerrores
            // 
            this.lerrores.AutoSize = true;
            this.lerrores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lerrores.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lerrores.ForeColor = System.Drawing.SystemColors.Window;
            this.lerrores.Location = new System.Drawing.Point(124, 326);
            this.lerrores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lerrores.Name = "lerrores";
            this.lerrores.Size = new System.Drawing.Size(19, 22);
            this.lerrores.TabIndex = 7;
            this.lerrores.Text = "0";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnReiniciar.Location = new System.Drawing.Point(221, 226);
            this.btnReiniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(110, 19);
            this.btnReiniciar.TabIndex = 9;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // laciertos
            // 
            this.laciertos.AutoSize = true;
            this.laciertos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.laciertos.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laciertos.ForeColor = System.Drawing.SystemColors.Window;
            this.laciertos.Location = new System.Drawing.Point(124, 298);
            this.laciertos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.laciertos.Name = "laciertos";
            this.laciertos.Size = new System.Drawing.Size(19, 22);
            this.laciertos.TabIndex = 2;
            this.laciertos.Text = "0";
            // 
            // lnivel
            // 
            this.lnivel.AutoSize = true;
            this.lnivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnivel.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnivel.ForeColor = System.Drawing.SystemColors.Window;
            this.lnivel.Location = new System.Drawing.Point(124, 271);
            this.lnivel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnivel.Name = "lnivel";
            this.lnivel.Size = new System.Drawing.Size(19, 22);
            this.lnivel.TabIndex = 3;
            this.lnivel.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(21, 323);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Errores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(21, 296);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Aciertos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(21, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Nivel";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // lturno
            // 
            this.lturno.AutoSize = true;
            this.lturno.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lturno.ForeColor = System.Drawing.SystemColors.Window;
            this.lturno.Location = new System.Drawing.Point(181, 70);
            this.lturno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lturno.Name = "lturno";
            this.lturno.Size = new System.Drawing.Size(148, 20);
            this.lturno.TabIndex = 9;
            this.lturno.Text = "Turno de: Jugador1";
            this.lturno.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClasificacion.Location = new System.Drawing.Point(221, 193);
            this.btnClasificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.Size = new System.Drawing.Size(110, 19);
            this.btnClasificacion.TabIndex = 8;
            this.btnClasificacion.Text = "Ver Clasificación";
            this.btnClasificacion.UseVisualStyleBackColor = false;
            this.btnClasificacion.Click += new System.EventHandler(this.btnClasificacion_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAceptar.Font = new System.Drawing.Font("Book Antiqua", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(24, 181);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(184, 72);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // trespuesta
            // 
            this.trespuesta.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.trespuesta.Location = new System.Drawing.Point(256, 147);
            this.trespuesta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trespuesta.Name = "trespuesta";
            this.trespuesta.Size = new System.Drawing.Size(47, 20);
            this.trespuesta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Digite el resultado de la operacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(221, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(190, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "=";
            // 
            // lnum2
            // 
            this.lnum2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lnum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum2.Location = new System.Drawing.Point(124, 104);
            this.lnum2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnum2.Name = "lnum2";
            this.lnum2.Size = new System.Drawing.Size(38, 19);
            this.lnum2.TabIndex = 3;
            // 
            // lop
            // 
            this.lop.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lop.Location = new System.Drawing.Point(83, 104);
            this.lop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lop.Name = "lop";
            this.lop.Size = new System.Drawing.Size(22, 19);
            this.lop.TabIndex = 2;
            // 
            // lnum1
            // 
            this.lnum1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lnum1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnum1.Location = new System.Drawing.Point(28, 104);
            this.lnum1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnum1.Name = "lnum1";
            this.lnum1.Size = new System.Drawing.Size(38, 19);
            this.lnum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "OPERACION:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 540);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lnum2;
        private System.Windows.Forms.Label lop;
        private System.Windows.Forms.Label lnum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox trespuesta;
        private System.Windows.Forms.Label laciertos;
        private System.Windows.Forms.Label lnivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lerrores;
        private System.Windows.Forms.Label lturno;
        private System.Windows.Forms.Button btnClasificacion;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

