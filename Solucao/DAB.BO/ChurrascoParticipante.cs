namespace DAB.BO
{
    public class ChurrascoParticipante : Generic.GenericAbstractEntity<DTO.ChurrascoParticipante>
    {
        /// <summary>
        /// Implementa o deletar
        /// </summary>
        /// <param name="entity"></param>
        public override void Deleta(DTO.ChurrascoParticipante participante)
        {
            // atualiza o valor 
            if (participante.ValorContribuicao.HasValue)
            {
                var churrascoBO = new BO.Churrasco();
                var churrasco = churrascoBO.BuscaPorID(participante.IdChurrasco);
                churrasco.ValorArrecadado -= participante.ValorContribuicao.Value;
                churrascoBO.Atualiza(churrasco);
            }

            base.Deleta(participante);
        }

        /// <summary>
        /// Implementa o deletar
        /// </summary>
        /// <param name="entity"></param>
        public override void Adiciona(DTO.ChurrascoParticipante participante)
        {
            // atualiza o valor 
            if (participante.ValorContribuicao.HasValue && participante.Pago)
            {
                var churrascoBO = new BO.Churrasco();
                var churrasco = churrascoBO.BuscaPorID(participante.IdChurrasco);
                churrasco.ValorArrecadado += participante.ValorContribuicao.Value;
                churrascoBO.Atualiza(churrasco);
            }

            base.Adiciona(participante);
        }


    }
}
