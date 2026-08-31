



- [Описание алгоритма по шагам](#описание-алгоритма-по-шагам)
  - [Оценка по сложности и по памяти](#оценка-по-сложности-и-по-памяти)
- [Пример визуализации алгоритма](#пример-визуализации-алгоритма)
- [Реализация в коде](#реализация-в-коде)
  - [Python](#python)
  - [C#](#c)
- [Литература](#литература)


# Описание алгоритма по шагам
Данный алгоритм сортирует коллекцию по следующему принципу:
1) Начать с первого элемента массива.
2) Сравнить текущий элемент со следующим.
3) Если текущий элемент больше следующего (для сортировки по возрастанию), поменять их местами.
4) Перейти к следующей паре элементов и повторить 3.
5) После одного полного прохода самый большой элемент окажется в конце массива.
6) Повторять проходы по массиву, каждый раз уменьшая область проверки на один элемент с конца.
7) Алгоритм завершает работу, когда:
   1) выполнено нужное количество проходов
   2) за один проход не произошло ни одного обмена.
   
## Оценка по сложности и по памяти
Сложность: **O(n^2)** <br>
Затраты по памяти: **O(1)** 

# Пример визуализации алгоритма
- https://www.toptal.com/developers/sorting-algorithms/bubble-sort



# Реализация в коде
## Python
```py
def BubbleSort(arr: list[float], reverse:bool = False) -> None:
    for i in range(0, len(arr)):
        f_sort_end = True
        for ii in range(1, len(arr) - i):
            # Случай если сортировка от меньшего к большему
            if((not reverse) and arr[ii - 1] > arr[ii]):
                f_sort_end = False
                arr[ii], arr[ii - 1] = arr[ii - 1], arr[ii]
            
            # Случай если сортировка от большего к меньшему
            elif(reverse and arr[ii - 1] < arr[ii]):
                f_sort_end = False
                arr[ii], arr[ii - 1] = arr[ii - 1], arr[ii]

        
        if(f_sort_end): return


arr = [3, 5, 2, 6, 9]
BubbleSort(arr) 
print(arr)

arr = [3, 5, 4, 8]
BubbleSort(arr) 
print(arr)



arr = [3, 5, 2, 6, 9]
BubbleSort(arr, True) 
print(arr)

arr = [3, 5, 4, 8]
BubbleSort(arr, True) 
print(arr)

```

## C#
```cs
void Print(List<int> col){
    Console.WriteLine($"[{string.Join(", ", col)}]");
}


void BubbleSort(List<int> arr, bool reverse = false){
    for(int i = 0; i < arr.Count; i += 1){
        bool f_sort_end = true;

        for(int ii = 1; ii < arr.Count - i; ii += 1){
            // Случай если сортировка от меньшего к большему
            if((!reverse) && arr[ii - 1] > arr[ii]){
                f_sort_end = false;
                (arr[ii], arr[ii - 1]) = (arr[ii - 1], arr[ii]); 
            }
            
            // Случай если сортировка от большего к меньшему
            else if(reverse && (arr[ii - 1] < arr[ii])){
                f_sort_end = false;
                (arr[ii], arr[ii - 1]) = (arr[ii - 1], arr[ii]);
            }
        }
        if(f_sort_end){ return; }
    }
}


List<int> arr = [3, 5, 2, 6, 9];
BubbleSort(arr); 
Print(arr);

arr = [3, 5, 4, 8];
BubbleSort(arr); 
Print(arr);


arr = [3, 5, 2, 6, 9];
BubbleSort(arr, true); 
Print(arr);

arr = [3, 5, 4, 8];
BubbleSort(arr, true); 
Print(arr);
```

# Литература
- https://younglinux.info/algorithm/bubble
