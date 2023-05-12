using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class Venta
    {
        // Constructor
        public Venta()
        {
            this._id = 0;
            this._comentarios = string.Empty;
            this._idusuario = 0;
          
        }

        public Venta(int id,
            string comentarios,         
            int idusuario)

        {
            this._id = id;
            this._comentarios = comentarios;
            this._idusuario = idusuario;

        }



        // Atributos
        private string _comentarios;
        private int _idusuario;
        private int _id;
    }
}
