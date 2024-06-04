using EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi.SemantickiInterfejsi;
using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaBazom.Interfejsi;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaBazom;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaPodacima;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Semanticka.SemantickiServisi
{
    public class RacunarskaOpremaServis : IRacunarskaOpremaServis
    {
        public IRacunarskaOpremaRepozitorijum _racunarskaOpremaRepozitorijum { get; set; }
        public DbContextOptions<DbContextBaza> _opcije { get; set; }
        public RacunarskaOpremaServis(DbContextOptions<DbContextBaza> opcije)
        {
            this._opcije = opcije;
            _racunarskaOpremaRepozitorijum = new RacunarskaOpremaRepozitorijum(opcije);
        }
        async Task<IEnumerable<RacunarskaOprema>> IRacunarskaOpremaServis.VratiSvuRacunarskuOpremu()
        {
             var nesto= await _racunarskaOpremaRepozitorijum.VratiSvuOpremu();
             return nesto;
        }

        async void IRacunarskaOpremaServis.DodajRacunarskuKomponentu(RacunarskaOprema racunar)
        {
             _racunarskaOpremaRepozitorijum.DodajRacunarskuKomponentu(racunar);


        }

        void IRacunarskaOpremaServis.ObrisiRacunarskuKomponentu(RacunarskaOprema racunar)
        {
            _racunarskaOpremaRepozitorijum.ObrisiRacunarskuKomponentu(racunar);
        }

        void IRacunarskaOpremaServis.IzmeniRacunarskuKomponentu(RacunarskaOprema racunar)
        {
            _racunarskaOpremaRepozitorijum.IzmeniRacunarskuKomponentu(racunar);
        }

        
    }
}
