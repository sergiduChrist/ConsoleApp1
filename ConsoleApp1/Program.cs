// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
             // Entertainement
              Console.WriteLine("Hello, my name is Serj !");

            int number = 14;
            Console.WriteLine("int number is " + number);
            string animal = "Lion";
            Console.WriteLine("string animal is " + animal);
            char x = 'X';
            Console.WriteLine("char x is " + x);
            double numberTwo = 14.07;
            Console.WriteLine("double numberTwo is " + numberTwo);
            bool condition = false;
            Console.WriteLine("bool condition is " + condition);



           //DECLARATION DES VARIABLES
            string nam = "";
            decimal numberOne, number2, moyenne;

            //AFFICHAGE DU MESSAGE ET REUPERATION DE L'INFORMATION
            Console.WriteLine("Write your name PLEASE !");
            nam = Console.ReadLine();

            Console.WriteLine("Saisissez votre première note");
            numberOne = decimal.Parse(Console.ReadLine()); 
            Console.WriteLine("Saisissez votre deuxième note");
            number2 = decimal.Parse(Console.ReadLine());

            //CALCUL DE LA MOYENNE
            moyenne = (numberOne + number2) / 2;

            Console.WriteLine("votre nom est " + nam + " et vous avez comme moyenne " + moyenne);

            string userName = "";
            int âge, annéedeNaissance, enCours;

            Console.WriteLine("Quel est votre nom?");
            userName = Console.ReadLine();

            //CALCUL DE L'ANNEE DE NAISSANCE

            enCours = 2022;
            âge = 16;

            annéedeNaissance = enCours - âge;

            Console.WriteLine("Quel est votre année de naissance?");
            annéedeNaissance = int.Parse(Console.ReadLine());

            Console.WriteLine("Votre nom est " + userName + " et vous avez " + âge);

            //Exo 1
            int numberOne1, numberTwo2;

            Console.WriteLine("input your first number");
            numberOne1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input your second number");
            numberTwo2 = int.Parse(Console.ReadLine());



            if (numberOne1 < numberTwo2) 
            {
                Console.WriteLine("le plus grand nombre est: " + numberTwo2);   
            }
            else if (numberOne1 > numberTwo2)
            {
                Console.WriteLine("le plus grand nombre est: " + numberOne1);
            }

            //Exo2

            int hauteur, Largeur;

            Console.WriteLine("Saisissez la hauteur");
            hauteur = int.Parse(Console.ReadLine());

            Console.WriteLine("Saisissez la largeur");
            Largeur = int.Parse(Console.ReadLine());

            if (hauteur > Largeur)
            {
                Console.WriteLine("l'image est en portrait");
            }
            else if (hauteur < Largeur)
            {
                Console.WriteLine("l'image et en paysage");

            }


























        }


    }           
}








