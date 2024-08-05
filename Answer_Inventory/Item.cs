namespace Answer_Inventory
{
    public class Item
    {
        public string name; // 아이템 이름
        public string Name { get { return name; } }


        // <랜덤 아이템 생성>
        // 아이템을 랜덤으로 생성하는 경우에 대한 피드백입니다.
        // 아래의 소스코드를 참고해주세요

        // static 함수로 Item을 반환하도록 소스코드를 구성한다면
        // 랜덤한 아이템 인스턴스가 필요시
        Item randomItem = Item.CreateRandom();

        public static Item CreateRandom()
        {
            Random random = new Random();
            int value = random.Next(0, 5);
            switch (value)
            {
                case 0:
                    return new Potion();
                case 1:
                    return new Weapon();
                case 2:
                    return new Armor();
                case 3:
                    return new Accessory();
                case 4:
                    return new Food();
            }
        }

    }
}

