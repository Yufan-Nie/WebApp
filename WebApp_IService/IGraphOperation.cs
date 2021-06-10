using System;
using System.Collections.Generic;
using System.Text;
using static WebApp_IService.IGraphOperation;

namespace WebApp_IService
{

    public interface IGraphOperation
    {
        // 定义 GetAera 方法，实现面积的计算
        float GetArea();


        // 定义周长属性，实现根据边长进行周长的计算
        // 修改下行代码，合理设置get和set访问器，使得Perimeter可读而不可写
        float Perimeter { get; }
    }
    /// <summary>
    /// 基类
    /// </summary>
    class Graph
    {
        public void setSideLength(float sideLength)
        {
             _sideLength = sideLength;
        }
        protected float _sideLength;    // 图形的边长
    }

    // 下面的三角形和正方形类，需要派生于Graph类，并实现 IGraphOperation 接口定义的方法
    class Triangle : Graph,IGraphOperation
    {
        public float Perimeter => _sideLength * 3;


        public float GetArea()
        {
            float height = (float)(_sideLength / 2 * Math.Sqrt(3));
            return _sideLength * height / 2;
        }
    }

    class Rect : Graph,IGraphOperation
    {
        public float Perimeter => _sideLength * 4;

        public float GetArea()
        {
            return (_sideLength * _sideLength);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IGraphOperation> listGraph = new List<IGraphOperation>();

            // 使用 listGraph 管理创建的图形，创建 三角形 和 正方形，边长为 5 
            Rect rect = new Rect();
            rect.setSideLength(5);
            double area = rect.GetArea();
            double Perimeter = rect.Perimeter;

            Triangle triangle = new Triangle();
            triangle.setSideLength(5);
            double trianglearea = triangle.GetArea();
            double trianglePerimeter = triangle.Perimeter;
            // listGraph中的对象使用 GetAera()方法和Perimeter属性输出 面积和边长
            Console.WriteLine("面积： {0}", area);
            Console.WriteLine("周长： ${0}", Perimeter);
            Console.WriteLine("三角形面积： {0}", trianglearea);
            Console.WriteLine("三角形周长： ${0}", trianglearea);
            Console.ReadKey();
        }
    }

}
