using aduanasVehicular.Controlador;
using aduanasVehicular.Dto;

namespace aduanasVehicular.Servicios
{
    /// <summary>
    /// funcionalidades de los metodos del menu interfaz
    /// </summary>
    
    internal class MenuImplementacion : MenuInterfaz
    {
        OperativaInterfaz oi = new OperativaImplementacion();
        public static List<VehiculoDto> listaVehiculos = new List<VehiculoDto>();

        public int MenuPrincipal()
        {
            Console.WriteLine("Menu Principal aduanas");
            Console.WriteLine("0.Cerrar aplicacion");
            Console.WriteLine("1.Puerta Sur");
            Console.WriteLine("2.Puerta Norte");
            Console.WriteLine("3.Puerta Oeste");
            Console.WriteLine("4.Puerta Este");
            Console.WriteLine("5.Puerta Este Norte");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }

        public void MenuPuertaSur()
        {
            int opcionSeleccionar;
            bool esCerrado = false;
            try
            {

                do
                {
                    opcionSeleccionar = PuertaSur();
                    switch (opcionSeleccionar)
                    {
                        case 0:
                            esCerrado = true;
                            Console.WriteLine("Atras");
                            break;
                        case 1:
                            oi.RegistrarVehiculo(listaVehiculos);
                            break;          
                    }

                } while (!esCerrado);

            }
            catch (IOException io)
            {
                Console.WriteLine("No se ha podido leer/escribir: " + io.Message);
            }
        }

        private int PuertaSur()
        {
            Console.WriteLine("Menu Puerta Sur");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Registrar vehiculos");

            int opcionEscogida = int.Parse(Console.ReadLine());

            return opcionEscogida;
        }
    }
}