namespace ClasseEmail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Esercizio - ClasseEmail
             Si consideri di voler gestire un email. Sono richiesti i seguenti dati: DA, A, CC, BCC, Oggetto, Messaggio, Data (default), 
            Priorità  con i valori: BASSA, NORMALE (default) o ALTA. Si ipotizzi che nei campi DA, A CC e BCC si possa inserire solo un indirizzo email.

             Si richiede di creare tre istanze, assegnando per ognuna una priorità differente.
             */

            Email email = new Email
            {
                Da = "io@gmail.com",
                A = "destinatario@gmail.com",
                CC = "copia@gmail.com",
                BCC = "copiaNascosta@gmail.com",
                Messaggio = "Mex prova.",
                Data = DateTime.Now,
                Priorita = Priorita.ALTA
            };

            Email email1 = new Email
            {
                Da = "io@gmail.com",
                A = "destinatario@gmail.com",
                CC = "copia@gmail.com",
                BCC = "copiaNascosta@gmail.com",
                Messaggio = "Mex prova.",
                Data = DateTime.Now,
                Priorita = Priorita.BASSA
            };

            Email email2 = new Email
            {
                Da = "io@gmail.com",
                A = "destinatario@gmail.com",
                CC = "copia@gmail.com",
                BCC = "copiaNascosta@gmail.com",
                Messaggio = "Mex prova.",
                Data = DateTime.Now,
                Priorita = Priorita.NORMALE
            };

            // Stampa dell'email
            Console.WriteLine(email.Stampa());
            Console.WriteLine(email1.Stampa());
            Console.WriteLine(email2.Stampa());




            // Determina azioni in base alla priorità

        }
    }
}