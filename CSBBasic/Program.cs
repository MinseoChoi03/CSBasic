﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBBasic
{
    class Program
    {
        //var name = "최민서";

        static void Main(string[] args)
        {
            //key word
            //ex as

            //context keyword;
            //var name = "최민서";
            //var var = "최민서";

            //식별자 identifier
            int alpha;
            int Alpha;
            //int break;
            //int 263alpha;
            //int bas space;
            //int 😘😂😊🤣❤❤😍❤;
            //int 한글숫자;

            //inline comnet
            /*
             comment
             */

            Console.Write("이건 안개형");
            Console.Write("입니다");
            Console.WriteLine("");
            Console.WriteLine("Hello");

            //자료형(Data type)
            //Integer
            Console.WriteLine(53 + 272 - 123);
            Console.WriteLine(53 * 3 - 3);
            Console.WriteLine(14 / 2); //7
            Console.WriteLine(14 / 3); //4
            Console.WriteLine(14 % 3); //2

            //Real Number
            Console.WriteLine(13.123);
            Console.WriteLine(0);
            Console.WriteLine(0.0);
            Console.WriteLine(14.0 / 2.0); //7.0
            Console.WriteLine(14.0 / 3.0); //4.6666667
            // Console.WriteLine(14.0 % 3.0);

            Console.WriteLine(14 / 3); //정수
            Console.WriteLine(14.0 / 3); //실수
            Console.WriteLine(14 / 3.0); //실수
            Console.WriteLine(14.0 / 3.0); //실수

            //Charater
            Console.WriteLine('A'); //문자 
            //String
            Console.WriteLine("A"); //문자열
            //Escape Charater
            Console.WriteLine("\t 탭 \\역슬래시 \n 개행 \" "); //문자열
            Console.WriteLine("미\t림여자정보과학고등학교"); //문자열
            Console.WriteLine("미림\t여자정보과학고등학교"); //문자열
            Console.WriteLine("미림여\t자정보과학고등학교"); //문자열
            Console.WriteLine("미림여자\t정보과학고등학교"); //문자열
            Console.WriteLine("미림여자정\t보과학고등학교"); //문자열
            Console.WriteLine("미림여자정보\t과학고등학교"); //문자열
            Console.WriteLine("미림여자정보과\t학고등학교"); //문자열
            Console.WriteLine("미림여자정보과학\t고등학교"); //문자열

            //문자열 연결 연산자
            //concat concatenate operator
            //concatenation operator

            Console.WriteLine("ABC" + "EFG");
            Console.WriteLine('A' + 'E');
            Console.WriteLine("ABC" + 'E');

            Console.WriteLine("ABC"[2]);
            Console.WriteLine("ABC"[3]);

            //bool
            bool isPlay = true;
            bool isDeath = false;

            //comparison operator
            Console.WriteLine(41 == 163);
            Console.WriteLine(41 != 163);
            Console.WriteLine(41 > 163); //gt
            Console.WriteLine(41 < 163); // it
            Console.WriteLine(41 >= 163);
            Console.WriteLine(41 <= 163);


            // Logic operator
            Console.WriteLine(!(true));
            Console.WriteLine(true == false);
            Console.WriteLine(true && false);

            //담항 연산자 - unary operator
            Console.WriteLine(!(true));
            int i = 0;
            i++;

            //이항 연산자 - binary operator
            i = 1 + 2;

            //삼항 연산자 - ternary operator
            int j;
            //j = (i > 3) ? 0 : 1;
            j = (i > 3) ? 0 : 1;

            //Console.WriteLine(3 < i < 8);
            Console.WriteLine(3 < i && i < 8);
            Console.WriteLine(3 > i || i > 8);
            Console.WriteLine(i < 3 || 8 < i);
        }
    }
}
