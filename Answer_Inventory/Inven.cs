namespace Answer_Inventory
{
    public class Inventory
    {
        public List<Item> inventory = new List<Item>(9);
        public int ItemCount = 0;

        private List<Item> items;


         public void Inven(Item item)
         {
             if (ItemCount >= 9)
             {
                 Console.WriteLine("인벤토리가 가득 찼습니다.");
             }
             else
             {
                // 피드백 전 작성했던 코드 : inventory.Insert(0, item); 

                // <리스트 효율>
                // 리스트의 Insert 대신 Add 사용을 추천드립니다!
                // 리스트는 마지막에 요소를 추가하는 경우 훨씬 좋은 효율을 가진 자료구조입니다.
                inventory.Add(item); 

                 ItemCount++;
             }
         }


        // <인벤토리 아이템 추가 제거>
        // 인벤토리에 아이템을 추가하는 과정과 제거하는 과정에 대한 고민이 있던 것으로 확인됩니다.
        // 인벤토리 클래스를 잘 생성해주셨고, 그렇다면 인벤토리의 메서드로 아이템 추가와 아이템 제거가 있으면 된다고 생각됩니다.
        public Inventory()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item) // = 아이템 추가
        {
            items.Add(item);
        }

        public void RemoveItem(int index) // = 아이템 제거
        {
            items.RemoveAt(index);
        }

        public void ShowAllItems()
        {
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].Name}");
            }
        }
    }
}
