using aduanasVehicular.Dto;
using aduanasVehicular.Servicios;

namespace aduanasVehicular.Controlador
{
    /// <summary>
    /// Funcionalidades de los metodos de la operativa
    /// <auto>nrojlla15042024</auto>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void RegistrarVehiculo(List<VehiculoDto> listaVehiculos)
        {
            Console.WriteLine("Registro de vehiculo");
            Console.WriteLine("----------------------");
            Console.WriteLine("Ingrese la matricula");
            string matriculaRegistro = Console.ReadLine();
            Console.WriteLine("Tipo de vehiculo (P,F,A)");
            char tipoVehiculoRegistro = char.Parse(Console.ReadLine());

            Console.WriteLine("¿Lleva mercancia?");
            char snRegistroMercancia = char.Parse(Console.ReadLine());
            bool esMercancia = false;
            if(snRegistroMercancia == 's')
            {
                esMercancia = true;
            }
            else
            {
                esMercancia = false;
            }
 
            DateTime fchaPuertaSurRegistro = DateTime.Now;

           // string zonaLugar = Utils.Utils.ZonaDestino(listaVehiculos);
        }

       
    }
}