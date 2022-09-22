int[] bilietai = { 0, 0, 0 };

    int menuItem;
    do
      {
	Console.WriteLine ("Bilietai online ir ne tik");
	Console.WriteLine ("M E N I U");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Bilietų užsakymas");
	Console.WriteLine ("2. Bilietų pardavimas");
	Console.WriteLine ("3. Ataskaita");
	Console.WriteLine ("4. Pabaiga");
	Console.WriteLine ("Jūsų pasirinkimas:");
	menuItem = Convert.ToInt32 (Console.ReadLine());
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
	Console.WriteLine();

    Console.WriteLine("Bilietai {0}, likutis {1}",i+1,bilietai[i]);
}
  static int[] OrderingTickets(int[] tickets)
  {
    int chooseItem;
    int kiekis;
    do
      {
	Console.WriteLine ("Kokius bilietus užsakysite?");
	Console.WriteLine ("---------------------------------");
	Console.WriteLine ("1. Kaina 10€,");
	Console.WriteLine ("2. Kaina 20€,");
	Console.WriteLine ("3. Kaina 30€,");
	Console.WriteLine ("4. Atsisakysite užsakymo");
	chooseItem = Convert.ToInt32 (Console.ReadLine ());
	switch (chooseItem)
	  {
	  case 1:
	    Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[0] += kiekis;
	    kiekis = 0;
	    break;
	  case 2:
	    Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[1] += kiekis;
        kiekis = 0;
	    break;
	  case 3:
	    Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
	    tickets[2] += kiekis;
        kiekis = 0;
	    break;
	  }
      }
    while (chooseItem != 4);

    return tickets;
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
                    Console.WriteLine("Deja,tokios rūšies bilietų nebeturime");
					break;
                }
                Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                 if (kiekis > tickets[0])
				{
					do
					{
						Console.WriteLine("Šiuo metu turime tik {0} bilietų.Pakeiskite kiekį į mažesnį", tickets[0]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[0]-kiekis)<0);
				}
				
       tickets[0] -= kiekis;
	    kiekis = 0;
	    break;
	  case 2:
                if (tickets[1] == 0)
                {
                    Console.WriteLine("Deja,tokios rūšies bilietų nebeturime");
					break;
                }
                Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine());
               
                if (kiekis > tickets[1])
                {
                    do
                    {
                        Console.WriteLine("Šiuo metu turime tik {0} bilietų.Pakeiskite kiekį į mažesnį", tickets[1]);
                        kiekis = Convert.ToInt32(Console.ReadLine());
                    } while ((tickets[1] - kiekis) < 0);
                }
              
                tickets[1] -= kiekis;
	    kiekis = 0;
	    break;
	  case 3:
                if (tickets[2] == 0)
                {
                    Console.WriteLine("Deja,tokios rūšies bilietų nebeturime");
					break;
                }
                Console.WriteLine ("Įveskite kiekį");
	    kiekis = Convert.ToInt32 (Console.ReadLine ());
               
               if (kiekis > tickets[2])
                {
                    do
                    {
                        Console.WriteLine("Šiuo metu turime tik {0} bilietų.Pakeiskite kiekį į mažesnį", tickets[2]);
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
/*
static Reportas(int[] tickets) {
    return (int) tickets;
}*/
