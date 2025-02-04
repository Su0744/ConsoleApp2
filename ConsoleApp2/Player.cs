using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum PlayerJop // 플레이어 직업
    {
        None = 0,
        Sword = 1,
        Mage = 2,
        Archer = 3
    }

    class Player : Creature   // 플레이어 공통 스팩(Creature의 protected 값을 가져오기위한 상속)
    {
        protected PlayerJop jop = PlayerJop.None; // 오류발생 및 확인하기 쉽게 초기값 설정


        protected Player(PlayerJop jop) : base(Chose.Player) // Creature의 enum player타입을 가져오는것(상속기준)
        // 내가 직업을 선택할수있게하는 코드(player는 자식과 자신의외에 사용 불가능)
        // 이유 = 자신과 자식의외에 사용하게 될시 불필요한곳에서 사용가능하기에 은닉성으로 강조
        {
            this.jop = jop;
        }

        public PlayerJop GetJop() { return jop; } // PlayerJop 데이터를 전역변수로 만든 코드

       
    }

    class Sword : Player  // player 상속 즉 Hp와 Damage를 사용가능
    {
        public Sword() : base(PlayerJop.Sword)  // player 클래스에 jop.sword를 가져오는 코드
        {
            Setinfo(200, 60); // 직업에 HP,Damage를 설정하는 작업 || setinfo는 상속받은 public 생성자안의 메서드
        }
    }
    class Mage : Player
    {
        public Mage() : base(PlayerJop.Mage)  // public은 다른 곳에서 참조 및 데이터 가져올시 필요한 전역 생성자
        {
            Setinfo(100, 150);
        }
    }
    class Archer : Player
    {
        public Archer() : base(PlayerJop.Archer)
        {
            Setinfo(130, 90);
        }
    }
}
