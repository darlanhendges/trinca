using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity
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

        /// <summary>
        /// Obtém ou define Quando.
        /// </summary>
        public DateTime Quando { get; set; }

        /// <summary>
        /// Obtém ou define Porque.
        /// </summary>
        public string Porque { get; set; }

        /// <summary>
        /// Obtém ou define Observacao.
        /// </summary>
        public string Observacao { get; set; }

        /// <summary>
        /// Obtém ou define PrecoSugeridoSemBebida.
        /// </summary>
        public decimal PrecoSugeridoSemBebida { get; set; }

        /// <summary>
        /// Obtém ou define PrecoSugeridoComBebido.
        /// </summary>
        public decimal PrecoSugeridoComBebido { get; set; }

        /// <summary>
        /// Obtém ou define ValorArrecadado.
        /// </summary>
        public decimal ValorArrecadado { get; set; }

    }

}
