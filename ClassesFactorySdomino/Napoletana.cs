﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesFactorySdomino
{
    public class Napoletana : Pizza
    {
        private readonly string _riga;
        private int _costo;
        private bool _integrale;
        private int _aggiunte;

        public Napoletana(int aggiunte, int costo)
        {
            _riga = "Napoletana";
            _costo = costo;
            _aggiunte = aggiunte;
        }

        public override string Name
        {
            get { return _riga; }
        }
        public override int Price
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public override int Aggiunte
        {
            get { return _aggiunte; }
            set { _aggiunte = value; }
        }

    }
}