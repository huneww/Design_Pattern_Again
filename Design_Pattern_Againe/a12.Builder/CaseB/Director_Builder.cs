using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Builder_Date
{
    private string name;
    private int age;

    public Builder_Date(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
}

public class Director
{
    private Builder builder;

    public Director(Builder builder)
    {
        this.builder = builder;
    }

    public string Build()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(builder.Head());
        sb.Append(builder.Body());
        sb.Append(builder.Foot());

        return sb.ToString();
    }
}

public abstract class Builder
{
    // 상속한 클스에서 데이터 접근을 위해 protected로 설정
    protected Builder_Date date;

    public Builder(Builder_Date date)
    {
        this.date = date;
    }

    // Date객체를 데이터를 원하는 형태의 문자로 포멧을 해주는 메서드
    public abstract string Head();
    public abstract string Body();
    public abstract string Foot();
}

public class ABuilder : Builder
{
    public ABuilder(Builder_Date date) : base(date)
    {
    }

    public override string Head()
    {
        return "";
    }

    public override string Body()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Name : ");
        sb.Append(date.GetName());
        sb.Append(", Age : ");
        sb.Append(date.GetAge());

        return sb.ToString();
    }

    public override string Foot()
    {
        return "";
    }
}

public class BBuilder : Builder
{
    public BBuilder(Builder_Date date) : base(date)
    {
    }

    public override string Head()
    {
        return "{\n"; 
    }

    public override string Body()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("\t\"Name\" : ");
        sb.Append("\"" + date.GetName() + "\",\n");
        sb.Append("\t\"Age\" : ");
        sb.Append("\"" + date.GetAge() + "\"");

        return sb.ToString();
    }

    public override string Foot()
    {
        return "\n}";
    }
}

public class CBuilder : Builder
{
    public CBuilder(Builder_Date date) : base(date)
    {
    }

    public override string Head()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<?xml version\"1.0\" encoding\"UTF-8\" ?>\n");
        sb.Append("<DATE>\n");

        return sb.ToString();
    }

    public override string Body()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("\t<NAME>");
        sb.Append(date.GetName());
        sb.Append("<NAME>");
        sb.Append("\n\t<AGE>");
        sb.Append(date.GetAge());
        sb.Append("<AGE>");

        return sb.ToString();
    }

    public override string Foot()
    {
        return "\n<DATE>";
    }
}
