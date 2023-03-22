namespace DollarCoder.Models

{
    public class Player
    {
        public string Name { get; set; }
        public int AtmBalance { get; set; }
        public static string PinCode { get; set ; }
       
        public static int Energy { get; set; } = 100;
        public static int EnergyBurn { get; set; } = 2;
        public static List<CoursesItem> CodesLanguagesOwned = new List<CoursesItem>();
        public List<FoodItems> PlayerBag { get; set; } = new List<FoodItems>();

        public static bool PlayeHavePin = false;

        public static bool LoggedIn = false;

        public void AddPincode()
        {
            AtmMachine.PinCodes.Add(PinCode);
            PlayeHavePin = true;
        }

        public static void DecreaseEnergy()
        {
            if(Game.counter == 10)
            {
                Energy -= EnergyBurn;
            }
            Console.WriteLine(Energy);
        }

        public void FillUpEnergy(FoodItems item)
        {
            Energy += item.EnergyBonus;
            PlayerBag.Remove(item);
        }

        public void LogOut()
        {
            LoggedIn = false;
        }

        public void BuyItem(FoodItems item)
        {
            if(AtmMachine.Balance < item.Price)
            {
                Console.WriteLine("Not enough money");

            } else
            {
                //temp money from atm
                AtmMachine.Balance -= item.Price;

                PlayerBag.Add(item);
            }

        }

        public void BuyCourse(CoursesItem item)
        {
            if (AtmMachine.Balance < item.Price)
            {
                Console.WriteLine("Not enough money");

            }
            else
            {
                //temp money from atm
                AtmMachine.Balance -= item.Price;

                CodesLanguagesOwned.Add(item);

            }


        }

    }
}
