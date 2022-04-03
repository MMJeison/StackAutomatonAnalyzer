
namespace StackAutomatonAnalyzer
{
    partial class IngresarDatosIniciales
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_SimbEntrada = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_SimbPila = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_Estados = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb_ConfgPila = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_SelecEstadoInicial = new System.Windows.Forms.ComboBox();
            this.btn_AgrSimbEntrada = new System.Windows.Forms.Button();
            this.btn_AgrSimbPila = new System.Windows.Forms.Button();
            this.btn_AgrEstado = new System.Windows.Forms.Button();
            this.btn_AgrSimbConfg = new System.Windows.Forms.Button();
            this.btn_ElimSimbEntrada = new System.Windows.Forms.Button();
            this.btn_ElimSimbPila = new System.Windows.Forms.Button();
            this.btn_ElimEstado = new System.Windows.Forms.Button();
            this.btn_ElimSimbConfg = new System.Windows.Forms.Button();
            this.btn_Continuar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_SimbEntrada);
            this.panel1.Location = new System.Drawing.Point(51, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 208);
            this.panel1.TabIndex = 0;
            // 
            // lb_SimbEntrada
            // 
            this.lb_SimbEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_SimbEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SimbEntrada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_SimbEntrada.FormattingEnabled = true;
            this.lb_SimbEntrada.ItemHeight = 25;
            this.lb_SimbEntrada.Location = new System.Drawing.Point(0, 0);
            this.lb_SimbEntrada.Name = "lb_SimbEntrada";
            this.lb_SimbEntrada.Size = new System.Drawing.Size(128, 206);
            this.lb_SimbEntrada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simbolos de entrada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simbolos en la pila";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_SimbPila);
            this.panel2.Location = new System.Drawing.Point(226, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 208);
            this.panel2.TabIndex = 2;
            // 
            // lb_SimbPila
            // 
            this.lb_SimbPila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_SimbPila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SimbPila.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_SimbPila.FormattingEnabled = true;
            this.lb_SimbPila.ItemHeight = 25;
            this.lb_SimbPila.Location = new System.Drawing.Point(0, 0);
            this.lb_SimbPila.Name = "lb_SimbPila";
            this.lb_SimbPila.Size = new System.Drawing.Size(128, 206);
            this.lb_SimbPila.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_Estados);
            this.panel3.Location = new System.Drawing.Point(393, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 165);
            this.panel3.TabIndex = 4;
            // 
            // lb_Estados
            // 
            this.lb_Estados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_Estados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Estados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Estados.FormattingEnabled = true;
            this.lb_Estados.ItemHeight = 25;
            this.lb_Estados.Location = new System.Drawing.Point(0, 0);
            this.lb_Estados.Name = "lb_Estados";
            this.lb_Estados.Size = new System.Drawing.Size(128, 163);
            this.lb_Estados.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(378, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lb_ConfgPila);
            this.panel4.Location = new System.Drawing.Point(572, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(130, 174);
            this.panel4.TabIndex = 6;
            // 
            // lb_ConfgPila
            // 
            this.lb_ConfgPila.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_ConfgPila.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ConfgPila.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ConfgPila.FormattingEnabled = true;
            this.lb_ConfgPila.ItemHeight = 25;
            this.lb_ConfgPila.Location = new System.Drawing.Point(0, 0);
            this.lb_ConfgPila.Name = "lb_ConfgPila";
            this.lb_ConfgPila.Size = new System.Drawing.Size(128, 172);
            this.lb_ConfgPila.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(557, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 55);
            this.label4.TabIndex = 5;
            this.label4.Text = "Configuracion inicial de la pila";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(378, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 55);
            this.label5.TabIndex = 7;
            this.label5.Text = "Seleccionar estado inicial";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_SelecEstadoInicial
            // 
            this.cb_SelecEstadoInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelecEstadoInicial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_SelecEstadoInicial.FormattingEnabled = true;
            this.cb_SelecEstadoInicial.Location = new System.Drawing.Point(392, 304);
            this.cb_SelecEstadoInicial.MaxDropDownItems = 4;
            this.cb_SelecEstadoInicial.Name = "cb_SelecEstadoInicial";
            this.cb_SelecEstadoInicial.Size = new System.Drawing.Size(130, 29);
            this.cb_SelecEstadoInicial.TabIndex = 8;
            this.cb_SelecEstadoInicial.SelectedIndexChanged += new System.EventHandler(this.cb_SelecEstadoInicial_SelectedIndexChanged);
            // 
            // btn_AgrSimbEntrada
            // 
            this.btn_AgrSimbEntrada.Location = new System.Drawing.Point(51, 346);
            this.btn_AgrSimbEntrada.Name = "btn_AgrSimbEntrada";
            this.btn_AgrSimbEntrada.Size = new System.Drawing.Size(130, 34);
            this.btn_AgrSimbEntrada.TabIndex = 9;
            this.btn_AgrSimbEntrada.Text = "Agregar";
            this.btn_AgrSimbEntrada.UseVisualStyleBackColor = true;
            this.btn_AgrSimbEntrada.Click += new System.EventHandler(this.btn_AgrSimbEntrada_Click);
            // 
            // btn_AgrSimbPila
            // 
            this.btn_AgrSimbPila.Location = new System.Drawing.Point(226, 346);
            this.btn_AgrSimbPila.Name = "btn_AgrSimbPila";
            this.btn_AgrSimbPila.Size = new System.Drawing.Size(130, 34);
            this.btn_AgrSimbPila.TabIndex = 10;
            this.btn_AgrSimbPila.Text = "Agregar";
            this.btn_AgrSimbPila.UseVisualStyleBackColor = true;
            this.btn_AgrSimbPila.Click += new System.EventHandler(this.btn_AgrSimbPila_Click);
            // 
            // btn_AgrEstado
            // 
            this.btn_AgrEstado.Location = new System.Drawing.Point(393, 346);
            this.btn_AgrEstado.Name = "btn_AgrEstado";
            this.btn_AgrEstado.Size = new System.Drawing.Size(130, 34);
            this.btn_AgrEstado.TabIndex = 11;
            this.btn_AgrEstado.Text = "Agregar";
            this.btn_AgrEstado.UseVisualStyleBackColor = true;
            this.btn_AgrEstado.Click += new System.EventHandler(this.btn_AgrEstado_Click);
            // 
            // btn_AgrSimbConfg
            // 
            this.btn_AgrSimbConfg.Location = new System.Drawing.Point(571, 267);
            this.btn_AgrSimbConfg.Name = "btn_AgrSimbConfg";
            this.btn_AgrSimbConfg.Size = new System.Drawing.Size(130, 34);
            this.btn_AgrSimbConfg.TabIndex = 12;
            this.btn_AgrSimbConfg.Text = "Agregar";
            this.btn_AgrSimbConfg.UseVisualStyleBackColor = true;
            this.btn_AgrSimbConfg.Click += new System.EventHandler(this.btn_AgrSimbConfg_Click);
            // 
            // btn_ElimSimbEntrada
            // 
            this.btn_ElimSimbEntrada.Location = new System.Drawing.Point(51, 386);
            this.btn_ElimSimbEntrada.Name = "btn_ElimSimbEntrada";
            this.btn_ElimSimbEntrada.Size = new System.Drawing.Size(130, 34);
            this.btn_ElimSimbEntrada.TabIndex = 13;
            this.btn_ElimSimbEntrada.Text = "Eliminar";
            this.btn_ElimSimbEntrada.UseVisualStyleBackColor = true;
            this.btn_ElimSimbEntrada.Click += new System.EventHandler(this.btn_ElimSimbEntrada_Click);
            // 
            // btn_ElimSimbPila
            // 
            this.btn_ElimSimbPila.Location = new System.Drawing.Point(226, 386);
            this.btn_ElimSimbPila.Name = "btn_ElimSimbPila";
            this.btn_ElimSimbPila.Size = new System.Drawing.Size(130, 34);
            this.btn_ElimSimbPila.TabIndex = 14;
            this.btn_ElimSimbPila.Text = "Eliminar";
            this.btn_ElimSimbPila.UseVisualStyleBackColor = true;
            this.btn_ElimSimbPila.Click += new System.EventHandler(this.btn_ElimSimbPila_Click);
            // 
            // btn_ElimEstado
            // 
            this.btn_ElimEstado.Location = new System.Drawing.Point(393, 386);
            this.btn_ElimEstado.Name = "btn_ElimEstado";
            this.btn_ElimEstado.Size = new System.Drawing.Size(130, 34);
            this.btn_ElimEstado.TabIndex = 15;
            this.btn_ElimEstado.Text = "Eliminar";
            this.btn_ElimEstado.UseVisualStyleBackColor = true;
            this.btn_ElimEstado.Click += new System.EventHandler(this.btn_ElimEstado_Click);
            // 
            // btn_ElimSimbConfg
            // 
            this.btn_ElimSimbConfg.Location = new System.Drawing.Point(571, 307);
            this.btn_ElimSimbConfg.Name = "btn_ElimSimbConfg";
            this.btn_ElimSimbConfg.Size = new System.Drawing.Size(130, 34);
            this.btn_ElimSimbConfg.TabIndex = 16;
            this.btn_ElimSimbConfg.Text = "Eliminar";
            this.btn_ElimSimbConfg.UseVisualStyleBackColor = true;
            this.btn_ElimSimbConfg.Click += new System.EventHandler(this.btn_ElimSimbConfg_Click);
            // 
            // btn_Continuar
            // 
            this.btn_Continuar.Location = new System.Drawing.Point(572, 386);
            this.btn_Continuar.Name = "btn_Continuar";
            this.btn_Continuar.Size = new System.Drawing.Size(130, 34);
            this.btn_Continuar.TabIndex = 17;
            this.btn_Continuar.Text = "Continuar";
            this.btn_Continuar.UseVisualStyleBackColor = true;
            this.btn_Continuar.Click += new System.EventHandler(this.btn_Continuar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cambiar Simbolo Fin De Secuencia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 49);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cambiar Simbolo Pila Vacia";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(571, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // IngresarDatosIniciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Continuar);
            this.Controls.Add(this.btn_ElimSimbConfg);
            this.Controls.Add(this.btn_ElimEstado);
            this.Controls.Add(this.btn_ElimSimbPila);
            this.Controls.Add(this.btn_ElimSimbEntrada);
            this.Controls.Add(this.btn_AgrSimbConfg);
            this.Controls.Add(this.btn_AgrEstado);
            this.Controls.Add(this.btn_AgrSimbPila);
            this.Controls.Add(this.btn_AgrSimbEntrada);
            this.Controls.Add(this.cb_SelecEstadoInicial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "IngresarDatosIniciales";
            this.Size = new System.Drawing.Size(750, 450);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_SelecEstadoInicial;
        private System.Windows.Forms.Button btn_AgrSimbEntrada;
        private System.Windows.Forms.Button btn_AgrSimbPila;
        private System.Windows.Forms.Button btn_AgrEstado;
        private System.Windows.Forms.Button btn_AgrSimbConfg;
        private System.Windows.Forms.Button btn_ElimSimbEntrada;
        private System.Windows.Forms.Button btn_ElimSimbPila;
        private System.Windows.Forms.Button btn_ElimEstado;
        private System.Windows.Forms.Button btn_ElimSimbConfg;
        private System.Windows.Forms.ListBox lb_SimbEntrada;
        private System.Windows.Forms.ListBox lb_SimbPila;
        private System.Windows.Forms.ListBox lb_Estados;
        private System.Windows.Forms.ListBox lb_ConfgPila;
        private System.Windows.Forms.Button btn_Continuar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
