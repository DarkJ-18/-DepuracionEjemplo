namespace DepuracionEjemplo
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
            this.label2 = new System.Windows.Forms.Label();
            this.lvnumeros = new System.Windows.Forms.ListView();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.lbvalores = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consecutivo con uso de ciclo Mientras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresa un valor";
            // 
            // lvnumeros
            // 
            this.lvnumeros.Location = new System.Drawing.Point(32, 122);
            this.lvnumeros.Name = "lvnumeros";
            this.lvnumeros.Size = new System.Drawing.Size(108, 236);
            this.lvnumeros.TabIndex = 2;
            this.lvnumeros.UseCompatibleStateImageBehavior = false;
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(148, 74);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(100, 20);
            this.txtnumero.TabIndex = 3;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnmostrar.Location = new System.Drawing.Point(189, 142);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 43);
            this.btnmostrar.TabIndex = 4;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // lbvalores
            // 
            this.lbvalores.FormattingEnabled = true;
            this.lbvalores.Location = new System.Drawing.Point(323, 122);
            this.lbvalores.Name = "lbvalores";
            this.lbvalores.Size = new System.Drawing.Size(108, 238);
            this.lbvalores.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(189, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Funcion Fibonacci";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbvalores);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.lvnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvnumeros;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.ListBox lbvalores;
        private System.Windows.Forms.Button button1;
    }
}

