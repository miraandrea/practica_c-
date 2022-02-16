using System;

namespace Practica_C__
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas instructor");
            Console.WriteLine();
            Console.WriteLine("Ejemplo 1: Estructura condicional simple.");
            Console.WriteLine("Ejemplo 2: Estructura condicional doble.");
            Console.WriteLine("Ejemplo 3: Estructura condicional multiple.");
            Console.WriteLine("Ejemplo 4: Estructura condicional anidado.");
            Console.WriteLine("Ejemplo 5: Estructura dependiendo de o segun.");
            Console.WriteLine("Ejemplo 6: Estructura ciclica.");
            Console.WriteLine("Ejemplo 7: Integracion estructura condicional y ciclicas (while if-else) (for is-else).");
            Console.WriteLine();
            Console.WriteLine("Que ejemplo deseas mirar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            if(opcion == 1)
            {
                Console.WriteLine("Cantidad de bodega: ");
                int bodega = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de cliente: ");
                int cliente = Convert.ToInt32(Console.ReadLine());
                if (bodega < cliente)
                {
                    Console.WriteLine("Es necesario realizar el pedido");
                }
                if (bodega > cliente)
                {
                    Console.WriteLine("No es necesario realizar el pedido");
                }
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Cantidad de bodega: ");
                int bodega = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de cliente: ");
                int cliente = Convert.ToInt32(Console.ReadLine());
                if (bodega < cliente)
                {
                    Console.WriteLine("Es necesario realizar el pedido");
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido");
                }
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Cantidad de bodega: ");
                int bodega = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de cliente: ");
                int cliente = Convert.ToInt32(Console.ReadLine());
                int cantidad = (bodega - cliente);
                if (bodega < cliente)
                {
                    Console.WriteLine("Es necesario realizar el pedido");
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido, unidades que hacen falta para vender " + cantidad);
                }
            }
            else if (opcion == 4)
            {
                Console.WriteLine("Cantidad de bodega: ");
                int bodega = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Cantidad de cliente: ");
                int cliente = Convert.ToInt32(Console.ReadLine());
                int cantidad = (bodega - cliente);
                if (bodega < cliente)
                {
                    Console.WriteLine("Es necesario realizar el pedido");
                }
                else if (cantidad <= 10)
                {
                    Console.WriteLine("No es necesario realizar el pedido. ¡alerta generada! Quedan " + cantidad);
                }
                else
                {
                    Console.WriteLine("No es necesario realizar el pedido, unidades que hacen falta para vender " + cantidad);
                }
            }
            else if (opcion == 5)
            {
                Console.WriteLine("Valor de la compra: ");
                double compra = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Que dia de la semana estamos: ");
                int diasemana = Convert.ToInt32(Console.ReadLine());
                if (diasemana == 1)
                {
                    double descuento = compra - (compra * 0.5);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 2)
                {
                    double descuento = compra - (compra * 0.3);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 3)
                {
                    double descuento = compra - (compra * 0.10);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 4)
                {
                    double descuento = compra - (compra * 0.4);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 5)
                {
                    double descuento = compra - (compra * 0.6);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 6)
                {
                    double descuento = compra - (compra * 0.2);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
                else if (diasemana == 7)
                {
                    double descuento = compra - (compra * 0.1);
                    Console.WriteLine("valor total por pagar con descuento: " + descuento);
                    Console.WriteLine("valor total por pagar SIN descuento: " + compra);
                }
            }
            else if (opcion == 6)
            {
                Console.WriteLine("Cantidad de producto: ");
                int produecto = Convert.ToInt32(Console.ReadLine());
                var factura = 0;

                for (int i = 1; i <= produecto; i++)
                {
                    Console.WriteLine("Cantidad del producto " + i + ": ");
                    int cantidad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("valor del producto " + i + ": ");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    int multiplicar = cantidad * valor;

                    factura += multiplicar;
                }
                Console.WriteLine("Valor total de factura: " + factura);
            }
            else if (opcion == 7)
            {
                Console.WriteLine("Cantidad de clientes: ");
                int cliente = Convert.ToInt32(Console.ReadLine());
       
                var total = 0;

                for (int e = 1; e <= cliente; e++)
                {

                    Console.WriteLine("Cliente " + e);
                    Console.WriteLine("Cantidad de producto: ");
                    int produecto = Convert.ToInt32(Console.ReadLine());
                    var factura = 0;

                    for (int i = 1; i <= produecto; i++)
                    {
                        Console.WriteLine("Cantidad del producto " + i + ": ");
                        int cantidad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("valor del producto " + i + ": ");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        int multiplicar = cantidad * valor;

                        factura += multiplicar;
                        if (factura >= 100000)
                        {
                            double descuento = factura - (factura * 0.10);
                            Console.WriteLine("Valor total de factura: " + descuento);
                        }
                        total += multiplicar;
                    }
                    Console.WriteLine("Valor total de factura: " + factura);
                }
                Console.WriteLine("Total vendido: " + total);
            }
            else
            {
                Console.WriteLine("chao instructor");
            }
        }
    }
}
