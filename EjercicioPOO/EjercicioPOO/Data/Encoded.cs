using EjercicioPOO.Classes;
using System.Collections.Generic;
using System.Windows.Documents;

namespace EjercicioPOO.Data
{
    public static class Encoded
    {
        public static List<PublicTransport> listOfTranports = new List<PublicTransport>();

        public static void LoadTransports()
        {
            Encoded.listOfTranports.Add(new Bus(1, 0));
            Encoded.listOfTranports.Add(new Bus(2, 5));
            Encoded.listOfTranports.Add(new Bus(3, 0));
            Encoded.listOfTranports.Add(new Bus(4, 20));
            Encoded.listOfTranports.Add(new Bus(5, 0));
            Encoded.listOfTranports.Add(new Cab(11, 0));
            Encoded.listOfTranports.Add(new Cab(12, 3));
            Encoded.listOfTranports.Add(new Cab(13, 0));
            Encoded.listOfTranports.Add(new Cab(14, 0));
            Encoded.listOfTranports.Add(new Cab(15, 1));
        }
    }
}
