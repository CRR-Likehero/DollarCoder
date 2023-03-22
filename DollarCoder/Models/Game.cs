namespace DollarCoder.Models
{
    public class Game
    {
        public static int dollars { get; set; }
        public static string text = "";

        public static Random rand = new Random();
        public static int randomIndex = rand.Next(RandomCode.RandomCodes.Count);
        public static string sentence = RandomCode.RandomCodes[randomIndex];
        public static int charIndex = 0;
        public static int counter = 0;

        public void RandomText()
        {
            if (charIndex < sentence.Length)
            {
                text += (sentence[charIndex]);
                charIndex++;
                counter++;

            }
            else
            {
                text += "\r\n" + "\r\n";
                randomIndex = rand.Next(RandomCode.RandomCodes.Count);
                sentence = RandomCode.RandomCodes[randomIndex];
                charIndex = 0;
            }
        }

        public void IncreaseStats()
        {
           if (counter == 10)
            {
                IncrementDollars();
                Player.DecreaseEnergy();
                counter = 0;
            }
                
        }

        public void IncrementDollars()
        {
            dollars++;

        }

    }
}

