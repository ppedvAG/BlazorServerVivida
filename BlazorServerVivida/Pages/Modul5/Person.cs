using System.ComponentModel.DataAnnotations;

namespace BlazorServerVivida.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Muss was rein")]
        [StringLength(10, ErrorMessage="max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Muss was rein")]
        [Range(120,190, ErrorMessage="zwischen 120 und 190")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "Muss was rein")]
        public DateTime GebTag { get; set; }
    }
}
