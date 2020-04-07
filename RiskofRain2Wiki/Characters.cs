using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskofRain2Wiki
{
    class Characters
    {
        public void CharacterList()
        {
            List<string> Characters = new List<string>();
            foreach (string character in new string[9] { "Commando", "Huntress", "MUL-T", "Engineer", "Artificer", "Mercenary", "Rex", "Loader", "Acrid" })
            {
                Characters.Add(character);
                Console.WriteLine(character);
            }
        }
        public void Commando()
        {
            Console.WriteLine("The Commando is the first playable character, and is very simple with few strengths or weaknesses. The commando benefits greatly from items like Soldier's Syringe and Hopoo Feather.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Huntress()
        {
            Console.WriteLine("The Huntress is an extremely mobile and powerful bow-wielder, but also very succeptible to damage.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void MULT()
        {
            Console.WriteLine("MUL-T is an aggressive survivor with two seperate left click abilities, and the ability to carry 2 different equipments, making him a very versatile survivor.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Engineer()
        {
            Console.WriteLine("The Engineer is a defensive survivor whose playstyle revolves around his Auto Turrets.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Artificer()
        {
            Console.WriteLine("The Artificer is a glass-cannon character whose abilities revolve around using the elements to her advantage.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Mercenary()
        {
            Console.WriteLine("The Mercenary is a high damage output sword wielder with high mobility and low health.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Rex()
        {
            Console.WriteLine("Rex is a low mobility character that is able to manage his healthpool very well, with multiple abilities that either heal or damage himself.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Loader()
        {
            Console.WriteLine("The Loader is a very high mobility character who utilizes the momentum from his grappling hook to damage high-health enemies.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
        public void Acrid()
        {
            Console.WriteLine("Acrid is a dinosaur-like creature who uses his poison spit to slowly wittle away his enemies.");
            Console.WriteLine("Do you want to see abilities, or useful items?");
        }
    }
}
