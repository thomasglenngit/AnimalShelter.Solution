using System.Collections.Generic;

namespace PhoneBook.Models
{
    public class Category
    {
        public Category()
        {
            this.Animals = new HashSet<Animal>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Animal> Animals { get; set; }
    }
}