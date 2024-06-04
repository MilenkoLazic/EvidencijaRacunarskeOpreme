using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi.SemantickiInterfejsi
{
    public interface IRacunarskaOpremaServis
    {
        public Task<IEnumerable<RacunarskaOprema>> VratiSvuRacunarskuOpremu();
        public void DodajRacunarskuKomponentu(RacunarskaOprema racunar);
        public void ObrisiRacunarskuKomponentu(RacunarskaOprema racunar);
        public void IzmeniRacunarskuKomponentu(RacunarskaOprema racunar);
        
    }
}
