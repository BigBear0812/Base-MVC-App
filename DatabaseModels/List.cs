using System.Collections.Generic;

namespace DatabaseModels
{
    public class List
    {
        public int ListId { get; set; }
        public string ListName { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
