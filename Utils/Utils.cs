using aduanasVehicular.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aduanasVehicular.Utils
{
    internal class Utils
    {
        public static void ZonaDestino(List<VehiculoDto> zona, bool esPuertaSur, bool esMercancia)
        {
            foreach (VehiculoDto zonaDto in zona)
            {
                if (zonaDto.EsMercancia == false && zonaDto.VehiculoTipo.Equals('P'))
                {
                    zonaDto.EsMercancia = false;
                    zonaDto.EsZonaPuertaSur = false;
                    zonaDto.EsZonaPuertaOeste = true;
                    Console.WriteLine("Zona Oeste");

                }
                else if (zonaDto.VehiculoTipo.Equals('F') || zonaDto.VehiculoTipo.Equals('A'))
                {

                    if (esMercancia == true)
                    {
                        zonaDto.EsZonaPuertaPIF = true;
                        zonaDto.EsZonaPuertaEste = true;
                        zonaDto.EsZonaPuertaSur = false;
                        Console.WriteLine("Zona Este ");

                    }
                    else if (esMercancia == false)
                    {
                        zonaDto.EsZonaPuertaSur = false;
                        zonaDto.EsZonaPuertaNorte = true;
                        Console.WriteLine("Zona Norte ");

                    }
                }
            }
        }
    }
}
