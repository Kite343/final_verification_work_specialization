# Итоговая проверочная работа

## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Deпmark", "Kazan"] -> []

##  Решение

**1)** Создадим метод для заполнения массива. Использовать Split не будем, там как строки могут содержать пробелы или другие знаки припенания,
что делает не возможным разбивку.

Метод заполнения массива:

Метод запрашивает количество строк (n), которые намерен ввести пользователь. Далее создаётся строковый массив размера n.
Затем, с помощью цикла for массив заполняется строками.

Воизбежание введения не числового значения, а так же отрицательного числа, ввод количества строк выполнен через метод, проверяющий введенное значение.

**2)** Созаем метод решающий посталенную задачу:

В качестве аргумента метод принимает массив из которого необходимо выбрать строки не длиннее 3 символов.

Работа метода:

Создается переменная count - в неё будет вестись подсчет количества строк не превышаеющих 3 символов.
Это значение будет использовано для определения размера нового массива.

Создается переменная numbers строкового типа, в неё через запятую будут записаны индексы строк удовлетворяющие поставленной задаче.

С помощью цикла for проходимся по всем элементам массива, проверяем длину каждого элемента массива. При значениях длины <=3 - 
увеличиваем count на 1, в numbers добавляем значение индекса, переведенное в строковый тип.

Создаем новый массив размера count, который будет содержать строки из заданного массива длинной не более 3 символов.

*Далее, с помощью Split можно разбить строку numbers и получить массив со значениями индексов строк удовлетворяющих условиям задачи. 
Но в учебных целях выберем чуть более сложный путь.*

Создаём числовую переменную j для перехода по индексам нового массива.

Создаём строковую переменную index - в неё будем из строки numbers переписывать значение индекса элемента из заданной строки,
удовлетворяющего условиям задачи.

С помощю foreach проходимся по элементам строки numbers. 
Каждый элемент записываем в переменную index до тех пор пока не встретим ",". 
Как только попадается ",":

+ в новый массив на место элемента j записыватся значение элемента из заданного массива с позиции index (index перевести в числовое занчение)
+ значение переменной index приравнивается к пустой строке
+ значение j увеличивается на 1, чтобы записать следующий элемент на следующую позицию в новом массиве.

После прохода всех этих действий метод возвращает новый массив, отвечающий условиям задачи.

**3)** 
Задаем переменную строковый массив и заполняем через метод заполнения массива данными пользователя.

Выводим на печать заданный пользователем массив. 
В случе если в массиве 0 элементов выводим на печать "пустой массив"

Создаем переменную (строковый массив), которая будет содержать строки длинной не более 3 символов, 
заполняем её с помощью метода решающего поставленную задачу.

Выводим на печать полученный массив. Если в массиве нет элементов, то на печать выводится "строк длинной 3 символа и менее - нет".

