using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public enum Gamemode // 플레이어의 위치에 따른 위치정의
    {
        None = 0,
        Loby = 1,
        Town = 2,
        Field = 3
    }
    class Game
    {
        private Gamemode mode = Gamemode.Loby; // 자신말고 사용할것이 없기에 private
        private Player player; // player 클래스 선언
        int countLoby = 2; // 캐릭터 재설정 횟수 제한
        public void Prosess() // mode에 따른 행동 설정
        {
            switch(mode)  // 모드에 따라 행동변경
            {
                case Gamemode.Loby: // Loby일 경우
                    ProsessLoby(); // 캐릭터 선택 및 생성
                    break;
                case Gamemode.Town: // Town일 경우
                    ProsessTown();
                    break;
                case Gamemode.Field: // Field일 경우
                    break;
            }
        }

        private void ProsessLoby() 
        // 캐릭터 선택 및 생성
        // (여기서 public이 아닌 private으로 한이유는 관리하는 prosees에서 다부를수 있게 때문)
        {
            // 플레이어가 직업을 선택하는 단계
            Console.WriteLine("직업을 선택해주세요");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 법사");
            Console.WriteLine("[3] 궁수");

            string jopchose = Console.ReadLine();

            switch (jopchose) // 플레이어의 선택으로 인해서 직업생성
            {
                case "1":
                    player = new Sword(); // 플레이어의 직업 생성
                    mode = Gamemode.Town; // 이후 바로 다음단계를 위한 mode를 Town으로 변경
                   break;
                case "2":
                    player = new Mage();
                    mode = Gamemode.Town;
                    break;
                case "3":
                    player = new Archer();
                    mode = Gamemode.Town;
                    break;
            }
        }

        private void ProsessTown()
        {
            
            // 선택의 길
            Console.WriteLine("마을에 왔습니다.");
            Console.WriteLine("[1] 필드로 떠나겠습니까?");
            Console.WriteLine($"[2] 직업 변경하시겠습니까?(다만 횟수제한있슴 {countLoby}회)");
            Console.WriteLine("[3] 마을에 있겠습니까?");

            string input = Console.ReadLine();

            switch (input) 
            {
                case "1":
                    mode = Gamemode.Field; // 1번일시 필드
                    break;
                case "2":
                    if(countLoby > 0) // 캐릭터 횟수제한 조건
                    {
                      mode = Gamemode.Loby; // 2번일시 캐릭터 재선택가능 및 재생성
                      countLoby--; // 한번 선택시 -1
                      Console.WriteLine($"\n{countLoby}회 남았습니다.\n"); // 플레이어에게 알려줌 몇번남았는지
                    }
                    else // 캐릭터 횟수제한이 끝나여 한번더 선택했을시 나오는 문구
                    {
                        Console.WriteLine("\n선택이 불가합니다. \n");
                    }
                    break;
                case "3":
                    mode = Gamemode.Town; // 3번일시 머무르는 선택
                    break;
            }
        }
    }
}
