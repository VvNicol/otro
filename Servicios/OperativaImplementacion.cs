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
            char tipoVehiculoRegistro = char.Parse(Console.ReadLine().ToUpper());
            bool esPuertaSur = true;
            Console.WriteLine("¿Lleva mercancia? s/n");
            char snRegistroMercancia = char.Parse(Console.ReadLine().ToLower());

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
            VehiculoDto nuevoVehiculo = new VehiculoDto(matriculaRegistro,tipoVehiculoRegistro,esPuertaSur,esMercancia,fchaPuertaSurRegistro);
            
            Utils.Utils.ZonaDestino(new List<VehiculoDto> { nuevoVehiculo }, esPuertaSur,esMercancia);

            listaVehiculos.Add(nuevoVehiculo);
        }      
    }
}