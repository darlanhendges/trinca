using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB.DTO
{
    /// <summary>
    /// Representa uma ChurrascoParticipante.
    /// </summary>
    [Table("ChurrascoParticipante")]
    public partial class ChurrascoParticipante
    {
        /// <summary>
        /// Define o construtor da classe
        /// </summary>
        public ChurrascoParticipante()
        {

        }

        /// <summary>
        /// Obtém ou define Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtém ou define IdChurrasco.
        /// </summary>
        public int IdChurrasco { get; set; }

        /// <summary>
        /// Obtém ou define Nome.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Obtém ou define ValorContribuicao.
        /// </summary>
        public decimal? ValorContribuicao { get; set; }

        /// <summary>
        /// Obtém ou define ComBebida.
        /// </summary>
        public bool ComBebida { get; set; }

        /// <summary>
        /// Obtém ou define Pago.
        /// </summary>
        public bool Pago { get; set; }

        /// <summary>
        /// Obtém ou define DataInscricao.
        /// </summary>
        public DateTime DataInscricao { get; set; }

    }

}
