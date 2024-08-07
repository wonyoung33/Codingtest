namespace _120807_숫자_비교하기
{
    // 문제 :    숫자 비교하기 120807
    // 시작날짜 : 2024,08,07
    // 문제설명 : 정수 num1과 num2가 매개변수로 주어집니다.
    // 두 수가 같으면 1 다르면 -1을 retrun하도록 solution 함수를 완성해주세요.

    // 입출력 예 설명 #1
    // num1이 2이고 num2가 3이므로 다릅니다. 따라서 -1을 return합니다.

    // 입출력 예 설명 #2
    // num1이 11이고 num2가 11이므로 같습니다. 따라서 1을 return합니다.

    // 입출력 예 설명 #3
    // num1이 7이고 num2가 99이므로 다릅니다. 따라서 -1을 return합니다.

    // 풀이 : 서로같으면 1을 출력하고 다르면 -1을 출력하는문제이다
    // 우선 num1r과 num2을/를 서로 같은연산자인 관계연산자 == 를 사용해준다
    // 그다음 참과 거짓을 구분해야하기때문에 조건문인 if와 else를 사용해서 풀어준다
    // 참이면 1을 거짓이면 -1을 출력하게된다.


    public class Solution
    {
        public int solution(int num1, int num2)
        {
            int answer = 0;
            if (num1 == num2)
                answer = 1;                       
            else            
                answer = -1;

            return answer;            
            
        }
    }
}
