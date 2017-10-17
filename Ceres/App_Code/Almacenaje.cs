using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Collections;

/// <summary>
/// Descripción breve de Almacenaje
/// </summary>
public class Almacenaje
{    
    DataSet1 DataSetLocal;
    DataSet1TableAdapters.UsuarioTableAdapter adaptadorUsuarios;
    DataSet1TableAdapters.RecetaTableAdapter adaptadorReceta;
    DataSet1TableAdapters.Receta_Confirmada1TableAdapter adaptadorRecetaConfirmada;
    DataSet1TableAdapters.ModeradorTableAdapter adaptadorModerador;
    DataSet1TableAdapters.Receta_A_ModificarTableAdapter adaptadorRecetaAModificar;
    DataSet1TableAdapters.AdministradorTableAdapter adaptadorAdministrador;
    DataSet1TableAdapters.EspecialistaTableAdapter adaptadorEspecialista;
    DataSet1TableAdapters.RestauranteTableAdapter adaptadorRestaurante;
    DataSet1TableAdapters.MensajeForoTableAdapter adaptadorForo;
    DataSet1TableAdapters.MensajePrivadoTableAdapter adaptadorMensajePrivado;
    DataSet1TableAdapters.QueriesTableAdapter adaptadorConsultas;
    DataSet1TableAdapters.ProductoTableAdapter adaptadorProductos;
    DataSet1TableAdapters.PedidoTableAdapter adaptadorPedidos;
    DataSet1TableAdapters.ComentarioTableAdapter adaptadorComentario;

	public Almacenaje()
	{        
        //Se instancian los elementos necesarios del dataset
        DataSetLocal = new DataSet1();
        adaptadorUsuarios = new DataSet1TableAdapters.UsuarioTableAdapter();
        adaptadorReceta = new DataSet1TableAdapters.RecetaTableAdapter();
        adaptadorRecetaConfirmada = new DataSet1TableAdapters.Receta_Confirmada1TableAdapter();
        adaptadorModerador = new DataSet1TableAdapters.ModeradorTableAdapter();
        adaptadorAdministrador = new DataSet1TableAdapters.AdministradorTableAdapter();
        adaptadorEspecialista = new DataSet1TableAdapters.EspecialistaTableAdapter();
        adaptadorRestaurante = new DataSet1TableAdapters.RestauranteTableAdapter();
        adaptadorRecetaAModificar = new DataSet1TableAdapters.Receta_A_ModificarTableAdapter();
        adaptadorForo = new DataSet1TableAdapters.MensajeForoTableAdapter();
        adaptadorMensajePrivado = new DataSet1TableAdapters.MensajePrivadoTableAdapter();
        adaptadorConsultas = new DataSet1TableAdapters.QueriesTableAdapter();
        adaptadorProductos = new DataSet1TableAdapters.ProductoTableAdapter();
        adaptadorPedidos = new DataSet1TableAdapters.PedidoTableAdapter();
        adaptadorComentario = new DataSet1TableAdapters.ComentarioTableAdapter();
        
	}

    /// <summary>
    /// Metodo que devuelve un usuario 
    /// </summary>
    /// <param name="alias">alias del usuario</param>
    /// <returns>clase usuario, o null si no existe el usuario</returns>
    public Usuario devuelveUsuario(String alias)
    {
        Usuario UsuarioDevuelto = new Usuario();        
        

        adaptadorUsuarios.FillByAlias(DataSetLocal.Usuario, alias);

        //Si se pide un usuario que no exist een la base de datos, se devuelve nulo
        if (DataSetLocal.Usuario.Count == 0)
            return null;

        UsuarioDevuelto.Apellido1 = DataSetLocal.Usuario[0].Apellidos;
        UsuarioDevuelto.Nombre = DataSetLocal.Usuario[0].Nombre;
        UsuarioDevuelto.ID = DataSetLocal.Usuario[0].Id_Usuario;
        UsuarioDevuelto.Contrasena = DataSetLocal.Usuario[0].Contraseña;
        UsuarioDevuelto.Alias = DataSetLocal.Usuario[0].Alias;
        

        //if (adaptadorModerador.GetDataByModerador(UsuarioDevuelto.ID).Count != 0)
        //{
            //Devuelve Moderador Como no hace falta, pues ya se hará en el futuro lejano lejanooooooo
            //
        //}
        /* ESTE CACHO DE CODIGO GENERA LOS DIFERENTES TIPOS DE USUARIOS SEGÚN LOS ROLES
         * Funciona muy bien :)
         */
        //Si el usuario es un administrador, le devuelve un administrador
        if(adaptadorAdministrador.GetDataAdministrador(UsuarioDevuelto.ID).Count != 0)
        {
            Administrador admin = new Administrador(UsuarioDevuelto.Nombre, UsuarioDevuelto.Apellido1, UsuarioDevuelto.Apellido2, UsuarioDevuelto.Alias);
            admin.Contrasena = UsuarioDevuelto.Contrasena;
            admin.ID = UsuarioDevuelto.ID;
            return admin;
        }
        
        //Si el usuario es un especialista, le devuelve un especialista, y además lo rellena 
        if(adaptadorEspecialista.GetDataEspecialista(UsuarioDevuelto.ID).Count != 0){
            Especialista esp = new Especialista(UsuarioDevuelto.Nombre, 
                UsuarioDevuelto.Apellido1, 
                UsuarioDevuelto.Apellido2, 
                UsuarioDevuelto.Alias,
                adaptadorEspecialista.GetDataEspecialista(UsuarioDevuelto.ID)[0].Id_Especialista.ToString()
                );
            esp.Contrasena = UsuarioDevuelto.Contrasena;
            esp.ID = UsuarioDevuelto.ID;
            return esp;        
        }
        //Si el usuario es un especialista, le devuelve un restaurante, y además lo rellena 
        if (adaptadorRestaurante.GetDataByIdUsuario(UsuarioDevuelto.ID).Count != 0)
        {
            Restaurante rest = new Restaurante(UsuarioDevuelto.Nombre,
                UsuarioDevuelto.Apellido1, 
                UsuarioDevuelto.Apellido2, 
                UsuarioDevuelto.Alias, 
                adaptadorRestaurante.GetDataByIdUsuario(UsuarioDevuelto.ID)[0].Direccion, 
                (float)adaptadorRestaurante.GetDataByIdUsuario(UsuarioDevuelto.ID)[0].Precio);
            rest.Contrasena = UsuarioDevuelto.Contrasena;
            rest.ID = UsuarioDevuelto.ID;
            return rest;
        }
        
        //Si no ha resultado ser nada, es usuario plano, y como tal se devuelve
        return UsuarioDevuelto;    
    }

    //Se devuelve un usuario según id.
    public Usuario devuelveUsuario(int id_usuario)
    {
        return devuelveUsuario(adaptadorUsuarios.GetDataByIdUsuario(id_usuario)[0].Alias);
    }

    public void InsertaUsuario(String alias, String nombre, String apellidos, String contrasena)
    {
        adaptadorUsuarios.InsertQueryAnadir(alias, nombre, apellidos, contrasena);
    }

    public void insertaAdministrador(int id_usuario)
    {
        adaptadorAdministrador.AnadirAdministrador(id_usuario);
    }

    public void insertaEspecialista(int id_usuario, String noColegiado)
    {
        adaptadorEspecialista.InsertarEspecialista(id_usuario, noColegiado);
        
    }

    public void insertaRestaurante(int id_usuario, String direccion, double precio)
    {
        adaptadorRestaurante.insertarRestaurante(id_usuario, direccion, precio);
    }

    public void borraPrivilegiosAdministrador(String alias)
    {
        Usuario usuario = devuelveUsuario(alias);
        adaptadorAdministrador.BorrarAdministrador(usuario.ID);
    }
    public void borraPrivilegiosRestaurante(String alias)
    {
        Usuario usuario = devuelveUsuario(alias);
        adaptadorRestaurante.BorrarRestaurante(usuario.ID);
    }
    public void borraPrivilegiosEspecialista(String alias)
    {
        Usuario usuario = devuelveUsuario(alias);
        adaptadorEspecialista.BorrarEspecialista(usuario.ID);
    }
 

    /// <summary>
    /// Recupera una array de recetas de una categoria
    /// </summary>
    /// <param name="categoria"> Categoria elegida</param>
    /// <returns>Array de recetas</returns>
    public ArrayList recuperaReceta(String categoria)
    {
        //Se crea un ArrayList de recetas que se van a devolver, cuando se realice la consulta en la base de datos
        //devolvera una serie de tuplas que compartiran la categoria, puede ser 1 sola receta, ninguna o varias
        //por eso la necesidad de un array
        ArrayList Recetas= new ArrayList();

        //Creamos un  objeto receta auxiliar para ir rellenando el ArrayList
        Receta Receta_Aux = new Receta();
        
       

        //Llamada a la consulta SQL para recoger todas las recetas que compartan la categoria
        adaptadorReceta.FillByCategoria(DataSetLocal.Receta, categoria);
        
        //Insertamos en el ArrayList las recetas 
        for (int i = 0; i <= DataSetLocal.Receta.Count; i++)
        {
            Receta_Aux.Categoria = DataSetLocal.Receta[i].Categoria;
            Receta_Aux.estado = (Receta.Estado)DataSetLocal.Receta[i].Estado;
            Receta_Aux.Nombre = DataSetLocal.Receta[i].Nombre;
            Receta_Aux.Nombre_Autor = DataSetLocal.Receta[i].Alias;
            Receta_Aux.Ruta_Formulario = DataSetLocal.Receta[i].Formulario;
            Receta_Aux.Imagen = recuperaReceta(Receta_Aux.Id).Imagen;


            Recetas.Add(Receta_Aux);
        }


            //Devuelve el Arraylist con la informacion deseada
            return Recetas;
    }


    public Receta recuperaReceta(int ID)
    {


        //Llamada a la consulta SQL para recoger las recetas con determinada ID
        adaptadorReceta.FillByID_Receta(DataSetLocal.Receta, ID);
        Receta Receta_Aux = new Receta();

        Receta_Aux.Categoria = DataSetLocal.Receta[0].Categoria;
        Receta_Aux.estado = (Receta.Estado)DataSetLocal.Receta[0].Estado;
        Receta_Aux.Nombre = DataSetLocal.Receta[0].Nombre;
        Receta_Aux.Nombre_Autor = DataSetLocal.Receta[0].Alias;
        Receta_Aux.Ruta_Formulario = DataSetLocal.Receta[0].Formulario;
        Receta_Aux.Id = ID;

        Receta_Aux.Imagen = DataSetLocal.Receta[0].Imagen;

        return Receta_Aux;
    }

    public void ModificarReceta(string Nombre, string Categoria, int id_usuario, string Formulario, short estado, int ID_Receta)
    {
        adaptadorReceta.UpdateReceta(Nombre, Categoria, id_usuario, estado, Formulario, ID_Receta);        

    }

    public void anadirImagen(String imagen, int id)
    {        
        adaptadorReceta.IncluirImagen(imagen, id);
    }

    public int maxid()
    {
        return (int)adaptadorReceta.DevuelveMaximoIdReceta();
    }


    public void AlmacenarMenu(int Id_u, DateTime Fecha, int Id_receta1, int Id_receta2
        , int Id_receta3, int Id_receta4, int Id_receta5, int Id_receta6)
    //Realizamos la insercion en la BBDD de un menu
    {
        //Creamos el Adaptador de Tabla
        DataSet1TableAdapters.MenuTableAdapter adaptadorMenu = new DataSet1TableAdapters.MenuTableAdapter();
        
        adaptadorMenu.InsertQueryMenu(Fecha, Id_receta1, Id_receta2
        , Id_receta3, Id_receta4, Id_receta5, Id_receta6, Id_u);

    }

    public void AlmacenarReceta(string Nombre, string Categoria, int id_usuario, string Formulario, short estado)
    //Realizamos la insercion en la BBDD de una receta
    {   
        //Añadir al dataset
        adaptadorReceta.InsertQueryReceta(Nombre, Categoria, id_usuario, Formulario, estado);
    }
    public void AlmacenarRecetaConfirmada(int ID_Receta, DateTime Fecha_Creacion)
    {
        //Añadir al dataset (tabla receta Confirmada)
        adaptadorRecetaConfirmada.InsertQueryRecetaConfirmada(ID_Receta, Fecha_Creacion);
    }

    public void AlmacenarRecetaAModificar(int Id_receta, String Error)
    {
        //Añadir al dataset(Tupla receta a modificar)        
        adaptadorRecetaAModificar.InsertQueryRecetaAModificar(Id_receta, Error);
    }
    public ArrayList recuperarRecetas()
    {
        ArrayList recetas = new ArrayList();
        //Recuperar recetas
        return recetas;
    }

    public Menu recuperarMenu(int id)
    {                
        //Recuperar recetas correspondientes
        int[] receta = new int[6];
        //Recuperar menu
        Menu menu = new Menu(receta);
        return menu;
    }

    /// <summary>
    /// Modifica el nombre de una receta
    /// </summary>
    /// <param name="id">el identificador de la receta</param>
    /// <param name="nombre">el nombre a modificar</param>
    /// <returns>si existía la receta o no</returns>
    public bool modificarRecetaNombre(int id, String nombre)
    {
        Receta receta = new Receta();
        //Añadir dataSet FillByRecetasID
        adaptadorReceta.FillByID_Usuario(DataSetLocal.Receta, id);
        if (DataSetLocal.Receta.Count == 0)
            return false;
        DataSetLocal.Receta[0].Nombre = nombre;        
        return true;
    }
    //Formulario es el texto de la receta!
    public bool modificarRecetaFormulario(int id, String entrada)
    {
        Receta receta = new Receta();
        //Recuperar de la base de datos
        //Si no esta la receta en la base de datos
        if (false)
            return false;
        receta.Ruta_Formulario = entrada;
        return true;
    }


    //Añadido a partir de la segunda iteracion
    //Zona de Foro

    public void insertaMensajeForo(int id_emisor, DateTime fecha, String asunto, String texto, int id_hilo)
    {
        adaptadorForo.InsertMensajeForo(id_emisor, fecha, asunto, texto, id_hilo);

    }

    //Codigo de la muerte.... Inserta un nuevo hilo en el sistema, está sincronizado para que se ejecute de manera no concurrente
    public void inserNuevoHilo(int id_emisor, DateTime fecha, String asunto, String texto)
    {
        MensajeForo mens = new MensajeForo();
        lock (mens)
        {
            adaptadorForo.InsertMensajeForo(id_emisor, fecha, asunto, texto, adaptadorConsultas.devuelveMaximoHilo().Value + 1);            
        }
    }

    public void modificaMensajeForo(DateTime Fecha, String asunto, String texto,int id_mensaje)
    {
        adaptadorForo.UpdateMensajeForo(Fecha, asunto, texto, id_mensaje);
    }
    

    public MensajeForo devuelveMensajeForo(int id_mensaje)
    {
        adaptadorForo.FillByIdMensaje(DataSetLocal.MensajeForo,id_mensaje);
        MensajeForo mens = new MensajeForo(DataSetLocal.MensajeForo[0].Id_Mensaje_Foro,
            DataSetLocal.MensajeForo[0].Id_Envia,
            DataSetLocal.MensajeForo[0].Fecha,
            DataSetLocal.MensajeForo[0].Asunto,
            DataSetLocal.MensajeForo[0].Texto,
            DataSetLocal.MensajeForo[0].Id_Hilo);
        return mens;
     
    }

    /*public Object[,] devuelveMensajesForo()
    {
        adaptadorForo.FillByConsultaDeLaMuerte(DataSetLocal.MensajeForo);
        Object[,] lista = new Object[DataSetLocal.MensajeForo.Count,4];

        for (int i = 0; i < DataSetLocal.MensajeForo.Count; i++)
        {
            lista[i,0] = DataSetLocal.MensajeForo[i].Alias;
            lista[i,1] = DataSetLocal.MensajeForo[i].Asunto;
            lista[i,2] = DataSetLocal.MensajeForo[i].Fecha;
            lista[i,3] = DataSetLocal.MensajeForo[i].Id_Hilo;
        }
        return lista;

    }
    */
    public MensajeForo[] devuelveMensajes(int id_hilo)
    {        
        adaptadorForo.FillByIdHilo(DataSetLocal.MensajeForo, id_hilo);
        MensajeForo[] arrayMens = new MensajeForo[DataSetLocal.MensajeForo.Count];
        for (int i = 0; i < DataSetLocal.MensajeForo.Count; i++)
        {            
                arrayMens[i] = new MensajeForo(
                DataSetLocal.MensajeForo[i].Id_Mensaje_Foro,
                DataSetLocal.MensajeForo[i].Id_Envia,
                DataSetLocal.MensajeForo[i].Fecha,
                DataSetLocal.MensajeForo[i].Asunto,
                DataSetLocal.MensajeForo[i].Texto,
                DataSetLocal.MensajeForo[i].Id_Hilo);
        }
        
        return arrayMens;
    }

    //Zona de mensajes privados
    public void AlmacenarMensajePrivado(int id_emisor, int id_receptor, String asunto, String texto, DateTime fecha)
    {
        adaptadorMensajePrivado.InsertMensajePrivado(id_emisor,id_receptor,asunto,texto,fecha);
    }

    //Zona de Productos

    public Producto devuelveProductoPorId(int id_producto)
    {
        adaptadorProductos.FillByIdProducto(DataSetLocal.Producto, id_producto);
        if (DataSetLocal.Producto.Count == 0)
            return null;
        Producto retorno = new Producto(DataSetLocal.Producto[0].Nombre,
                                        DataSetLocal.Producto[0].Descripcion,
                                        DataSetLocal.Producto[0].Imagen,
                                        (float)DataSetLocal.Producto[0].Precio,
                                        DataSetLocal.Producto[0].Stock,
                                        DataSetLocal.Producto[0].Id_Producto);
        return retorno;
    }

    public void InsertaProducto(int idproducto,String Nombre, String Descripcion, String Imagen, float Precio, int Stock)
    {
        adaptadorProductos.InsertQueryProducto(Nombre, Descripcion, Imagen,(decimal)Precio,Stock,idproducto);
        
    }

    public void ActualizaProducto(String Nombre, String Descripcion, String Imagen, float Precio, int Stock, int id)
    {
        adaptadorProductos.UpdateQueryProductoByIdProducto(Nombre, Descripcion, Imagen, Stock, (decimal)Precio, id);
    }

   /* public Pedido devuelveProductoPorIdUsuario(int idUsuario)
    {
        adaptadorPedidos.FillByIdUsuario(DataSetLocal.Pedido,idUsuario);
        if (DataSetLocal.Pedido.Count == 0)
            return null;
        Pedido[] pedidos = new Pedido[DataSetLocal.Pedido.Count];
        int i = 0;
        foreach (DataSet1.PedidoRow a in DataSetLocal.Pedido)
        {
            pedidos[0] = new Pedido(a.id
        }
        return null;

    }*/

    public void insertaProductoEnPedido(int Pedido, int Producto, int cantidad)
    {
        adaptadorPedidos.InsertQueryPedido(Pedido, Producto, cantidad);
        adaptadorPedidos.ActualizarPrecio();
    }

    public void insertaNuevoPedido(int idUsuario)
    {
        adaptadorPedidos.InsertNuevoPedido(idUsuario);
    }

    public void borraProductoEnPedido(int Pedido, int LineaPedido)
    {
        adaptadorPedidos.DeleteQueryPorPedidoyNL(LineaPedido, Pedido);
        adaptadorPedidos.ActualizarPrecio();
    }

    public int pedidoUltimo(int idUsuario)
    {
        if (adaptadorPedidos.MaximoPedido(idUsuario) != null)
            return (int)adaptadorPedidos.MaximoPedido(idUsuario);
        else
            return -1;
        
    }

    public void InsertarComentario(string Comentario, int Id_Usuario, int Id_Receta, int Puntuación){
        adaptadorComentario.InsertFila(Comentario, Id_Usuario, Id_Receta, Puntuación);
    }

   
}