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

        [TestMethod]
        public void Teste255()
        {
            PegaMensagem pegaMensagem = new PegaMensagem();

            string res = pegaMensagem.PegaComando("2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_999_9999_2_22_222_3_33_333_4_44_444_5_55_555_6_66_666_7_77_777_7777_8_88_888_9_99_9999");

            Assert.AreEqual("NÃO É PERMITIDO MENSAGEM ACIMA DE 255 CARACTERES", res);
        }
    }
}
