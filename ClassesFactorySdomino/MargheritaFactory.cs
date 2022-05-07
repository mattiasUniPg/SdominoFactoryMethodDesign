using System;

namespace ClassesFactorySdomino
{
    public class MargheritaFactory : PizzaFactory
    {
        private int _costo;
        private int _aggiunte;

        public MargheritaFactory(int costo, int aggiunte)
        {
            _costo = costo;
            _aggiunte = aggiunte;
        }
        public override Pizza GetPizza()
        {
            return new Margherita(_costo, _aggiunte);
        }
    }
}