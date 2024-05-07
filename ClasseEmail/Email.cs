using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ClasseEmail
{
    internal class Email
    {
        public string Da { get; set; }
        public string A { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Messaggio { get; set; }
        public DateTime Data { get; set; }
        public Priorita Priorita { get; set; }

        public Email() // Costruttore predefinito
        {
            // Imposta valori predefiniti
            Data = DateTime.Now;
            Priorita = Priorita.NORMALE;
        }

        public Email(string da, string a, string cc, string bcc, string messaggio, DateTime data, Priorita priorita)
        {
            Da = da;
            A = a;
            CC = cc;
            BCC = bcc;
            Messaggio = messaggio;
            Data = data;
            Priorita = priorita;
        }

        public string DeterminaPriorita()
        {
            // Definisce il comportamento in base alla priorità
            switch (Priorita)
            {
                case Priorita.BASSA:
                    return "Azioni a bassa priorità";
                case Priorita.ALTA:
                    return "Azioni ad alta priorità";
                default:
                    return "Azioni a priorità normale";
            }
        }

         public string Stampa()
        {
            return $"" +
                $"\nDa: {Da}" +
                $"\nA: {A}" +
                $"\nCC: {CC}" +
                $"\nBCC: {BCC}" +
                $"\nMessaggio: {Messaggio}" +
                $"\nData: {Data}" + 
                $"\nPriorita: {Priorita}" +
                $"\nFrase: {DeterminaPriorita()}" 
                ;
        }
    }

    public enum Priorita
    {
        BASSA,
        NORMALE,
        ALTA
    }
}
