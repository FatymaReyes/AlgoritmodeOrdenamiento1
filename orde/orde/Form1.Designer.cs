namespace orde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSeleccion = new System.Windows.Forms.Button();
            this.BtnBurbuja = new System.Windows.Forms.Button();
            this.BtnInsercion = new System.Windows.Forms.Button();
            this.BtnCombinacion = new System.Windows.Forms.Button();
            this.BtnRapida = new System.Windows.Forms.Button();
            this.BtnMonton = new System.Windows.Forms.Button();
            this.BtnBinaria = new System.Windows.Forms.Button();
            this.BtnLineal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(210, 54);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(282, 22);
            this.TextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agrega los nùmeros:";
            // 
            // BtnSeleccion
            // 
            this.BtnSeleccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccion.ForeColor = System.Drawing.Color.Black;
            this.BtnSeleccion.Location = new System.Drawing.Point(532, 94);
            this.BtnSeleccion.Name = "BtnSeleccion";
            this.BtnSeleccion.Size = new System.Drawing.Size(174, 35);
            this.BtnSeleccion.TabIndex = 2;
            this.BtnSeleccion.Text = "Selection sort";
            this.BtnSeleccion.UseVisualStyleBackColor = true;
            this.BtnSeleccion.Click += new System.EventHandler(this.BtnSeleccion_Click_1);
            // 
            // BtnBurbuja
            // 
            this.BtnBurbuja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBurbuja.ForeColor = System.Drawing.Color.Black;
            this.BtnBurbuja.Location = new System.Drawing.Point(532, 134);
            this.BtnBurbuja.Name = "BtnBurbuja";
            this.BtnBurbuja.Size = new System.Drawing.Size(174, 24);
            this.BtnBurbuja.TabIndex = 3;
            this.BtnBurbuja.Text = "Bubble sort";
            this.BtnBurbuja.UseVisualStyleBackColor = true;
            this.BtnBurbuja.Click += new System.EventHandler(this.BtnBurbuja_Click);
            // 
            // BtnInsercion
            // 
            this.BtnInsercion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInsercion.ForeColor = System.Drawing.Color.Black;
            this.BtnInsercion.Location = new System.Drawing.Point(537, 203);
            this.BtnInsercion.Name = "BtnInsercion";
            this.BtnInsercion.Size = new System.Drawing.Size(169, 31);
            this.BtnInsercion.TabIndex = 4;
            this.BtnInsercion.Text = "Insertion Sort";
            this.BtnInsercion.UseVisualStyleBackColor = true;
            this.BtnInsercion.Click += new System.EventHandler(this.BtnInsercion_Click);
            // 
            // BtnCombinacion
            // 
            this.BtnCombinacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCombinacion.ForeColor = System.Drawing.Color.Black;
            this.BtnCombinacion.Location = new System.Drawing.Point(532, 164);
            this.BtnCombinacion.Name = "BtnCombinacion";
            this.BtnCombinacion.Size = new System.Drawing.Size(174, 33);
            this.BtnCombinacion.TabIndex = 5;
            this.BtnCombinacion.Text = "Marge sort";
            this.BtnCombinacion.UseVisualStyleBackColor = true;
            this.BtnCombinacion.Click += new System.EventHandler(this.BtnCombinacion_Click);
            // 
            // BtnRapida
            // 
            this.BtnRapida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRapida.ForeColor = System.Drawing.Color.Black;
            this.BtnRapida.Location = new System.Drawing.Point(537, 240);
            this.BtnRapida.Name = "BtnRapida";
            this.BtnRapida.Size = new System.Drawing.Size(169, 30);
            this.BtnRapida.TabIndex = 6;
            this.BtnRapida.Text = "Quick Sort";
            this.BtnRapida.UseVisualStyleBackColor = true;
            this.BtnRapida.Click += new System.EventHandler(this.BtnRapida_Click);
            // 
            // BtnMonton
            // 
            this.BtnMonton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonton.ForeColor = System.Drawing.Color.Black;
            this.BtnMonton.Location = new System.Drawing.Point(532, 54);
            this.BtnMonton.Name = "BtnMonton";
            this.BtnMonton.Size = new System.Drawing.Size(174, 34);
            this.BtnMonton.TabIndex = 7;
            this.BtnMonton.Text = "Heap Sort";
            this.BtnMonton.UseVisualStyleBackColor = true;
            this.BtnMonton.Click += new System.EventHandler(this.BtnMonton_Click);
            // 
            // BtnBinaria
            // 
            this.BtnBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBinaria.Location = new System.Drawing.Point(-2, 90);
            this.BtnBinaria.Name = "BtnBinaria";
            this.BtnBinaria.Size = new System.Drawing.Size(158, 39);
            this.BtnBinaria.TabIndex = 8;
            this.BtnBinaria.Text = "Busqueda Binaria";
            this.BtnBinaria.UseVisualStyleBackColor = true;
            this.BtnBinaria.Click += new System.EventHandler(this.BtnBinaria_Click);
            // 
            // BtnLineal
            // 
            this.BtnLineal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLineal.Location = new System.Drawing.Point(-2, 54);
            this.BtnLineal.Name = "BtnLineal";
            this.BtnLineal.Size = new System.Drawing.Size(161, 30);
            this.BtnLineal.TabIndex = 9;
            this.BtnLineal.Text = "Busqueda Lineal";
            this.BtnLineal.UseVisualStyleBackColor = true;
            this.BtnLineal.Click += new System.EventHandler(this.BtnLineal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de Ordenamineto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Metodo de Busqueda:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 287);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(718, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnLineal);
            this.Controls.Add(this.BtnBinaria);
            this.Controls.Add(this.BtnMonton);
            this.Controls.Add(this.BtnRapida);
            this.Controls.Add(this.BtnCombinacion);
            this.Controls.Add(this.BtnInsercion);
            this.Controls.Add(this.BtnBurbuja);
            this.Controls.Add(this.BtnSeleccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox1);
            this.Name = "Form1";
            this.Text = "Trabajo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSeleccion;
        private System.Windows.Forms.Button BtnBurbuja;
        private System.Windows.Forms.Button BtnInsercion;
        private System.Windows.Forms.Button BtnCombinacion;
        private System.Windows.Forms.Button BtnRapida;
        private System.Windows.Forms.Button BtnMonton;
        private System.Windows.Forms.Button BtnBinaria;
        private System.Windows.Forms.Button BtnLineal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

