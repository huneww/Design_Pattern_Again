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
            /*
                객체 생성 과정을 클래스로 캡슐화 처리하여 대신 생성하게 하는 생성 디자인
                클라이언트는 new 연산자를 이용하여 객체를 생성하지 않기 때문에
                클라이언트와 객체간 강한 결합이 발생하지 않음

                각각의 객체 마다 공장 클래스를 전부 만들어줘야함
                그렇기에 객체가 많아질수록 관리해야할 클래스가 늘어남
             */

            //// 객체A의 공장 클래스에서 객체 생성
            //Factory_Ship shipA = new Factory_Ship_A_Factory().OrderShip();
            //// 객체A정보 확인
            //Console.WriteLine(shipA.ToString());
            //Console.WriteLine("============================================");
            //// 객체B의 공장 클래스에서 객체 생성
            //Factory_Ship shipB = new Factory_Ship_B_Factory().OrderShip();
            //// 객체B정보 확인
            //Console.WriteLine(shipB.ToString());
            #endregion

            #region 추상 팩토리
            /*
                팩토리 메서드와는 다르게 각 객체별로 공장 클래스를 한개씩 만들지 않고
                유사한 객체들은 한개의 묶음으로 하여 공장 클래스 한개로 생성 함
                
                객체군이 늘어나면 팩토리 메서드처럼 새로 만들 객체군에 맞는 클래스를 전부 만들어야함
                새로운 객체를 추가하려면 기존에있던 객체군을 전부 수정해야함
             */

            //// 윈도우용 버튼을 생성
            //Ab_Factory_Button_Window windowBtn = Ab_Factory_Window.Instance.CreateButton() as Ab_Factory_Button_Window;
            //// 맥용 체크박스를 생성
            //Ab_Factory_CheckBox_Mac macCheckBox = Ab_Factory_Mac.Instance.CreateCheckBox() as Ab_Factory_CheckBox_Mac;
            //// 컴포넌트의 상위 클래스로 변수를 설정하여
            //// 윈도우, 맥 두 운영체제에서 사용할수 있도록 할수 있음
            //Ab_Factory_Text text = Ab_Factory_Window.Instance.CreateText();
            //text = Ab_Factory_Mac.Instance.CreateText();
            //Console.WriteLine("============================================");
            #endregion

            #region 프록시
            //Normal_Proxy proxy_Test = new Normal_Proxy(new RealSubject());
            //proxy_Test.Action();
            //Console.WriteLine("============================================\n");
            //// 객체 정보를 저장
            //// 객체를 생성하지는 않음
            //IImage image1 = new Proxy_Image("이미지1");
            //IImage image2 = new Proxy_Image("이미지2");
            //IImage image3 = new Proxy_Image("이미지3");
            //// 객체 정보를 토대로 객체를 생성
            //image2.ShowImage();
            //Console.WriteLine("============================================\n");

            //// 회사의 구성
            //Bad_Employee CTO = new Bad_Employee("CTO", POSITION.DIRECTOR);
            //Bad_Employee devManager = new Bad_Employee("Dev Manager", POSITION.MANAGER);
            //Bad_Employee soundManager = new Bad_Employee("Sound Manager", POSITION.MANAGER);
            //Bad_Employee devStaff = new Bad_Employee("Dev Staff", POSITION.STAFF);
            //Bad_Employee soundStaff = new Bad_Employee("Sound Staff", POSITION.STAFF);
            //List<Bad_Employee> list = new List<Bad_Employee>();
            //list.Add(CTO);
            //list.Add(devManager);
            //list.Add(soundManager);
            //list.Add(devStaff);
            //list.Add(soundStaff);

            //// 회사 인원 정보를 조회할 사람
            //Bad_Employee viewer = new Bad_Employee("Viewer", POSITION.STAFF);

            //// 디렉터, 매니저, 스테프 모두의 정보가 출력됨
            //Bad_PrintEmployeeInfo print = new Bad_PrintEmployeeInfo(viewer);
            //print.PrintAllInfo(list);

            //Console.WriteLine("============================================\n");
            //ProtectedEmployee CTO2 = new ProtectedEmployee(new Employee("CTO",POSITION.DIRECTOR));
            //ProtectedEmployee devManager2 = new ProtectedEmployee(new Employee("Dev Manager", POSITION.MANAGER));
            //ProtectedEmployee soundManager2 = new ProtectedEmployee(new Employee("Sound Manager", POSITION.MANAGER));
            //ProtectedEmployee devStaff2 = new ProtectedEmployee(new Employee("Dev Staff", POSITION.STAFF));
            //ProtectedEmployee soundStaff2 = new ProtectedEmployee(new Employee("Sound Staff", POSITION.STAFF));
            //List<IEmployee> list2 = new List<IEmployee>();
            //list2.Add(CTO2);
            //list2.Add(devManager2);
            //list2.Add(soundManager2);
            //list2.Add(devStaff2);
            //list2.Add(soundStaff2);

            //// 정보를 출력할 사람
            //Employee viewer2 = new Employee("Me", POSITION.STAFF);
            //PrintEmployeeInfo printInfo = new PrintEmployeeInfo(viewer2);
            //printInfo.printAllInfo(list2);
            //Console.WriteLine("============================================\n");

            //// 높은 직책의 사람
            //Employee viewer3 = new Employee("Me2", POSITION.DIRECTOR);
            //PrintEmployeeInfo printInfo2 = new PrintEmployeeInfo(viewer3);
            //printInfo2.printAllInfo(list2);

            #endregion

            #region 어댑터
            /*
                서로 호환되지 않는 클스들이 호환되도록 연결하는 패턴
                상속 혹은 합성으로 어댑터 패턴을 만들수 있음
                
                새로운 인터페이스, 어댑터 클래스를 추가해야하기 때문에 코드가 복잡해짐
             */

            Test_New_Service service = new Test_Adaptor(new Test_Service());
            service.Method(5);
            Console.WriteLine("============================================");
            Test_New_Service service2 = new Test_Adaptor2();
            service2.Method(10);
            Console.WriteLine("============================================");

            // 클라이언트는 A,B 정렬 엔진이 아닌 어댑터 클래스를 할당
            ISortEngine sortEngine = new SortEngineAdaptor(new A_SortEngine(), new B_SortEngine());
            SortingMachine sortingMachine = new SortingMachine();
            sortingMachine.SetSortEngine(sortEngine);
            sortingMachine.Sorting();
            #endregion
            Console.WriteLine("============================================");
        }
    }
}