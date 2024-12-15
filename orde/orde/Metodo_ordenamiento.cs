using System;
using System.Collections.Generic;
using System.Linq;

namespace orde
{
    public class Metodo_ordenamiento
    {
        public int[] ParseNumbers(string input)
        {
            try
            {
               
                return input.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
            }
            catch (FormatException)
            {
                throw new FormatException("Por favor, asegúrese de poder ingresar solo números separados por comas.");
            }
            catch (Exception ex)
            {
                throw new Exception("Ocurrió un error al procesar los números: " + ex.Message);
            }
        }

     
        public string DisplayNumbers(int[] numbers)
        {
            return string.Join(", ", numbers);
        }

        // Burbuja
        public int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        //  Inserción
        public int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            return arr;
        }

     // Selección
        public int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }

               
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }

        // Merge Sort
        public int[] MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;
            int[] left = MergeSort(arr.Take(mid).ToArray());
            int[] right = MergeSort(arr.Skip(mid).ToArray());

            return Merge(left, right);
        }

        private int[] Merge(int[] left, int[] right)
        {
            List<int> result = new List<int>();
            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            result.AddRange(left.Skip(i));
            result.AddRange(right.Skip(j));

            return result.ToArray();
        }

        // QuickSort
        public int[] QuickSort(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            int pivot = arr[0];
            int[] less = arr.Skip(1).Where(x => x <= pivot).ToArray();
            int[] greater = arr.Skip(1).Where(x => x > pivot).ToArray();

            return QuickSort(less)
                    .Concat(new int[] { pivot })
                    .Concat(QuickSort(greater))
                    .ToArray();
        }

        // HeapSort
        public int[] HeapSort(int[] arr)
        {
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
                Heapify(arr, arr.Length, i);

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                Heapify(arr, i, 0);
            }
            return arr;
        }

        private void Heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                Heapify(arr, n, largest);
            }
        }

        // Búsqueda Lineal
        public int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; 
                }
            }
            return -1;
        }

        // Búsqueda Binaria
        public int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid; 
                }
               
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
               
                else
                {
                    high = mid - 1;
                }
            }
        }
    }
}
