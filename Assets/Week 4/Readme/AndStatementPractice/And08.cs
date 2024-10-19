using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And08 : TMPInputHandler<float>
{
    //Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng

    //Viết chương trình kiểm tra xem người dùng có đủ điều kiện nhận phần thưởng không nếu họ **đã hoàn thành ít nhất 10 nhiệm vụ**, **điểm trung bình nhiệm vụ >= 8** và** đã đăng nhập vào hệ thống trong 7 ngày qua**.

    protected override void Exercise()
    {
        if (valuesOutput[0] > 9 && valuesOutput[1] > 7 && valuesOutput[2] > 6)
        {
            CanvasCtrl.Instance.Result.text = "đủ điều kiện nhận phần thưởng";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không đủ điều kiện nhận phần thưởng";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 3;
        this.indexMaxToggleList = 0;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "Bài Tập 8: Đủ Điều Kiện Nhận Phần Thưởng\r\nViết chương trình kiểm tra xem người dùng có đủ điều kiện nhận phần thưởng không nếu họ **đã hoàn thành ít nhất 10 nhiệm vụ**, **điểm trung bình nhiệm vụ >= 8** và **đã đăng nhập vào hệ thống trong 7 ngày qua**.\r\n";
        CanvasCtrl.Instance.PlaceholderText[0].text = "số nhiệm vụ đã hoàn thành";
        CanvasCtrl.Instance.PlaceholderText[1].text = "điểm trung bình nhiệm vụ";
        CanvasCtrl.Instance.PlaceholderText[2].text = "số ngày đăng nhập";
    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        //Is int 
        if (valuesOutput[0] % 1 != 0 || valuesOutput[2] % 1 != 0)
        {
            this.PrintInvalidData();
            return;
        }

        this.Exercise();

        foreach (TMP_InputField inputField in CanvasCtrl.Instance.InputFieldList)
        {
            inputField.text = null;
        }

        this.ClearList();
    }
}
