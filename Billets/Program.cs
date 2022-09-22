/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

/* Online C# Compiler and Editor */
using System.IO;
using System;
public class Program
{
  static void Main ()
  {
    int[] bilietai = { 0, 0, 0 };
    int menuItem;
    do
      {
	Console.WriteLine ("Bilietai online ir ne tik");
	Console.WriteLine ("M E N I U");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Bilietø uþsakymas");
	Console.WriteLine ("2. Bilietø pardavimas");
	Console.WriteLine ("3. Ataskaita");
	Console.WriteLine ("4. Pabaiga");
	Console.WriteLine ("Jûsø pasirinkimas:");
	menuItem = Convert.ToInt32 (Console.ReadLine ());
	switch (menuItem)
	  {
	  case 1:
	    OrderingTickets (bilietai);
	    break;
	  case 2:
	    SoldingTickets (bilietai);
	    break;
	    /*
	       case 3:
	       Reportas (bilietai);
	       break; */
	  }
      }
    while (menuItem != 4);
    for (int i = 0; i < bilietai.Length; i++)
      {
	Console.WriteLine (bilietai[i]);
      }
  }

  static int[] OrderingTickets (int[]tickets)
  {
    int chooseItem;
    int kiekis;
    do
      {
	Console.WriteLine ("Kokius bilietus uþsakysite?");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Kaina 10€,");
	Console.WriteLine ("2. Kaina 20€,");
	Console.WriteLine ("3. Kaina 30€,");
	Console.WriteLine ("4. Atsisakysite uþsakymo");
	chooseItem = Convert.ToInt32 (Console.ReadLine ());
	switch (chooseItem)
	  {
	  case 1:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[0] += kiekis;
	    kiekis = 0;
	    break;
	  case 2:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[1] += kiekis;
	    kiekis = 0;
	    break;
	  case 3:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[2] += kiekis;
	    kiekis = 0;
	    break;
	  }
      }
    while (chooseItem != 4);

    return tickets;
  }
  static int[] SoldingTickets (int[]tickets)
  {
    int chooseItem;
    int kiekis;
    do
      {
	Console.WriteLine ("Kokius bilietus pirksite?");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Kaina 10€,");
	Console.WriteLine ("2. Kaina 20€,");
	Console.WriteLine ("3. Kaina 30€,");
	Console.WriteLine ("4. Atsisakysite pirkimo");
	chooseItem = Convert.ToInt32 (Console.ReadLine ());
	switch (chooseItem)
	  {
	  case 1:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[0] -= kiekis;
	    kiekis = 0;
	    break;
	  case 2:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[1] -= kiekis;
	    kiekis = 0;
	    break;
	  case 3:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[2] -= kiekis;
	    kiekis = 0;
	    break;
	  }
      }
    while (chooseItem != 4);

    return tickets;

  }
/*
static Reportas(int[] tickets) {
    return (int) tickets;
}*/
}
