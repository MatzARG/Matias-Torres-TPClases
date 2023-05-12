using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class Usuario
    {
        // Constructor
        public Usuario()
        {
            this._id = 0;
            this._nombre = string.Empty;
            this._apellido = string.Empty;
            this._nombreusuario = string.Empty;
            this._contraseña = string.Empty;
            this._mail = string.Empty;
           
        }

        public Usuario(int id,
            string nombre,
            string apellido,
            string nombreusuario,
            string contraseña,
            string mail)
        {
            this._nombre = nombre;
            this._id = id;
            this._apellido = apellido;
            this._nombreusuario = nombreusuario;
            this._contraseña = contraseña;
            this._mail = mail;
    
        }



        // Atributos
        private string _nombre;
        private string _apellido;
        private string _nombreusuario;
        private string _contraseña;
        private string _mail;
        private int _id;
    }
}

