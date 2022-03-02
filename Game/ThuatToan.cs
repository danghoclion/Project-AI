using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ThuatToan
    {
        public static List<string> DanhSach = new List<string>();
        public List<Edge> edges;
        public ThuatToan(string path)
        {
            string[] data = System.IO.File.ReadAllLines(path);
            edges = new List<Edge>();
            foreach (var item in data)
            {
                string[] s = item.Split(' ');
                edges.Add(new Edge(s[0], s[1]));
            }

        }
        public Dictionary<string, string> father = new Dictionary<string, string>();
        public void BFS()
        {
            Console.Write("Nhap dinh dau: ");
            string s = 1.ToString();
            Console.Write("Nhap dinh cuoi: ");
            string f = 14.ToString();

            foreach (var item in edges)
            {
                if (!father.ContainsKey(item.u))
                    father.Add(item.u, null);
                if (!father.ContainsKey(item.v))
                    father.Add(item.v, null);
            }
            List<string> DONG = new List<string>();
            Queue<string> q = new Queue<string>();
            q.Enqueue(s);
            while (q.Count != 0)
            {
                string temp = q.Peek();
                DONG.Add(temp);
                q.Dequeue();
                List<string> dske = edges.Where(p => p.u == temp).Select(p => p.v).ToList();
                foreach (var i in dske)
                {
                    if (!DONG.Contains(i))
                    {
                        q.Enqueue(i);
                        father[i] = temp;
                    }
                }

            }
            InDuongDi(s, f, father);
        }
        public void InDuongDi(string s, string f, Dictionary<string, string> father)
        {
            //if (s == f)
            //    Console.Write(f + " -> ");
            //else
            if (father[f] == null)
                Console.WriteLine("Khong tim duoc");
            else
            {
                InDuongDi(s, father[f], father);
                //Console.Write(f + " -> ");
                DanhSach.Add(f);

            }
        }
        public List<string> DanhSach1()
        {
            List<string> temp = new List<string>();
            foreach (var item in DanhSach)
                temp.Add(item);
            return temp;
        }
        public string tesst(int i)
        {
            return DanhSach[i];
        }
    }
}
