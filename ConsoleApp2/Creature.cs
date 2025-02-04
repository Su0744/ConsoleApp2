using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Chose
    {
        None = 0,
        Player = 1,
        Monster = 2
    } 

    class Creature
    {
        Chose chose;

        protected int Hp = 0;
        protected int Attack = 0;

        protected Creature(Chose type)
        {
            chose = type;
        }

        public void Setinfo(int Hp, int Attack) // Player안에 있는 protected 타입 변수를 다른 지역에서 사용가능하겟금하는 코드
        {
            this.Hp = Hp;   // 매개변수에 입력된 값을 현재 있는 protected 변수에 값을 넣어주는 행위
            this.Attack = Attack;
        }

        public int GetHp() { return Hp; } // Player에 있는 protected 변수 값을 다른 클래스 및 메서드에서 사용가능하게 금함
        public int GetAttack() { return Attack; }  // return은 현재 protected 값을 현재 메서드에 주는 행위임
        public bool IsDead() { return Hp <= 0; }   // 플레이어가 죽었는지 확인하는 코드

        public void OnDamage(int damage) // 데미지를 넣는 작업
        {
            Hp -= damage;  // Hp에서 damage를 빼는 작업
            if (Hp < 0)     // Hp가 음수가 되는걸 막기위해서라는데 사실상 필요없는것같은느낌
                Hp = 0;
        }

    }
}
