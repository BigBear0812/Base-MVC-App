using System.ComponentModel.DataAnnotations;

namespace DatabaseModels
{
    public class ToDoItem
    {
        [Key]
        public int ItemId { get; set; }
        public int ListId { get; set; }
        public int Quantity { get; set; }
        public string ItemName { get; set; }
    }
}
