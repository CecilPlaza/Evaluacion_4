using Evaluación_4.Models;

Console.WriteLine("Tabla de Videojuegos y Compañias");

using (EFContext bd = new EFContext())
{   //Cada una de las acciones realizadas estan de manera automatizada

    // 1- Obtencion de Compañias de Videojuegos de mayor a menor
    var ordenCompania = bd.CompaniaDeVideojuegos
         .Where(x => x.Id >= 1 && x.Id <= 4)
         .OrderByDescending(x => x.Id)
         .ToList();

    Console.WriteLine("Listado de Compañias");
    foreach (var CompaniaDeVideojuego in ordenCompania)
    {
        Console.Write(CompaniaDeVideojuego.Id);
        Console.Write(" ");
        Console.WriteLine(CompaniaDeVideojuego.NombreCompania);
    }

    // 2- Obtencion de ventas realizadas por videojuego
    double ventasVideojuego = bd.Videojuegos.Average(x => x.CopiasVendidas);
    Console.WriteLine(" ");
    Console.WriteLine("Ventas aproximadas de los videojuegos de todas las empresas en millones");
    Console.WriteLine(ventasVideojuego);
    Console.WriteLine(" ");

    // 3- Obtencion fecha de las compañias de videojuegos

    DateTime min = bd.CompaniaDeVideojuegos.Min(x => x.Fundado);
    Console.WriteLine(" ");
    Console.Write("La compañia mas longeva es: ");
    Console.Write(min);
    Console.WriteLine(" ");

    // 4- Insercion de una compañia de videojuegos

    CompaniaDeVideojuego nuevaCompania = new CompaniaDeVideojuego()
    {
        Id = 5,
        NombreCompania = "Activision Blizzard",
        Fundado = Convert.ToDateTime("2008-01-01"),
        DominaMercado = true,
        AnioIndustria = 14
    };

    bd.CompaniaDeVideojuegos.Add(nuevaCompania);
    bd.SaveChanges();

    // 5- Actualizar los datos de la tercera compañia ingresada "Xbox" a "Microsoft (Xbox)" y los años
    //cambiaran por los años de la industria en si o sea Microsfot

    var editarCompania = bd.CompaniaDeVideojuegos.FirstOrDefault(x => x.Id == 3);
    editarCompania.NombreCompania = "Microsoft(Xbox)";
    editarCompania.AnioIndustria = 48;
    bd.CompaniaDeVideojuegos.Update(editarCompania);
    bd.SaveChanges();
    Console.WriteLine(" ");
    Console.Write("Se actualizo la compañia: ");
    Console.Write(editarCompania.NombreCompania);
    // 6- Eliminar el videojuego 

    var eliminarVideojuego = bd.Videojuegos.FirstOrDefault(x => x.Id == 22);
    bd.Videojuegos.Remove(eliminarVideojuego);
    bd.SaveChanges();
    Console.WriteLine(" ");
    Console.Write("Se eliminó el Videojuego de la base de datos: ");
    Console.Write(eliminarVideojuego.NombreVideojuego);
    Console.WriteLine(" ");

}