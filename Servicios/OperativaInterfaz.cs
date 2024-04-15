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
        /// Muestra la lista que estan actualmente en la puerta oeste
        /// </summary>
        /// <param name="listaVehiculos"></param>
        void mostrarListaPuertaOste(List<VehiculoDto> listaVehiculos);


        /// <summary>
        /// Registro de vehiculo nuevo
        /// </summary>
        /// <param name="listaVehiculos"></param>
        void RegistrarVehiculo(List<VehiculoDto> listaVehiculos);
    }
}