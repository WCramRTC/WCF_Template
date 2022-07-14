using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace CharLib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]

    public class CharacterService : ICharacterService
    {

        List<Character> list = new List<Character>
        {
        };

        public Character GetChar(string name)
        {
            return list.Find(x => x.Name.ToLower() == name.ToLower());
        }

        public List<Character> ListOfCharacters()
        {
            return list;
        }

        public void PopulateList()
        {
            Random rand = new Random();
            string[] namesArray = { "Will", "Desi", "Elena", "Christine", "Khrystina", "Scott", "Moiz", "Eric", "Harry", "Nathan", "Josh" };
            string[] jobsArray = { "Mage", "Warrior", "Bard", "Druid", "Warlock", "Paladin" };
            string[] raceArray = { "Human", "Gnome", "Dwarf", "Orc", "Goblin", "Elf" };

            list.Clear();

            Character c = null;

            for (int i = 0; i < 5; i++)
            {
                c = new Character(
                    namesArray[rand.Next(namesArray.Length)],
                    rand.Next(20, 50),
                    jobsArray[rand.Next(jobsArray.Length)],
                    raceArray[rand.Next(raceArray.Length)]
                    );

                list.Add(c);
            }
        }
    }
}
