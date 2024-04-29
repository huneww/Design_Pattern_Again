using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 발행자
public class WeatherAPI
{
    // 온도
    public float temp;
    // 습도
    public float humidity;
    // 기압
    public float pressure;
    // 관찰자 저장 리스트
    List<Observer_IUser> observers = new List<Observer_IUser>();

    // 발행자의 상태 변경 메서드
    public void Change()
    {
        Random random = new Random();
        temp = (float)random.NextDouble() * 10f;
        humidity = (float)random.NextDouble() * 10f;
        pressure = (float)random.NextDouble() * 10f;

        // 관찰자 전원 호출
        PrintAllInfo();
    }

    // 관찰자 추가
    public void AddObserver(Observer_IUser user)
    {
        observers.Add(user);
    }

    // 관찰자 제거
    public void RemoveObserver(Observer_IUser user)
    { 
        observers.Remove(user);
    }

    // 관찰자 전원 호출
    public void PrintAllInfo()
    {
        if (observers.Count <= 0)
        {
            return;
        }

        foreach (var ob in observers)
        {
            ob.Display(this);
        }
    }

}

// 관찰자가 상속받을 인터페이스
public interface Observer_IUser
{
    public void Display(WeatherAPI weather);
}

public class KoreanUser : Observer_IUser
{
    // 관찰자 정보
    string name;

    public KoreanUser(string name)
    {
        this.name = name;
    }

    // 발행자 상태 변경시 호출될 메서드
    public void Display(WeatherAPI weather)
    {
        Console.WriteLine($"{name} : {weather.temp}C, {weather.humidity}g/m3, {weather.pressure}hpa");
    }
}