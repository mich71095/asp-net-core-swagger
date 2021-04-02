using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Todo.Demo.Models
{
    public class Customer
    {
        /// <summary>
        /// Customer Id
        /// </summary>
        [Required]
        public int Id { get; set; }
        
        /// <summary>
        /// Name
        /// </summary>
        [DefaultValue("John Doe")]
        public string Name { get; set; }
        
        /// <summary>
        /// Address
        /// </summary>
        public string Address { get; set; }
    }
}