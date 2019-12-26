using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            Console.WriteLine("국어 점수를 입력해 주세요.");
            scores[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("영어 점수를 입력해 주세요.");
            scores[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("수학 점수를 입력해 주세요.");
            scores[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("과학 점수를 입력해 주세요.");
            scores[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("사회 점수를 입력해 주세요.");
            scores[4] = int.Parse(Console.ReadLine());

            Console.Write("총점은 ");
            Console.Write(scores[0] + scores[1] + scores[2] + scores[3] + scores[4]);
            Console.WriteLine("입니다.");

            Console.Write("평균은 ");
            Console.Write((scores[0] + scores[1] + scores[2] + scores[3] + scores[4])/5);
            Console.WriteLine("입니다.");
        }
    }
}
