using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 프록시와 생성 클래스의 상위 클래스
public interface IImage
{
    public abstract void ShowImage();
}

public class Proxy_Image : IImage
{
    // 생성할 객체
    private IImage image;
    // 객체의 정보 혹은 경로
    private string path;

    // 프록시 생성시 객체의 정보만을 저장
    // 객체를 생성하지 않음
    public Proxy_Image(string path)
    {
        this.path = path;
    }

    // 객체 생성을 클라이언트가 요청
    public void ShowImage()
    {
        // 객체를 늦게 생성
        image = new Proxy_HighResoultionImage(path);
        // 생성한 객체 출력
        image.ShowImage();
    }
}

// 객체 생성 클래스
public class Proxy_HighResoultionImage : IImage
{
    // 생성할 객체
    string img;

    public Proxy_HighResoultionImage(string path)
    {
        // 객체 생성
        LoadImage(path);
    }

    private void LoadImage(string path)
    {
        // 객체 생성 시간
        Thread.Sleep(1000);
        // 객체 생성
        this.img = path;

        // 객체 생성 여부 확인
        if (string.IsNullOrEmpty(img))
        {
            // 실패시 오류 출력
            Console.WriteLine("Image Load Error");
            return;
        }

        // 객체 생성
        Console.WriteLine("Image Load Success");
    }

    // 객체 정보 출력
    public void ShowImage()
    {
        Console.WriteLine($"{img} Show");
    }
}
