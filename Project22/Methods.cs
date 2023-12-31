﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Project22
{
    public static class Methods
    {
        /// <summary>
        /// Метод конвертации строки, который принимает в себя переменную
        /// строкового типа и возвращает переменную типа double.
        /// В методе создается массив типа char и с помощью
        /// метода SplitText происходит разделение введенной строки.
        /// Далее происходит инициализация ралзичных переменных. При
        /// условии, что первый элемент массива равен 45 (т.е. минус),
        /// то результирующий коэффициент задаётся = -1 (т.е. результат
        /// будет отрицательным). Стартовая итерация, при этом, будет равна
        /// 1 (т.е. начало цикла будет с элемента 1, а не с 0) и каунтер
        /// цикла будет установлен в значение 1. При условии, что первый 
        /// элемент массива равен 43 (т.е. плюс), то стартовая итерация 
        /// будет равна 1 (т.е. начало цикла будет с элемента 1, а не с 0) 
        /// и каунтер цикла будет установлен в значение 1. При этом
        /// результирующий коэффициент останется неизменным (т.е. результат
        /// будет положительным).
        /// Далее происходит запуск цикла for с перебором полученного
        /// массива char. Первым условием цикла является проверка числа
        /// number на корректность диапазона для типа double. Далее
        /// происходит проверка на совпадение элемента char десятичному
        /// числу от 0 до 9. При совпадении происходит математическая
        /// операция, при которой в каждой последующей итерации полученное
        /// число будет умножаться на 10 и прибавляться следующее число
        /// в коллекции. Также есть условие, что если элемент char равен
        /// пустому символу (пробелу), то произойдет переход цикла на
        /// следующую итерацию с увеличением счётчика. Если элемент char
        /// равен символу "," или ".", то произойдет завершение цикла
        /// (это будет говорить о том, что необходимо перейти к дробной
        /// части числа). Если элементом char будет являться любой другой
        /// символ, то число будет считаться некорректным и произойдет
        /// завершение цикла, с присвоением счётчика = -1 и выводом
        /// на экран сообщения об ошибке.
        /// Далее происходит проверка, что размер массива больше каунтера 
        /// первого цикла и что каунтер имеет значение больше 0 (т.е. не 
        /// было ошибок в первом цикле) и инициализация нового каунтера 
        /// для следующего цикла. Происходит запуск цикла для дробной части,
        /// в котором происходит дальнейший перебор коллекции с итерации, 
        /// которая принимает значение первого каунтера +1. В цикле 
        /// происходит проверка совпадения элемента массива char 
        /// десятичному с значением от 0 до 9 и при совпадении рассчитывается
        /// число, которое прибавляется к ранее полученному числу.
        /// При этом в каждой последующей итерации происходит умножение на
        /// коэффициент 0.1, а также происходит подсчёт количества итераций.
        /// Если элемент массива char равен пустому (пробелу), то происходит
        /// переход на следующую итерацию с увеличением каунтера на +1.
        /// Если элемент массива char равен любому другому элементу, то
        /// происходит завершение цикла и вывод сообщения о неверном формате.
        /// По окончанию происходит проверка, что count не равен -1. И 
        /// если число итераций в дробном цикле меньше 15, то происходит
        /// округление полученного числа до необходимого числа элементов (до
        /// числа равного количеству итераций в дробном цикле). В противном 
        /// случае результат не округляется. Для подсчёте результата 
        /// используется ранее полученный результирующий коэффициент 
        /// (определяющий положительное число или отрицательное) и 
        /// полученное ранее число.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double ConvertMethod(this string str)
        {
            char[] wordsOutput = SplitText(str);
            int i = 0;
            double number = 0;
            int count = 0;
            double resultCoefficient = 1;
            int startIteration = 0;

            if (wordsOutput[0] == 45)
            {
                resultCoefficient *= -1;
                startIteration = 1;
                count += 1;
            }
            else if(wordsOutput[0] == 43)
            {
                startIteration = 1;
                count += 1;
            }

            #region Цикл целой части

            for (int k = startIteration; k < wordsOutput.Length; k++)
            {
                if (number < 1.7E+307 && number > -1.7E+307)
                {
                    if (wordsOutput[k] >= 48 && wordsOutput[k] <= 57)
                    {
                        number = number * 10 + (wordsOutput[k] - 48);
                        count++;
                    }
                    else if (wordsOutput[k] == 32)
                    {
                        count++;
                    }
                    else if (wordsOutput[k] == 46 || wordsOutput[k] == 44)
                    {
                        break;
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка формата");
                        count = -1;
                        break;
                    }
                }
                else
                {
                    MessageBox.Show($"Выход за предел размеров хранимого значения типа double");
                    count = -1;
                    break;
                }    
            }
            #endregion
            int iterationCount = 0;

            #region Цикл дробной части

            if (wordsOutput.Length > count && count > 0)
            {
                double iterationValue = 1;
                
                for (int j = count + 1; j < wordsOutput.Length; j++)
                {
                    if (wordsOutput[j] >= 48 && wordsOutput[j] <= 57)
                    {
                        double fractionNumber = (0.1 * iterationValue * (wordsOutput[j] - 48));
                        number = number + fractionNumber;
                        iterationValue *= 0.1;
                        iterationCount++;
                    }
                    else if (wordsOutput[j] == 32)
                    {
                        count++;
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка формата");
                        count = -1;
                        break;
                    }
                }
            }
            double result = 0;
            #endregion

            if (count != -1)
            {
                if (iterationCount <= 14)
                {
                    result = Math.Round(number * resultCoefficient, iterationCount);
                }
                else
                {
                    result = number * resultCoefficient;
                }
            }
            return result;
        }

        /// <summary>
        /// Метод разделения введенной строки на отдельные элементы типа char,
        /// принимающий переменную строкового типа и возвращающий массив 
        /// элементов char.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static char[] SplitText(string text)
        {
            char[] words = text.ToCharArray();
            return words;
        }
    }
}
