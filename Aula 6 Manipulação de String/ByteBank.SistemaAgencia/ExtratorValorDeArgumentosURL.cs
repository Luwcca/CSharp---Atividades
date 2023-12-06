using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        string URL {  get;}

        private readonly string _argumentos;


        public ExtratorValorDeArgumentosURL(string url)
        {

            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("o argumento não pode ser nulo ou vazio", nameof(url));
            }

            

            int indiceInterrogação = url.IndexOf('?');

            _argumentos = url.Substring(indiceInterrogação + 1);


            URL = url;

        }

        // moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "="; // moedaDestino=
            int indiceTermo = argumentoEmCaixaAlta.IndexOf(termo); // x

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('&');

            //o IndexOF retorna -1 caso não exista 
            if (indiceEComercial == -1)
            {
                return resultado;
            }




            return resultado.Remove(indiceEComercial);


        }


    }
}
