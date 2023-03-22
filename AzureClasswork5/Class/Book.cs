using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureClasswork5.Class
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Title: {Title}, AuthorId: {AuthorId}";
        }
    }
}
