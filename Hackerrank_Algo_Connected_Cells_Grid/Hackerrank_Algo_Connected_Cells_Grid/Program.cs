using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_Algo_Connected_Cells_Grid
{
    class Program
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] grid = new int[n, m];
            var visited = new bool[n, m];
            for (int i = 0; i < n; i++)
            {
                var temp = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    grid[i, j] = Convert.ToInt32(temp[j]);
                    visited[i, j] = false;
                }
            }
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //Console.Write(grid[i,j]  + " ");
                    if (!visited[i, j]) max = Math.Max(max, find(grid, visited, i, j, n, m));
                }
                //Console.WriteLine();
            }
            Console.WriteLine(max);
        }
        public static int find(int[,] grid, bool[,] visited, int i, int j, int M, int N)
        {
            if (i < 0 || j < 0 || i >= M || j >= N) return 0;
            if (visited[i, j]) return 0;
            visited[i, j] = true;
            if (grid[i, j] == 0)
                return 0;
            else
                return 1 +
                find(grid, visited, i - 1, j - 1, M, N) +
                find(grid, visited, i - 1, j, M, N) +
                find(grid, visited, i - 1, j + 1, M, N) +
                find(grid, visited, i, j - 1, M, N) +
                find(grid, visited, i, j, M, N) +
                find(grid, visited, i, j + 1, M, N) +
                find(grid, visited, i + 1, j - 1, M, N) +
                find(grid, visited, i + 1, j, M, N) +
                find(grid, visited, i + 1, j + 1, M, N);

        }
    }
}
