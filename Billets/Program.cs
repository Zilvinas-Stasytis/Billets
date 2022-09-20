using System;
int bilietaiPo10, bilietaiPo20, bilietaiPo30;
int kiekis10, kiekis20, kiekis30;
int menuItem;
Console.WriteLine("Bilietai online ir ne tik");
Console.WriteLine("M E N I U");
Console.WriteLine("---------------------------------");
Console.WriteLine("1. Bilietų užsakymas");
Console.WriteLine("2. Bilietų pardavimas");
Console.WriteLine("3. Ataskaita");
Console.WriteLine("4. Pabaiga");
Console.WriteLine ("Jūsų pasirinkimas:")
menuItem = (Convert.ToInt32(Console.ReadLine());
bilietaiPo10 = 0;
bilietaiPo20 = 0;  
bilietaiPo30 = 0;

switch (menuItem)
{
    case 1:OrderingTickets(bilietaiPo10,bilietaiPo20,bilietaiPo30);break;
    case 2:SoldingTickets();break;
    case 3:Reportas();break;  
}
    OrderingTickets(int Po10, int Po20, int Po30)
        {
        int chooseItem;
        Console.WriteLine("Kokius bilietus užsakysite?");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1. Kaina 10€");
        Console.WriteLine("2. Kaina 20€");
        Console.WriteLine("3. Kaina 30€");
        Console.WriteLine("4. Atsisakysite užsakymo");
        chooseItem = (Convert.ToInt32(Console.ReadLine());
        switch (chooseItem)
        {
            case 1:
                Console.WriteLine("Įveskite kiekį");
                Po10 = (Convert.ToInt32(Console.ReadLine());
                kiekis10 += Po10; break;
            case 2:
                 break;
        case 3:
            break;
 default: break;
        }
    }

