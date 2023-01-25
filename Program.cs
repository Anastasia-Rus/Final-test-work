using System;
using static System.Console;

Clear();

string[] Method1(string[] input, int x) {
    string[] output = new string[C(input,[x])];

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


