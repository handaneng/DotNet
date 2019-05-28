﻿// LINQ Distinct(): 컬렉션(시퀀스)에서 중복 제거
using System.Linq;

class LINQ_Distinct
{
    static void Main()
    {
        var data = Enumerable.Repeat(3, 5); // 3을 5개 저장
        var result = data.Distinct(); // Distinct()로 중복 제거
        foreach (var num in result)
        {
            System.Console.Write("{0}\t", num); // 중복이 제거되어 3만 출력
        }
        System.Console.WriteLine();

        int[] arr = { 2, 2, 3, 3, 3 }; // 2와 3을 중복해서 배열에 저장
        var r = arr.Distinct();
        foreach (var num in r)
        {
            System.Console.Write($"{num}\t"); // 2와 3만이 중복이 제거되어 출력
        }
        System.Console.WriteLine();
    }
}
