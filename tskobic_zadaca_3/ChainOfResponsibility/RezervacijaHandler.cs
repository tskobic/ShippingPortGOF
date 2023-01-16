﻿using tskobic_zadaca_3.Singleton;
using tskobic_zadaca_3.Visitor;

namespace tskobic_zadaca_3.ChainOfResponsibility
{
    public class RezervacijaHandler : BaseHandler
    {
        public RezervacijaHandler() : base()
        {

        }

        public override void Handle(int idBrod)
        {
            BrodskaLukaSingleton bls = BrodskaLukaSingleton.Instanca();
            DateTime datum = bls.VirtualniSatOriginator.VirtualnoVrijeme;
            TimeOnly vrijeme = TimeOnly.FromTimeSpan(datum.TimeOfDay);
            DayOfWeek dan = datum.DayOfWeek;

            Rezervacija? rezervacija = bls.BrodskaLuka!.Rezervacije.Find(x => x.IdBrod == idBrod
                        && x.DatumOd.Date.Equals(datum.Date) && TimeOnly.FromDateTime(x.DatumOd) <= vrijeme
                        && TimeOnly.FromDateTime(x.DatumOd).AddHours(x.SatiTrajanja) > vrijeme);
            if (rezervacija != null)
            {
                bls.Controller.SetModelState($"Status broda {idBrod}: Trenutno ima odobrenu rezervaciju.");
            }
            else
            {
                bls.Controller.SetModelState($"Status broda {idBrod}: Trenutno nema odobrenu rezervaciju.");
                if (NextHandler != null)
                {
                    NextHandler.Handle(idBrod);
                }
            }
        }
    }
}