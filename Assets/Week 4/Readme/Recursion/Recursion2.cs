using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Recursion2 : Recursion
{
    //    ### Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N

    //**Yêu cầu**:
    //Viết một hàm đệ quy để tính** tổng các số** từ 1 đến `n`.

    //**Hướng dẫn**:

    //- Nếu `n = 1`, trả về 1.
    //- Gọi lại hàm với giá trị `n-1` và cộng kết quả với `n`.
    [SerializeField] protected int number = default;
    protected int i = default;
    protected BigInteger factorialNumber = default;
    protected override void Exercise()
    {
        this.factorialNumber += this.i;
        this.i++;

        if (this.i > this.number)
        {
            Debug.Log(this.factorialNumber);
            return;
        }
        this.Exercise();
    }
}
