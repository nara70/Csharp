using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace is52_Doroshenko_07
{
    class is52_Doroshenko_07
    {
        /// <summary>
        /// Заміна місцями елементів
        /// </summary>
        /// <param name="A">Масив</param>
        /// <param name="a">перший елемент</param>
        /// <param name="b">другий елемент</param>
        public static void Swap(int[] A, int a, int b)
        {
            int tmp;
            tmp = A[a];
            A[a] = A[b];
            A[b] = tmp;
        }
        /// <summary>
        /// Пошук індекса елемента
        /// </summary>
        /// <param name="A">Масив</param>
        /// <param name="m">Значення елементу масиву</param>
        /// <returns>індекс елемента</returns>
        public static int Find(int[] A, int m)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == m)
                    return i;
            }
            return 0;
        }
        /// <summary>
        /// Пошук максимального елементу піраміди та запис до іншої
        /// </summary>
        /// <param name="A">піраміда</param>
        /// <returns>максимальний елемент</returns>
        public static int HeapExtractMax(int[] A)
        {
            int tmp;
            tmp = A.Max();
            for (int i = Find(A, A.Max()); i < A.Length - 1; i++)
            {
                A[i] = A[i + 1];

            }
            return tmp;
        }
        /// <summary>
        /// Пошук мінімального елементу піраміди та запис до іншої
        /// </summary>
        /// <param name="A">піраміда</param>
        /// <returns>мінімальний елемент</returns>
        public static int HeapExtractMin(int[] A)
        {
            int buf;
            buf = A.Min();
            for (int i = Find(A, A.Min()); i < A.Length - 1; i++)
            {
                A[i] = A[i + 1];

            }
            int[] B = new int[A.Length - 1];
            Array.Copy(A, B, A.Length - 1);
            A = B;
            return buf;

        }
        /// <summary>
        /// Пошук батьківського вузла
        /// </summary>
        /// <param name="i">індекс вузла</param>
        /// <returns>Ідекс батьківського вузла</returns>
        public static int Parent(int i)
        {
            return (i - 1) / 2;
        }
        /// <summary>
        /// Пошук лівого нащадка
        /// </summary>
        /// <param name="i">індекс вузла</param>
        /// <returns>індекс лівого нащадка</returns>
        public static int Left(int i)
        {
            return 2 * i + 1;
        }
        /// <summary>
        /// Пошук правого нащадка
        /// </summary>
        /// <param name="i">індекс вузла</param>
        /// <returns>індекс правого нащадка</returns>
        public static int Right(int i)
        {
            return 2 * i + 2;
        }
        /// <summary>
        /// Підтримка властивості незростаючої піраміди
        /// </summary>
        /// <param name="A">піраміда</param>
        /// <param name="i">індекс</param>
        /// <param name="heap_size">Розмір піраміди</param>
        public static void MaxHeapify(int[] A, int i, int heap_size)
        {
            int p = Left(i);
            int q = Right(i);
            int largest;
            if (p < heap_size && A[p] > A[i])
            {
                largest = p;
            }
            else
                largest = i;
            if (q < heap_size && A[q] > A[largest])
                largest = q;
            if (largest != i)
            {
                Swap(A, i, largest);
                MaxHeapify(A, largest, heap_size);
            }
        }
        /// <summary>
        /// Побудова незростаючої піраміди
        /// </summary>
        /// <param name="A">Вхідний масив</param>
        public static void BuildMaxHeap(int[] A)
        {
            int heap_size = A.Length;
            for (int i = A.Length / 2; i >= 0; i--)
                MaxHeapify(A, i, heap_size);
        }
        /// <summary>
        /// Підтримка властивості неспадної піраміди
        /// </summary>
        /// <param name="A">піраміда</param>
        /// <param name="i">індекс</param>
        /// <param name="heap_size">Розмір піраміди</param>
        public static void MinHeapify(int[] A, int i, int heap_size)
        {
            int p = Left(i);
            int q = Right(i);
            int min;
            if (p < heap_size && A[p] < A[i])
            {
                min = p;
            }
            else
                min = i;
            if (q < heap_size && A[q] < A[min])
                min = q;
            if (min != i)
            {
                Swap(A, i, min);
                MinHeapify(A, min, heap_size);
            }
        }
        /// <summary>
        /// Побудова неспадної піраміди
        /// </summary>
        /// <param name="A">Вхідний масив</param>
        public static void BuildMinHeap(int[] A)
        {
            int heap_size = A.Length;
            for (int i = A.Length / 2; i >= 0; i--)
                MinHeapify(A, i, heap_size);
        }
        /// <summary>
        /// Зчитування з файлу
        /// </summary>
        /// <param name="path">Шлях до файлу</param>
        /// <returns>Дані</returns>
        public static int[] ReadFromFile(string path)
        {
            FileStream f = new FileStream(path, FileMode.Open);
            StreamReader r = new StreamReader(f);
            int n = Convert.ToInt32(r.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = Convert.ToInt32(r.ReadLine());
            }
            f.Close();
            return A;
        }
        /// <summary>
        /// Запис результату
        /// </summary>
        /// <param name="path">Шлях до файлу</param>
        /// <param name="A">Дані</param>
        public static void WriteAnswer(string path, int[] A)
        {
            FileStream f = new FileStream(path, FileMode.OpenOrCreate);   //Відкриття вихідного файлу
            StreamWriter w = new StreamWriter(f);
            int[] heap_high = new int[0];                              //Неспадна піраміда
            int[] heap_low = new int[0];                              //Незростаюча піраміда
            for (int i = 0; i < A.Length; i++)                         //Процес поєтапного визначення медіан
            {
                if (i == 0 || A[i] < heap_low.Max())
                {
                    Array.Resize<int>(ref heap_low, heap_low.Length + 1);
                    heap_low[heap_low.Length - 1] = A[i];
                }
                else
                {
                    Array.Resize<int>(ref heap_high, heap_high.Length + 1);
                    heap_high[heap_high.Length - 1] = A[i];
                }
                if (heap_high.Length == heap_low.Length - 2)
                {
                    Array.Resize<int>(ref heap_high, heap_high.Length + 1);
                    heap_high[heap_high.Length - 1] = HeapExtractMax(heap_low);
                    int[] B = new int[heap_low.Length - 1];
                    Array.Copy(heap_low, B, heap_low.Length - 1);
                    heap_low = B;
                }
                else if (heap_high.Length == heap_low.Length + 2)
                {
                    Array.Resize<int>(ref heap_low, heap_low.Length + 1);
                    heap_low[heap_low.Length - 1] = HeapExtractMin(heap_high);
                    int[] B = new int[heap_high.Length - 1];
                    Array.Copy(heap_high, B, heap_high.Length - 1);
                    heap_high = B;
                }
                BuildMaxHeap(heap_low);
                BuildMinHeap(heap_high);
                if (i % 2 != 0)
                {
                    w.WriteLine(heap_low[0] + " " + heap_high[0]);
                }
                else if (heap_low.Length > heap_high.Length)
                    w.WriteLine(heap_low[0]);
                else
                    w.WriteLine(heap_high[0]);
            }
            w.Close();
            f.Close();
        }
        static void Main(string[] args)
        {
            string path_of_file_with_answer = "is52_Doroshenko_05_output.txt";
            string path;
            Console.Write("Please, enter the path of your input file: ");
            path = Console.ReadLine();
            int[] A = ReadFromFile(path);
            WriteAnswer(path_of_file_with_answer, A);
        }
    }
}

