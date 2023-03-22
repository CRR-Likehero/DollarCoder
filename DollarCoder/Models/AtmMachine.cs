namespace DollarCoder.Models
    
{
    public class AtmMachine
    {

        public static List<string> PinCodes = new List<string>();

        public int WithDrawAmount { get; set; }
        public int DepositAmount { get; set; }
        public static int Balance { get; set; }

        public bool Error = false;

        public void Deposit()
        { 
            if( DepositAmount > Game.dollars)
            {
               
                Error = true;

            } else
            {
                Balance += +DepositAmount;

                Game.dollars -= DepositAmount;

                Error = false;

            }
        }

        public void WithDraw()
        {
            if (WithDrawAmount > Balance)
            {
                Error = true;
            } else
            {
                Balance -= WithDrawAmount;

                Game.dollars += WithDrawAmount;

                Error = false;

            }

        }

        public static void SearchForPin(string code)
        {
            Console.WriteLine(code);
            Console.WriteLine(PinCodes.Count);
            if(PinCodes.Contains(code))
            {
                Console.WriteLine("Succes");
                Player.LoggedIn = true;
            } else
            {
                Console.WriteLine("Pin is not found");
            }
            
        }
    }
}
