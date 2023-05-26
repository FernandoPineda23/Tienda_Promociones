using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaMajo.Entity;

namespace TareaMajo.Services
{
    public class Funcion
    {
        public void RealizarCompra()
        {
            try
            {
                Cliente cliente = new Cliente();    

                Console.WriteLine("Ingrese el nombre:");
                cliente.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el apellido:");
                cliente.Apellido = Console.ReadLine();

                Console.WriteLine("Ingrese la edad:");
                cliente.Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el teléfono:");
                cliente.Telefono = Console.ReadLine();

                Console.WriteLine("Ingrese el correo:");
                cliente.Correo = Console.ReadLine();
                Console.Clear();
                double totalCompra = 0;
                double des, totalpag, pagomes;
                

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Ingrese el precio del artículo " + i + ":");
                    double precio = double.Parse(Console.ReadLine());
                    totalCompra += precio;
                }

                Console.WriteLine("\nTotal de compra: " +totalCompra);

                if (totalCompra >= 10000)
                {
                    Console.WriteLine("\nTiene la opcion de hacer pagos de 3 a 6 meses sin intereses");
                    Console.WriteLine("Por favor seleccione una de las siguientes opciones");
                    Console.WriteLine("1) Pagar a 3 meses");
                    Console.WriteLine("2) Pagar a 6 meses");
                    int opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (opcion==1)
                    {
                        Console.WriteLine("ha elegido la opcion de pago a 3 meses sin intereses");
                        Console.WriteLine("\n¡Felicidades! se ha realizado correctamente la operacion");
                        pagomes =totalCompra/3;
                        Console.WriteLine("El total a pagar sera de " + pagomes + " pesos cada mes, durante un periodo de 3 meses");

                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("ha elegido la opcion de pago a 6 meses sin intereses");
                        Console.WriteLine("\n¡Felicidades! se ha realizado correctamente la operacion");
                        pagomes = totalCompra / 6;
                        Console.WriteLine("El total a pagar sera de " + pagomes + " pesos cada mes, durante un periodo de 6 meses");
                        
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese una de las opciones que se le muestre");
                    }


                }
                else if (totalCompra >= 8000)
                {
                    Console.WriteLine("\n¡Felicidades! puede realizar su pago a 3 meses sin intereses");
                    pagomes = totalCompra / 3;
                    Console.WriteLine("El total a pagar sera de " + pagomes + " pesos cada mes, durante un periodo de 3 meses");
                    Console.WriteLine("\nDatos ingresados:");
                    
                }
                else if (totalCompra >= 5000)
                {
                    Console.WriteLine("\n¡Felicidades! Tiene un 10% de descuento en su compra");
                    des = totalCompra * 0.10;
                    totalpag = totalCompra - des;
                    Console.WriteLine("El total a pagar es de "+totalpag+" pesos");
                }
                Console.WriteLine("\nDatos ingresados:");
                Console.WriteLine("\nNombre: " + cliente.Nombre);
                Console.WriteLine("Apellido: " + cliente.Apellido);
                Console.WriteLine("Edad: " + cliente.Edad);
                Console.WriteLine("Teléfono: " + cliente.Telefono);
                Console.WriteLine("Correo: " + cliente.Correo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error: " + ex.Message);
            }
        }
    }
}
