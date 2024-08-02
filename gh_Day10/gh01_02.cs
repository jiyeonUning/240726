namespace gh_Day10_1
{ // 기본이 되는 클래스

    public class Inventory
    {
        public List<Item> inventory = new List<Item>(9); // 아이템 소지 최대 9칸을 가진 인벤토리 배열
        public int ItemCount = 0; // 아이템 갯수

        public void Inven(Item item)
        {
            if (ItemCount >= 9) // 최대 소지 갯수 초과 시,
            {
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }
            else
            {
                inventory.Insert(0, item); // 그 외의 경우, Insert함수를 사용해 입력된 아이템 값을 추가
                ItemCount++; // 아이템 갯수 +1
            }
        }
    }


    public class Item
    {
        public string name; // 아이템 이름

        public string Name { get { return name; } }
    }
}