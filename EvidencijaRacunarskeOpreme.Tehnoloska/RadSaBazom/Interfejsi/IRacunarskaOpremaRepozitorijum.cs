using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Tehnoloska.RadSaBazom.Interfejsi
{
    public interface IRacunarskaOpremaRepozitorijum
    {
        Task<IEnumerable<Podaci.RacunarskaOprema>> VratiSvuOpremu();
        Task DodajRacunarskuKomponentu(RacunarskaOprema racunar);
        Task ObrisiRacunarskuKomponentu(RacunarskaOprema racunarZaBrisanje);
        void IzmeniRacunarskuKomponentu(RacunarskaOprema racunarZaIzmenu);
       


    }
}
