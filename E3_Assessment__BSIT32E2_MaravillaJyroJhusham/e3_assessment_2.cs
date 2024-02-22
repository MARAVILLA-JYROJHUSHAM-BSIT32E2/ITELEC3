using System;

namespace Assessment{

    class Array{

        static void Main(string[] args){

            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++){
                num[i] = (i+1) * (i+1);
            }

            int max = num[0];

            for (int i = 1; i < num.Length; i++){
                if (num[i] > max){
                    max = num[i];
                }
            }

            Console.WriteLine("Largest Element in the Array: " + max);
        }
    }
}
