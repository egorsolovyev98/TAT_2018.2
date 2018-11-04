using System;

namespace task_DEV5
{
    /// <summary>
    /// Menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// The car catalog.
        /// </summary>
        private CarCatalog carCatalog;


        /// <summary>
        /// The command.
        /// </summary>
        private ICommand command;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="carCatalog">Car catalog.</param>
        public Menu(CarCatalog carCatalog)
        {
            this.carCatalog = carCatalog;
        }


        /// <summary>
        /// Shows the commands.
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Enter command:\n" +
                              "1.add brand model amount price\n" +
                              "2.count types\n" +
                              "3.count all\n" +
                              "4.average price\n" +
                              "5.average price type\n" +
                              "6.exit\n");
            string brand;
            string model;
            int amount;
            double price;
            bool exit = false;
        
            while (!exit)
            {
                string[] inputString = Console.ReadLine().Split(' ');
                AvailableCommands commands = GetCommand(inputString);

                switch (commands)
                {
                    case AvailableCommands.Add:
                        brand = inputString[1];
                        model = inputString[2];
                        amount = Convert.ToInt32(inputString[3]);
                        price = Convert.ToDouble(inputString[4]);
                        Car car = new Car(brand, model, amount, price);
                        command = new Add(carCatalog,car);
                        break;

                    case AvailableCommands.CountTypes:
                        command = new CountTypes(carCatalog);
                        break;

                    case AvailableCommands.CountAll:
                        command = new CountAll(carCatalog);
                        break;

                    case AvailableCommands.AveragePrice:
                        command = new AveragePrice(carCatalog);
                        break;

                    case AvailableCommands.AveragePriceType:
                        brand = inputString[2];
                        command = new AveragePriceType(carCatalog, brand);
                        break;

                    case AvailableCommands.Exit:
                        exit = true;
                        break;

                    case AvailableCommands.NoCommand:
                        Console.WriteLine("Not a command. Try again.");
                        break;
                }

                if ((commands != AvailableCommands.Exit) && (commands != AvailableCommands.NoCommand))
                {
                    command.Execute();
                }
            }

        }


        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <returns>The command.</returns>
        /// <param name="str">String.</param>
        private AvailableCommands GetCommand(string[] str)
        {
           
            if ((str.Length == 5) && str[0].ToLower() == "add")
            {
                return AvailableCommands.Add;
            }
            else if (str[0].ToLower() == "exit")
            {
                return AvailableCommands.Exit;
            }
            else if ((str.Length == 2) && str[0].ToLower() == "count" && str[1].ToLower() == "types")
            {
                return AvailableCommands.CountTypes;
            }
            else if ((str.Length == 2) && str[0].ToLower() == "count" && str[1].ToLower() == "all")
            {
                return AvailableCommands.CountAll;
            }
            else if ((str.Length == 2) && str[0].ToLower() == "average" && str[1].ToLower() == "price")
            {
                return AvailableCommands.AveragePrice;
            }
            else if ((str.Length == 3) && str[0].ToLower() == "average" && str[1].ToLower() == "price")
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