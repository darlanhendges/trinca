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
            if (participante.ValorContruicao.HasValue)
            {
                var churrascoBO = new BO.Churrasco();
                var churrasco = churrascoBO.BuscaPorID(participante.IdChurrasco);
                churrasco.ValorArrecadado -= participante.ValorContruicao.Value;
                churrascoBO.Atualiza(churrasco);
            }

            base.Deleta(participante);
        }

    }
}
