using System.Security.Cryptography;
using aduanasVehicular.Dto;
using aduanasVehicular.Servicios;

namespace aduanasVehicular.Controlador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string GestionRevisionVehiculos = "AduanasVehicular.txt"; 
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionSeleccionar;
            bool esCerrado = false;
            try
            {

                do
                {
                    opcionSeleccionar = mi.MenuPrincipal();
                    switch (opcionSeleccionar)
                    {
                        case 0:
                            esCerrado = true;
                            Console.WriteLine("La aplicacion se ha cerrado");
                            break;
                        case 1:
                            mi.MenuPuertaSur();
                            break;
                        case 2:
                            //oi.MenuPuertaOeste();
                            break;
                        case 3:
                            //oi.MenuPuertaNorte();
                            break;
                        case 4:
                           // oi.MenuPuertaEste();
                            break;
                        case 5:
                            //oi.MenuPuertaEsteNorte();
                            break;
                    }

                } while (!esCerrado);

            }
            catch (IOException io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }
    }
}
