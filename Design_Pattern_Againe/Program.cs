using System.Net;

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

            //Test_New_Service service = new Test_Adaptor(new Test_Service());
            //service.Method(5);
            //Console.WriteLine("============================================");
            //Test_New_Service service2 = new Test_Adaptor2();
            //service2.Method(10);
            //Console.WriteLine("============================================");

            //// 클라이언트는 A,B 정렬 엔진이 아닌 어댑터 클래스를 할당
            //ISortEngine sortEngine = new SortEngineAdaptor(new A_SortEngine(), new B_SortEngine());
            //SortingMachine sortingMachine = new SortingMachine();
            //sortingMachine.SetSortEngine(sortEngine);
            //sortingMachine.Sorting();
            #endregion

            #region 데코레이터
            /*
                필요한 기능의 조합을 런타임에 동적으로 생성할수 있음

                장식자중에서 일부를 제거하기가 어렵다
                어느 장식자를 먼저하느냐에 따라 실행 순서가 결정되됨
                순서에 의존하지 않는 방식으로 구현하기 힘듬
             */

            //// 원본 객체 생성
            //IWeapon weapon = new BaseWeapon();
            //weapon.AimAndFire();
            //Console.WriteLine("============================================");
            //// Generade 추가
            //IWeapon generade_Weapon = new Generade(weapon);
            //generade_Weapon.AimAndFire();
            //Console.WriteLine("============================================");
            //// Scope, Buttstock 추가
            //IWeapon scope_ButtStock_Weapon = new Scoped(new ButtStock(weapon));
            //scope_ButtStock_Weapon.AimAndFire();
            //Console.WriteLine("============================================\n");

            //PlayerAttack playerAttack = new PlayerAttack();
            //playerAttack.Attack();
            //Console.WriteLine("============================================");

            //IAttack playerAttack2 = new PlayerAttackSkill("SkillA", playerAttack);
            //playerAttack2.Attack();
            //((PlayerAttackSkill)playerAttack2).Skill();
            //Console.WriteLine("============================================");

            //IAttack playerAttack3 = new PlayerAttackPassive(0.5, new PlayerAttackSkill("SkillB", new PlayerAttack()));
            //playerAttack3.Attack();
            //((PlayerAttackPassive)playerAttack3).Passive();
            //IAttack skill = ((PlayerAttackPassive)playerAttack3).GetInnerAttack();
            //if (skill is PlayerAttackSkill)
            //{
            //    (skill as PlayerAttackSkill).Skill();
            //}

            #endregion

            #region 옵저버
            /*
                옵저버(관찰자)가 관찰하고 있는 대상의 상태가 변화가 발생할떄
                대상자는 직접 목록의 각 관찰자들에게 통지하고, 관찰자들은 알림을 받아 조치를 취함

                유튜브 채널은 발행자(Subject)가 되고 구독자들은 관찰자(Observer)가 되는 구조로 보면 된다.
                실제로 유튜버가 영상을 올리면 여러명의 구독자들은 모두 영상이 올라왔다는 알림을 받는데,
                이를 패턴 구조로 보자면 구독자들은 해당 채널을 구독함으로써 채널에 어떠한 변화(영상을 올리거나 커뮤니티에 글을 쓰거나)가 생기게 되면 바로 연락을 받아 탐지하는 것이다.
                반면 구독을 해지하거나 안한 시청자에게는 알림이 가지않게 된다.
                출처: https://inpa.tistory.com/entry/GOF-💠-옵저버Observer-패턴-제대로-배워보자 [Inpa Dev 👨‍💻:티스토리]
             */

            //// 발행자 생성
            //ConcreteSubject publisher = new ConcreteSubject();
            //// 관찰자 생성
            //ObserverA a = new ObserverA();
            //ObserverB b = new ObserverB();
            //ObserverA a2 = new ObserverA();
            //// 발행자에 관찰자 추가
            //publisher.AddObserver(a);
            //publisher.AddObserver(b);
            //publisher.AddObserver(a2);
            //Console.WriteLine("============================================");
            //// 발행자 상태 변경
            //publisher.NotifyObserver();
            //Console.WriteLine("============================================");
            //// 관찰자 제거
            //publisher.RemoveObserver(a);
            //Console.WriteLine("============================================");
            //// 발행자 상태 변경
            //publisher.NotifyObserver();
            //Console.WriteLine("============================================\n");

            //WeatherAPI weatherAPI = new WeatherAPI();
            //weatherAPI.AddObserver(new KoreanUser("UserA"));
            //weatherAPI.Change();
            //Console.WriteLine("============================================");
            //weatherAPI.AddObserver(new KoreanUser("UserB"));
            //weatherAPI.AddObserver(new KoreanUser("UserC"));
            //weatherAPI.AddObserver(new KoreanUser("UserD"));
            //weatherAPI.Change();

            #endregion

            #region 반복자
            /*
                일련의 데이터 집합에 대하여 순차적으로 접근을 지원하는 패턴
                배열, 리스트는 데이터가 일정한 순서로 저장도어있지만
                그래프, 트리 같은 데이터의 집합은 일정한 순서가 없기때문에 반복자 패턴을 이용하여 데이터를 접근함
             */

            //ConcreteAggregate aggregate = new ConcreteAggregate(5);
            //aggregate.Add(1);
            //aggregate.Add(2);
            //aggregate.Add(3);
            //aggregate.Add(4);
            //aggregate.Add(5);
            //aggregate.Add(6);

            //// 이터레이터 객체 반환
            //Iterator iterator = aggregate.iterator();

            //while (iterator.hasNext())
            //{
            //    Console.Write(iterator.next() + " -> ");
            //}

            //MyAggregate<string> aggr = new MyAggregate<string>();
            //aggr[0] = "A";
            //aggr[1] = "B";
            //aggr[2] = "C";

            //IITerator<string> iterator1 = aggr.CreateIterator(ITERATORTYPE.A);

            //while (iterator1.HasNext())
            //{
            //    string item = iterator1.Next();
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 퍼사드
            /*
                퍼사드 패턴(Facade Pattern)은 사용하기 복잡한 클래스 라이브러리에 대해 사용하기 편하게 간편한 인터페이스(API)를 구성하기 위한 구조 패턴 이다.
                예를들어 라이브러리의 각 클래스와 메서드들이 어떤 목적의 동작인지 이해하기 어려워 바로 가져다 쓰기에는 난이도가 높을때,
                이에 대한 적절한 네이밍과 정리를 통해 사용자로 하여금 쉽게 라이브러리를 다룰수 있도록 인터페이스를 만드는데,
                우리가 교제를 보고 필기노트에 재정리를 하듯이 클래스를 재정리하는 행위로 보면 된다.
                출처: https://inpa.tistory.com/entry/GOF-💠-퍼사드Facade-패턴-제대로-배워보자 [Inpa Dev 👨‍💻:티스토리]
             */

            // 안좋은예
            // DateBase, Cache 여러가지의 클래스를 생성 및 사용하고 있음
            // 후에 개발자가 위의 둘중 하나라도 생성 하지 않았다면
            // 서비스 중에 버그가 발생할수 있음

            //// 데이터베이스 생성 및 등록
            //DateBase db = new DateBase();
            //db.Add("A", new Date("nameA", "birthdayA", "emailA"));
            //db.Add("B", new Date("nameB", "birthdayB", "emailB"));
            //db.Add("C", new Date("nameC", "birthdayC", "emailC"));

            //// 캐시 생성
            //Cache cache = new Cache();

            //// 데이터 조회
            //string name = "A";
            //Date date = cache.Get(name);

            //// 캐시에 데이터가 없다면
            //if (date == null)
            //{
            //    // 데이터 베이스에서 데이터 획득
            //    date = db.Get(name);
            //    if (date != null)
            //    {
            //        // 캐쉬에 데이터 저장
            //        cache.Add(date);
            //    }
            //}

            //if (date != null)
            //{
            //    Console.WriteLine(date.ToString());
            //}


            //// 위의 코드를 Facade클래스의 메서드로 변경하여
            //// 특정 클래스를 생성하지 않는 것을 방지할수있음
            //Facade facde = new Facade();
            //// 데이터 베이스 데이터 로드
            //facde.Insert();
            //// 데이터를 찾고 찾은 데이터 정보 출력 까지
            //facde.Run("A");

            #endregion

            #region 빌더
            /*
                빌더 패턴(Builder Pattern)은 복잡한 객체의 생성 과정과 표현 방법을 분리하여 다양한 구성의 인스턴스를 만드는 생성 패턴이다.
                생성자에 들어갈 매개 변수를 메서드로 하나하나 받아들이고 마지막에 통합 빌드해서 객체를 생성하는 방식이다. 
                출처: https://inpa.tistory.com/entry/GOF-💠-빌더Builder-패턴-끝판왕-정리 [Inpa Dev 👨‍💻:티스토리]
             */

            //Person person = new Person.Builder("nameA", "15").Gender("Male").Birthday("2000,1,1").PhoneNumber("000-0000-0000").build();
            //Console.WriteLine(person.ToString());
            //Console.WriteLine();
            //// 디렉터 빌더
            //Builder_Date date = new Builder_Date("홍길동", 23);
            //Director director = new Director(new ABuilder(date));
            //string result = director.Build();
            //Console.WriteLine(result + "\n");
            //director = new Director(new BBuilder(date));
            //result = director.Build();
            //Console.WriteLine(result + "\n");
            //director = new Director(new CBuilder(date));
            //result = director.Build();
            //Console.WriteLine(result + "\n");

            #endregion

            #region 경량
            /*
                경량 패턴은 재사용 가능한 객체 인스턴스를 공유시켜 메모리 사용량을 최소화하는 구조 패턴
                캐시 개념을 코드로 패턴화 한것으로 보면됨, 자주 변화는 속성과 변하지 않는 속성을 분리하고 변하지 않는 속성을 캐시하여 재사용해 메모리 사용량을 줄이는 방식
                동일하거나 유사한 객체들 사이에 가능한 많은 데이터를 서로 공유하여 사용하도록 하여 최적화하는 패턴
             */

            // 안좋은 예
            //// 1500MB사용
            //Fly_Terrain terrain = new Fly_Terrain();

            //for (int i = 0; i < 5; i++)
            //{
            //    terrain.Render("Oak", new object(), new object());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    terrain.Render("Acacia", new object(), new object());
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    terrain.Render("Jungle", new object(), new object());
            //}
            //Fly_Memory.PrintSize();
            //Console.WriteLine("=======================================");

            //Weight_Terrain terrain2 = new Weight_Terrain();
            //for (int i = 0; i < 5; i++)
            //{
            //    terrain2.Render("Oak");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    terrain2.Render("Acacia");
            //}
            //for (int i = 0; i < 5; i++)
            //{
            //    terrain2.Render("Jungle");
            //}
            //Weight_Memory.PrintSize();
            #endregion

            #region 복합체
            /*
                복합체 패턴(Composite Pattern)은 복합 객체(Composite) 와 단일 객체(Leaf)를 동일한 컴포넌트로 취급하여,
                클라이언트에게 이 둘을 구분하지 않고 동일한 인터페이스를 사용하도록 하는 구조 패턴이다.
                복합체 패턴은 전체-부분의 관계를 갖는 객체들 사이의 관계를 트리 계층 구조로 정의해야 할때 유용하다.
                윈도우나 리눅스의 파일 시스템 구조, 마인크래프트 모드중에 가방모드를 떠올려보면 쉽게 이해할 수 있다.
                출처: https://inpa.tistory.com/entry/GOF-💠-복합체Composite-패턴-완벽-마스터하기 [Inpa Dev 👨‍💻:티스토리]
             */

            //// 최상위 복합체
            //Composite composite1 = new Composite();

            //// 최상위 복합체에 자식으로 넣을 객체
            //Leaf leaf1 = new Leaf();
            //// 최상위 복합체에 자식으로 넣을 또다른 복합체
            //Composite composite2 = new Composite();

            //composite1.AddLeaf(leaf1);
            //composite1.AddLeaf(composite2);

            //// composite2에 넣을 자식 객체
            //Leaf leaf2 = new Leaf();
            //Leaf leaf3 = new Leaf();
            //Leaf leaf4 = new Leaf();

            //composite2.AddLeaf(leaf2);
            //composite2.AddLeaf(leaf3);
            //composite2.AddLeaf(leaf4);

            //// 최상위 복합체의 자식들 호출
            //composite1.Operation();

            //Console.WriteLine();

            //// 메인 가방 생성
            //Bag mainBag = new Bag("메인 가방");

            //// 메인 가방의 아이템 생성
            //Item armor = new Item("갑옷", 250);
            //Item sword = new Item("검", 500);

            //// 메인 가방에 저장
            //mainBag.Add(armor);
            //mainBag.Add(sword);

            //// 서브 가방 생성
            //Bag foodBag = new Bag("음식 가방");

            //// 서브 가방의 아이템 생성
            //Item apple = new Item("사과", 400);
            //Item banna = new Item("바나나", 130);

            //// 서브 가방에 아이템 저장
            //foodBag.Add(apple);
            //foodBag.Add(banna);

            //// 서브 가방 메인 가방에 저장
            //mainBag.Add(foodBag);

            //Console.WriteLine(mainBag.GetPrice());
            //// 서브 가방의 값만 획득 가능
            //Console.WriteLine(foodBag.GetPrice());
            #endregion

            #region 책임 연쇄
            /*
                클라이언트의 요청에 대한 세세한 처리를 하나의 객체가 전부 처리하는것이 아닌
                여러 객체들로 나누고, 객체들을 사슬 처럼 연결해 집한 안에서 연쇄적으로 처리하는 패턴
             */

            CharacterEventHandler chEvent = new CharacterEventHandler();
            UIEventHandler uiEvent = new UIEventHandler();

            chEvent.SetNext(uiEvent);

            Character ch = new Character("Player");
            UI ui = new UI("MainMenu");

            chEvent.HandleEvent("MouseClick", ch);
            chEvent.HandleEvent("MouseClick", ui);
            chEvent.HandleEvent("OtherEvent", ch);

            uiEvent.SetNext(chEvent);
            uiEvent.HandleEvent("MouseClick2", ch);

            #endregion
        }
    }
}