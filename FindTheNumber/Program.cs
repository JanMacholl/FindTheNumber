using System;



public class FindTheNumber
{

    static void Main(string[] args)
    {   //zunächst einmal die Daten um die es geht
        string eing;
        int geraten;
        int geheim;
        int versuche = 0;
        {   //Rechner wählt eine zufällige Zahl aus
            Random zufall = new Random();
            geheim = zufall.Next(1001);
            
            do
            {   //Die Aufforderung eine Zahl einzugeben mit der demensprechenden ReadLine
                Console.Write("Zahl eingeben (0-1000): ");
                eing = Console.ReadLine();
                //Den eingegebenen Text in eine Ganzzahl konvertieren. Daher Convert.ToInt32
                geraten = Convert.ToInt32(eing);

                if (geraten < geheim)
                {
                    Console.WriteLine("Diese Zahl ist zu klein");
                }
                if (geraten > geheim)
                {
                    Console.WriteLine("Diese Zahl ist zu groß");
                }
                //versuchscounter immer um einen erhöhen, wenn das geratene "ungleich" der geheimen Zahl und versuche ist.
                versuche = versuche + 1;
            } while (geraten != geheim && versuche < 6);
            // Wenn das geratene gleich der Geheimzahl ist, gebe folgenden Satz aus. 
            if (geraten == geheim)
            {
                Console.WriteLine("Klasse, du hast die Zahl erraten und du hast nur " + versuche
                + " Versuche benötigt");
            }
            else //Ist dies nicht der Fall gebe folgenden Satz aus. 
            {
                Console.WriteLine("Verloren es wäre " + geheim
                    + " gewesen!");
            }
            Console.ReadKey();
        }
    }
}





