using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Recursion1 : Recursion
{
    //    ### Bài Tập 1: Tính Giai Thừa Của Một Số

    //**Yêu cầu**:
    //Viết một hàm đệ quy để tính** giai thừa** của một số nguyên dương `n`. Giai thừa của `n` được tính bằng công thức:
    //n! = n _(n - 1) _(n - 2) _..._ 1

    //**Hướng dẫn**:

    //- Nếu `n = 0`, trả về 1 (giai thừa của 0 bằng 1).
    //- Gọi lại hàm với giá trị `n-1` và nhân kết quả với `n`.

    [SerializeField] protected int number = default;
    protected int i = 1;
    protected BigInteger factorialNumber = 1;
    protected override void Exercise()
    {
        this.factorialNumber *= this.i;
        this.i++;

        if (this.i > this.number)
        {
            Debug.Log(this.factorialNumber);
            return;
        }
        this.Exercise();
    }
}
