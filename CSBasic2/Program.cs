﻿using System;

namespace CSBasic2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour ==  11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간 입니다");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간 입니다");
            }

            double score = 3.7;
            if(score == 4.5)
            {
                Console.WriteLine("신");
            }
            else if(4.2 <= score)
            {
                Console.WriteLine("교수님의 사랑");
            }
            else if (3.5 <= score)
            {
                Console.WriteLine("협 체제의 수호자");
            }
            else if (2.8 <= score)
            {
                Console.WriteLine("일반인");
            }
            else if (2.3 <= score)
            {
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            }
            else if (1.75 <= score)
            {
                Console.WriteLine("오락문화의 선구자");
            }
            else if (1.0 <= score)
            {
                Console.WriteLine("불가족 천민");
            }
            else if (0.5 <= score)
            {
                Console.WriteLine("자벌레");
            }
            else if (0 <= score)
            {
                Console.WriteLine("플랑크톤");
            }
            else
            {
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");
            }

            Console.Write("이번 달은 몇 월인가요?");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("Winter");
                    break;

                case 3: case 4: case 5:
                    Console.WriteLine("Spring");
                    break;

                case 6: case 7: case 8:
                    Console.WriteLine("Summer");
                    break;

                case 9: case 10: case 11:
                    Console.WriteLine("Autumn");
                    break;

                default:
                    Console.WriteLine("지구에 있는 거 맞나요?");
                    break;
            }

            string input2 = Console.ReadLine();
            int num = int.Parse(input2);

            Console.WriteLine(num > 2 ? "자연수" : "자연수 아님");
            //Console.WriteLine(num > 2 ? a() : b());
        }
    }
}
