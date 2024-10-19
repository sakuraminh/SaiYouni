using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And06 : TMPInputHandler<int>
{
    //### Bài Tập 6: Xét Tuyển Nhân Viên

    //Viết chương trình kiểm tra xem một ứng viên có được tuyển dụng không nếu họ **đã tốt nghiệp đại học**, **có ít nhất 2 năm kinh nghiệm** và **đã vượt qua bài kiểm tra năng lực**.


    protected override void Exercise()
    {
        if (this.valuesOutput[0] > 1 && CanvasCtrl.Instance.ToggleList[0].isOn == true && CanvasCtrl.Instance.ToggleList[1].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "được tuyển dụng";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không được tuyển dụng";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 1;
        this.indexMaxToggleList = 2;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 6: Xét Tuyển Nhân Viên\r\nViết chương trình kiểm tra xem một ứng viên có được tuyển dụng không nếu họ **đã tốt nghiệp đại học**, **có ít nhất 2 năm kinh nghiệm** và **đã vượt qua bài kiểm tra năng lực**.\r\n";
        CanvasCtrl.Instance.PlaceholderText[0].text = "số năm kinh nghiệm";
        CanvasCtrl.Instance.ToggleListText[0].text = "đã tốt nghiệp đại học?";
        CanvasCtrl.Instance.ToggleListText[1].text = "đã vượt qua bài kiểm tra năng lực?";
    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        if (valuesOutput[0] < 0)
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
