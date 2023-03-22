using System.Text.Json;
using System.Text.Json.Serialization;

namespace DollarCoder.Models
{
    public class RandomCode
    {
        public int Id { get; set; }
        public string CodeLanguage { get; set; }
        public string[] CodeText { get; set; }



        //List that populates the Game.cs list that Takes random code strings and print the output
        public static List<string> RandomCodes = new List<string> {""};

        //List that is populated with the random code languages in RandomCode.json
        public static List<RandomCode> CodeDB = new List<RandomCode>();

        //Populates the RandomCodes list with the code text in RandomCode.json
        public void LoadCodeLanguage(int selectedLanguage)
        {

            if (RandomCodes.Count > 0)
            {
                RandomCodes.Clear();

            }

            foreach (string code in CodeDB[selectedLanguage].CodeText)
            {
                RandomCodes.Add(code);
                
            }

        }
    }
}
