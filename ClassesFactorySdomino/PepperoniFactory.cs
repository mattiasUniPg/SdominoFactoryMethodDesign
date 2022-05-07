using System;

namespace ClassesFactorySdomino
{
    public class PepperoniFactory : PizzaFactory
    {
        private int _costo;
        private int _aggiunte;

        public PepperoniFactory(int costo, int aggiunte)
        {
            _costo = costo;
            _aggiunte = aggiunte;
        }
        public override Pizza GetPizza()
        {
            return new Pepperoni(_costo, _aggiunte);
        }
    }
}