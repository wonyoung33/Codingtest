namespace _120817_배열의_평균값
{
    // 문제 : 배열의 평균값
    // 시작날짜 : 2024,08,08
    // 문제설명 : 정수 배열 numbers가 매개변수로 주어집니다. 
    // numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.

    // 제한사항
    // 0 ≤ numbers의 원소 ≤ 1,000
    // 1 ≤ numbers의 길이 ≤ 100
    // 정답의 소수 부분이 .0 또는 .5인 경우만 입력으로 주어집니다.

    // 입출력 예시#1
    // numbers의 원소들의 평균 값은 5.5입니다.
    // 입출력 예시#2
    // numbers의 원소들의 평균 값은 94.0입니다.

    // 풀이
    // 평균을 구하는 문제이다.
    // Average를 써서 간단하고 빠르게 풀어보자 중요! 꼭 LINQ를 붙여줘야 Average가 작동함
    // C#의 LINQ에서는 집계 함수를 제공한다. 그 중 Average()메서드는
    // 컬렉션과 같은 집합에서 숫자타입인 값의 평균을 계산하기위해 사용된다. 

     
    using System;
    using System.Linq;
    public class Solution
    {
        public double solution(int[] numbers)
        {
            return numbers.Average();
        }
    }


}
