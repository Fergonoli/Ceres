using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Class1
/// </summary>
public class ClasePruebas
{
    String prueba = "";

	public ClasePruebas()
	{
        Almacenaje almacenaje = new Almacenaje();
        AñadeCadenaPrueba("AAA");
        AñadeCadenaPrueba(almacenaje.devuelveUsuario("SrDnDirector").Nombre);
        AñadeCadenaPrueba(almacenaje.devuelveUsuario("SrDnDirector").GetType().ToString());
	}

    

    public void AñadeCadenaPrueba(String cadena)
    {
        prueba += cadena;
    }

    public String devuelveCadenaPrueba()
    {
        return prueba;
    }
}