namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // Game 클래스 선언 및 초기화

            while (true)  // 반복하기위한 반복문
            {
                game.Prosess(); // Game에 있는 전역메서드 Prosess 가져오기
            }
        }
    }
}
