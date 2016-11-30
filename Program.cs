using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    namespace Airport
    {
        public class Flight
        {

            public string Airline;
            public string FlightNumber;
            public DateTime DepartureTime;
            public DateTime ArrivalTime;
            public string DepartureAirport;
            public string ArrivalAirport;
            public string DepatureTerminal;
            public string ArrivalTerminal;
            public Status Status;
            public string Gate;

            public override string ToString()
            {
                String format = "[MM/dd hh:mm]";
                StringBuilder stringBilder = new StringBuilder();
                stringBilder.AppendFormat("{0} ", Airline)
                    .AppendFormat("{0} ", FlightNumber)
                    .AppendFormat("{0} ", DepartureTime.ToString(format))
                    .AppendFormat("{0} ", ArrivalTime.ToString(format))
                    .AppendFormat("{0} ", DepartureAirport)
                    .AppendFormat("{0} ", DepatureTerminal)
                    .AppendFormat("{0} ", ArrivalAirport)
                    .AppendFormat("{0} ", ArrivalTerminal)
                    .AppendFormat("{0} ", Status)
                    .AppendFormat("{0} ", Gate);
                return stringBilder.ToString();
            }
        }

        public enum Status
        {
            CheckIn,
            GateClosed,
            Arrived,
            DepartedAt,
            Unknown,
            Canceled,
            ExpectedAt,
            Delayed,
            InFlight
        }
        class Program
        {
            static void Main(string[] args)
            {
                #region Collection Init

                string emergencyInf = "Acol' beseder";

                var flightCollection = new List<Flight>()
            {
                new Flight()
                    {
                        Airline = "Pegasus Airlines",
                        FlightNumber = "PC4751",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Istanbul Sabiha",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 3, 40 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 4, 40 , 00 )
                    },

                    new Flight()
                    {
                        Airline = "Belavia",
                        FlightNumber = "B2 836",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Minsk",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 5, 00 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 7, 00 , 00 )

                    },
                   new Flight()
                    {
                        Airline = "Ukr International Airlines",
                        FlightNumber = "PS 024",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Kyiv Boryspil",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 7, 05 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 8, 05 , 00 )
                    },

                    new Flight()
                    {
                        Airline = "LOT Polish Airlines",
                        FlightNumber = "LO 762",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Warsaw",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 18, 00 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 20, 00 , 00 )

                    },
                   new Flight()
                    {
                        Airline = "Ukr International Airlines",
                        FlightNumber = "PS 793",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Tel Aviv",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 21, 20 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 23, 50 , 00 )

                    },
                   new Flight()
                    {
                        Airline = "Belavia",
                        FlightNumber = "B2 836",
                        DepartureAirport = "Kharkov",
                        ArrivalAirport = "Minsk",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 08, 5, 00 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 08, 7, 00 , 00 )
                    },

                    new Flight()
                    {
                        Airline = "Pegasus Airlines",
                        FlightNumber = "PC 750",
                        DepartureAirport = "Istanbul Sabiha",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 1, 20 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 1, 50 , 00 )
                    },

                     new Flight()
                    {
                        Airline = "Ukr International Airlines",
                        FlightNumber = "PS 502",
                        DepartureAirport = "Kutaisi",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 4, 00 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 4, 30 , 00 )
                    },

                      new Flight()
                    {
                        Airline = "Ukr International Airlines",
                        FlightNumber = "PS 025",
                        DepartureAirport = "Kyiv Boryspil",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 16, 50 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 17, 50 , 00 )
                    },

                      new Flight()
                    {
                        Airline = "LOT Polish Airlines",
                        FlightNumber = "LO 761",
                        DepartureAirport = "Warsaw",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 17, 20 , 00 ),
                        DepartureTime = new DateTime( 2016, 12, 07, 19, 50 , 00 )
                    },

                      new Flight()
                    {
                        Airline = "Belavia",
                        FlightNumber = "B2 835",
                        DepartureAirport = "Minsk",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 07, 23, 15, 00 ),
                        DepartureTime = new DateTime( 2016, 12, 08, 01, 30 , 00 )
                    },

                      new Flight()
                    {
                        Airline = "Ukr International Airlines",
                        FlightNumber = "PS 794",
                        DepartureAirport = "Tel Aviv",
                        ArrivalAirport = "Kharkov",
                        DepatureTerminal = "1",
                        ArrivalTerminal = "1",
                        Status = Status.DepartedAt,
                        Gate = "2A",
                        ArrivalTime = new DateTime( 2016, 12, 08, 04, 45, 00 ),
                        DepartureTime = new DateTime( 2016, 12, 08, 07, 30 , 00 )
                    },


                    };
                #endregion

                const string currentAirportName = "Kharkov";
                const String format = "[MM/dd hh:mm]";
                bool exitKeyPassed = false;

                do //MAIN LOOP
                {
                    ConsoleKeyInfo key;

                    do //GET KEY LOOP
                    {
                        Console.WriteLine("(I)nput, (D)eleting (E)diting (S)how table (F)light information E(x)it");
                        key = Console.ReadKey();

                    } while (key.KeyChar != 'i' && key.KeyChar != 'd' && key.KeyChar != 'e' && key.KeyChar != 's' && key.KeyChar != 'f' && key.KeyChar != 'x');


                    switch (key.KeyChar)
                    {
                        case 'i':

                            #region Add New Element
                            string airline;
                            Console.WriteLine("Airline:");
                            airline = Console.ReadLine();

                            string flightNumber;
                            Console.WriteLine("Flight Number:");
                            flightNumber = Console.ReadLine();

                            DateTime departureTime;
                            Console.WriteLine("Departure Time:");
                            string departureTimeString = Console.ReadLine();
                            departureTime = DateTime.Parse(departureTimeString);

                            DateTime arrivalTime;
                            Console.WriteLine("Arrival Time:");
                            string arrivalTimeString = Console.ReadLine();
                            arrivalTime = DateTime.Parse(arrivalTimeString);

                            string departureAirport;
                            Console.WriteLine("Departure Airport:");
                            departureAirport = Console.ReadLine();

                            string arrivalAirport;
                            Console.WriteLine("Arrival Airport:");
                            arrivalAirport = Console.ReadLine();

                            string depatureTerminal;
                            Console.WriteLine("Depature Terminal:");
                            depatureTerminal = Console.ReadLine();

                            string arrivalTerminal;
                            Console.WriteLine("Arrival Terminal:");
                            arrivalTerminal = Console.ReadLine();

                            Status status;
                            Console.WriteLine("Satus:");
                            string statusString = Console.ReadLine();
                            status = (Status)Enum.Parse(typeof(Status), statusString);

                            string gate;
                            Console.WriteLine("Gate:");
                            gate = Console.ReadLine();



                            Flight newFlight = new Flight
                            {

                                Airline = airline,
                                FlightNumber = flightNumber,
                                DepartureTime = departureTime,
                                ArrivalTime = arrivalTime,
                                DepartureAirport = departureAirport,
                                ArrivalAirport = arrivalAirport,
                                DepatureTerminal = depatureTerminal,
                                ArrivalTerminal = arrivalTerminal,
                                Status = status,
                                Gate = gate
                            };

                            flightCollection.Add(newFlight);

                            #endregion

                            break;

                        case 'd':

                            #region DELETE
                            Console.WriteLine("Flight Number For Delete: ");
                            string flightNumberForDelete;
                            flightNumberForDelete = Console.ReadLine();
                            Flight findedFlight = new Flight();

                            foreach (var item in flightCollection)
                            {
                                if (item.FlightNumber == flightNumberForDelete)
                                {
                                    findedFlight = item;
                                }
                            }
                            flightCollection.Remove(findedFlight);

                            #endregion

                            break;
                        case 'e':

                            #region Edit

                            Console.WriteLine("Flight Number For Edit: ");
                            string flightNumberForEdit;
                            flightNumberForEdit = Console.ReadLine();

                            int editFlyIndex = -1;

                            int i = -1;
                            foreach (var flight in flightCollection)
                            {
                                i++;
                                if (flightNumberForEdit == flight.FlightNumber)
                                {
                                    editFlyIndex = i;
                                }
                            }

                            if (editFlyIndex == -1)
                            {
                                Console.WriteLine("Wrong Flight Number!!!");
                                Console.Beep();
                                break;
                            }

                            StringBuilder stringBuilderEdit = new StringBuilder("Choose what do you want to edit:").AppendLine();

                            stringBuilderEdit.AppendLine("\t(0)Airline")
                                             .AppendLine("\t(1)FlightNumber")
                                             .AppendLine("\t(2)DepartureTime")
                                             .AppendLine("\t(3)ArrivalTime")
                                             .AppendLine("\t(4)DepartureAirport")
                                             .AppendLine("\t(5)ArrivalAirport")
                                             .AppendLine("\t(6)DepatureTerminal")
                                             .AppendLine("\t(7)ArrivalTerminal")
                                             .AppendLine("\t(8)Status")
                                             .AppendLine("\t(9)Gate");

                            Console.WriteLine(stringBuilderEdit.ToString());

                            var editingСhoice = Console.ReadKey();
                            switch (editingСhoice.KeyChar)
                            {
                                case '0':
                                    Console.WriteLine("New Airline:");
                                    var newAirline = Console.ReadLine();
                                    flightCollection[editFlyIndex].Airline = newAirline;
                                    break;
                                case '1':
                                    Console.WriteLine("New FlightNumber:");
                                    var newFlightNumber = Console.ReadLine();
                                    flightCollection[editFlyIndex].FlightNumber = newFlightNumber;
                                    break;
                                case '2':
                                    Console.WriteLine("New DepartureTime:");
                                    var newDepartureTime = Console.ReadLine();
                                    departureTime = DateTime.Parse(newDepartureTime);
                                    flightCollection[editFlyIndex].DepartureTime = departureTime;
                                    break;
                                case '3':
                                    Console.WriteLine("New ArrivalTime:");
                                    var newArrivalTime = Console.ReadLine();
                                    arrivalTime = DateTime.Parse(newArrivalTime);
                                    flightCollection[editFlyIndex].ArrivalTime = arrivalTime;
                                    break;
                                case '4':
                                    Console.WriteLine("New DepartureAirport:");
                                    var newDepartureAirport = Console.ReadLine();
                                    flightCollection[editFlyIndex].DepartureAirport = newDepartureAirport;
                                    break;
                                case '5':
                                    Console.WriteLine("New ArrivalAirport:");
                                    var newArrivalAirport = Console.ReadLine();
                                    flightCollection[editFlyIndex].ArrivalAirport = newArrivalAirport;
                                    break;
                                case '6':
                                    Console.WriteLine("New DepatureTerminal:");
                                    var newDepatureTerminal = Console.ReadLine();
                                    flightCollection[editFlyIndex].DepatureTerminal = newDepatureTerminal;
                                    break;
                                case '7':
                                    Console.WriteLine("New ArrivalTerminal:");
                                    var newArrivalTerminal = Console.ReadLine();
                                    flightCollection[editFlyIndex].ArrivalTerminal = newArrivalTerminal;
                                    break;
                                case '8':
                                    Console.WriteLine("New Status:");
                                    var newStatus = Console.ReadLine();
                                    status = (Status)Enum.Parse(typeof(Status), newStatus);
                                    flightCollection[editFlyIndex].Status = status;

                                    break;
                                case '9':
                                    Console.WriteLine("New Gate:");
                                    var newGate = Console.ReadLine();
                                    flightCollection[editFlyIndex].Gate = newGate;
                                    break;
                            }


                            #endregion

                            break;
                        case 's':

                            #region SHOW TABLE
                            Console.WriteLine("\n***Departure Table****");
                            foreach (var flight in flightCollection)
                            {
                                if (flight.DepartureAirport == currentAirportName)
                                {
                                    StringBuilder stringBilder = new StringBuilder();
                                    stringBilder.AppendFormat("{0} ", flight.Airline)
                                        .AppendFormat("{0} ", flight.FlightNumber)
                                        .AppendFormat("{0} ", flight.DepartureTime.ToString(format))
                                        .AppendFormat("{0} ", flight.ArrivalTime.ToString(format))
                                        .AppendFormat("{0} ", flight.DepartureAirport)
                                        .AppendFormat("{0} ", flight.DepatureTerminal)
                                        .AppendFormat("{0} ", flight.ArrivalAirport)
                                        .AppendFormat("{0} ", flight.ArrivalTerminal)
                                        .AppendFormat("{0} ", flight.Status)
                                        .AppendFormat("{0} ", flight.Gate);
                                    Console.WriteLine(stringBilder.ToString());

                                }
                            }


                            Console.WriteLine("\n***Arrival Table****");
                            foreach (var flight in flightCollection)
                            {
                                if (flight.ArrivalAirport == currentAirportName)
                                {
                                    StringBuilder stringBilder = new StringBuilder();
                                    stringBilder.AppendFormat("{0} ", flight.Airline)
                                        .AppendFormat("{0} ", flight.FlightNumber)
                                        .AppendFormat("{0} ", flight.DepartureTime.ToString(format))
                                        .AppendFormat("{0} ", flight.ArrivalTime.ToString(format))
                                        .AppendFormat("{0} ", flight.DepartureAirport)
                                        .AppendFormat("{0} ", flight.DepatureTerminal)
                                        .AppendFormat("{0} ", flight.ArrivalAirport)
                                        .AppendFormat("{0} ", flight.ArrivalTerminal)
                                        .AppendFormat("{0} ", flight.Status)
                                        .AppendFormat("{0} ", flight.Gate);
                                    Console.WriteLine(stringBilder.ToString());

                                }
                            }


                            var color = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(String.Format("Info: {0}", emergencyInf));
                            Console.ForegroundColor = color;

                            #endregion

                            break;
                        case 'f':

                            #region Info Search
                            StringBuilder stringBuilderInformation = new StringBuilder("Choose by what information:").AppendLine();

                            stringBuilderInformation.AppendLine("\t(0)by Airline")
                                                    .AppendLine("\t(1)by FlightNumber")
                                                    .AppendLine("\t(2)by DepartureTime")
                                                    .AppendLine("\t(3)by ArrivalTime")
                                                    .AppendLine("\t(4)by DepartureAirport")
                                                    .AppendLine("\t(5)by ArrivalAirport");

                            Console.WriteLine(stringBuilderInformation.ToString());

                            var infoСhoice = Console.ReadKey();
                            switch (infoСhoice.KeyChar)
                            {
                                case '0':
                                    Console.WriteLine("Airline:");
                                    string infoAirline = Console.ReadLine();

                                    foreach (var flight in flightCollection)
                                    {
                                        if (flight.Airline == infoAirline)
                                        {
                                            StringBuilder stringBilder = new StringBuilder();
                                            stringBilder.AppendFormat("{0} ", flight.Airline)
                                                .AppendFormat("{0} ", flight.FlightNumber)
                                                .AppendFormat("{0} ", flight.DepartureTime.ToString(format))
                                                .AppendFormat("{0} ", flight.ArrivalTime.ToString(format))
                                                .AppendFormat("{0} ", flight.DepartureAirport)
                                                .AppendFormat("{0} ", flight.DepatureTerminal)
                                                .AppendFormat("{0} ", flight.ArrivalAirport)
                                                .AppendFormat("{0} ", flight.ArrivalTerminal)
                                                .AppendFormat("{0} ", flight.Status)
                                                .AppendFormat("{0} ", flight.Gate);
                                            Console.WriteLine(stringBilder.ToString());
                                        }
                                        else
                                        {
                                            Console.WriteLine("Wrong Airline!!!");
                                            Console.Beep();
                                            break;
                                        }
                                    }
                                    break;
                                case '1':
                                    Console.WriteLine("FlightNumber:");
                                    string infoFlightNumber;
                                    infoFlightNumber = Console.ReadLine();

                                    int infoFlightNumberIndex = -1;

                                    int k = -1;
                                    foreach (var flight in flightCollection)
                                    {
                                        k++;
                                        if (infoFlightNumber == flight.FlightNumber)
                                        {
                                            infoFlightNumberIndex = k;
                                        }
                                    }

                                    if (infoFlightNumberIndex == -1)
                                    {
                                        Console.WriteLine("Wrong FlightNumber!!!");
                                        Console.Beep();
                                        break;
                                    }
                                    break;
                               case '4':
                                    Console.WriteLine("DepartureAirport:");
                                    string infoDepartureAirport;
                                    infoDepartureAirport = Console.ReadLine();

                                    int infoFlightDepAirIndex = -1;

                                    int l = -1;
                                    foreach (var flight in flightCollection)
                                    {
                                        l++;
                                        if (infoDepartureAirport == flight.DepartureAirport)
                                        {
                                            infoFlightDepAirIndex = l;
                                        }
                                    }

                                    if (infoFlightDepAirIndex == -1)
                                    {
                                        Console.WriteLine("Wrong DepartureAirport!!!");
                                        Console.Beep();
                                        break;
                                    }
                                    break;
                                case '5':
                                    Console.WriteLine("ArrivalAirport:");
                                    string infoArrivalAirport;
                                    infoArrivalAirport = Console.ReadLine();

                                    int infoFlightArrAirIndex = -1;

                                    int m = -1;
                                    foreach (var flight in flightCollection)
                                    {
                                        m++;
                                        if (infoArrivalAirport == flight.ArrivalAirport)
                                        {
                                            infoFlightArrAirIndex = m;
                                        }
                                    }

                                    if (infoFlightArrAirIndex == -1)
                                    {
                                        Console.WriteLine("Wrong ArrivalAirport!!!");
                                        Console.Beep();
                                        break;
                                    }
                                    break;
                            }
                                    #endregion

                            break;


                            case 'x':
                            exitKeyPassed = true;
                            break;
                    }



                    Console.ReadKey();
                } while (!exitKeyPassed);

            }
        }
    }
}

