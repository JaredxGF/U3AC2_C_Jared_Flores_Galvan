using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace U2AC2_C_Jared_Flores_Galvan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string nombre, apellidoPaterno, apellidoMaterno, correo, correoinicio, contraseña, confirmacionDeContraseña, contraseñainicio;
            byte edad;
            int color, tamañoCsl;

            //Recoleccion de datos del usuario
            #region 

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Favor de ingresar los datos solicitados para registrarse");
            Console.WriteLine("Nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Apellido Paterno");
            apellidoPaterno = Console.ReadLine();
            Console.WriteLine("Apellido Materno");
            apellidoMaterno = Console.ReadLine();
            Console.WriteLine("Edad");
            edad = Convert.ToByte(Console.ReadLine());




            //registro de correo y contraseña
            Console.WriteLine("Ingresa tu correo electronico");
            correo = Console.ReadLine();
            Console.WriteLine("Ingresa tu Contraseña");
            contraseña = Console.ReadLine();
            Console.WriteLine("Confirmar Contraseña");
            confirmacionDeContraseña = Console.ReadLine();


            #endregion

            //IF COMPROVACION DE DATOS INGRESADOS POR EL USUARIO
            if (contraseña == confirmacionDeContraseña)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Es hora de iniciar sesión");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Ingrese los datos solicitados");
                Console.WriteLine("Correo:");
                correoinicio = Console.ReadLine();
                Console.WriteLine("Contraseña:");
                contraseñainicio = Console.ReadLine();
                Console.Clear();

            }


            else
            {
                Console.WriteLine("Verifique que las contraseñas sean iguales");
                Console.WriteLine("Saliendo de la consola.");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo de la consola..");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo de la consola...");
                Thread.Sleep(2000);
                return;
            }

            if (correo == correoinicio) //IF DE INICIO DE SESION
            {




                if (confirmacionDeContraseña == contraseñainicio)
                {

                    Console.WriteLine("Bienvenido");
                


                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    Console.WriteLine("Saliendo de la consola.");
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo de la consola..");
                    Thread.Sleep(2000);
                    Console.WriteLine("Saliendo de la consola...");
                    Thread.Sleep(2000);
                    return;
                }
            }
            else
            {
                Console.WriteLine("El correo no coincide");

                Console.WriteLine("Saliendo de la consola.");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo de la consola..");
                Thread.Sleep(2000);
                Console.WriteLine("Saliendo de la consola...");
                Thread.Sleep(2000);

                return;
            }
            //configurador de colores de consola
            Console.WriteLine("Antes de entrar personalice la consola\n");
            Console.WriteLine("Escriba el color que desea");

            Console.WriteLine("1 = rojo \t 2 = gris \t 3 = verde \t 4 = amarillo \t 5 = magenta");


            //modificacion de color de la consola
            color = Convert.ToInt16(Console.ReadLine());


            switch (color)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Clear();
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    break;
                case 5:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Usted no a elegido ningun color");
                    break;
            }

            //configuracion de tamaño de la consola
            Console.WriteLine("Elija el tamaño de la consola");
            Console.WriteLine("1 = 100x40 \t 2 = 80x20");

            tamañoCsl = Convert.ToInt32(Console.ReadLine());
            switch (tamañoCsl)
            {
                case 1:
                    Console.WindowWidth = 100; //ancho
                    Console.WindowHeight = 40; //alto
                    break;
                case 2:
                    Console.WindowWidth = 80;//ancho
                    Console.WindowHeight = 20; //alto
                    break;

                default:
                    Console.WriteLine("ingrese correctamente los datos como se solicitan para cambiar el tamaño de la consola");
                    break;
            }

            //titulo de la consola

            Console.WriteLine("Escribe el titulo que le quieras asignar a la consola");
            Console.Title = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hola {0}", nombre);
            Console.WriteLine("Datos del usuario:");
            Console.WriteLine("Nombre:{0} {1} {2}", nombre, apellidoPaterno, apellidoMaterno);
            Console.WriteLine("Edad:{0}", edad);


            Console.WriteLine("Presione ENTER para salir de la consola");
            Console.ReadKey();
        }
    }
}
