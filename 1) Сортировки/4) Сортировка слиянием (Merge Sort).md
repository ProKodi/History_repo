



- [Описание алгоритма по шагам](#описание-алгоритма-по-шагам)
  - [Оценка по сложности и по памяти](#оценка-по-сложности-и-по-памяти)
    - [Сложность:](#сложность)
    - [Затраты по памяти](#затраты-по-памяти)
- [Пример визуализации алгоритма](#пример-визуализации-алгоритма)
  - [Исходный массив:](#исходный-массив)
  - [Шаг 1 — разделение массива](#шаг-1--разделение-массива)
  - [Шаг 2 — рекурсивное разделение](#шаг-2--рекурсивное-разделение)
  - [Шаг 3 — слияние](#шаг-3--слияние)
  - [Шаг 4 — финальное слияние](#шаг-4--финальное-слияние)
  - [Итог](#итог)
- [Реализация в коде](#реализация-в-коде)
  - [Python](#python)
  - [C#](#c)


# Описание алгоритма по шагам
Массив рекурсивно делится на две части, затем каждая часть сортируется и после этого происходит слияние (merge) двух отсортированных массивов.
1) разделение массива
2) рекурсивное разделение
3) слияние
4) финальное слияние




## Оценка по сложности и по памяти
### Сложность: 
**O(n * log(n))**
  
### Затраты по памяти
- **O(n)** - Требуется дополнительный массив для процесса слияния.


# Пример визуализации алгоритма
## Исходный массив:
```
A = [8, 3, 5, 2]
```
## Шаг 1 — разделение массива
Разделить массив на две равные части.
```
[8, 3]   [5, 2]
```
## Шаг 2 — рекурсивное разделение
Продолжать деление, пока размер подмассива не станет равен 1.
```
[8, 3] → [8] [3]
[5, 2] → [5] [2]
```
## Шаг 3 — слияние
Объединить два отсортированных массива в один.
```
[8] [3] → [3, 8]
[5] [2] → [2, 5]
```
## Шаг 4 — финальное слияние
```
[3, 8]   [2, 5]
2 3 5 8
```
## Итог
```
[2, 3, 5, 8]
```



# Реализация в коде
## Python
```py
def merge(left, right):
    result = []
    i = 0
    j = 0

    while i < len(left) and j < len(right):
        if left[i] < right[j]:
            result.append(left[i])
            i += 1
        else:
            result.append(right[j])
            j += 1

    result.extend(left[i:])
    result.extend(right[j:])

    return result


def merge_sort(arr):
    if len(arr) <= 1:
        return arr

    mid = len(arr) // 2

    left = merge_sort(arr[:mid])
    right = merge_sort(arr[mid:])

    return merge(left, right)


data = [8, 3, 5, 2]
print(merge_sort(data))
```

## C#
```cs
using System;

class Program
{
    static void MergeSort(int[] arr, int left, int right)
    {
        if (left >= right)
            return;

        int mid = (left + right) / 2;

        MergeSort(arr, left, mid);
        MergeSort(arr, mid + 1, right);

        Merge(arr, left, mid, right);
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;
        int j = mid + 1;
        int k = 0;

        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j])
                temp[k++] = arr[i++];
            else
                temp[k++] = arr[j++];
        }

        while (i <= mid)
            temp[k++] = arr[i++];

        while (j <= right)
            temp[k++] = arr[j++];

        for (int t = 0; t < temp.Length; t++)
            arr[left + t] = temp[t];
    }

    static void Main()
    {
        int[] arr = { 8, 3, 5, 2 };

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine(string.Join(", ", arr));
    }
}
```