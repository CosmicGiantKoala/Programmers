using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;

namespace CodingTestIDE
{
/*
 * 문제 설명

m개의 행과 n개의 열로 구성된 격자가 주어지며, 이는 사막 지도를 나타냅니다. 사막 지도의 가장 왼쪽 위칸 좌표는 (0, 0), 오른쪽 아래칸 좌표는 (m-1, n-1)입니다. 이 사막 어딘가에 가로 w, 세로 h 크기의 선인장 구역을 조성하려 합니다. 선인장 구역은 격자 축에 맞춘 연속된 w × h 크기의 부분 격자이며, 회전할 수 없습니다.

비구름은 미리 정해진 순서대로 격자의 여러 칸에 비를 뿌립니다. 이때 빗방울이 처음으로 선인장 구역에 포함된 칸에 떨어졌을 때, 그 시점을 선인장이 처음으로 비를 맞는 순간으로 기록합니다. 당신은 선인장이 가능한 한 늦게 비를 맞도록, 선인장 구역의 위치를 정하려고 합니다.

선인장이 비를 맞지 않도록 선인장 구역의 위치를 정할 수 있다면 해당 위치가 가장 우선됩니다.
가능한 늦게 비를 맞는 선인장 구역 후보가 여러 개라면 그중 가장 위쪽 행, 그래도 여러 개면 가장 왼쪽 열에 위치한 구역을 선택합니다.

격자의 세로 길이와 가로 길이를 나타내는 정수 m, n, 선인장 구역의 세로 길이와 가로 길이를 나타내는 정수 h, w, 그리고 빗방울이 떨어지는 순서대로 칸의 좌표를 담은 2차원 정수 배열 drops가 매개변수로 주어집니다. 주어진 조건을 만족하는 선인장 구역에 포함된 가장 왼쪽 위칸의 좌표를 정수 배열로 return 하도록 solution 함수를 완성해 주세요.
제한사항

1 ≤ m, n ≤ 500,000
1 ≤ m × n ≤ 500,000
1 ≤ h ≤ m
1 ≤ w ≤ n
1 ≤ drops의 길이 ≤ m × n
    drops[i]는 [r, c] 형태입니다.
    drops[i]는 i + 1번째로 떨어진 빗방울의 좌표를 의미합니다.
    0 ≤ r < m
    0 ≤ c < n
    drops의 모든 원소는 서로 다른 칸을 나타냅니다.

 */
    public class Exam468379 : Exam
    {
        private int m = 4;
        private int n = 4;
        private int h = 3;
        private int w = 1;

        private int[,] drops = new int[,]
            {{2,0}, {1,3}, {3,2}, {0,1}};

        public override void Run()
        {
            int[] answer = {-1,-1};
            int[,] area = new int[m,n];
            int maxValue = m * n + 1;
            int verticalRow = m - (h - 1);
            int horizontalRow = n - (w - 1);
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    area[i, j] = maxValue;
                }
            }
            
            for (int i = 0; i < drops.GetLength(0); i++)
            {
                var drops_v = drops[i, 0];
                var drops_h = drops[i, 1];
                area[drops_v, drops_h] = i;
            }

            int[,] horizontalResult = new int[m, horizontalRow];
            for (int vertical = 0; vertical < m; vertical++)
            {
                var window = new LinkedList<int>();
                for (int horizontal = 0; horizontal < n; horizontal++)
                {
                    if (window.Count > 0 && window.First.Value <= horizontal - w) window.RemoveFirst();
                    while (window.Count > 0 && area[vertical, window.Last.Value] >= area[vertical, horizontal])
                    {
                        window.RemoveLast();
                    }

                    window.AddLast(horizontal);

                    if (horizontal >= w - 1)
                    {
                        horizontalResult[vertical, horizontal - w + 1] = area[vertical, window.First.Value];
                    }
                }
            }
            
            int[,] verticalResult = new int[verticalRow, horizontalRow];
            for (int horizontal = 0; horizontal < horizontalRow; horizontal++)
            {
                var window = new LinkedList<int>();
                for (int vertical = 0; vertical < m; vertical++)
                {
                    if (window.Count>0 && window.First.Value <= vertical - h) window.RemoveFirst();
                    while (window.Count >0 && horizontalResult[window.Last.Value,horizontal] >= horizontalResult[vertical, horizontal])
                    {
                        window.RemoveLast();
                    }
                    window.AddLast(vertical);
                    if (vertical >= h - 1)
                    {
                        verticalResult[vertical - h +1, horizontal] = horizontalResult[window.First.Value, horizontal];
                    }
                }
            }

            int lastArea = -1;
            for (int vertical = 0; vertical < verticalRow; vertical++)
            {
                for (int horizontal = 0; horizontal < horizontalRow; horizontal++)
                {
                    if (verticalResult[vertical, horizontal] > lastArea)
                    {
                        answer[0] = vertical;
                        answer[1] = horizontal;
                        lastArea = verticalResult[vertical, horizontal];
                    }
                }
            }

            Console.WriteLine($"{answer[0]}, {answer[1]}");
        }
    }
}