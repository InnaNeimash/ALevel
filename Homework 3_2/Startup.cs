using Homework_3_2.Model;
using Homework_3_2.Service.Abstaction;

namespace Homework_3_2
{
    internal class Startup
    {
        private readonly IPhoneBookService _phonebookService;
        public Startup(IPhoneBookService phonebookService)
        {
            _phonebookService = phonebookService;
        }
        public void Stat()
        {
            GetPhoneBook();
            SortByCulture();
        }
        private void GetPhoneBook()
        {
            var phonebooks = _phonebookService.GetPhoneBooks();
            Console.WriteLine("Your phonebook: ");
            foreach (var phonebook in phonebooks)
            {
                Console.WriteLine(phonebook.ToString());
            }
        }
        private void SortByCulture()
        {
            var phonebooks = _phonebookService.GetPhoneBooks();
            var phonebooks1 = new List<PhoneBook>();
            var phonebooks2 = new List<PhoneBook>();
            var phonebooks3 = new List<PhoneBook>();
            Console.WriteLine("Change the culture: 1-English, 2-Ukrainian");
            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                foreach (var phonebook in phonebooks)
                {
                    if (phonebook.FoolName == "-")
                    {
                        phonebooks1.Add(phonebook);
                    }
                    else if(phonebook.FoolName=="")
                    {
                        phonebooks3.Add(phonebook);
                    }
                    else phonebooks2.Add(phonebook);

                } 
                phonebooks2.Sort((x, y) => string.Compare(x.FoolName, y.FoolName, StringComparison.InvariantCulture));
                Console.WriteLine("Phonebook sorted by fool name");
                foreach (var phonebook in phonebooks2)
                { Console.WriteLine(phonebook.ToString()); }
                phonebooks1.Sort((x, y) => x.Number.CompareTo(y.Number));
                 Console.WriteLine("Phoneboook sorted by number");
                foreach (var phonebook in phonebooks1)
                { Console.WriteLine(phonebook.ToString()); }
                Console.WriteLine("Phoneboook sorted");
                foreach (var phonebook in phonebooks3)
                { Console.WriteLine(phonebook.ToString()); }
            }
            else
            {
                foreach (var phonebook in phonebooks)
                {
                    if (phonebook.FoolName == "-")
                    {
                        phonebooks1.Add(phonebook);
                    }
                    else if (phonebook.FoolName == "")
                    {
                        phonebooks3.Add(phonebook);
                    }
                    else phonebooks2.Add(phonebook);
                }
                phonebooks2.Sort((x, y) => string.Compare(x.FoolName, y.FoolName, StringComparison.CurrentCulture));
                Console.WriteLine("Phonebook sorted by fool name");
                foreach (var phonebook in phonebooks2)
                { Console.WriteLine(phonebook.ToString()); }
                phonebooks1.Sort((x, y) => x.Number.CompareTo(y.Number));
                Console.WriteLine("Phoneboook sorted by number");
                foreach (var phonebook in phonebooks1)
                { Console.WriteLine(phonebook.ToString()); }
                Console.WriteLine("Phoneboook sorted");
                foreach (var phonebook in phonebooks3)
                { Console.WriteLine(phonebook.ToString()); }
            }
        }
    }
}

                
                        
                    
                    
                



                  

                    


                  
                
           
           
        
                
               
