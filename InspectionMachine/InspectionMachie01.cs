namespace InspectionMachine
{

    /* 과제. 괄호 검사기
      다음의 조건을 충족하는 괄호 검사기 프로그램을 구현하시오.

      1. 괄호가 바르게 짝지어졌다는 것은, 열렸으면 짝지어서 닫혀야 한다 라는 뜻이다.
      2. 텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 프로그램을 작성하자.
      3. 검사할 괄호 : [], {}, ()

     예시 )
            ()완성, (() 미완성, [[(){}]] 완성, [(})] 미완성
     
    */

    // 괄호열음과 괄호닫음이 함께 있어야 true, 그 외 false.
    // 텍스트 입력 받음 = Console.ReadLine();



    public class InspectionMachie01
    {
        public class TrueFalse
        {
            public string answer = Console.ReadLine();

            public string TRUE = "완성";
            public string FALSE = "미완성";
            List<string> lists = new List<string>(5);

            public void List()
            {
                lists.Add("[");
                lists.Add("]");
                        
                lists.Add("{");
                lists.Add("}");
                  
                lists.Add("(");
                lists.Add(")");
            }

            public void OK()
            {
                //lists[0] + lists[1] = true;
            }

            public void Succcess()
            {
                if (lists.Contains(answer) == false)
                {
                    Console.WriteLine($"{answer} : {FALSE}");
                }

                else if (lists.Contains(answer) == true)
                {
                    Console.WriteLine($"{answer} : {TRUE}");
                }
            }
        }
    }
}
