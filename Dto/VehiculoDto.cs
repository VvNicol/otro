using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aduanasVehicular.Dto
{
    /// <summary>
    /// Base de datos de los vehiculos
    /// <autor>nrojlla 15042024</autor>
    /// </summary>
    internal class VehiculoDto
    {
        string mariculaV = "aaaaa";
        char vehiculoTipo = 'A';
        bool esZonaPuertaSur = false;
        bool esZonaPuertaNorte = false;
        bool esZonaPuertaOeste = false;
        bool esZonaPuertaEste = false;
        bool esZonaPuertaPIF = false;
        bool esZonaPuertaEsteNorte = false;
        bool esMercancia = false;
        bool esMercanciaApta = false;
        DateTime fechaControlPS = new DateTime(31 / 12 / 9999);
        DateTime fechaControlPN = new DateTime(31 / 12 / 9999);
        DateTime fechaControlPO = new DateTime(31 / 12 / 9999);
        DateTime fechaControlPE = new DateTime(31 / 12 / 9999);
        DateTime fechaControlEN = new DateTime(31 / 12 / 9999);

        public VehiculoDto(string mariculaV, char vehiculoTipo, bool esZonaPuertaSur, bool esMercancia, DateTime fechaControlPS)
        {
            this.esZonaPuertaSur = esZonaPuertaSur;
            this.mariculaV = mariculaV;
            this.vehiculoTipo = vehiculoTipo;  
            this.esMercancia = esMercancia;
            this.fechaControlPS = fechaControlPS;
        }

        public string MariculaV { get => mariculaV; set => mariculaV = value; }
        public char VehiculoTipo { get => vehiculoTipo; set => vehiculoTipo = value; }
        public bool EsMercancia { get => esMercancia; set => esMercancia = value; }
        public bool EsMercanciaApta { get => esMercanciaApta; set => esMercanciaApta = value; }
        public DateTime FechaControlPS { get => fechaControlPS; set => fechaControlPS = value; }
        public DateTime FechaControlPN { get => fechaControlPN; set => fechaControlPN = value; }
        public DateTime FechaControlPO { get => fechaControlPO; set => fechaControlPO = value; }
        public DateTime FechaControlPE { get => fechaControlPE; set => fechaControlPE = value; }
        public DateTime FechaControlEN { get => fechaControlEN; set => fechaControlEN = value; }
        public bool EsZonaPuertaSur { get => esZonaPuertaSur; set => esZonaPuertaSur = value; }
        public bool EsZonaPuertaNorte { get => esZonaPuertaNorte; set => esZonaPuertaNorte = value; }
        public bool EsZonaPuertaOeste { get => esZonaPuertaOeste; set => esZonaPuertaOeste = value; }
        public bool EsZonaPuertaEste { get => esZonaPuertaEste; set => esZonaPuertaEste = value; }
        public bool EsZonaPuertaPIF { get => esZonaPuertaPIF; set => esZonaPuertaPIF = value; }
        public bool EsZonaPuertaEsteNorte { get => esZonaPuertaEsteNorte; set => esZonaPuertaEsteNorte = value; }
    }
}
