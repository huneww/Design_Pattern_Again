using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 데이터 베이스의 데이터 클래스
public class Date
{
    private string name;
    private string birthday;
    private string email;

    public Date(string name, string birthday, string email)
    {
        this.name = name;
        this.birthday = birthday;
        this.email = email;
    }

    public string GetName()
    {
        return name;
    }
    
    public string GetBirthday()
    {
        return birthday;
    }

    public string GetEmail()
    {
        return email;
    }

    public override string ToString()
    {
        return $"Name : {name}\nBirthDay : {birthday}\nEmail : {email}\n===============================";
    }

}

public class DateBase
{
    private Dictionary<string, Date> db = new Dictionary<string, Date>();

    public void Add(string name, Date date)
    {
        db.Add(name, date);
    }

    public Date Get(string name)
    {
        // 데이터 로딩
        Thread.Sleep(250);

        if (!db.ContainsKey(name))
        {

        }

        return db[name];
    }
}

// DateBase에서 조회된 데이터를 임시 저장할 클래스
public class Cache
{
    private Dictionary<string, Date> cache = new Dictionary<string, Date>();

    public void Add(Date date)
    {
        cache.Add(date.GetName(), date);
    }

    public Date Get(string name)
    {
        if (cache.ContainsKey(name))
        {
            return cache[name];
        }

        return null;
    }
}

public class Facade
{
    private DateBase db = new DateBase();
    private Cache cache = new Cache();

    public void Insert()
    {
        db.Add("A", new Date("nameA", "birthdayA", "emailA"));
        db.Add("B", new Date("nameB", "birthdayB", "emailB"));
        db.Add("C", new Date("nameC", "birthdayC", "emailC"));
    }

    public void Run(string name)
    {
        // 데이터 조회
        Date date = cache.Get(name);

        // 캐시에 데이터가 없다면
        if (date == null)
        {
            // 데이터 베이스에서 데이터 획득
            date = db.Get(name);
            if (date != null)
            {
                // 캐쉬에 데이터 저장
                cache.Add(date);
            }
        }

        if (date != null)
        {
            Console.WriteLine(date.ToString());
        }
        else
        {
            Console.WriteLine("Date is Not Have");
        }
    }

}