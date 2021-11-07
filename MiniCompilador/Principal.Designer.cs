namespace analizadorLexico
{
    partial class Principal
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtResLexico = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtErroresLexico = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSintactico = new System.Windows.Forms.DataGridView();
            this.lblArbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtErroresSemantico = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Pila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 54);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(540, 249);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpresion_KeyPress);
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresar.ForeColor = System.Drawing.Color.Maroon;
            this.lblIngresar.Location = new System.Drawing.Point(16, 21);
            this.lblIngresar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(258, 31);
            this.lblIngresar.TabIndex = 1;
            this.lblIngresar.Text = "Introduzca un codigo";
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnalizar.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnalizar.Location = new System.Drawing.Point(1007, 341);
            this.btnAnalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(144, 54);
            this.btnAnalizar.TabIndex = 2;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtResLexico
            // 
            this.txtResLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResLexico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtResLexico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResLexico.Location = new System.Drawing.Point(936, 57);
            this.txtResLexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResLexico.Multiline = true;
            this.txtResLexico.Name = "txtResLexico";
            this.txtResLexico.ReadOnly = true;
            this.txtResLexico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResLexico.Size = new System.Drawing.Size(289, 246);
            this.txtResLexico.TabIndex = 3;
            this.txtResLexico.TextChanged += new System.EventHandler(this.txtResLexico_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimpiar.Location = new System.Drawing.Point(1176, 341);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(144, 54);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtErroresLexico
            // 
            this.txtErroresLexico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErroresLexico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtErroresLexico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErroresLexico.Location = new System.Drawing.Point(1247, 54);
            this.txtErroresLexico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErroresLexico.Multiline = true;
            this.txtErroresLexico.Name = "txtErroresLexico";
            this.txtErroresLexico.ReadOnly = true;
            this.txtErroresLexico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErroresLexico.Size = new System.Drawing.Size(267, 249);
            this.txtErroresLexico.TabIndex = 6;
            this.txtErroresLexico.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.Maroon;
            this.lblResultado.Location = new System.Drawing.Point(1137, 25);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(213, 31);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Analizador Léxico";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, -219);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Analizador Sintáctico";
            // 
            // dgvSintactico
            // 
            this.dgvSintactico.AllowUserToAddRows = false;
            this.dgvSintactico.AllowUserToDeleteRows = false;
            this.dgvSintactico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSintactico.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSintactico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSintactico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pila,
            this.Entrada,
            this.Salida});
            this.dgvSintactico.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSintactico.Location = new System.Drawing.Point(579, 396);
            this.dgvSintactico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSintactico.Name = "dgvSintactico";
            this.dgvSintactico.RowHeadersWidth = 50;
            this.dgvSintactico.Size = new System.Drawing.Size(947, 302);
            this.dgvSintactico.TabIndex = 12;
            // 
            // lblArbol
            // 
            this.lblArbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArbol.AutoSize = true;
            this.lblArbol.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArbol.ForeColor = System.Drawing.Color.Maroon;
            this.lblArbol.Location = new System.Drawing.Point(8, 361);
            this.lblArbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArbol.Name = "lblArbol";
            this.lblArbol.Size = new System.Drawing.Size(229, 31);
            this.lblArbol.TabIndex = 14;
            this.lblArbol.Text = "Codigo Intermedio";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(587, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Analizador Semantico";
            // 
            // txtErroresSemantico
            // 
            this.txtErroresSemantico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtErroresSemantico.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtErroresSemantico.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtErroresSemantico.Location = new System.Drawing.Point(579, 57);
            this.txtErroresSemantico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtErroresSemantico.Multiline = true;
            this.txtErroresSemantico.Name = "txtErroresSemantico";
            this.txtErroresSemantico.ReadOnly = true;
            this.txtErroresSemantico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtErroresSemantico.Size = new System.Drawing.Size(310, 246);
            this.txtErroresSemantico.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsTab = true;
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(13, 396);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(552, 309);
            this.textBox2.TabIndex = 17;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(245, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generar Codigo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(587, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Analizador Sintantico";
            // 
            // Pila
            // 
            this.Pila.HeaderText = "Nodo";
            this.Pila.MaxInputLength = 32;
            this.Pila.MinimumWidth = 6;
            this.Pila.Name = "Pila";
            this.Pila.Width = 350;
            // 
            // Entrada
            // 
            this.Entrada.HeaderText = "Ingreso";
            this.Entrada.MinimumWidth = 6;
            this.Entrada.Name = "Entrada";
            this.Entrada.Width = 125;
            // 
            // Salida
            // 
            this.Salida.HeaderText = "Escape";
            this.Salida.MinimumWidth = 6;
            this.Salida.Name = "Salida";
            this.Salida.Width = 125;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1924, 815);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtErroresSemantico);
            this.Controls.Add(this.lblArbol);
            this.Controls.Add(this.dgvSintactico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtErroresLexico);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResLexico);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Principal";
            this.Text = "Compilador";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSintactico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtResLexico;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtErroresLexico;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSintactico;
        private System.Windows.Forms.Label lblArbol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtErroresSemantico;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salida;
    }
}

