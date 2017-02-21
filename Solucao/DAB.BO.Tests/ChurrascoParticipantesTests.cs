using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB.BO.Tests
{
    [TestClass]
    public class ChurrascoParticipantesTests
    {

        public int IdChurrasco { get; set; }
        public List<int> Ids { get; set; }


        [TestInitialize]
        public void Inicializa()
        {
            Ids = new List<int>();
            var churrasco = new ChurrascoTests();
            churrasco.Insert();
            IdChurrasco = churrasco.Id;

            Assert.AreNotEqual(0, IdChurrasco);
        }

        [TestMethod]
        public void ValidaCrud()
        {
            var participante1 = new DTO.ChurrascoParticipante()
            {
                IdChurrasco = IdChurrasco,
                Nome = "Darlan Hendges",
                Pago = true,
                DataInscricao = DateTime.Now,
                ValorContruicao = 25.5M,
                ComBebida = true
            };

            var participante2 = new DTO.ChurrascoParticipante()
            {
                IdChurrasco = IdChurrasco,
                Nome = "Erci Hendges",
                Pago = true,
                DataInscricao = DateTime.Now,
                ValorContruicao = 15.5M,
                ComBebida = false
            };

            var participante3 = new DTO.ChurrascoParticipante()
            {
                IdChurrasco = IdChurrasco,
                Nome = "Evandro Carlos Hendges",
                Pago = false,
                DataInscricao = DateTime.Now,
                ValorContruicao = 0,
                ComBebida = false
            };

            var bo = new BO.ChurrascoParticipante();

            bo.Adiciona(participante1);
            Assert.AreNotEqual(0, participante1.Id);

            bo.Adiciona(participante2);
            Assert.AreNotEqual(0, participante2.Id);

            bo.Adiciona(participante3);
            Assert.AreNotEqual(0, participante3.Id);

            Ids.Add(participante1.Id);
            Ids.Add(participante2.Id);
            Ids.Add(participante3.Id);
        }

        [TestCleanup]
        public void Finaliza()
        {
            var churrasco = new BO.Churrasco().BuscaPorID(IdChurrasco);

            foreach (int id in Ids)
            {
                var participante = new DAB.BO.ChurrascoParticipante().BuscaPorID(id);
                new BO.ChurrascoParticipante().Deleta(participante);


                participante = new DAB.BO.ChurrascoParticipante().BuscaPorID(id);

                if (participante != null)
                {
                    throw new Exception("Erro, não excluiu o participante!");
                }
            }
        }
    }
}
