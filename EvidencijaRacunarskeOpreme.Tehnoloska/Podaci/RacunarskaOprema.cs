using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Tehnoloska.Podaci
{
    public class RacunarskaOprema
    {
        [Key]
        public int IdKomponente { get; set; }
        public string ProizvodjacKomponente { get; set; }
        public string ModelKomponente { get; set; }
        public int CenaKomponente { get; set; }
        public DateTime DatumProizvodnje { get; set; }
        public string ZemljaPorekla { get; set; }
        
    }
}
