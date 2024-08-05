namespace gh_Day10_1
{
    /*     과제 1. 동적 인벤토리 구현하기
           다음의 조건을 충족하는 인벤토리 시스템을 구현하시오 :
            
            1. 프로그램 시작 시 인벤토리는 빈 상태에서 시작한다.
            2. 프로그램이 구동되는 동안 입력마다 콘솔에 지속적으로 인벤토리의 상태를 표시한다
            3. 인벤토리는 최대 9개의 아이템을 가질 수 있다.
            4. 인벤토리는 빈칸 없이 앞부터 채워서 가진다
            5. 숫자키 0을 누르면 랜덤으로 아이템의 종류를 획득하고 인벤토리에 추가한다
            6. 숫자키 1~9를 누르면 해당하는 숫자의 아이템을 제거한다

            구현 클래스
             1. Inventory
             2. Item
             3. Potion : Item
             4. Weapon : Item
             5. Armor : Item
             6. Accessory : Item
             7. Food : Item                                                                                */



    public class gh01
    {
        public class itemNum
        {
            public static void ItemNum()
            {
                Item item = new Item();
                item = new Potion();
                item = new Armor();
                item = new Weapon();
                item = new Accessory();
                item = new Food();
            }
        
        }



        static void Main()
        {
            Inventory inventory = new Inventory();
            Random rand = new Random(); // 랜덤함수 Random.

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

                    if (Answer == 10) // 0~9 외의 숫자를 입력했을 때,
                    {
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                    }

                    else if (Answer == 0) // 0을 입력했을 때,
                    {
                        // 랜덤한 아이템 획득
                        int randItem = rand.Next();
                        // randItem = itemNum.ItemNum(); 아이템 자식 클래스에 어떻게 숫자를 매기나요?.. (배열?)
                    }

                    else // 위 if와 else if 외 숫자를 입력했을 때(=1~9 숫자),
                    {
                        // 숫자에 저장된 아이템을 버림
                    }
                }
            }

        }

    }
}
