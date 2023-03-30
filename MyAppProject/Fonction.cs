namespace Fonction;

public class Fonction
{
    public static double CalculerPerimetreCarre(double cote)
    {
        return 4.0 * cote;
    }

    public static double CalculerPerimetreCercle(double rayon)
    {
        return 3.1416 * 2 * rayon;
    }


    public static void AfficherLesPerimetres(double cote, double rayon)
    {
        Console.WriteLine("Le perimetre du carre est de " + CalculerPerimetreCarre(cote));
        Console.WriteLine("Le perimetre du cercle est de " + CalculerPerimetreCercle(rayon));
    }
}
