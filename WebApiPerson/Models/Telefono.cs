using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPerson.Models
{
    public class Telefono
    {
        [Key]
        public  int  TelId { get; set; }

      
        public int PersonId { get; set; }
        public Person persona { get; set; }

        public string Numero { get; set; }
    }
}
