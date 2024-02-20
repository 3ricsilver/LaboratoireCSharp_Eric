// See https://aka.ms/new-console-template for more information
/*using Class1.cs
*/
using MyShapeLibrary;

//coordonnée
/*Coordonee Test1 = new Coordonee();
Coordonee Test2 = new Coordonee(2,4);

Console.WriteLine("Test 1!");
Console.WriteLine(Test1);

Console.WriteLine("Test 2!");
Console.WriteLine(Test2);
*/


//carré
/*Carre TestCarre1 = new Carre();
Console.WriteLine("Test Carré  1 (constructeur par défaut) :");
Console.WriteLine(TestCarre1);

// Création d'un carré avec le constructeur d'initialisation
Carre TestCarre2 = new Carre(1, 2, 5);
Console.WriteLine("Test Carré  2 (constructeur d'initialisation) :");
Console.WriteLine(TestCarre2);

// Modification de la longueur du côté et affichage
TestCarre2.Cote = 10;
Console.WriteLine("Test Carré  2 après modification de la longueur du côté :");
Console.WriteLine(TestCarre2);*/

//cercle
/*Cercle TestCercle1 = new Cercle();
Console.WriteLine("Test Cercle  1 (constructeur par défaut) :");
Console.WriteLine(TestCercle1);

Cercle TestCercle2 = new Cercle(1, 2, 5);
Console.WriteLine("Test Cercle  2 (constructeur d'initialisation) :");
Console.WriteLine(TestCercle2);

TestCercle2.Rayon = 10;
Console.WriteLine("Test Cercle  2 après modification du rayon :");
Console.WriteLine(TestCercle2);*/

Rectangle TestRectangle1 = new Rectangle();
Console.WriteLine("Test Rectangle   1 (constructeur par défaut) :");
Console.WriteLine(TestRectangle1);


Rectangle TestRectangle2 = new Rectangle(1, 2, 5, 10);
Console.WriteLine("Test Rectangle   2 (constructeur d'initialisation) :");
Console.WriteLine(TestRectangle2);

TestRectangle2.Longueur = 15;
TestRectangle2.Largeur = 20;
Console.WriteLine("Test Rectangle   2 après modification de la longueur et de la largeur :");
Console.WriteLine(TestRectangle2);