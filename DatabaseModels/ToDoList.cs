using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class ToDoList
    {
        [Key]
        public int ListId { get; set; }
        public string ListName { get; set; }

        public ICollection<ToDoItem> Items { get; set; }
    }
}
