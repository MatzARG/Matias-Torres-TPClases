using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico;

namespace Producto
{
    internal class Producto
    {
        // Constructor
        public Producto()
        {
            this._id = 0;
            this._descripcion = string.Empty;
            this._costo = 0;
            this._precioventa = 0;
            this._stock = 0;
            this._idusuario = 0;
            
        }

        public Producto(int id,
            string descripcion,
            float costo,
            float precioventa,
            int stock,
            int idusuario)
        {
            this._id = id;
            this._descripcion = descripcion;
            this._costo = costo;
            this._precioventa = precioventa;
            this._stock = stock;
            this._idusuario = idusuario;

        }



        // Atributos
        private int _id;
        private string _descripcion;
        private float _costo;
        private float _precioventa;
        private int _stock;
        private int _idusuario;
    }
}

public int id
{
    get
    {
        return this._id;
    }
    set
    {
        this._id = value;
    }
}

public string descripcion
{
    get
    {
        return this._descripcion;
    }
    set
    {
        this._descripcion = value;
    }
}

public float costo
{
    get
    {
        return this._costo;
    }
    set
    {
        this._costo = value;
    }
}

public float precioventa
{
    get
    {
        return this._precioventa;
    }
    set
    {
        this._precioventa = value;
    }
}

public int stock
{
    get
    {
        return this._stock;
    }
    set
    {
        this._stock = value;
    }
}

public int idusuario
{
    get
    {
        return this._idusuario;
    }
    set
    {
        this._idusuario = value;
    }
}

namespace Usuario
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

public int id
{
    get
    {
        return this._id;
    }
    set
    {
        this._id = value;
    }
}

public string mail
{
    get
    {
        return this._mail;
    }
    set
    {
        this._mail = value;
    }
}

public string contraseña
{
    get
    {
        return this._contraseña;
    }
    set
    {
        this._contraseña = value;
    }
}

public string nombreusuario
{
    get
    {
        return this._nombreusuario;
    }
    set
    {
        this._nombreusuario = value;
    }
}

public string apellido
{
    get
    {
        return this._apellido;
    }
    set
    {
        this._apellido = value;
    }
}

public string nombre
{
    get
    {
        return this._nombre;
    }
    set
    {
        this._nombre = value;
    }
}

namespace ProductoVendido
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

public int id
{
    get
    {
        return this._id;
    }
    set
    {
        this._id = value;
    }
}

public int idventa
{
    get
    {
        return this._idventa;
    }
    set
    {
        this._idventa = value;
    }
}

public int stock
{
    get
    {
        return this._stock;
    }
    set
    {
        this._stock = value;
    }
}

public int idproducto
{
    get
    {
        return this._idproducto;
    }
    set
    {
        this._idproducto = value;
    }
}

namespace Venta
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

public int id
{
    get
    {
        return this._id;
    }
    set
    {
        this._id = value;
    }
}

public int idusuario
{
    get
    {
        return this._idusuario;
    }
    set
    {
        this._idusuario = value;
    }
}

public string comentarios
{
    get
    {
        return this._comentarios;
    }
    set
    {
        this._comentarios = value;
    }
}




