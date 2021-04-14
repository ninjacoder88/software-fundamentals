using System;

namespace FacadeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BiosecurityScreener biosecurity = new BiosecurityScreener();
            ManufacturabilityScreener manufacturability = new ManufacturabilityScreener();
            CreditCheck creditCheck = new CreditCheck();

            ManufacturingRequest r = new ManufacturingRequest(biosecurity, manufacturability, creditCheck);
            r.CanProcess();
        }
    }
}
