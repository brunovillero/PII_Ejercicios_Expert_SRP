using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertidorMoneda.ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioTotal;
        }
    }
}