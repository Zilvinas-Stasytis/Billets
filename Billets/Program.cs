using System;
class Program {
  static void Main() {
int[] bilietai = { 0, 0, 0 };
int[] uzsakyta = { 0, 0, 0 };
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
	menuItem = Convert.ToInt32 (Console.ReadLine());
	switch (menuItem)
	  {
	  case 1:
	    OrderingTickets (bilietai,uzsakyta);
	    break;
	  case 2:
	    SoldingTickets (bilietai);
	    break;
	   case 3:
	       Reportas (bilietai,uzsakyta);
	       break; 
	  }
      }
    while (menuItem != 4);
  }
 static (int[], int[]) OrderingTickets (int[] tickets, int[] ordered)
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
				ordered[0] += kiekis;
	    kiekis = 0;
	    break;
	  case 2:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[1] += kiekis;
				ordered[1] += kiekis;
				kiekis = 0;
	    break;
	  case 3:
	    Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[2] += kiekis;
				ordered[2] += kiekis;
				kiekis = 0;
	    break;
	  }
      } while (chooseItem != 4);
    return (tickets, ordered);
  }
  static int[] SoldingTickets (int[] tickets)
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
	chooseItem = Convert.ToInt32 (Console.ReadLine());
	switch (chooseItem)
	  {
	  case 1:
                if (tickets[0] == 0)
                {
                    Console.WriteLine("Deja,tokios rûðies bilietø nebeturime");
					break;
                }
                Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                 if (kiekis > tickets[0])
				{
					do
					{
						Console.WriteLine("Ðiuo metu turime tik {0} bilietø.Pakeiskite kieká á maþesná", tickets[0]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[0]-kiekis)<0);
				}
				
       tickets[0] -= kiekis;
	    kiekis = 0;
	    break;
	  case 2:
                if (tickets[1] == 0)
                {
                    Console.WriteLine("Deja,tokios rûðies bilietø nebeturime");
					break;
                }
                Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                if (kiekis > tickets[1])
                {
                    do
                    {
                        Console.WriteLine("Ðiuo metu turime tik {0} bilietø.Pakeiskite kieká á maþesná", tickets[1]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[1] - kiekis) < 0);
                }
              
                tickets[1] -= kiekis;
				kiekis = 0;
	    break;
	  case 3:
                if (tickets[2] == 0)
                {
                    Console.WriteLine("Deja,tokios rûðies bilietø nebeturime");
					break;
                }
                Console.WriteLine ("Áveskite kieká");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
               
               if (kiekis > tickets[2])
                {
                    do
                    {
                        Console.WriteLine("Ðiuo metu turime tik {0} bilietø.Pakeiskite kieká á maþesná", tickets[2]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[2] - kiekis) < 0);
                }
                
                tickets[2] -= kiekis;
				kiekis = 0;
	    break;
	  }
      }
    while (chooseItem != 4);

    return tickets;

  }

static (int[], int[]) Reportas(int[] tickets, int[] ordered) 
{
	int chooseItem;
	 do { 
	Console.WriteLine("A T A S K A I T A");
	Console.WriteLine("---------------------------------");
	Console.WriteLine("1. Uþsakyta bilietø ið viso uþ 10€");
	Console.WriteLine("2. Uþsakyta bilietø ið viso uþ 20€");
	Console.WriteLine("3. Uþsakyta bilietø ið viso uþ 30€");
	Console.WriteLine("4. Parduota bilietø uþ 10€");
	Console.WriteLine("5. Parduota bilietø uþ 20€");
	Console.WriteLine("6. Parduota bilietø uþ 30€");
	Console.WriteLine("7. Likutis bilietø uþ 10€");
	Console.WriteLine("8. Likutis bilietø uþ 20€");
	Console.WriteLine("9. Likutis bilietø uþ 30€");
	Console.WriteLine("10. Baigti ataskaità");
	chooseItem = Convert.ToInt32(Console.ReadLine());
   	switch (chooseItem) 
		{
		case 1:
			Console.WriteLine("Uþsakyta bilietø uþ 10€ – {0}", ordered[0]); break;
		case 2:
			Console.WriteLine("Uþsakyta bilietø uþ 20€ – {0}", ordered[1]); break;
		case 3:
			Console.WriteLine("Uþsakyta bilietø uþ 30€ – {0}", ordered[2]); break;
		case 4:
			Console.WriteLine("Nupirkta bilietø uþ 10€ – {0}", ordered[0] - tickets[0]); break;
		case 5:
			Console.WriteLine("Nupirkta bilietø uþ 20€ – {0}", ordered[1] - tickets[1]); break;
		case 6:
			Console.WriteLine("Nupirkta bilietø uþ 30€ – {0}", ordered[2] - tickets[2]); break;
		case 7:
			Console.WriteLine("Likutis bilietø uþ 10€ – {0}", tickets[0]); break;
		case 8:
			Console.WriteLine("Likutis bilietø uþ 20€ – {0}", tickets[1]); break;
		case 9:
			Console.WriteLine("Likutis bilietø uþ 30€ – {0}", tickets[2]); break;
	}
} 
	while (chooseItem != 10);
	Console.WriteLine("-----------------------------------------------------------------");
	return  (tickets, ordered);
}
  }