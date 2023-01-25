using System;
using static System.Console;

Clear();

string[] Method1(string[] input, int x) {
    string[] output = new string[Method2(input,x)];

    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= x) {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}
int Method2(string[] input, int x) {
    int count = 0;

    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= x) {
            count++;
        }
    }

    return count;
}
string[] Array() {
    Write("Введите значения массива через пробел: ");
    return ReadLine().Split(" ");
}
string[] array = Array();
string[] result = Method1(array, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");


