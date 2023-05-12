using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico;

namespace TrabajoPractico
{
    internal class Ropa
    {
        // Constructor
        public Ropa()
        {
            this._color = string.Empty;
            this._edad = 0;
            this._genero = string.Empty;
            this._material = string.Empty;
            this._producto = string.Empty;
            this._talle = string.Empty;
            this._capucha = false;
            this._modelocapucha = 0;
            this._id = 0;
            this._descripcion = string.Empty;
            this._costo = 0;
            this._precioventa = 0;
            this._stock = 0;
            this._idusuario = 0;
            
        }

        public Ropa(string color,
            string genero,
            string material,
            string producto,
            short edad,
            string talle,
            bool capucha,
            short modelocapucha,
            int id,
            string descripcion,
            float costo,
            float precioventa,
            int stock,
            int idusuario)
        {
            this._color = color;
            this._edad = edad;
            this._genero = genero;
            this._material = material;
            this._producto = producto;
            this._talle = talle;
            this._capucha = capucha;
            this._modelocapucha = modelocapucha;
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioventa = precioventa;
            this._stock = stock;
            this._idusuario = idusuario;

        }



        // Atributos
        private string _color;
        private string _talle;
        private string _producto;
        private string _material;
        private string _genero;
        private short _edad;
        private bool _capucha;
        private short _modelocapucha;
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioventa;
        private int _stock;
        private int _idusuario;




        public bool TieneCapuchas()
        {
            return _modelocapucha > 0;
        }
    }
}





