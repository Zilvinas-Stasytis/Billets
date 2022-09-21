


int[] bilietai = { 0, 0, 0 };
int menuItem;
/*static OrderingTickets;
static SoldingTickets;
static Reportas;
*/
Console.WriteLine("Bilietai online ir ne tik");
    Console.WriteLine("M E N I U");
    Console.WriteLine("---------------------------------");
    Console.WriteLine("1. Bilietų užsakymas");
    Console.WriteLine("2. Bilietų pardavimas");
    Console.WriteLine("3. Ataskaita");
    Console.WriteLine("4. Pabaiga");
    Console.WriteLine("Jūsų pasirinkimas:");
    menuItem = Convert.ToInt32(Console.ReadLine());
    switch (menuItem)
    {
        case 1:
            OrderingTickets(bilietai);
            break;
        /*case 2:
            SoldingTickets(bilietai);
            break;
        case 3:
            Reportas(bilietai);
            break;*/
    }
Console.WriteLine("Bilietai po 10€ {0:}, bilietai po 20€ {1}, bilietai po 30€ {2}", bilietai[0], bilietai[1], bilietai[2]);
static OrderingTickets(int[] tickets)
{
    int chooseItem; int kiekis;
    do
    {
        Console.WriteLine("Kokius bilietus užsakysite?");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("1. Kaina 10€");
        Console.WriteLine("2. Kaina 20€");
        Console.WriteLine("3. Kaina 30€");
        Console.WriteLine("4. Atsisakysite užsakymo");
        chooseItem = Convert.ToInt32(Console.ReadLine());
        switch (chooseItem)
        {
            case 1:
                Console.WriteLine("Įveskite kiekį");
                kiekis = Convert.ToInt32(Console.ReadLine());
                tickets[0] += kiekis;
                kiekis = 0;
                break;
            case 2:
                Console.WriteLine("Įveskite kiekį");
                kiekis = Convert.ToInt32(Console.ReadLine());
                tickets[1] += kiekis;
                kiekis = 0;
                break;
            case 3:
                Console.WriteLine("Įveskite kiekį");
                kiekis = Convert.ToInt32(Console.ReadLine());
                tickets[2] += kiekis;
                kiekis = 0;
                break;
        }
    } while (chooseItem != 4);

    for (int i = 0; i < tickets.Length; i++)
    {
        return tickets[i];
    }
    
    /*static void SoldingTickets(int[] tickets) { 
    };
    static void Reportas(int[] tickets) { 
    };*/
}

       