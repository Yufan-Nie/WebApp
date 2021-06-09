using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp_IService
{
    interface IGraphOperation
    {
        // 定义 GetAera 方法，实现面积的计算
        float GetAera();

        // 定义周长属性，实现根据边长进行周长的计算
        // 修改下行代码，合理设置get和set访问器，使得Perimeter可读而不可写
        float Perimeter { get; }
    }

    class Graph
    {
        public Graph(float sideLength) { _sideLength = sideLength; }
        protected float _sideLength;	// 图形的边长
    }

    // 下面的三角形和正方形类，需要派生于Graph类，并实现 IGraphOperation 接口定义的方法
    class Triangle
    {
    }
    class Rect
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<IGraphOperation> listGraph = new List<IGraphOperation>();

            // 使用 listGraph 管理创建的图形，创建 三角形 和 正方形，边长为 5 

            // listGraph中的对象使用 GetAera()方法和Perimeter属性输出 面积和边长

        }
    }

}
