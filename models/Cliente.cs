using System.ComponentModel.DataAnnotations;

namespace appweb1.models
{
    
    public class Cliente
    {
        [Key]
        public int Idcliente {get;set; }
        
        public string Nombres {get; set; }

        public string Apellidos {get; set; } 

        public String DNI { get; set; }
    }
}