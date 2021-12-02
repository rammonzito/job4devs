﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP(List<string> ingredientes) : base(ingredientes)
        {
        }

        public override void Preparar()
        {
            Console.WriteLine("Ignora tudo e coloca cebola");
        }
    }
}