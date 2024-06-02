namespace DamageCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwordDame swordDame = new SwordDame();
            Random random = new Random();

            while (true)
            {
                Console.Write("[0] Ani magiczny, ani płonący; [1] Magiczny; [2] Płonący; [3] Magiczny i płonący; Inne wartości - KONIEC: ");
                char keyChar = Console.ReadKey(false).KeyChar;

                if (keyChar != '0' && keyChar != '1' && keyChar != '2' && keyChar != '3')
                    return;

                swordDame.Roll = random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);

                swordDame.SetMagic(keyChar == '1' || keyChar == '3');
                swordDame.SetFlaming(keyChar == '2' || keyChar == '3');

                Console.WriteLine("\nRzut: " + swordDame.Roll + ", punkty obrażeń: " + swordDame.Damage + "\n");
            }
        }
    }
}
