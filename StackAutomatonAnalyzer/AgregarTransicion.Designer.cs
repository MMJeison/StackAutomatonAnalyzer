
namespace StackAutomatonAnalyzer
{
    partial class AgregarTransicion
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_SelecSimbolo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_AddSimbolo = new System.Windows.Forms.Button();
            this.cb_OpPila = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_SelecEstado = new System.Windows.Forms.ComboBox();
            this.cb_OpEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_OpEntrada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cb_SelecSimbolo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_AddSimbolo);
            this.panel1.Controls.Add(this.cb_OpPila);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 220);
            this.panel1.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 61);
            this.button3.TabIndex = 20;
            this.button3.Text = "Limpiar Simbolos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(176, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 43);
            this.label5.TabIndex = 19;
            this.label5.Text = "Selecciona un simbolo";
            // 
            // cb_SelecSimbolo
            // 
            this.cb_SelecSimbolo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelecSimbolo.FormattingEnabled = true;
            this.cb_SelecSimbolo.Location = new System.Drawing.Point(160, 70);
            this.cb_SelecSimbolo.Name = "cb_SelecSimbolo";
            this.cb_SelecSimbolo.Size = new System.Drawing.Size(121, 29);
            this.cb_SelecSimbolo.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(10, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 131);
            this.panel2.TabIndex = 17;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(3, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(98, 84);
            this.listBox1.TabIndex = 0;
            // 
            // btn_AddSimbolo
            // 
            this.btn_AddSimbolo.Location = new System.Drawing.Point(160, 109);
            this.btn_AddSimbolo.Name = "btn_AddSimbolo";
            this.btn_AddSimbolo.Size = new System.Drawing.Size(121, 32);
            this.btn_AddSimbolo.TabIndex = 16;
            this.btn_AddSimbolo.Text = "Add Simbolo";
            this.btn_AddSimbolo.UseVisualStyleBackColor = true;
            this.btn_AddSimbolo.Click += new System.EventHandler(this.btn_AddSimbolo_Click);
            // 
            // cb_OpPila
            // 
            this.cb_OpPila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OpPila.FormattingEnabled = true;
            this.cb_OpPila.Location = new System.Drawing.Point(9, 34);
            this.cb_OpPila.Name = "cb_OpPila";
            this.cb_OpPila.Size = new System.Drawing.Size(121, 29);
            this.cb_OpPila.TabIndex = 15;
            this.cb_OpPila.SelectedIndexChanged += new System.EventHandler(this.cb_OpPila_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Operacion sobre la pila";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cb_SelecEstado);
            this.panel3.Controls.Add(this.cb_OpEstado);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(327, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 158);
            this.panel3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Selecciona un estado";
            // 
            // cb_SelecEstado
            // 
            this.cb_SelecEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_SelecEstado.FormattingEnabled = true;
            this.cb_SelecEstado.Location = new System.Drawing.Point(39, 114);
            this.cb_SelecEstado.Name = "cb_SelecEstado";
            this.cb_SelecEstado.Size = new System.Drawing.Size(126, 29);
            this.cb_SelecEstado.TabIndex = 14;
            // 
            // cb_OpEstado
            // 
            this.cb_OpEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OpEstado.FormattingEnabled = true;
            this.cb_OpEstado.Location = new System.Drawing.Point(39, 52);
            this.cb_OpEstado.Name = "cb_OpEstado";
            this.cb_OpEstado.Size = new System.Drawing.Size(126, 29);
            this.cb_OpEstado.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(42, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 12;
            this.label2.Text = "Operacion sobre el estado";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cb_OpEntrada);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(327, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 96);
            this.panel4.TabIndex = 14;
            // 
            // cb_OpEntrada
            // 
            this.cb_OpEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OpEntrada.FormattingEnabled = true;
            this.cb_OpEntrada.Location = new System.Drawing.Point(42, 50);
            this.cb_OpEntrada.Name = "cb_OpEntrada";
            this.cb_OpEntrada.Size = new System.Drawing.Size(121, 29);
            this.cb_OpEntrada.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(38, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 44);
            this.label3.TabIndex = 6;
            this.label3.Text = "Operacion sobre la entrada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Id: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 29);
            this.textBox1.TabIndex = 16;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // AgregarTransicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarTransicion";
            this.Size = new System.Drawing.Size(548, 338);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_SelecSimbolo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_AddSimbolo;
        private System.Windows.Forms.ComboBox cb_OpPila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_SelecEstado;
        private System.Windows.Forms.ComboBox cb_OpEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_OpEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}
