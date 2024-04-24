namespace Design_Pattern_Againe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 전략 패턴
            /*
                런타임 중에 알고리즘 전략을 임의로 선택을 객체의 움직임을 실시간으로 변경
                객체의 행동 패턴이 자주 변형될때 사용
             */


            //// 무기 정보 생성
            //Weapon_Info info = new Weapon_Info("Sword", "5", "2.5");
            //// 플레이어 추가, 플레이어 장착 무기 생성
            //Strategy_User user = new Strategy_User(new Strategy_Sword(info));
            //// 무기 사용
            //// 출력 : Sword Action, 무기 정보
            //user.UseWeapon();
            //Console.WriteLine("============================================");

            //// 무기 정보 변경
            //info.SetInfo("Shield", "1", "1");
            //// 플레이어 무기 변경
            //user.SetWeapon(new Strategy_Shield(info));
            //// 무기 사용
            //// 출력 : Shield Action, 무기 정보
            //user.UseWeapon();

            //Console.WriteLine();
            ////=======================================================

            //// 로봇 생성
            //// 로봇 초기 설정
            //Strategy_Robot robot = new Strategy_Robot(new Strategy_Walk(), new Strategy_Korean());
            //// 로봇 이동, 번역 메서드 호출
            //robot.Move();
            //robot.Translate();
            //Console.WriteLine("============================================");
            //// 로봇 이동 방식 변경
            //robot.SetMove(new Strategy_Run());
            //// 로봇 번역 방식 변경
            //robot.SetTranslate(new Strategy_Japanese());
            //// 로봇 이동, 번역 메서드 호출
            //robot.Move();
            //robot.Translate();
            #endregion

            #region 템플릿 패턴
            /*
                여러 클래스가 공통으로 사용되는 메서드를 상위 클래스의 메서드로 템플릿화하고
                세부적인 동작은 상위 클래스를 상속받고 있는 하위 클래스에서 각각 역할에 맞게 다르게 구현
             */

            //// 알고리즘 생성
            //Template_Test_Base template_Test = new Template_Test_A();
            //// 알고리즘 실행
            //template_Test.TemplateMethods();
            //Console.WriteLine("============================================");
            //// 알고리즘 변경
            //template_Test = new Template_Test_B();
            //// 알고리즘 실행
            //template_Test.TemplateMethods();
            //Console.WriteLine("============================================");
            //// 알고리즘 변경
            //template_Test = new Template_Test_C();
            //// 알고리즘 실행
            //template_Test.TemplateMethods();
            //Console.WriteLine();

            //PlusFileProcessor plus = new PlusFileProcessor("1/2/3/4/5");
            //Console.WriteLine(plus.Processor());
            //Console.WriteLine("============================================");
            //MultiplyFileProcessor multiply = new MultiplyFileProcessor("1/2/3/4/5");
            //Console.WriteLine(multiply.Processor());
            #endregion

            #region 상태 패턴
            /*
                객체의 특정 상태에 따라 행동이 달라지는 상황에서 생태를 조건문으로 검사하지 않고
                상태를 객체화 하여 상태에 따라 다른 행동을 취하도록 하는것
                또다른 상태가 추가 되더라도 이전에있던 상태에는 영향이 없음
             */

            //// 플레이어 생성 및 초기 상태 설정
            //State_Test_Player player = new State_Test_Player(new State_Test_State_A());
            //// 액션 호출
            //// A 액션
            //player.Action();
            //Console.WriteLine("============================================");
            //// 상태 변경
            //// State_A => State_B
            //player.SetState(new State_Test_State_B());
            //// 액션 호출
            //// B 액션
            //player.Action();
            //Console.WriteLine("============================================");
            //// 상태 변경
            //// State_B => State_C
            //player.SetState(new State_Test_State_C());
            //// 액셜 호출
            //// C 액션 호출
            //// 상태 변경됨
            //// State_C => State_B
            //player.Action();
            //Console.WriteLine("============================================");
            //// 액셜 호출
            //// B 액션
            //player.Action();
            //Console.WriteLine("============================================");
            #endregion

            #region 팩토리 메서드
            #endregion
            Console.WriteLine("============================================");
        }
    }
}