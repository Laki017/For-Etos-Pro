using System;

namespace GetParityNum_lib
{
    /// <summary>
    /// Сделал методы расширения для целых чисел для определения четности числа.
    /// </summary>
    public static class ParytiNum
    {
        /// <summary>
        /// Все нечетные числа имеют первый бит равный 1. Метод возвращает true если результат логического & будет равен 0.
        /// Данный метод использует меньше инструкций и выполняется бестрей, ниже в блоке комметариев,
        /// методы представлены в ассемблерных инстрекциях.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsParytiNum(this int num) => (num & 1) == 0;
        /// <summary>
        /// Данный метод извлекает остаток от деления, и возвращает true если остаток от деления равен 0.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsParytiNumber(this int num) => num % 2 > 0 ? false : true;
    }
}

/*
	i & 1;
mov     eax,dword ptr [rbp+30h]  
and     eax,1  
mov     dword ptr [rbp+34h],eax 

    i % 2;
mov     eax,dword ptr [rbp+30h]  
mov     edx,dword ptr [rbp+30h]  
shr     edx,1Fh  
add     edx,dword ptr [rbp+30h]  
and     edx,0FFFFFFFEh  
sub     eax,edx  
mov     dword ptr [rbp+34h],eax 
*/

