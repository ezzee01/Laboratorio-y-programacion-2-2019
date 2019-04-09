namespace Clase_6
{
  partial class frmRegistro
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
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblYahoo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.chkDireccionActual = new System.Windows.Forms.CheckBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cmbNumeroInicial = new System.Windows.Forms.ComboBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.grbSexo = new System.Windows.Forms.GroupBox();
            this.rdbOtros = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.lblDescripcionContra = new System.Windows.Forms.Label();
            this.lblErrorNumero = new System.Windows.Forms.Label();
            this.lblErrorContraseña = new System.Windows.Forms.Label();
            this.lblErrorDireccion = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.grbSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnContinuar.Location = new System.Drawing.Point(31, 362);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(272, 47);
            this.btnContinuar.TabIndex = 13;
            this.btnContinuar.Text = "&Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblTitulo.Location = new System.Drawing.Point(99, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(137, 29);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Registrarse";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSubTitulo.Location = new System.Drawing.Point(28, 38);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(282, 18);
            this.lblSubTitulo.TabIndex = 3;
            this.lblSubTitulo.Text = "Crear una dirección de correo electrónico";
            this.lblSubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSubTitulo.Click += new System.EventHandler(this.lblSubTitulo_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleDescription = "";
            this.txtNombre.AccessibleName = "";
            this.txtNombre.Location = new System.Drawing.Point(31, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "";
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(203, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNombre.Enabled = false;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNombre.Location = new System.Drawing.Point(36, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 15);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Enabled = false;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblApellido.Location = new System.Drawing.Point(209, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(29, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(187, 20);
            this.txtDireccion.TabIndex = 3;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblYahoo
            // 
            this.lblYahoo.AutoSize = true;
            this.lblYahoo.BackColor = System.Drawing.SystemColors.Control;
            this.lblYahoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblYahoo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblYahoo.Location = new System.Drawing.Point(219, 116);
            this.lblYahoo.Name = "lblYahoo";
            this.lblYahoo.Size = new System.Drawing.Size(91, 17);
            this.lblYahoo.TabIndex = 9;
            this.lblYahoo.Text = "@yahoo.com";
            this.lblYahoo.Click += new System.EventHandler(this.lblYahoo_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDireccion.Enabled = false;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDireccion.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblDireccion.Location = new System.Drawing.Point(34, 117);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(117, 15);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección de correo ";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // chkDireccionActual
            // 
            this.chkDireccionActual.AutoSize = true;
            this.chkDireccionActual.Location = new System.Drawing.Point(31, 164);
            this.chkDireccionActual.Name = "chkDireccionActual";
            this.chkDireccionActual.Size = new System.Drawing.Size(276, 17);
            this.chkDireccionActual.TabIndex = 4;
            this.chkDireccionActual.Text = "Quiero usar mi direccíon actual de correo electrónico";
            this.chkDireccionActual.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContraseña.Enabled = false;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblContraseña.Location = new System.Drawing.Point(37, 194);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(70, 15);
            this.lblContraseña.TabIndex = 12;
            this.lblContraseña.Text = "Contraseña";
            this.lblContraseña.Click += new System.EventHandler(this.lblContraseña_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(32, 192);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // cmbNumeroInicial
            // 
            this.cmbNumeroInicial.DisplayMember = "+1";
            this.cmbNumeroInicial.FormattingEnabled = true;
            this.cmbNumeroInicial.Items.AddRange(new object[] {
            "+1",
            "+54"});
            this.cmbNumeroInicial.Location = new System.Drawing.Point(31, 238);
            this.cmbNumeroInicial.Name = "cmbNumeroInicial";
            this.cmbNumeroInicial.Size = new System.Drawing.Size(57, 21);
            this.cmbNumeroInicial.TabIndex = 6;
            this.cmbNumeroInicial.Text = "+1";
            this.cmbNumeroInicial.SelectedIndexChanged += new System.EventHandler(this.cmbNumeroInicial_SelectedIndexChanged);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumero.Enabled = false;
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblNumero.Location = new System.Drawing.Point(109, 241);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(93, 13);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Numero de celular";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(104, 239);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(199, 20);
            this.txtNumero.TabIndex = 7;
            this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.dtpFecha.Location = new System.Drawing.Point(31, 282);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(272, 21);
            this.dtpFecha.TabIndex = 8;
            this.dtpFecha.Value = new System.DateTime(2019, 4, 8, 21, 26, 26, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // grbSexo
            // 
            this.grbSexo.Controls.Add(this.rdbOtros);
            this.grbSexo.Controls.Add(this.rdbMasculino);
            this.grbSexo.Controls.Add(this.rdbFemenino);
            this.grbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.grbSexo.Location = new System.Drawing.Point(31, 309);
            this.grbSexo.Name = "grbSexo";
            this.grbSexo.Size = new System.Drawing.Size(272, 47);
            this.grbSexo.TabIndex = 9;
            this.grbSexo.TabStop = false;
            this.grbSexo.Text = "Sexo";
            this.grbSexo.Enter += new System.EventHandler(this.grbSexo_Enter);
            // 
            // rdbOtros
            // 
            this.rdbOtros.AutoSize = true;
            this.rdbOtros.Location = new System.Drawing.Point(216, 19);
            this.rdbOtros.Name = "rdbOtros";
            this.rdbOtros.Size = new System.Drawing.Size(54, 19);
            this.rdbOtros.TabIndex = 12;
            this.rdbOtros.TabStop = true;
            this.rdbOtros.Text = "Otros";
            this.rdbOtros.UseVisualStyleBackColor = true;
            this.rdbOtros.CheckedChanged += new System.EventHandler(this.rdbOtros_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(27, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(82, 19);
            this.rdbMasculino.TabIndex = 10;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(116, 19);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(81, 19);
            this.rdbFemenino.TabIndex = 11;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            this.rdbFemenino.CheckedChanged += new System.EventHandler(this.rdbFemenino_CheckedChanged);
            // 
            // lblDescripcionContra
            // 
            this.lblDescripcionContra.AutoSize = true;
            this.lblDescripcionContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescripcionContra.Location = new System.Drawing.Point(135, 194);
            this.lblDescripcionContra.Name = "lblDescripcionContra";
            this.lblDescripcionContra.Size = new System.Drawing.Size(111, 15);
            this.lblDescripcionContra.TabIndex = 16;
            this.lblDescripcionContra.Text = "6 o mas caracteres";
            // 
            // lblErrorNumero
            // 
            this.lblErrorNumero.AutoSize = true;
            this.lblErrorNumero.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorNumero.Location = new System.Drawing.Point(109, 262);
            this.lblErrorNumero.Name = "lblErrorNumero";
            this.lblErrorNumero.Size = new System.Drawing.Size(98, 13);
            this.lblErrorNumero.TabIndex = 17;
            this.lblErrorNumero.Text = "*Numero incorrecto";
            this.lblErrorNumero.Visible = false;
            this.lblErrorNumero.Click += new System.EventHandler(this.lblErrorNumero_Click);
            // 
            // lblErrorContraseña
            // 
            this.lblErrorContraseña.AutoSize = true;
            this.lblErrorContraseña.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorContraseña.Location = new System.Drawing.Point(37, 215);
            this.lblErrorContraseña.Name = "lblErrorContraseña";
            this.lblErrorContraseña.Size = new System.Drawing.Size(115, 13);
            this.lblErrorContraseña.TabIndex = 18;
            this.lblErrorContraseña.Text = "*Contraseña incorrecta";
            this.lblErrorContraseña.Visible = false;
            this.lblErrorContraseña.Click += new System.EventHandler(this.lblErrorContraseña_Click);
            // 
            // lblErrorDireccion
            // 
            this.lblErrorDireccion.AutoSize = true;
            this.lblErrorDireccion.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorDireccion.Location = new System.Drawing.Point(37, 138);
            this.lblErrorDireccion.Name = "lblErrorDireccion";
            this.lblErrorDireccion.Size = new System.Drawing.Size(106, 13);
            this.lblErrorDireccion.TabIndex = 19;
            this.lblErrorDireccion.Text = "*Direccion incorrecta";
            this.lblErrorDireccion.Visible = false;
            this.lblErrorDireccion.Click += new System.EventHandler(this.lblErrorDireccion_Click);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorNombre.Location = new System.Drawing.Point(36, 91);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(98, 13);
            this.lblErrorNombre.TabIndex = 20;
            this.lblErrorNombre.Text = "*Nombre incorrecto";
            this.lblErrorNombre.Visible = false;
            this.lblErrorNombre.Click += new System.EventHandler(this.lblErrorNombre_Click);
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorApellido.Location = new System.Drawing.Point(209, 89);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(98, 13);
            this.lblErrorApellido.TabIndex = 21;
            this.lblErrorApellido.Text = "*Apellido incorrecto";
            this.lblErrorApellido.Visible = false;
            this.lblErrorApellido.Click += new System.EventHandler(this.lblErrorApellido_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 421);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorDireccion);
            this.Controls.Add(this.lblErrorContraseña);
            this.Controls.Add(this.lblErrorNumero);
            this.Controls.Add(this.lblDescripcionContra);
            this.Controls.Add(this.grbSexo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cmbNumeroInicial);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.chkDireccionActual);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblYahoo);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnContinuar);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.grbSexo.ResumeLayout(false);
            this.grbSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnContinuar;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label lblSubTitulo;
    private System.Windows.Forms.TextBox txtNombre;
    private System.Windows.Forms.TextBox txtApellido;
    private System.Windows.Forms.Label lblNombre;
    private System.Windows.Forms.Label lblApellido;
    private System.Windows.Forms.TextBox txtDireccion;
    private System.Windows.Forms.Label lblYahoo;
    private System.Windows.Forms.Label lblDireccion;
    private System.Windows.Forms.CheckBox chkDireccionActual;
    private System.Windows.Forms.Label lblContraseña;
    private System.Windows.Forms.TextBox txtContraseña;
    private System.Windows.Forms.ComboBox cmbNumeroInicial;
    private System.Windows.Forms.Label lblNumero;
    private System.Windows.Forms.TextBox txtNumero;
    private System.Windows.Forms.DateTimePicker dtpFecha;
    private System.Windows.Forms.GroupBox grbSexo;
    private System.Windows.Forms.RadioButton rdbOtros;
    private System.Windows.Forms.RadioButton rdbMasculino;
    private System.Windows.Forms.RadioButton rdbFemenino;
    private System.Windows.Forms.Label lblDescripcionContra;
    private System.Windows.Forms.Label lblErrorNumero;
    private System.Windows.Forms.Label lblErrorContraseña;
    private System.Windows.Forms.Label lblErrorDireccion;
    private System.Windows.Forms.Label lblErrorNombre;
    private System.Windows.Forms.Label lblErrorApellido;
  }
}

