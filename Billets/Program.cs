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
	Console.WriteLine ("1. Biliet� u�sakymas");
	Console.WriteLine ("2. Biliet� pardavimas");
	Console.WriteLine ("3. Ataskaita");
	Console.WriteLine ("4. Pabaiga");
	Console.WriteLine ("J�s� pasirinkimas:");
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
	Console.WriteLine ("Kokius bilietus u�sakysite?");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Kaina 10�,");
	Console.WriteLine ("2. Kaina 20�,");
	Console.WriteLine ("3. Kaina 30�,");
	Console.WriteLine ("4. Atsisakysite u�sakymo");
	chooseItem = Convert.ToInt32 (Console.ReadLine ());
	switch (chooseItem)
	  {
	  case 1:
	    Console.WriteLine ("�veskite kiek�");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[0] += kiekis;
				ordered[0] += kiekis;
	    kiekis = 0;
	    break;
	  case 2:
	    Console.WriteLine ("�veskite kiek�");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[1] += kiekis;
				ordered[1] += kiekis;
				kiekis = 0;
	    break;
	  case 3:
	    Console.WriteLine ("�veskite kiek�");
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
	Console.WriteLine ("1. Kaina 10�,");
	Console.WriteLine ("2. Kaina 20�,");
	Console.WriteLine ("3. Kaina 30�,");
	Console.WriteLine ("4. Atsisakysite pirkimo");
	chooseItem = Convert.ToInt32 (Console.ReadLine());
	switch (chooseItem)
	  {
	  case 1:
                if (tickets[0] == 0)
                {
                    Console.WriteLine("Deja,tokios r��ies biliet� nebeturime");
					break;
                }
                Console.WriteLine ("�veskite kiek�");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                 if (kiekis > tickets[0])
				{
					do
					{
						Console.WriteLine("�iuo metu turime tik {0} biliet�.Pakeiskite kiek� � ma�esn�", tickets[0]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[0]-kiekis)<0);
				}
				
       tickets[0] -= kiekis;
	    kiekis = 0;
	    break;
	  case 2:
                if (tickets[1] == 0)
                {
                    Console.WriteLine("Deja,tokios r��ies biliet� nebeturime");
					break;
                }
                Console.WriteLine ("�veskite kiek�");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                if (kiekis > tickets[1])
                {
                    do
                    {
                        Console.WriteLine("�iuo metu turime tik {0} biliet�.Pakeiskite kiek� � ma�esn�", tickets[1]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[1] - kiekis) < 0);
                }
              
                tickets[1] -= kiekis;
				kiekis = 0;
	    break;
	  case 3:
                if (tickets[2] == 0)
                {
                    Console.WriteLine("Deja,tokios r��ies biliet� nebeturime");
					break;
                }
                Console.WriteLine ("�veskite kiek�");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
               
               if (kiekis > tickets[2])
                {
                    do
                    {
                        Console.WriteLine("�iuo metu turime tik {0} biliet�.Pakeiskite kiek� � ma�esn�", tickets[2]);
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
	Console.WriteLine("1. U�sakyta biliet� i� viso u� 10�");
	Console.WriteLine("2. U�sakyta biliet� i� viso u� 20�");
	Console.WriteLine("3. U�sakyta biliet� i� viso u� 30�");
	Console.WriteLine("4. Parduota biliet� u� 10�");
	Console.WriteLine("5. Parduota biliet� u� 20�");
	Console.WriteLine("6. Parduota biliet� u� 30�");
	Console.WriteLine("7. Likutis biliet� u� 10�");
	Console.WriteLine("8. Likutis biliet� u� 20�");
	Console.WriteLine("9. Likutis biliet� u� 30�");
	Console.WriteLine("10. Baigti ataskait�");
	chooseItem = Convert.ToInt32(Console.ReadLine());
   	switch (chooseItem) 
		{
		case 1:
			Console.WriteLine("U�sakyta biliet� u� 10� � {0}", ordered[0]); break;
		case 2:
			Console.WriteLine("U�sakyta biliet� u� 20� � {0}", ordered[1]); break;
		case 3:
			Console.WriteLine("U�sakyta biliet� u� 30� � {0}", ordered[2]); break;
		case 4:
			Console.WriteLine("Nupirkta biliet� u� 10� � {0}", ordered[0] - tickets[0]); break;
		case 5:
			Console.WriteLine("Nupirkta biliet� u� 20� � {0}", ordered[1] - tickets[1]); break;
		case 6:
			Console.WriteLine("Nupirkta biliet� u� 30� � {0}", ordered[2] - tickets[2]); break;
		case 7:
			Console.WriteLine("Likutis biliet� u� 10� � {0}", tickets[0]); break;
		case 8:
			Console.WriteLine("Likutis biliet� u� 20� � {0}", tickets[1]); break;
		case 9:
			Console.WriteLine("Likutis biliet� u� 30� � {0}", tickets[2]); break;
	}
} 
	while (chooseItem != 10);
	Console.WriteLine("-----------------------------------------------------------------");
	return  (tickets, ordered);
}
  }