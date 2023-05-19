namespace GestionInventario.Vista
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.labelRut = new System.Windows.Forms.Label();
            this.labelContra = new System.Windows.Forms.Label();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtRut
            // 
            this.txtRut.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRut.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRut.Location = new System.Drawing.Point(177, 95);
            this.txtRut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(135, 28);
            this.txtRut.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(177, 156);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(135, 28);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // labelRut
            // 
            this.labelRut.AutoSize = true;
            this.labelRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRut.Location = new System.Drawing.Point(113, 98);
            this.labelRut.Name = "labelRut";
            this.labelRut.Size = new System.Drawing.Size(43, 24);
            this.labelRut.TabIndex = 2;
            this.labelRut.Text = "Rut:";
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContra.Location = new System.Drawing.Point(45, 164);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(111, 24);
            this.labelContra.TabIndex = 3;
            this.labelContra.Text = "Contraseña:";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(177, 252);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(136, 37);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(49, 252);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 37);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(127, 210);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 26);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Mostrar contraseña";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 331);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.labelContra);
            this.Controls.Add(this.labelRut);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtRut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label labelRut;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}