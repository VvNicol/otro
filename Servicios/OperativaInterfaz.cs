using aduanasVehicular.Dto;

namespace aduanasVehicular.Servicios
{
    /// <summary>
    /// Biblioteca de metodos de la aplicacion
    /// <autor>nrojlla150420204</autor>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Registro de vehiculo nuevo
        /// </summary>
        /// <param name="listaVehiculos"></param>
        void RegistrarVehiculo(List<VehiculoDto> listaVehiculos);
    }
}