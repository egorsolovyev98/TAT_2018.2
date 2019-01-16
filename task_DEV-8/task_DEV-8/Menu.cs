using System;
using System.Collections.Generic;

namespace task_DEV8
{
    /// <summary>
    /// Menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private VehicleCatalog carCatalog;


        /// <summary>
        /// The truck catalog.
        /// </summary>
        private VehicleCatalog truckCatalog;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public Menu(VehicleCatalog carCatalog, VehicleCatalog truckCatalog)
        {
            this.carCatalog = carCatalog;
            this.truckCatalog = truckCatalog;
        }


        /// <summary>
        /// Shows the commands.
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Enter command:\n" +
                              "1.execute\n" +
                              "2.count_types truck(car)\n" +
                              "3.count_all truck(car)\n" +
                              "4.average_price truck(car)\n" +
                              "5.average_price truck(car) type\n");

            var commandsList = new List<ICommand>();
            string brand;
            bool execute = false;
            VehicleCatalog catalog;
            AvailableCommands command;

            while (!execute)
            {
                string[] inputString = Console.ReadLine().Split(' ');
                command = GetCommand(inputString);

                if ((command != AvailableCommands.Execute) && (command != AvailableCommands.NoCommand))
                {
                    catalog = GetVehicleCatalog(inputString);
                }
               
                switch (command)
                {
                    case AvailableCommands.CountTypes:
                        commandsList.Add(new CountTypesCommand(carCatalog));
                        break;

                    case AvailableCommands.CountAll:
                        commandsList.Add(new CountAllCommand(carCatalog));
                        break;

                    case AvailableCommands.AveragePrice:
                        commandsList.Add(new AveragePriceCommand(carCatalog));
                        break;

                    case AvailableCommands.AveragePriceType:
                        brand = inputString[1];
                        commandsList.Add(new AveragePriceTypeCommand(carCatalog, brand));
                        break;

                    case AvailableCommands.Execute:
                        execute = true;
                        break;

                    case AvailableCommands.NoCommand:
                        Console.WriteLine("Not a command. Try again.");
                        break;
                }
            }

            foreach(var i in commandsList)
            {
                i.Execute();
            }
        }


        /// <summary>
        /// Gets the vehicle catalog.
        /// </summary>
        /// <returns>The vehicle catalog.</returns>
        /// <param name="inputString">Input string.</param>
        private VehicleCatalog GetVehicleCatalog(string[] inputString)
        {
            return inputString[1].Equals("car") ? carCatalog : truckCatalog;
        }


        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <returns>The command.</returns>
        /// <param name="str">String.</param>
        private AvailableCommands GetCommand(string[] str)
        {
            if (str[0].ToLower().Equals("execute"))
            {
                return AvailableCommands.Execute;
            }
            else if (str[0].ToLower().Equals("count_types"))
            {
                return AvailableCommands.CountTypes;
            }
            else if (str[0].ToLower().Equals("count_all"))
            {
                return AvailableCommands.CountAll;
            }
            else if (str[0].ToLower().Equals("average_price"))
            {
                return AvailableCommands.AveragePrice;
            }
            else if ((str.Length == 3) && str[0].ToLower().Equals("average_price"))
            {
                return AvailableCommands.AveragePriceType;
            }
            else
            {
                return AvailableCommands.NoCommand;
            }
        }
    }
}