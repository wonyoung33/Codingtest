﻿namespace _120806_두_수의_나눗셈
{
    // 문제
    // 시작날짜
    // 문제설명 : 정수 num1과 num2가 매개변수로 주어질 때, 
    // num1을 num2로 나눈 값에 1,000을 곱한 후
    // 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.

    // 제한사항
    // 0 < num1 ≤ 100
    // 0 < num2 ≤ 100

    // 입출력 예시#1
    // num1이 3, num2가 2이므로 3 / 2 = 1.5에 1,000을 곱하면 1500이 됩니다.
    // 입출력 예시#2
    // num1이 7, num2가 3이므로 7 / 3 = 2.33333...에 1,000을 곱하면
    // 2333.3333.... 이 되며, 정수부분은 2333입니다.
    // 입출력 예시#3
    // num1이 1, num2가 16이므로 1 / 16 = 0.0625에 1,000을 곱하면 62.5가 되며,
    // 정수 부분은 62입니다.

    // 풀이
    // 나누기(/)와 곱하기(*)연산자를 사용해야하는 문제이다.
    // num1과 num2를 나누어주고 나누기 한 값을 1000 곱해준다.


    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;

            answer = 1000 * num1 / num2;
            return answer;
        }
    }

}
