﻿# Control-Test
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Решение: Массив задается на старте алгоритма. В начале программы задаем максимальную длину строки (3), чтоб при дальнейшем изменении условия не потребовалось менять весь код. 

Описываем три метода:
1. Метод CheckLength - возвращает правду, если переданная ему строка меньше, либо равна максимальной длине строки
2. Метод GetLengthNewArray - возвращает количество элементов массива, удовлетворяющих условию задачи
3. Метод FillNewArray - заполняет новый массив

Сама программа задает стартовый массив. Затем создает новую пустую строку. Ее длина определяется вторым методом. Затем с помощью третьего метода заполняем новый массив. И выводим его на экран. 
