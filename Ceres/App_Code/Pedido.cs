using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedido
/// </summary>
public class Pedido
{

    int idPedido;
    float precio;
    int idUsuario;
    public struct LP
    {
        public int noLinea;
        public int cantidad;
        public int idProducto;
    };
    public LP[] LineaPedido;


	public Pedido(int IDPEDIDO,float PRECIO, int IDUSUARIO, Pedido.LP[] pedidose)
	{
        idPedido = IDPEDIDO;
        precio = PRECIO;
        idUsuario = IDUSUARIO;
        LineaPedido = pedidose;
		
	}
}