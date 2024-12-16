// Initialisation de la taille et du poids
int taille, poids;

Console.Write("--- Quelle taille je dois prendre ? --- \n\n");

// Utilisation du Console.ReadLine & Int.Parse pour avoir la valeur de l'utilisateur
Console.Write("Entrez votre taille (en cm) : ");
taille = int.Parse(Console.ReadLine());

Console.Write("Entrez votre poids (en kg) : ");
poids = int.Parse(Console.ReadLine());

// Différent If else pour déterminé la taille et le poid 
// If ... else pour la catégorie 1
if
    ((poids >= 43 && poids <= 47) && (taille >= 145 && taille <= 169) ||
    (poids >= 48 && poids <= 53) && (taille >= 145 && taille <= 166) ||
    (poids >= 54 && poids <= 59) && (taille >= 145 && taille <= 163) ||
    (poids >= 60 && poids <= 65) && (taille >= 145 && taille <= 160))
    {
        Console.Write("\n\n Prenez la taille 1\n\n");
    }

//If ... Else pour la catégorie 2
else if 
    ((poids >= 48 && poids <= 53) && (taille >= 169 && taille <= 178) || 
    (poids >= 54 && poids <= 59) && (taille >= 166 && taille <= 175) || 
    (poids >= 60 && poids <= 65) && (taille >= 163 && taille <= 172) || 
    (poids >= 66 && poids <= 71) && (taille >= 160 && taille <= 169))
        {
            Console.Write("\n\n Prenez la taille 2\n\n");
        }

//If ...else Pour la catégorie 3
else if 
    ((poids >= 54 && poids <= 59) && (taille >= 178 && taille <= 183) || 
    (poids >= 60 && poids <= 65) && (taille >= 175 && taille <= 183) || 
    (poids >= 66 && poids <= 71) && (taille >= 172 && taille <= 183) || 
    (poids >= 72 && poids <= 77) && (taille >= 163 && taille <= 183))
{
    Console.Write("\n\n Prenez la taille 3 \n\n");
            }

//En cas qu'aucun des choix de l'utilisateur rentre dans les catégorie
else
    {
        Console.Write("\n\n Aucune taille ne vous correspond \n\n");
    }

