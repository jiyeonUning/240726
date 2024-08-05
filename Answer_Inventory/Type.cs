namespace Answer_Inventory
{
    // 아이템 종류
    public class Potion : Item
    {
        public Potion()
        {
            this.name = "포션";
        }
    }


    public class Weapon : Item
    {
        public Weapon()
        {
            this.name = "무기";
        }
    }


    public class Armor : Item
    {
        public Armor()
        {
            this.name = "갑옷";
        }
    }


    public class Accessory : Item
    {
        public Accessory()
        {
            this.name = "장신구";
        }
    }


    public class Food : Item
    {
        public Food()
        {
            this.name = "음식";
        }
    }
}

