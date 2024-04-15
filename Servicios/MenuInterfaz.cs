namespace aduanasVehicular.Servicios
{
    /// <summary>
    /// Biblioteca de metodos de menus
    /// <autor>nrojlla15042024</autor>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Menu principal para acceder a S,N,O,E,EN
        /// </summary>
        /// <returns></returns>
        int MenuPrincipal();

        /// <summary>
        /// Menu puerta Oeste para vehiculos P
        /// </summary>
        void MenuPuertaOeste();

        /// <summary>
        /// Menu de la puerta Sur
        /// </summary>
        void MenuPuertaSur();
    }
}