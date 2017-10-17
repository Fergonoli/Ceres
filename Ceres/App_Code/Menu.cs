using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Array de 6 platos que contiene el menú para un día (Desayuno, Plato 1 Comida, Plato 2 Comida, Postre Comida, Plato Cena y Postre Cena)
/// </summary>
public class Menu
{
    //Array que contiene los 6 platos del menú
    protected static int []platos=new int[6];

    //Constructor por defecto
    public Menu()
    {
        for (int i=0; i<6; i++)
            platos[i]=0;
    }

    //Constructor de Menú con un array de Recetas
    public Menu(int[] plat)
    {
        for (int i = 0; i < 6; i++)
            platos[i] = plat[i];
    }

    //Inserta el desayuno en el array
    public static void insertarDesayuno(int plat){
        platos[0] = plat;
    }

    //Inserta el primer plato de la comida en el array
    public static void insertarPlato1(int plat)
    {
        platos[1] = plat;
    }

    //Inserta el segundo plato de la comida en el array
    public static void insertarPlato2(int plat)
    {
        platos[2] = plat;
    }

    //Inserta el postre de la comida en el array
    public static void insertarPostre1(int plat)
    {
        platos[3] = plat;
    }

    //Inserta el plato de la cena en el array
    public static void insertarCena(int plat)
    {
        platos[4] = plat;
    }

    //Inserta el postre de la cena en el array
    public static void insertarPostre2(int plat)
    {
        platos[5] = plat;
    }

    public static int verPlato(int i)
    {
        return platos[i];
    }

    //Inserta el menú en la base de datos
    public static void insertarMenu(int IDUsuario)
    {
        //Usuario u = new Usuario();
        Almacenaje a = new Almacenaje();
        //u = a.devuelveUsuario(System.Web.HttpContext.Current.User.Identity.Name);
        a.AlmacenarMenu(IDUsuario, DateTime.Now, platos[0], platos[1], platos[2], platos[3], platos[4], platos[5]);
    }
}