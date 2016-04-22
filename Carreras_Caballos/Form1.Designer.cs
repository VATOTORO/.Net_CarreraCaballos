namespace Carreras_Caballos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelCarrera = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.comboBoxCaballo = new System.Windows.Forms.ComboBox();
            this.labelSaldoTotal = new System.Windows.Forms.Label();
            this.labelApuesta = new System.Windows.Forms.Label();
            this.textBoxApuesta = new System.Windows.Forms.TextBox();
            this.labelSelectCaballo = new System.Windows.Forms.Label();
            this.botonIniciar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxBase = new System.Windows.Forms.ComboBox();
            this.labelBase = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelCarrera
            // 
            this.panelCarrera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCarrera.BackgroundImage")));
            this.panelCarrera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCarrera.Location = new System.Drawing.Point(12, 12);
            this.panelCarrera.Name = "panelCarrera";
            this.panelCarrera.Size = new System.Drawing.Size(917, 353);
            this.panelCarrera.TabIndex = 0;
            this.panelCarrera.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCarrera_Paint);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(967, 36);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(154, 21);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "SALDO TOTAL";
            this.labelTotal.Visible = false;
            // 
            // comboBoxCaballo
            // 
            this.comboBoxCaballo.AccessibleName = "";
            this.comboBoxCaballo.FormattingEnabled = true;
            this.comboBoxCaballo.Items.AddRange(new object[] {
            "SELECCIONAR",
            "Caballo 1",
            "Caballo 2",
            "Caballo 3",
            "Caballo 4"});
            this.comboBoxCaballo.Location = new System.Drawing.Point(990, 266);
            this.comboBoxCaballo.Name = "comboBoxCaballo";
            this.comboBoxCaballo.Size = new System.Drawing.Size(107, 21);
            this.comboBoxCaballo.TabIndex = 2;
            this.comboBoxCaballo.Visible = false;
            // 
            // labelSaldoTotal
            // 
            this.labelSaldoTotal.AutoSize = true;
            this.labelSaldoTotal.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoTotal.Location = new System.Drawing.Point(1010, 75);
            this.labelSaldoTotal.Name = "labelSaldoTotal";
            this.labelSaldoTotal.Size = new System.Drawing.Size(59, 19);
            this.labelSaldoTotal.TabIndex = 3;
            this.labelSaldoTotal.Text = "$5000";
            this.labelSaldoTotal.Visible = false;
            // 
            // labelApuesta
            // 
            this.labelApuesta.AutoSize = true;
            this.labelApuesta.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApuesta.Location = new System.Drawing.Point(991, 124);
            this.labelApuesta.Name = "labelApuesta";
            this.labelApuesta.Size = new System.Drawing.Size(109, 21);
            this.labelApuesta.TabIndex = 4;
            this.labelApuesta.Text = "APUESTA";
            this.labelApuesta.Visible = false;
            // 
            // textBoxApuesta
            // 
            this.textBoxApuesta.Location = new System.Drawing.Point(993, 173);
            this.textBoxApuesta.Name = "textBoxApuesta";
            this.textBoxApuesta.Size = new System.Drawing.Size(105, 20);
            this.textBoxApuesta.TabIndex = 5;
            this.textBoxApuesta.Visible = false;
            this.textBoxApuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApuesta_KeyPress);
            // 
            // labelSelectCaballo
            // 
            this.labelSelectCaballo.AutoSize = true;
            this.labelSelectCaballo.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectCaballo.Location = new System.Drawing.Point(963, 213);
            this.labelSelectCaballo.Name = "labelSelectCaballo";
            this.labelSelectCaballo.Size = new System.Drawing.Size(164, 19);
            this.labelSelectCaballo.TabIndex = 6;
            this.labelSelectCaballo.Text = "Seleccionar caballo";
            this.labelSelectCaballo.Visible = false;
            // 
            // botonIniciar
            // 
            this.botonIniciar.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonIniciar.Location = new System.Drawing.Point(937, 325);
            this.botonIniciar.Name = "botonIniciar";
            this.botonIniciar.Size = new System.Drawing.Size(211, 40);
            this.botonIniciar.TabIndex = 7;
            this.botonIniciar.Text = "Iniciar carrera";
            this.botonIniciar.UseVisualStyleBackColor = true;
            this.botonIniciar.Visible = false;
            this.botonIniciar.Click += new System.EventHandler(this.botonIniciar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Items.AddRange(new object[] {
            "5000",
            "10000",
            "20000",
            "30000",
            "40000",
            "50000"});
            this.comboBoxBase.Location = new System.Drawing.Point(981, 193);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBase.TabIndex = 8;
            this.comboBoxBase.SelectedIndexChanged += new System.EventHandler(this.comboBoxBase_SelectedIndexChanged);
            // 
            // labelBase
            // 
            this.labelBase.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBase.Location = new System.Drawing.Point(935, 128);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(214, 42);
            this.labelBase.TabIndex = 9;
            this.labelBase.Text = "Escoger saldo base para iniciar el juego";
            this.labelBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 377);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.comboBoxBase);
            this.Controls.Add(this.botonIniciar);
            this.Controls.Add(this.comboBoxCaballo);
            this.Controls.Add(this.labelSelectCaballo);
            this.Controls.Add(this.textBoxApuesta);
            this.Controls.Add(this.labelApuesta);
            this.Controls.Add(this.labelSaldoTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.panelCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCarrera;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ComboBox comboBoxCaballo;
        private System.Windows.Forms.Label labelSaldoTotal;
        private System.Windows.Forms.Label labelApuesta;
        private System.Windows.Forms.TextBox textBoxApuesta;
        private System.Windows.Forms.Label labelSelectCaballo;
        private System.Windows.Forms.Button botonIniciar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxBase;
        private System.Windows.Forms.Label labelBase;
    }
}

