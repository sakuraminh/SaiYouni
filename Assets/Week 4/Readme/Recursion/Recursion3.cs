using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Recursion3 : Recursion
{
    //    ### Bài Tập 3: Chuỗi Fibonacci

    //**Yêu cầu**:
    //Viết một hàm đệ quy để tính số Fibonacci thứ `n`. Chuỗi Fibonacci được định nghĩa như sau:
    //F(0) = 0, F(1) = 1, F(n) = F(n-1) + F(n-2)

    //**Hướng dẫn**:

    //- Nếu `n = 0`, trả về 0.
    //- Nếu `n = 1`, trả về 1.
    //- Gọi lại hàm với giá trị `n-1` và `n-2` và cộng kết quả của hai hàm này.

    [SerializeField] protected int number = default;
    protected int count = 1;
    protected BigInteger fibonacciCurrent = default;
    protected BigInteger fibonacciPrevious = default;
    protected override void Exercise()
    {
        BigInteger nextFibonacci;
        if (count < 3)
        {
            nextFibonacci = this.count - 1;
            this.fibonacciPrevious = this.fibonacciCurrent;
            this.fibonacciCurrent = nextFibonacci;
            this.count++;
            this.Exercise();
            return;
        }
        nextFibonacci = this.fibonacciCurrent + this.fibonacciPrevious;
        this.fibonacciPrevious = this.fibonacciCurrent;
        this.fibonacciCurrent = nextFibonacci;
        this.count++;

        if (count > this.number)
        {
            Debug.Log(nextFibonacci);
            return;
        }
        this.Exercise();
    }
}
