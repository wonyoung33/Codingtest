﻿namespace 나머지_구하기_120810
{
    // 문제 : 나머지 구하기120810
    // 시작날짜 : 2024,08,05 ~ 2024,08,06 
    // 문제설명 : 정수 num1,num2가 매개변수로 주어질 때,num1를num2로 나눈 나머지를 
    // return하도록 solution함수를 완성해주세요.

    // 입출력예시 #1
    // num1이3, num2가 2이므로 3을 2로 나눈 나머지 1을  return합니다.
    // 입출력예시 #2
    // num1이10 ,num2가 5이므로 10을 5로 나눈 나머지 0을  return합니다.

    // 풀이 : int(자료형)에 num1,과 num2를 넣어준다.
    // 그리고 나누는 문자를 %로 return에 표현해준다.
    // 주의!!! &이아닌 %으로 표현해주어야한다.

    public class Solution
    {
        public int solution(int num1, int num2)
        {

            return num1 % num2;
        }
    }

}
