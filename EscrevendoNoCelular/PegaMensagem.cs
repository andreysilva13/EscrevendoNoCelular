using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class PegaMensagem
    {
        Comandos comandos;
        public string PegaComando(string comando)
        {
            string mensagemConvertida = "";
            bool pode = false;
            comandos = new Comandos();
            char[] comandoSeparado = comando.ToCharArray();
            foreach (char charSeparado in comandoSeparado)
            {
                if (charSeparado != '1' && charSeparado != '2' && charSeparado != '3'
                 && charSeparado != '4' && charSeparado != '5'
                 && charSeparado != '6' && charSeparado != '7'
                 && charSeparado != '8' && charSeparado != '9'
                 && charSeparado != '0' && charSeparado != '_')
                    pode = false;
                else
                    pode = true;
            }
            if (pode)
                mensagemConvertida = comandos.Converter(comando);
            else
                mensagemConvertida = "HÁ UM COMANDO INVÁLIDO";
            return mensagemConvertida;
        }
    }
}
