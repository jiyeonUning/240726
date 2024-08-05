namespace Answer_Inventory
{
    public class Answer
    {
        static void Main()
        {
            Inventory inventory = new Inventory();
            Item item = new Item();
            Random rand = new Random();

            List<string> itemList = new List<string>();

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("0 숫자를 입력하면, 랜덤으로 아이템을 획득해 인벤토리에 보관합니다.");
                    Console.WriteLine("1 ~ 9 사이의 숫자를 입력하면, 해당하는 아이템을 버립니다.");
                    Console.WriteLine("입력 : ");

                    string answer = Console.ReadLine();
                    int Answer = int.Parse(answer);

                    if (Answer == 10)
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                    }

                    else if (Answer == 0)
                    {
                        item.CreateRandom() = inventory.AddItem(item.CreateRand);
                    }

                    else 
                    {
                        inventory.RemoveItem(Answer);
                    }
                }
            }
        }
    }
}
