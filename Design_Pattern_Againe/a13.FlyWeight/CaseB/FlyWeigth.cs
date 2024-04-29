using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Weight_Memory
{
    public static long size = 0;
    public static void PrintSize()
    {
        Console.WriteLine("total Memory Size : {0}MB", size);
    }
}

public class TreeModel
{
    long objSize = 90;

    public string type;
    object mesh;
    object texture;

    public TreeModel(string type, object mesh, object texture)
    {
        this.type = type;
        this.mesh = mesh;
        this.texture = texture;

        Weight_Memory.size += objSize;
    }
}

public class Tree
{
    long objSize = 10;

    public double pos_X;
    public double pos_Y;

    TreeModel model;

    public Tree(TreeModel model, double pos_x, double pos_y)
    {
        Random random = new Random();

        this.model = model;
        this.pos_X = pos_x;
        this.pos_Y = pos_y;

        Weight_Memory.size += objSize;
    }
}

public class TreeFactory
{
    // TreeModel를 딕셔너리에 저장
    private static Dictionary<string, TreeModel> cache = new Dictionary<string, TreeModel>();

    public static TreeModel GetTreeModel(string type)
    {
        if (cache.ContainsKey(type))
        {
            return cache[type];
        }
        else
        {
            // 새로운 트리 모델 생성
            TreeModel model = new TreeModel(type, new object(), new object());
            Console.WriteLine("Create New TreeModel");
            cache.Add(type, model);

            return model;
        }
    }
}

public class Weight_Terrain
{
    const int CANVAS_SIZE = 100;

    // 나무 랜더링
    public void Render(string type)
    {
        // 캐싱되어있는 나무 모델링 가져오기
        TreeModel model = TreeFactory.GetTreeModel(type);
        // 나무 생성
        Random random = new Random();
        Tree tree = new Tree(model, random.NextDouble() * CANVAS_SIZE, random.NextDouble() * CANVAS_SIZE);

        Console.WriteLine($"Create in\nX : {tree.pos_X} / Y : {tree.pos_Y}\nType : {model.type}");
    }
}