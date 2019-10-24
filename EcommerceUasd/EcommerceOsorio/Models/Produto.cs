using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceOsorio.Models
{
    [Table("Produtos")]
    public class Produto
    {
        //Annotations ASP.NET Core
        public Produto() { CriadoEm = DateTime.Now; }
        [Key]
        public int ProdutoId { get; set; }
        [Display(Name ="Nome:")]
        [Required(ErrorMessage = "Campo Obrigatório!")]
        public string Nome { get; set; }

        [Display(Name = "Descrição:")]
        [MinLength(5 , ErrorMessage ="Numero minimo de 5 caracteres!")]
        [MaxLength(100, ErrorMessage = "No maximo 100 caracteres!")]
        public string Descricao { get; set; }

        [Display(Name = "Quantidade:")]
        [Range(1, 1000, ErrorMessage ="No minimo 1 e no maximo 1000 produtos!")]
        public int Quantidade { get; set; }

        [Display(Name = "Preço:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public double Preco { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
