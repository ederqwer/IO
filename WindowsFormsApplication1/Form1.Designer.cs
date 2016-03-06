namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ragrupado = new System.Windows.Forms.RadioButton();
            this.rnagrupado = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rcuadrada = new System.Windows.Forms.RadioButton();
            this.rgorov = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rpoisson = new System.Windows.Forms.RadioButton();
            this.rexponencial = new System.Windows.Forms.RadioButton();
            this.rnormal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdiscretos = new System.Windows.Forms.RadioButton();
            this.rcontinuos = new System.Windows.Forms.RadioButton();
            this.table = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ragrupado);
            this.groupBox1.Controls.Add(this.rnagrupado);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 71);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // ragrupado
            // 
            this.ragrupado.AutoSize = true;
            this.ragrupado.Checked = true;
            this.ragrupado.Location = new System.Drawing.Point(6, 19);
            this.ragrupado.Name = "ragrupado";
            this.ragrupado.Size = new System.Drawing.Size(76, 17);
            this.ragrupado.TabIndex = 0;
            this.ragrupado.TabStop = true;
            this.ragrupado.Text = "Agrupados";
            this.ragrupado.UseVisualStyleBackColor = true;
            // 
            // rnagrupado
            // 
            this.rnagrupado.AutoSize = true;
            this.rnagrupado.Location = new System.Drawing.Point(6, 42);
            this.rnagrupado.Name = "rnagrupado";
            this.rnagrupado.Size = new System.Drawing.Size(92, 17);
            this.rnagrupado.TabIndex = 1;
            this.rnagrupado.TabStop = true;
            this.rnagrupado.Text = "No agrupados";
            this.rnagrupado.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rcuadrada);
            this.groupBox4.Controls.Add(this.rgorov);
            this.groupBox4.Location = new System.Drawing.Point(12, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 70);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bondad de ajuste";
            // 
            // rcuadrada
            // 
            this.rcuadrada.AutoSize = true;
            this.rcuadrada.Checked = true;
            this.rcuadrada.Location = new System.Drawing.Point(6, 19);
            this.rcuadrada.Name = "rcuadrada";
            this.rcuadrada.Size = new System.Drawing.Size(81, 17);
            this.rcuadrada.TabIndex = 13;
            this.rcuadrada.TabStop = true;
            this.rcuadrada.Text = "Ji-Cuadrada";
            this.rcuadrada.UseVisualStyleBackColor = true;
            // 
            // rgorov
            // 
            this.rgorov.AutoSize = true;
            this.rgorov.Location = new System.Drawing.Point(6, 42);
            this.rgorov.Name = "rgorov";
            this.rgorov.Size = new System.Drawing.Size(80, 17);
            this.rgorov.TabIndex = 14;
            this.rgorov.TabStop = true;
            this.rgorov.Text = "kolmogorov";
            this.rgorov.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rpoisson);
            this.groupBox3.Controls.Add(this.rexponencial);
            this.groupBox3.Controls.Add(this.rnormal);
            this.groupBox3.Location = new System.Drawing.Point(12, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Distribución";
            // 
            // rpoisson
            // 
            this.rpoisson.AutoSize = true;
            this.rpoisson.Checked = true;
            this.rpoisson.Location = new System.Drawing.Point(6, 19);
            this.rpoisson.Name = "rpoisson";
            this.rpoisson.Size = new System.Drawing.Size(62, 17);
            this.rpoisson.TabIndex = 7;
            this.rpoisson.TabStop = true;
            this.rpoisson.Text = "Poisson";
            this.rpoisson.UseVisualStyleBackColor = true;
            // 
            // rexponencial
            // 
            this.rexponencial.AutoSize = true;
            this.rexponencial.Location = new System.Drawing.Point(6, 42);
            this.rexponencial.Name = "rexponencial";
            this.rexponencial.Size = new System.Drawing.Size(83, 17);
            this.rexponencial.TabIndex = 8;
            this.rexponencial.TabStop = true;
            this.rexponencial.Text = "Exponencial";
            this.rexponencial.UseVisualStyleBackColor = true;
            // 
            // rnormal
            // 
            this.rnormal.AutoSize = true;
            this.rnormal.Location = new System.Drawing.Point(6, 65);
            this.rnormal.Name = "rnormal";
            this.rnormal.Size = new System.Drawing.Size(58, 17);
            this.rnormal.TabIndex = 9;
            this.rnormal.TabStop = true;
            this.rnormal.Text = "Normal";
            this.rnormal.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdiscretos);
            this.groupBox2.Controls.Add(this.rcontinuos);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 72);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de datos";
            // 
            // rdiscretos
            // 
            this.rdiscretos.AutoSize = true;
            this.rdiscretos.Checked = true;
            this.rdiscretos.Location = new System.Drawing.Point(6, 19);
            this.rdiscretos.Name = "rdiscretos";
            this.rdiscretos.Size = new System.Drawing.Size(69, 17);
            this.rdiscretos.TabIndex = 3;
            this.rdiscretos.TabStop = true;
            this.rdiscretos.Text = "Discretos";
            this.rdiscretos.UseVisualStyleBackColor = true;
            // 
            // rcontinuos
            // 
            this.rcontinuos.AutoSize = true;
            this.rcontinuos.Location = new System.Drawing.Point(6, 42);
            this.rcontinuos.Name = "rcontinuos";
            this.rcontinuos.Size = new System.Drawing.Size(72, 17);
            this.rcontinuos.TabIndex = 4;
            this.rcontinuos.TabStop = true;
            this.rcontinuos.Text = "Continuos";
            this.rcontinuos.UseVisualStyleBackColor = true;
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.fi});
            this.table.Location = new System.Drawing.Point(172, 12);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(644, 291);
            this.table.TabIndex = 22;
            // 
            // x
            // 
            this.x.HeaderText = "x";
            this.x.Name = "x";
            // 
            // fi
            // 
            this.fi.HeaderText = "fi";
            this.fi.Name = "fi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "α%";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(436, 319);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "5";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(663, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "gl = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "E ( x ) =";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(744, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 351);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.table);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ragrupado;
        private System.Windows.Forms.RadioButton rnagrupado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rcuadrada;
        private System.Windows.Forms.RadioButton rgorov;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rpoisson;
        private System.Windows.Forms.RadioButton rexponencial;
        private System.Windows.Forms.RadioButton rnormal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdiscretos;
        private System.Windows.Forms.RadioButton rcontinuos;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn fi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

