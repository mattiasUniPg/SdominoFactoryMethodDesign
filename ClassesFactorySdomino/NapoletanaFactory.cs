using System;

namespace ClassesFactorySdomino
{
    public class NapoletanaFactory
    {
        private int _costo;
        private int _aggiunte;

        public NapoletanaFactory(int costo, int aggiunte)
        {
            _costo = costo;
            _aggiunte = aggiunte;
        }
        public override Pizza GetPizza()
        {
            return new Napoletana(_costo, _aggiunte);
        }
    }
}
