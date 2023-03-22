using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureClasswork5.Class
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Book> Books { get; set; }

        public Author()
        {
            Books = new List<Book>();
        }
        public override string ToString()
        {
            string str = $"{Surname}'s Books:\n";
            foreach(var item in Books)
            {
                str += $"{item.Title}\n";
            }
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}\n{str}";
        }
    }
}
