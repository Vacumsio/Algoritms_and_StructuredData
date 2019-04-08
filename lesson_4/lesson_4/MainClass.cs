using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 1. *Количество маршрутов с препятствиями. Реализовать чтение массива с препятствием и нахождение количество маршрутов.
Карта для примера:
3 3
1 1 1
0 1 0
0 1 0

2. Решить задачу о нахождении длины максимальной подпоследовательности с помощью матрицы.

3. ***Требуется обойти конём шахматную доску размером N × M, пройдя через все поля доски по одному разу. 
Здесь алгоритм решения такой же, как и в задаче о 8 ферзях. Разница только в проверке положения коня.
*/
namespace lesson_4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            StarMatrix cw = new StarMatrix();
            cw.ReadMap();
            cw.DrawMap();
            
        }
    }
}
