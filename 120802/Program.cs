﻿namespace _120820_나이_출력
{
    // 문제 : 나이출력 120820 
    // 시작날짜 : 2024,08,07
    // 문제설명 : 머쓱이는 선생님이 몇 년도에 태어났는지 궁금해졌습니다.
    // 2022년 기준 선생님의 나이 age가 주어질 때,
    // 선생님의 출생 연도를 return 하는 solution 함수를 완성해주세요

    // 제한사항
    // 0 < age ≤ 120
    // 나이는 태어난 연도에 1살이며 매년 1월 1일마다 1살씩 증가합니다.

    // 입출력 예시#1
    // 2022년 기준 40살이므로 1983년생입니다.
    // 입출력 예시#1
    // 2022년 기준 23살이므로 2000년생입니다.

    // 풀이
    // 나이(age)를 구하는 문제이다
    // 년도마다 1살씩 증가하기때문에 
    // 기준인 2022년도에 나이를 빼서(-) 넣어주고 
    // 다시 리턴값으로 더해주면(+) 답이 나오게된다.


    public class Solution
    {
        public int solution(int age)
        {
            int answer = 2022-age;
            
            return answer+1;
        }
    }

}
