using System.ComponentModel.DataAnnotations;

namespace WebApiPerson.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }
        public List<Telefono>Telefonos { get; set; }
    }
}
