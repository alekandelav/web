﻿using Internal;
using System;
using Microsoft.VisualBasic.CompilerServices;
// Напишите программу, которая
// 1. На выход принимает число и
// 2. Выдает его квадрат (число умножение на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.WriteLine ("Введите цело число");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");
