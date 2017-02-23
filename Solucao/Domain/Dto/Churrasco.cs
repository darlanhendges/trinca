using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB.DTO
{
    // <summary>
    /// Representa uma Churrasco.
    /// </summary>
    [Table("Churrasco")]
    public partial class Churrasco
    {
        /// <summary>
        /// Define o construtor da classe
        /// </summary>
        public Churrasco()
        {

        }

        /// <summary>
        /// Obtém ou define Id.
        /// </summary>
        public int Id { get; set; }

        [Display(Name="Data")]
        [Required(ErrorMessage = "{0} é requirido.")]
        [DataType(DataType.Date)]
        /// <summary>
        /// Obtém ou define Quando.
        /// </summary>
        public DateTime Quando { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "{0} é requirido.")]
        /// <summary>
        /// Obtém ou define Porque.
        /// </summary>
        public string Porque { get; set; }

        [Display(Name = "Obs")]
        [DataType(DataType.MultilineText)]
        /// <summary>
        /// Obtém ou define Observacao.
        /// </summary>
        public string Observacao { get; set; }

        [Display(Name = "Preço S/ Bebida")]
        [Required(ErrorMessage = "{0} é requirido.")]
        /// <summary>
        /// Obtém ou define PrecoSugeridoSemBebida.
        /// </summary>
        public decimal PrecoSugeridoSemBebida { get; set; }

        [Display(Name = "Preço C/ Bebida")]
        [Required(ErrorMessage = "{0} é requirido.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        /// <summary>
        /// Obtém ou define PrecoSugeridoComBebido.
        /// </summary>
        public decimal PrecoSugeridoComBebido { get; set; }

        [Display(Name = "Total Arrecadado")]
        [Required(ErrorMessage = "{0} é requirido.")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        /// <summary>
        /// Obtém ou define ValorArrecadado.
        /// </summary>
        public decimal ValorArrecadado { get; set; }
    }

}
