using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상위 클래스
public abstract class FileProcessor
{
    // 텍스트 파일의 경로
    // 지금은 그냥 확인할 숫자 문자열
    private string path;
    
    // 경로 지정
    public FileProcessor(string path)
    {
        this.path = path;
    }

    // 경로의 파일을 읽고 결과값 반환
    public int Processor()
    {
        string[] arr = path.Split("/");
        int result = GetResult();
        foreach (string str in arr)
        {
            result = Caculate(result, int.Parse(str));
        }
        return result;
    }

    // 하위 클래스에서 구현할 계산 방법, 초기 result의 값
    public abstract int Caculate(int result, int value);
    public abstract int GetResult();
}


public class PlusFileProcessor : FileProcessor
{
    // 경로 저장
    public PlusFileProcessor(string path) : base(path)
    {

    }

    // 계산
    public override int Caculate(int result, int value)
    {
        return result + value;
    }

    // result값
    public override int GetResult()
    {
        return 0;
    }
}

public class MultiplyFileProcessor : FileProcessor
{
    public MultiplyFileProcessor(string path) : base(path)
    {

    }

    public override int Caculate(int result, int value)
    {
        return result * value;
    }

    public override int GetResult()
    {
        return 1;
    }
}