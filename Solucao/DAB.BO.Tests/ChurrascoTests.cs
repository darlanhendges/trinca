using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB.BO.Tests
{
    [TestClass]
    public class ChurrascoTests
    {
        public int Id { get; set; }
        private DateTime DtOriginal { get; set; }

        [TestMethod]
        public void ValidaCrud()
        {
            Insert();
            Find();
            Update();
            Delete();
        }


        public void Delete()
        {
            var churrasco = new BO.Churrasco().BuscaPorID(Id);
            new BO.Churrasco().Deleta(churrasco);

            churrasco = new BO.Churrasco().BuscaPorID(Id);
            Assert.AreEqual(null, churrasco);
        }

        public void Update()
        {
            var churrasco = new BO.Churrasco().BuscaPorID(Id);
            churrasco.Quando = churrasco.Quando.AddDays(10);
            new BO.Churrasco().Atualiza(churrasco);


            churrasco = new BO.Churrasco().BuscaPorID(Id);
            Assert.AreEqual(churrasco.Quando, DtOriginal.AddDays(10));
        }

        public void Find()
        {
            var churrasco = new BO.Churrasco().BuscaPorID(Id);

            Assert.AreNotEqual(null, churrasco);
            Assert.AreEqual("Aniversário da Suélen", churrasco.Porque);
            Assert.AreEqual("Vamos que vai bombar. Cada um leva sua namorada ou namorado e vamos ver o que dá. A noite é uma criança.", churrasco.Observacao);
        }

        public void Insert()
        {
            var churrasco = new DAB.DTO.Churrasco()
            {
                Porque = "Aniversário da Suélen",
                Observacao = "Vamos que vai bombar. Cada um leva sua namorada ou namorado e vamos ver o que dá. A noite é uma criança.",
                Quando = DateTime.Now.AddDays(2),
                PrecoSugeridoComBebido = 10,
                PrecoSugeridoSemBebida = 25,
                ValorArrecadado = 0
            };


            var churrascoBO = new DAB.BO.Churrasco();

            churrascoBO.Adiciona(churrasco);
            Assert.AreNotEqual(null, churrasco.Id);

            Id = churrasco.Id;
            DtOriginal = churrasco.Quando;
        }

    }
}
