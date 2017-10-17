using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DarAltaProducto : System.Web.UI.Page
{
    Boolean Existe = false;

    protected void Page_Load(object sender, EventArgs e)
    {
        
        Label_Error_Descripcion.Visible = false;
        Label_Error_Imagen.Visible = false;
        Label_Error_Nombre_Producto.Visible = false;
        Label_Error_Precio.Visible = false;
        Label_Error_Proveedor.Visible = false;
        Label_Error_Stock.Visible = false;
        ErrorCodigo.Visible = false;

        Label_Descripcion_producto.Visible = false;
        Label_Imagen_Producto.Visible = false;
        Label_Introduccion_Formulario.Visible = false;
        Label_Nombre_Producto.Visible = false;
        Label_Nombre_Proveedor.Visible = false;
        Label_Precio.Visible = false;
        Label_Stock.Visible = false;

        TextBox_Descripcion_Producto.Visible = false;
        TextBox_Nombre_Producto.Visible = false;
        TextBox_Nombre_Proveedor.Visible = false;
        TextBox_Precio.Visible = false;
        TextBox_Stock.Visible = false;

        Button_Añadir.Visible = false;

        FileUpload_Imagen_Producto.Visible = false;

    }
    protected void Button_Añadir_Click(object sender, EventArgs e)
    {
        TextBox_Descripcion_Producto.Visible = true;
        Label_Descripcion_producto.Visible = true;
        TextBox_Nombre_Producto.Visible = true;
        Label_Nombre_Producto.Visible = true;
        TextBox_Nombre_Proveedor.Visible = true;
        Label_Nombre_Proveedor.Visible = true;
        TextBox_Precio.Visible = true;
        Label_Precio.Visible = true;
        TextBox_Stock.Visible = true;
        Label_Stock.Visible = true;
        Label_Imagen_Producto.Visible = true;
        FileUpload_Imagen_Producto.Visible = true;
        Button_Añadir.Visible = true;

        //Lanzar los mensajes de error por vacio        
        if (TextBox_Descripcion_Producto.Text == "")
        {
            Label_Error_Descripcion.Text = "El campo descripción está vacio";
            Label_Error_Descripcion.Visible = true;
        }

        if (TextBox_Nombre_Producto.Text == "")
        {
            Label_Error_Nombre_Producto.Text = "El campo nombre está vacío";
            Label_Error_Nombre_Producto.Visible = true;
        }

        if (TextBox_Nombre_Proveedor.Text == "")
        {
            Label_Error_Proveedor.Text = "El campo proveedor está vacío";
            Label_Error_Proveedor.Visible = true;
        }

        if (TextBox_Precio.Text == "")
        {
            Label_Error_Precio.Text = "El campo precio está vacío";
            Label_Error_Precio.Visible = true;
        }

        if (TextBox_Stock.Text == "")
        {
            Label_Error_Stock.Text = "El campo stock está vacío";
            Label_Error_Stock.Visible = true;
        }

        //IF para comprobrar que los campos estan rellenados
        if (TextBox_Descripcion_Producto.Text != "")
        {
            if (TextBox_Nombre_Producto.Text != "")
            {
                if (TextBox_Nombre_Proveedor.Text != "")
                {
                    if (TextBox_Precio.Text != "")
                    {
                        if (TextBox_Stock.Text != "")
                        {
                            //IF para comprobar que el campo precio es un campo
                            //positivo
                            if (int.Parse(TextBox_Stock.Text) > 0)
                            {
                                String extensionim = System.IO.Path.GetExtension(FileUpload_Imagen_Producto.FileName).ToLower();
                                if (extensionim == ".jpg" || extensionim == ".png")
                                {
                                    Producto producto = new Producto(TextBox_Nombre_Producto.Text, TextBox_Descripcion_Producto.Text, FileUpload_Imagen_Producto.FileName, float.Parse(TextBox_Precio.Text), int.Parse(TextBox_Stock.Text), int.Parse(TextBox_Id_Producto.Text));
                                    String ruta = Server.MapPath("~/imagenes/");
                                    producto.sincronizaProductoConBaseDeDatos();
                                    if (FileUpload_Imagen_Producto.HasFile)
                                        FileUpload_Imagen_Producto.PostedFile.SaveAs(ruta + FileUpload_Imagen_Producto.FileName);
                                    //Vaciamos los campos
                                    TextBox_Descripcion_Producto.Text = "";
                                    TextBox_Id_Producto.Text = "";
                                    TextBox_Nombre_Producto.Text = "";
                                    TextBox_Nombre_Proveedor.Text = "";
                                    TextBox_Precio.Text = "";
                                    TextBox_Stock.Text = "";

                                    //Ocultamos todos los campos menos los de código
                                    Label_Error_Descripcion.Visible = false;
                                    Label_Error_Imagen.Visible = false;
                                    Label_Error_Nombre_Producto.Visible = false;
                                    Label_Error_Precio.Visible = false;
                                    Label_Error_Proveedor.Visible = false;
                                    Label_Error_Stock.Visible = false;

                                    Label_Introduccion_Identificador.Text = "El producto se ha añadido correctamente";
                                    Label_Descripcion_producto.Visible = false;
                                    Label_Imagen_Producto.Visible = false;
                                    Label_Introduccion_Formulario.Visible = false;
                                    Label_Nombre_Producto.Visible = false;
                                    Label_Nombre_Proveedor.Visible = false;
                                    Label_Precio.Visible = false;
                                    Label_Stock.Visible = false;

                                    TextBox_Descripcion_Producto.Visible = false;
                                    TextBox_Nombre_Producto.Visible = false;
                                    TextBox_Nombre_Proveedor.Visible = false;
                                    TextBox_Precio.Visible = false;
                                    TextBox_Stock.Visible = false;

                                    Button_Añadir.Visible = false;

                                    FileUpload_Imagen_Producto.Visible = false;
                                }
                                else
                                    if (!FileUpload_Imagen_Producto.HasFile)
                                    {
                                        Label_Descripcion_producto.Visible = true;
                                        Label_Imagen_Producto.Visible = true;
                                        Label_Introduccion_Formulario.Visible = true;
                                        Label_Nombre_Producto.Visible = true;
                                        Label_Nombre_Proveedor.Visible = true;
                                        Label_Precio.Visible = true;
                                        Label_Stock.Visible = true;
                                        FileUpload_Imagen_Producto.Visible = true;
                                        TextBox_Descripcion_Producto.Visible = true;
                                        TextBox_Nombre_Producto.Visible = true;
                                        TextBox_Nombre_Proveedor.Visible = true;
                                        TextBox_Precio.Visible = true;
                                        TextBox_Stock.Visible = true;
                                        Button_Añadir.Visible = true;
                                        //Formato de imagen no válido
                                        Label_Error_Imagen.Visible = true;
                                        Label_Error_Imagen.Text = "La introducción de una imagen es obligatoria";
                                    }
                                    else
                                {
                                    Label_Descripcion_producto.Visible = true;
                                    Label_Imagen_Producto.Visible = true;
                                    Label_Introduccion_Formulario.Visible = true;
                                    Label_Nombre_Producto.Visible = true;
                                    Label_Nombre_Proveedor.Visible = true;
                                    Label_Precio.Visible = true;
                                    Label_Stock.Visible = true;
                                    FileUpload_Imagen_Producto.Visible = true;
                                    TextBox_Descripcion_Producto.Visible = true;
                                    TextBox_Nombre_Producto.Visible = true;
                                    TextBox_Nombre_Proveedor.Visible = true;
                                    TextBox_Precio.Visible = true;
                                    TextBox_Stock.Visible = true;
                                    Button_Añadir.Visible = true;
                                    //Formato de imagen no válido
                                    Label_Error_Imagen.Visible = true;
                                    Label_Error_Imagen.Text = "El formato de la imagen debe ser .jpg o .png";
                                }
                            }
                            else
                            {
                                //Stock negativo
                                Label_Error_Stock.Text = "Stock negativo";
                                Label_Error_Stock.Visible = true;
                            }
                        }
                    }
                }
            }
        }   
    }

    //protected void TextBox_Id_Producto_TextChanged(object sender, EventArgs e)
    //{
    //    Comprobar_Click(sender, e);

    //    if (TextBox_Id_Producto.Text != "")
    //    {
    //        int codigo;
    //        codigo = int.Parse(TextBox_Id_Producto.Text);


    //        if (Producto.existeProductoConIdTalQue(codigo))
    //        {
    //            Existe = true;

    //            Producto producto = new Producto(codigo);

    //            Label_Descripcion_producto.Visible = true;
    //            Label_Imagen_Producto.Visible = true;
    //            Label_Introduccion_Formulario.Visible = true;
    //            Label_Nombre_Producto.Visible = true;
    //            Label_Nombre_Proveedor.Visible = false;
    //            Label_Precio.Visible = true;
    //            Label_Stock.Visible = true;

    //            Label_Error_Descripcion.Visible = false;
    //            Label_Error_Imagen.Visible = false;
    //            Label_Error_Nombre_Producto.Visible = false;
    //            Label_Error_Precio.Visible = false;
    //            Label_Error_Proveedor.Visible = false;
    //            Label_Error_Stock.Visible = false;

    //            TextBox_Descripcion_Producto.Visible = true;
    //            TextBox_Descripcion_Producto.Text = producto.Descripcion;

    //            TextBox_Nombre_Producto.Visible = true;
    //            TextBox_Nombre_Producto.Text = producto.Nombre;

    //            TextBox_Precio.Visible = true;
    //            TextBox_Precio.Text = producto.Precio.ToString();

    //            TextBox_Stock.Visible = true;
    //            TextBox_Stock.Text = producto.stock.ToString();

    //            TextBox_Nombre_Proveedor.Visible = false;
    //            TextBox_Nombre_Proveedor.Text = "Proveedor";

    //            Button_Añadir.Visible = true;

    //            FileUpload_Imagen_Producto.Visible = true;
    //        }
    //        else
    //        {
    //            Label_Descripcion_producto.Visible = true;
    //            Label_Imagen_Producto.Visible = true;
    //            Label_Introduccion_Formulario.Visible = true;
    //            Label_Nombre_Producto.Visible = true;
    //            Label_Nombre_Proveedor.Visible = true;
    //            Label_Precio.Visible = true;
    //            Label_Stock.Visible = true;

    //            TextBox_Descripcion_Producto.Visible = true;
    //            TextBox_Nombre_Producto.Visible = true;
    //            TextBox_Nombre_Proveedor.Visible = true;
    //            TextBox_Precio.Visible = true;
    //            TextBox_Stock.Visible = true;

    //            Button_Añadir.Visible = true;

    //            FileUpload_Imagen_Producto.Visible = true;
    //        }
    //    }
    //}

    protected void Comprobar_Click(object sender, EventArgs e)
    {
        ErrorCodigo.Visible = false;

        if (TextBox_Id_Producto.Text != "")
        {
            int codigo;
            codigo = int.Parse(TextBox_Id_Producto.Text);


            if (Producto.existeProductoConIdTalQue(codigo))
            {
                Existe = true;

                Producto producto = new Producto(codigo);

                Label_Descripcion_producto.Visible = true;
                Label_Imagen_Producto.Visible = true;
                Label_Introduccion_Formulario.Visible = true;
                Label_Nombre_Producto.Visible = true;
                Label_Nombre_Proveedor.Visible = false;
                Label_Precio.Visible = true;
                Label_Stock.Visible = true;

                Label_Error_Descripcion.Visible = false;
                Label_Error_Imagen.Visible = false;
                Label_Error_Nombre_Producto.Visible = false;
                Label_Error_Precio.Visible = false;
                Label_Error_Proveedor.Visible = false;
                Label_Error_Stock.Visible = false;

                TextBox_Descripcion_Producto.Visible = true;
                TextBox_Descripcion_Producto.Text = producto.Descripcion;

                TextBox_Nombre_Producto.Visible = true;
                TextBox_Nombre_Producto.Text = producto.Nombre;

                TextBox_Precio.Visible = true;
                TextBox_Precio.Text = producto.Precio.ToString();

                TextBox_Stock.Visible = true;
                TextBox_Stock.Text = producto.stock.ToString();

                TextBox_Nombre_Proveedor.Visible = false;
                TextBox_Nombre_Proveedor.Text = "Proveedor";

                Button_Añadir.Visible = true;

                FileUpload_Imagen_Producto.Visible = true;

            }
            else
            {
                Label_Descripcion_producto.Visible = true;
                Label_Imagen_Producto.Visible = true;
                Label_Introduccion_Formulario.Visible = true;
                Label_Nombre_Producto.Visible = true;
                Label_Nombre_Proveedor.Visible = true;
                Label_Precio.Visible = true;
                Label_Stock.Visible = true;

                TextBox_Descripcion_Producto.Visible = true;
                TextBox_Nombre_Producto.Visible = true;
                TextBox_Nombre_Proveedor.Visible = true;
                TextBox_Precio.Visible = true;
                TextBox_Stock.Visible = true;

                Button_Añadir.Visible = true;

                FileUpload_Imagen_Producto.Visible = true;
            }
        }
        else
        {
            ErrorCodigo.Visible = true;
        }
    }
}