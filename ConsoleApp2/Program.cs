namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Mage();
            Monster monster = new Slime();

            int damage = player.GetAttack(); // player의 공격력을 damage 필드에 넣기
            monster.OnDamage(damage); // 해당 몬스터의 데미지를 입는 코드(damage는 플레이어의 공격력)

            Console.ReadKey();
        }
    }
}
