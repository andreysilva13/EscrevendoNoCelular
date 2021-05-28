using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EscrevendoNoCelular;

namespace Teste
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        public void Invalido()
        {
            PegaMensagem pegaMensagem = new PegaMensagem();

            string res = pegaMensagem.PegaComando("123131313a");

            Assert.AreEqual("HÁ UM COMANDO INVÁLIDO", res);
        }

        [TestMethod]
        public void BD()
        {
            PegaMensagem pegaMensagem = new PegaMensagem();

            string res = pegaMensagem.PegaComando("223");

            Assert.AreEqual("BD", res);
        }

        [TestMethod]
        public void Rech()
        {
            PegaMensagem pegaMensagem = new PegaMensagem();

            string res = pegaMensagem.PegaComando("77773367_7773302_222337777_777766606660366656667889999_9999555337777");

            Assert.AreEqual("SEMPRE ACESSO O DOJOPUZZLES", res);
        }
    }
}
