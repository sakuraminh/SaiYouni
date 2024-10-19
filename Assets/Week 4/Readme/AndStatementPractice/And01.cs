using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And01 : TMPInputHandler<int>
{
    //Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm

    //Viết chương trình kiểm tra xem một người có đủ điều kiện lái xe không, nếu họ **trên 18 tuổi**, **có giấy phép lái xe**, và** có kinh nghiệm lái xe trên 1 năm**.
    protected override void Exercise()
    {
        if (valuesOutput[0] > 18 && valuesOutput[1] > 1 && CanvasCtrl.Instance.ToggleList[0].isOn != false)
        {
            CanvasCtrl.Instance.Result.text = "Đủ điều kiện lái xe";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không đủ điều kiện lái xe";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 2;
        this.indexMaxToggleList = 1;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "Bài Tập 1: Kiểm Tra Tuổi, Giấy Phép, Và Kinh Nghiệm\r\nViết chương trình kiểm tra xem một người có đủ điều kiện lái xe không, nếu họ **trên 18 tuổi**, **có giấy phép lái xe**, và** có kinh nghiệm lái xe trên 1 năm**.";
        CanvasCtrl.Instance.PlaceholderText[0].text = "Tuổi";
        CanvasCtrl.Instance.PlaceholderText[1].text = "Số năm kinh nghiệm";
        CanvasCtrl.Instance.ToggleListText[0].text = "Có giấy phép lái xe hay không?";
    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        if (valuesOutput[0] > 100 || valuesOutput[0] < 1)
        {
            this.PrintInvalidData();
            this.ClearList();
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
