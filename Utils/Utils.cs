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
        public static void ZonaDestino(List<VehiculoDto> zona)
        {
            foreach (VehiculoDto zonaDto in zona)
            {   
               
                if (zonaDto.EsMercancia == false && zonaDto.VehiculoTipo.Equals('P'))
                {
                    zonaDto.EsMercancia = false;
                    zonaDto.EsZonaPuertaSur = false;
                    zonaDto.EsZonaPuertaOeste = true;

                }
                if (zonaDto.EsMercancia == false && zonaDto.VehiculoTipo.Equals('F') || zonaDto.VehiculoTipo.Equals('A'))
                {
                    zonaDto.EsMercancia = false;
                    zonaDto.EsZonaPuertaSur = false;
                    zonaDto.EsZonaPuertaNorte = true;
                }
                if (zonaDto.EsMercancia == true && zonaDto.VehiculoTipo.Equals('F') || zonaDto.VehiculoTipo.Equals('A'))
                {
                    zonaDto.EsMercancia = true;
                    zonaDto.EsZonaPuertaPIF = true;
                    zonaDto.EsZonaPuertaEste = true;
                    zonaDto.EsZonaPuertaSur = false;
                    
                }  
            }
        }
    }
}
