namespace InspectionMachine
{
    // 혼자 구현한 과제 코드는 InspectionMachie01.cs 참고
    // 스스로 구현하지 못하여, 개발자분께서 작성하신 코드에 주석으로 개인적인 해석을 다는 식으로 작성하였습니다.
    // 출처 : 양규빈 개발자님 - 2023.07.10 C# 스택 https://velog.io/@mayostar0514/C-%EC%8A%A4%ED%83%9D


    public class InspectionMachine_answer
    {

        static void Main()
        {
            void PrintStack(Stack<string> stack, string desc = "")
            {
                Console.WriteLine(desc);

                foreach (var item in stack)
                {
                    Console.WriteLine(" " + item);
                }
            }


            string[] start = { "{", "[", "(" }; // 여는 괄호
            string[] end = { "}", "]", ")" }; // 닫는 괄호

            string answer = Console.ReadLine();

            string[] split = answer.Split(' '); // 해당 빈칸을 기준으로 하여 문자열을 자른다.

            bool isNullStack = false; // = 스택 존재 유무를 판단하기 위한 bool 자료. true = 스택이 없다. / fasle = 스택이 아직 있다.

            Stack<string> stack = new Stack<string>(); // 스택함수 생성


            for (int i = 0; i < split.Length; i++) // i가 0이고, i가 split 배열보다 작을 때 까지, i를 더한다.
            {
                if (start.Contains(split[i])) // split[i]값이 start배열에 있을 경우,
                {
                    stack.Push(split[i]); // split[i]를 스택함수에 선입후출로 넣어 값을 쌓는다.
                }
                else // 그 외의 경우,
                {
                    if (stack.Count == 0) // 스택함수 안에 값이 남아있지 않다면,
                    {
                        isNullStack = true; // = 스택존재가 없음.
                        break; // 반복문 종료
                    }

                    // 스택함수 안에 값이 아직 남아있다면, 아래 내용이 적용됨.

                    int endIndex =
                        // FindIndex함수 : ()의 조건을 만족하는 가장 첫번째 값을 찾아 반환한다.
                        // => : 람다 연산자. 무명함수를 표현하는데에 사용. 사용법은 아래와 같음.
                        // (입력 파라미터) => (실행할 문장 블럭)

                        // 따라서 아래 코드를 해석해보자면,
                        // end배열이 있고, 해당 배열에 저장되어있던 string값들(=item)에서 값을 검사하고, 이 값들 중에서 split[i]을 찾는다.
                        // 이때 FindIndex함수가 Array List에서 위 조건을 만족하는 가장 첫번째 값을 찾아 반환한다.
                        Array.FindIndex(end, (item) => item == split[i]);

                    int startIndex =
                        // 아래 코드도 해석해보자면,
                        // start배열이 있고, 해당 배열에 저장되어있던 string값들(=item)에서 값을 검사하고, 이 값들 중에서 다음으로 나올 값을 확인한다.
                        // 이때 FindIndex함수가 Array List에서 위 조건을 만족하는 가장 첫번째 값을 찾아 반환한다.
                        Array.FindIndex(start, (item) => item == (string)stack.Peek());

                    // 위 과정을 진행하고
                    if (endIndex == startIndex) // 여는 괄호와 닫는 괄호가 같을 때,
                    {
                        Console.Write(" " + (string)stack.Pop() + " " + split[i]); //값을 꺼낸다.
                        // 여기서 +의 의미는 잘모르겠다... {}와 같은걸까요?
                    }
                    else // 여는 괄호와 닫는 괄호가 같지 않을 경우, 혹은 그 외의 경우,
                    {
                        stack.Push(split[i]); // Push함수를 사용해 split[i]를 다시 스택함수에 넣어둔다.
                    }
                }
            }

            //============================================================================================================

            Console.WriteLine();

            if (stack.Count > 0 || isNullStack) // 스택함수가 0보다 크거나, 스택함수가 존재하지 않을 경우
            {
                Console.WriteLine("수식 오류"); // 에러메세지를 띄운다.
            }
            else // 그 외의 경우엔
            {
                Console.WriteLine("정상적인 수식"); // 정상적인 수식이라고 알려준 후
            }

            PrintStack(stack); // PrintStack 함수를 호출하여 함수를 사용한다.
        }
    }
}
