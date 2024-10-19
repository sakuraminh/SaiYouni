using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recursion5 : Recursion
{
    /*### Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)

    **Yêu cầu**:
    Viết một hàm đệ quy để tìm **Ước Chung Lớn Nhất (UCLN)** của hai số nguyên `a` và `b` bằng thuật toán Euclid:
    UCLN(a, b) = UCLN(b, a % b)

    **Hướng dẫn**:

    - Nếu `b = 0`, trả về `a`.
    - Gọi lại hàm với giá trị `b` và `a % b`.*/

    [SerializeField] protected int a = default;
    [SerializeField] protected int b = default;

    protected override void Exercise()
    {
        Debug.Log(this.GCD(this.b, this.a % this.b));
    }
    protected virtual int GCD(int a, int b)
    {
        if (b == 0) return a;

        return GCD(b, a % b);
    }
}
