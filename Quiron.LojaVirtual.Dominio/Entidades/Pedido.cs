using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class Pedido
    {
        [Display(Name = "Nome:")]
        [Required (ErrorMessage="Infome seu nome")]
        public string NomeCliente { get; set; }
        
        [Display(Name="Cep:")]
        public string Cep { get; set; }

        [Display(Name = "Endereço:")]
        [Required(ErrorMessage = "Infome seu endereço")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Infome sua cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Infome seu bairro")]
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Infome seu estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Infome seu numero")]
        [Display(Name = "Número:")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Infome seu email")]
        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage="Email inválido")]
        public string Email { get; set; }

        [Display(Name = "Embrulhar para presente ?")]
        public bool EmbrulharPresente { get; set; }
    }
}
