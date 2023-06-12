﻿using GestionInventario.Controlador;
using GestionInventario.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInventario.Vista
{
    public partial class LoginForm : Form, ILoginVista
    {
        private readonly LoginController _controlador;
        private User loggedUser;

        public User GetUser
        {
            get
            {
                return loggedUser;
            }
        }

        public LoginForm()
        {
            InitializeComponent();
            _controlador = new LoginController(this);
        }

        public string Rut
        {
            get { return txtRut.Text.Trim(); }
        }

        public string Contraseña
        {
            get { return txtContraseña.Text.Trim(); }
        }


        public void MostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimpiarCampos()
        {
            txtRut.Text = "";
            txtContraseña.Text = "";
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = txtRut.Text.Trim();
            string password = txtContraseña.Text.Trim();
            if(_controlador.IniciarSesion(username, password))
            {
                this.loggedUser = _controlador.GetUser;
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(loggedUser == null) Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           txtContraseña.UseSystemPasswordChar = !txtContraseña.UseSystemPasswordChar;
        }


    }

    public interface ILoginVista
    {
        string Rut { get; }
        string Contraseña { get; }

        void LimpiarCampos();
        void MostrarMensaje(string v);
    }
}
