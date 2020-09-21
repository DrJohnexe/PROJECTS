using System;
using System.Xml;

namespace ACTIVIDAD_4
{
    class Program
    {
        class VECTORES
        {

            //ATRIBUTOS: SUELDO Y INDICE
            private int[] SUELDO;
            private int i;

            //FUNCION CREAR
            private void CREAR()
            {
                int j;
                i = -1;

                SUELDO = new int[5];
                for (j = 0; j <= 4; j++)

                    SUELDO[j] = 0;

                Console.WriteLine("!ARREGLO INICIALIZADO EXITOSAMENTE! \n");
                Console.WriteLine("TECLEA CUALQUIER TECLA PARA CONTINUAR");

                Console.ReadKey();
                Console.Clear();

            }

            //FUNCION GUARDAR DATOS
            private void GUARDAR_DATOS()
            {
                Console.Clear();
                Char res;

                do
                {
                    i++;
                    int s = 0;

                    if (i < 5)
                    {
                        s = i + 1;

                        Console.WriteLine("AGREGA SUELDO " + s + ": ");
                        SUELDO[i] = int.Parse(Console.ReadLine());
                        Console.WriteLine("!SUELDO AGREGADO CORRECTAMENTE! \n");
                        Console.WriteLine("¿DESEA AGREGAR OTRO SUELDO? s/n: ");
                        res = Convert.ToChar(Console.ReadLine());
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("!EL ARREGLO SE ECUENTRA LLENO! \n");
                        Console.WriteLine("TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                        Console.ReadKey();
                        res = 'n';
                        i--;
                    }
                }
                while (res == 's');
                Console.Clear();
            }

            //FUNCION ELIMINAR DATOS
            public void ELIMINAR_DATOS()
            {
                Console.Clear();
                char res;
                do
                {
                    

                    if (i > -1)
                    {
                        SUELDO[i] = 0;
                        Console.WriteLine("¿DESEA BORRAR OTRO NUMERO? s/n:");
                        res = Convert.ToChar(Console.ReadLine());
                        i--;
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("EL ARREGLO ESTA VACIO! \n");
                        Console.WriteLine("TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                        Console.ReadKey();
                        res = 'n';
                    }
                }
                while (res == 's');
                Console.Clear();
            }

            //FUNCION IMPRIMIR ELEMENTO 
            private void IMPRIMIR_ELEMENTO()
            {
                Console.Clear();
                bool encontrado; 
                encontrado = false;
                int num, j; ;

                Console.WriteLine("INGRESE NUMERO DEL ELEMENTO QUE DESEA BUSCAR: ");
                num = int.Parse(Console.ReadLine());
                j = 0;

                while (encontrado == false && j <= i)
                {
                    if (num == SUELDO[j])
                    {
                        encontrado = true;
                    }
                    else
                    {
                       j++;
                    }
                }
                if (encontrado == true)
                {
                    Console.WriteLine("ELEMENTO ENCONTRADO EN EL INDICE: " + i);

                    Console.WriteLine("\n TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ELEMENTO NO ENCONTRADO");
                    Console.WriteLine("TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                    Console.ReadKey();
                }

                Console.Clear();
            }

            //FUNCION IMPRIMIR TODOS
            public void IMPRIMIR_TODOS()
            {
                Console.Clear();
                if (i < 0)
                {          
                    Console.WriteLine("EL ARREGLO SE ENCUENTRA VACIO \n");
                    Console.WriteLine("TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                    Console.ReadKey();
                    Console.Clear();

                }
                else
                {
                    int s = -1;

                    for (int j = 0; j <= i; j++)
                    {
                        s = j + 1;
                        Console.WriteLine("EL VALOR DE LA COMPONENTE " + s +" ES: ["+SUELDO[j]+"]");
                    }
                    Console.WriteLine("\n TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                    Console.ReadKey();
                    Console.Clear();
                }
            }

            //FUNCION MENU
            public void MENU(VECTORES v)
            {
                int num;

                do
                {
                    Console.WriteLine(" ----------------------------------------------------------------------");
                    Console.WriteLine("|TECLEA EL NUMERO DE LA OPERACION QUE DESEES REALIZAR Y PRESIONA ENTER |");
                    Console.WriteLine("|----------------------------------------------------------------------|");
                    Console.WriteLine("|[1] AGREGAR DATOS                                                     |");
                    Console.WriteLine("|----------------------------------------------------------------------|");
                    Console.WriteLine("|[2] ELIMINAR DATOS                                                    |");
                    Console.WriteLine("|----------------------------------------------------------------------|");
                    Console.WriteLine("|[3] IMPRIMIR UN DATO                                                  |");
                    Console.WriteLine("|----------------------------------------------------------------------|");
                    Console.WriteLine("|[4] IMPRIMIR TODO EL ARREGLO                                          |");
                    Console.WriteLine("|----------------------------------------------------------------------|");
                    Console.WriteLine("|[5] SALIR                                                             |");
                    Console.WriteLine(" ----------------------------------------------------------------------\n");
                    Console.WriteLine("ESCOJA UNA OPCION: ");
                    num = int.Parse(Console.ReadLine());

                    switch (num)
                    {
                        case 1:
                            GUARDAR_DATOS();
                            break;
                        case 2:
                            ELIMINAR_DATOS();
                            break;
                        case 3:
                            IMPRIMIR_ELEMENTO();
                            break;
                        case 4:
                            IMPRIMIR_TODOS();
                            break;
                        case 5:
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("VALOR NUMERICO INCORRECTO! \n");
                            Console.WriteLine("TECLEA CUALQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                } while (num != 6);
            }

            //CREACION DE OBJETO Y EJECUCION DE FUNCIONES
            static void Main(string[] args)
            {
                VECTORES v = new VECTORES();
                v.CREAR();
                v.MENU(v);
            }
        }
    }
}
