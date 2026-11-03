namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    { 
       
        //Arthur dispose de 5 flèches pour chasser un cerf.
        int fleches = 5;
        //Consignes :
        //Demander au joueur si chaque tir touche ou rate la cible.
        Console.WriteLine("Tu touche ou rate la cible ?");
        string reponse = Console.ReadLine();
        //Décrémenter le nombre de flèches après chaque tir.
        fleches--;
        //Compter le nombre de tirs réussis.
        int tirsReussis = 0;
        if (reponse == "touche")
        {
            tirsReussis++;
        }
        else if (reponse == "rate")
        {
            //rien
        }
        else
        {
            Console.WriteLine("Répons par 'touche' ou 'rate'.");
            //Ne pas décrémenter le nombre de flèches pour une réponse invalide.
            fleches++;
        }
        //Arrêter la chasse lorsque les 5 flèches sont utilisées.
        if (fleches == 0)
        {
            Console.WriteLine("Chasse terminée!");
        }
        //Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        //Si la saisie est invalide, demander une nouvelle réponse
        //sans consommer de flèche.
        //Afficher le bilan final de la chasse.
        
    }
}
