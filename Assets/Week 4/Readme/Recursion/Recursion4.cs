using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Recursion4 : Recursion
{
    /*### Bài Tập 4: Đếm Ngược

    **Yêu cầu**:
    Viết một hàm đệ quy để in ra các số từ `n` đếm ngược về 1.

    **Hướng dẫn**:

    - Nếu `n = 0`, dừng việc in.
    - Gọi lại hàm với giá trị `n-1` sau khi in ra giá trị hiện tại của `n`.*/

    [SerializeField] protected int number = default;
    protected override void Exercise()
    {
        if (this.number == 10)
        {
            Debug.Log(this.number);
            this.number--;
            this.Exercise();
            return;
        }
        Debug.Log(this.number);
        this.number--;

        if (this.number < 1) return;

        this.Exercise();
    }
}
