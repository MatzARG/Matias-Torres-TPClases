using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal class ProductoVendido
    {
        // Constructor
        public ProductoVendido()
        {
            this._id = 0;
            this._idproducto = 0;
            this._stock = 0;
            this._idventa = 0;
       

        }

        public ProductoVendido(int id,
            int idproducto,
            int stock,
            int idventa)
          
        {
            this._idproducto = idproducto;
            this._id = id;
            this._stock = stock;
            this._idventa = idventa;

        }



        // Atributos
        private int _idproducto;
        private int _stock;
        private int _idventa;
        private int _id;
    }
}
