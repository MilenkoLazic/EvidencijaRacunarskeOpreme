using EvidencijaRacunarskeOpreme.Tehnoloska.Podaci;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaBazom.Interfejsi;
using EvidencijaRacunarskeOpreme.Tehnoloska.RadSaPodacima;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EvidencijaRacunarskeOpreme.Tehnoloska.RadSaBazom
{
    public class RacunarskaOpremaRepozitorijum:IRacunarskaOpremaRepozitorijum
    {
        public DbContextBaza _dbContextBaza { get; private set; }
        public RacunarskaOpremaRepozitorijum(DbContextOptions<DbContextBaza> opcije)
        {
            _dbContextBaza = new DbContextBaza(opcije);
        }

        async Task<IEnumerable<Podaci.RacunarskaOprema>> IRacunarskaOpremaRepozitorijum.VratiSvuOpremu()
        {
            
            var baza = await  _dbContextBaza.racunarskaOprema.ToListAsync();
            return baza;
        }

         async Task IRacunarskaOpremaRepozitorijum.DodajRacunarskuKomponentu(RacunarskaOprema racunar)
        {
              await _dbContextBaza.racunarskaOprema.AddAsync(racunar);
              _dbContextBaza.SaveChanges();
             
        }

        async Task IRacunarskaOpremaRepozitorijum.ObrisiRacunarskuKomponentu(RacunarskaOprema racunarZaBrisanje)
        {
            _dbContextBaza.racunarskaOprema.Remove(racunarZaBrisanje);
            _dbContextBaza.SaveChanges();
        }

         async void IRacunarskaOpremaRepozitorijum.IzmeniRacunarskuKomponentu(RacunarskaOprema racunarZaIzmenu)
        {
            var racunar= await _dbContextBaza.racunarskaOprema.FindAsync(racunarZaIzmenu.IdKomponente);
            racunar.ModelKomponente = racunarZaIzmenu.ModelKomponente;
            racunar.CenaKomponente=racunarZaIzmenu.CenaKomponente;
            racunar.ZemljaPorekla = racunarZaIzmenu.ZemljaPorekla;
            racunar.DatumProizvodnje = racunarZaIzmenu.DatumProizvodnje;
            racunar.ProizvodjacKomponente = racunarZaIzmenu.ProizvodjacKomponente;
            _dbContextBaza.SaveChanges();
            //Semanticka Greska
            //var racunar2 =  _dbContextBaza.racunarskaOprema.FindAsync(racunarZaIzmenu.CenaKomponente);
        }

        /*Task IRacunarskaOpremaRepozitorijum.FiltrirajRacunarskuKomponentu(string naziv)
        {
            _dbContextBaza
        }*/
    }
}
