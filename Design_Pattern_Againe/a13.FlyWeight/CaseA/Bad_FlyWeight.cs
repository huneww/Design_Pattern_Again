using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Fly_Memory
{
    public static long size = 0;

    public static void PrintSize()
    {
        Console.WriteLine("Total Memory Size : {0}MB", size);
    }
}

public class Fly_Tree
{
    private long objSize = 100;

    // 나무의 타입
    private string type;
    // 나무의 메쉬와 텍스처
    object mesh;
    object texture;

    // 나무 위치
    public double pos_x;
    public double pos_y;

    public Fly_Tree(string type, object mesh, object texture, double pos_x, double pos_y)
    {
        this.type = type;
        this.mesh = mesh;
        this.texture = texture;
        this.pos_x = pos_x;
        this.pos_y = pos_y;

        Fly_Memory.size += objSize;
    }
}

public class Fly_Terrain
{
    static int CANVAS_SCAL = 1000;

    public void Render(string type, object mesh, object texture)
    {
        Random random = new Random();
        Fly_Tree tree = new Fly_Tree(type, mesh, texture, random.NextDouble() * CANVAS_SCAL, random.NextDouble() * CANVAS_SCAL);

        Console.WriteLine($"Create in\nX : {tree.pos_x} / Y : {tree.pos_y}\nType : {type}");
    }
}