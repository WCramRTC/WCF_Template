using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace CharLib
{
    [ServiceContract]
    public interface ICharacterService
    {

        [OperationContract]
        Character GetChar(string name);

        [OperationContract]
        void PopulateList();

        [OperationContract]
        List<Character> ListOfCharacters();

    } // End ICharacterService

    [DataContract]
    public class Character
    {
        // Fields
        [DataMember]
        private string _name;
        [DataMember]
        private int _age;
        [DataMember]
        private string _race;
        [DataMember]
        private string _job;

        public Character(string name, int age, string race, string job)
        {
            Name = name;
            Age = age;
            Race = race;
            Job = job;
        }

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public string Race { get => _race; set => _race = value; }
        public string Job { get => _job; set => _job = value; }
    }
}
