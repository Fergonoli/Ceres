using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Producto
/// </summary>
public class Producto
{
    public String Nombre;
    public String Descripcion;
    public String Imagen;
    public float Precio;
    public int stock;
    public int identificador = 12;

    public Producto()
    {

    }

	public Producto(String nombre_e,String Descr, String imag, float prec, int sto, int ident)
	{
        Nombre = nombre_e;
        Descripcion = Descr;
        Imagen = imag;
        Precio = prec;
        stock = sto;
        identificador = ident;
	}

    /*
     * Devuelve un producto indicando su id. Si no existe la id, peta irremediablamente. 
     */
    public Producto(int id)
    {
        Producto a = devolverproducto(id);
        this.Nombre = a.Nombre;
        this.Descripcion = a.Descripcion;
        this.Imagen = a.Imagen;
        this.Precio = a.Precio;
        this.stock = a.stock;
        this.identificador = a.identificador;
    }

    static public bool existeProductoConIdTalQue(int id)
    {
        Almacenaje almacenaje = new Almacenaje();
        return (almacenaje.devuelveProductoPorId(id)!=null);
    }

    static public Producto devolverproducto(int id)
    {
        Almacenaje almacenaje = new Almacenaje();

        return almacenaje.devuelveProductoPorId(id);
    }

    //Sincroniza este producto para que existe en la B.D.
    public void sincronizaProductoConBaseDeDatos()
    {
        sincronizaProducto(this);
    }

    //Igual que el anterior, pero para cualquier objeto.
    public static void sincronizaProducto(Producto entrada)
    {
        Almacenaje almacenaje = new Almacenaje();
        if (existeProductoConIdTalQue(entrada.identificador))
            almacenaje.ActualizaProducto(entrada.Nombre, entrada.Descripcion, entrada.Imagen, entrada.Precio, entrada.stock, entrada.identificador);
        else
            almacenaje.InsertaProducto(entrada.identificador,entrada.Nombre, entrada.Descripcion, entrada.Imagen, entrada.Precio, entrada.stock);
    }
}