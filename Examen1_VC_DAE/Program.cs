namespace Examen1_VC_DAE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mainFlag = true;
            string eleccionMenu;
            int auxiliar;
            

            while (mainFlag)
            {
                eleccionMenu = "n";
                Console.WriteLine("----------------- EXAMEN PRACTICO 1 - VALERIA CALDERON -----------------");
                Console.WriteLine("\tElija el ejercicio para revisar: ");
                Console.WriteLine("\t\t1 - Costo de llamadas");
                Console.WriteLine("\t\t2 - Sistema de Biblioteca");
                Console.WriteLine("\t\t0 - Salir");
                Console.Write("\tOpcion: ");
                eleccionMenu = Console.ReadLine();
                auxiliar = int.Parse(eleccionMenu);

                Console.Clear();

                switch (auxiliar)
                {
                    case 0:
                        mainFlag = false;
                        Console.WriteLine("Gracias por revisar...");
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 1:
                        string clave = "";
                        double total = 0;
                        string minutos;
                        double precio;
                        string zonaClave;

                        Console.WriteLine("----------------- CALCULADOR LLAMADA TELEFONICA -----------------");
                        Console.WriteLine("Ingrese la clave asignada a su zona: ");
                        clave = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de minutos de duracion de la llamada: ");
                        minutos = Console.ReadLine();

                        Console.Clear();

                        Console.WriteLine("----------------- COBRO X LLAMADA -----------------");
                        
                        switch (clave)
                        {
                            case "12":
                                precio = 2;
                                zonaClave = "America del Norte";
                                total = precio * double.Parse(minutos);

                                Console.WriteLine("El costo total de su llamada es: $"+Math.Round(total,2));
                                Console.WriteLine("Zona: " + zonaClave);

                                break;

                            case "15":
                                precio = 2.2;
                                zonaClave = "America Central";
                                total = precio * double.Parse(minutos);

                                Console.WriteLine("El costo total de su llamada es: $" + Math.Round(total, 2));
                                Console.WriteLine("Zona: " + zonaClave);

                                break;
                            case "18":
                                precio = 4.5;
                                zonaClave = "America del Sur";
                                total = precio * double.Parse(minutos);

                                Console.WriteLine("El costo total de su llamada es: $" + Math.Round(total, 2));
                                Console.WriteLine("Zona: " + zonaClave);
                                break;
                            case "19":
                                precio = 3.5;
                                zonaClave = "Europa";
                                total = precio * double.Parse(minutos);

                                Console.WriteLine("El costo total de su llamada es: $" + Math.Round(total, 2));
                                Console.WriteLine("Zona: " + zonaClave);
                                break;
                            case "23":
                                precio = 6;
                                zonaClave = "Asia";
                                total = precio * double.Parse(minutos);

                                Console.WriteLine("El costo total de su llamada es: $" + Math.Round(total, 2));
                                Console.WriteLine("Zona: " + zonaClave);
                                break;
                            default:
                                Console.WriteLine("Zona telefónica invalida, intente de nuevo...");
                                break;

                        }

                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case 2:
                        string[] idLibro = { };
                        string[] tituloLibro = { };
                        string[] ISBN = { };
                        string[] edicionLibro = { };
                        string[] autorLibro = { };
                        bool flagSegundo = true;
                        int ej2Eleccion = 999;
                        int resultado = 9999;
                        string auxedicion;
                        string newTitulo;
                        string newISBN;
                        string newEdicion;
                        string newAutor;

                        while (flagSegundo)
                        {
                            Console.WriteLine("----------------- SISTEMA REGISTRO DE BIBLIOTECA -----------------");
                            Console.WriteLine("\tBIENVENIDO AL MENU PRINCIPAL, elija la opción deseada: ");
                            Console.WriteLine("\t\t1 - Agregar nuevo libro");
                            Console.WriteLine("\t\t2 - Mostrar listado de libros");
                            Console.WriteLine("\t\t3 - Buscar libro");
                            Console.WriteLine("\t\t4 - Editar información de libro");
                            Console.WriteLine("\t\t0 - SALIR");
                            Console.Write("\tSeleccion: ");

                            ej2Eleccion = int.Parse(Console.ReadLine());

                            switch (ej2Eleccion)
                            {
                                case 0:

                                    Console.Clear();
                                    flagSegundo = false;
                                    break;
                                case 1:

                                    bool caso1Flag = true;
                                    string addLibro;
                                    Console.Clear();

                                    while (caso1Flag)
                                    {
                                        Console.WriteLine("|----------------------- AGREGAR LIBRO -----------------------|");
                                        Console.WriteLine("Ingrese el codigo del libro: ");
                                        idLibro = idLibro.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese el titulo del libro: ");
                                        tituloLibro = tituloLibro.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese la ISBN del libro: ");
                                        ISBN = ISBN.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese la edicion del libro: ");
                                        edicionLibro = edicionLibro.Append(Console.ReadLine()).ToArray();
                                        Console.WriteLine("Ingrese el autor del libro: ");
                                        autorLibro = autorLibro.Append(Console.ReadLine()).ToArray();

                                        Console.WriteLine("¿Desea agregar otro libro? (S/N): ");
                                        addLibro = Console.ReadLine();
                                        addLibro = addLibro.ToUpper();

                                        Console.Clear();

                                        if (addLibro == "S")
                                        {
                                            caso1Flag = true;
                                        }
                                        else
                                        {
                                            caso1Flag = false;
                                        }

                                    }

                                    break;

                                case 2:

                                    if (idLibro.Length == 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("----------ERROR----------");
                                        Console.WriteLine("NO HAY LIBROS QUE MOSTRAR...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    else
                                    {
                                        Console.Clear();

                                        Console.WriteLine("|----------------------- LISTA LIBROS -----------------------|");
                                        Console.WriteLine(String.Format("{0,-10} {1,-30} {2,-15} {3,-15} {4,-30}", "ID", "Titulo Libro", "ISBN", "Edicion", "Autor"));

                                        for (int i = 0; i < idLibro.Length; i++)
                                        {
                                            Console.WriteLine(String.Format("{0,-10} {1,-30} {2,-15} {3,-15} {4,-30}", idLibro[i], tituloLibro[i], ISBN[i], edicionLibro[i], autorLibro[i]));
                                        }

                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    break;

                                case 3:
                                    resultado = 9999;
                                    string searchID;
                                    Console.Clear();
                                    Console.WriteLine("|----------------------- BUSCAR LIBRO -----------------------|");
                                    Console.Write("Ingrese ID a buscar: ");
                                    searchID = Console.ReadLine();

                                    for (int i = 0; i < idLibro.Length; i++)
                                    {
                                        if (searchID == idLibro[i])
                                        {
                                            resultado = i;
                                            break;
                                        }
                                    }

                                    if (resultado == 9999)
                                    {
                                        Console.WriteLine("Libro no encontrado, intente nuevamente...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("|----------------------- LIBRO ENCONTRADO -----------------------|");
                                        Console.WriteLine(String.Format("{0,-10} {1,-30} {2,-15} {3,-15} {4,-30}", "ID", "Titulo Libro", "ISBN", "Edicion", "Autor"));
                                        Console.WriteLine(String.Format("{0,-10} {1,-30} {2,-15} {3,-15} {4,-30}", idLibro[resultado], tituloLibro[resultado], ISBN[resultado], edicionLibro[resultado], autorLibro[resultado]));
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    break;

                                case 4:

                                    resultado = 9999;

                                    Console.WriteLine("|----------------------- EDITAR LIBRO -----------------------|");
                                    Console.Write("Ingrese ID: ");
                                    searchID = Console.ReadLine();

                                    for (int i = 0; i < idLibro.Length; i++)
                                    {
                                        if (searchID == idLibro[i])
                                        {
                                            resultado = i;
                                            break;
                                        }
                                    }

                                    if (resultado == 9999)
                                    {
                                        Console.WriteLine("Libro no encontrado, intente nuevamente...");
                                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        Console.WriteLine("|----------------------- EDITAR Libro -----------------------|");
                                        Console.WriteLine("\t¿Que informacion desea editar? Seleccione:");
                                        Console.WriteLine("\t\t1 - Titulo");
                                        Console.WriteLine("\t\t2 - ISBN");
                                        Console.WriteLine("\t\t3 - Num de Edicion");
                                        Console.WriteLine("\t\t4 - Autor");
                                        Console.WriteLine("\t\t0 - SALIR");
                                        Console.Write("Opcion: ");
                                        auxedicion = Console.ReadLine();

                                        switch (auxedicion)
                                        {
                                            case "1":

                                                Console.WriteLine("Titulo actual: " + tituloLibro[resultado]);
                                                Console.Write("Ingrese nuevo titulo: ");
                                                newTitulo = Console.ReadLine();
                                                Console.WriteLine("Titulo modificado...");
                                                tituloLibro[resultado] = newTitulo;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "2":

                                                Console.WriteLine("ISBN actual: " + ISBN[resultado]);
                                                Console.Write("Ingrese nuevo ISBN: ");
                                                newISBN = Console.ReadLine();
                                                Console.WriteLine("ISBN Modificado...");
                                                ISBN[resultado] = newISBN;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "3":

                                                Console.WriteLine("Edicion actual: " + edicionLibro[resultado]);
                                                Console.Write("Ingrese nueva edicion de libro: ");
                                                newEdicion = Console.ReadLine();
                                                Console.WriteLine("Edicion modificada...");
                                                edicionLibro[resultado] = newEdicion;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "4":

                                                Console.WriteLine("Autor actual: " + autorLibro[resultado]);
                                                Console.Write("Ingrese nuevo autor: ");
                                                newAutor = Console.ReadLine();
                                                Console.WriteLine("Autor de libro modificado...");
                                                autorLibro[resultado] = newAutor;

                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();

                                                break;

                                            case "0":
                                                Console.Clear();
                                                break;

                                            default:
                                                Console.WriteLine("EDICION NO VÁLIDA, INTENTE NUEVAMENTE...");
                                                Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;

                                        }

                                    }

                                    break;

                                default:

                                    Console.Clear();
                                    Console.WriteLine("Opcion invalida... intente de nuevo");
                                    Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }

                        break;

                    default:
                        Console.WriteLine("Opcion invalida... intente de nuevo");
                        Console.WriteLine("\n\nPRESIONE [ENTER] PARA CONTINUAR...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}