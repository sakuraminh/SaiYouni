using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And09 : TMPInputHandler<int>
{
    //### Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức

    //Viết chương trình kiểm tra xem nhân viên có đủ điều kiện thăng chức không nếu họ** đã làm việc trên 5 năm**, **đạt chỉ tiêu công việc hàng năm**, và** không vi phạm kỷ luật**.

    protected override void Exercise()
    {
        if (valuesOutput[0] > 5 && CanvasCtrl.Instance.ToggleList[0].isOn == true && CanvasCtrl.Instance.ToggleList[1].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "đủ điều kiện thăng chức";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không đủ điều kiện thăng chức";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 1;
        this.indexMaxToggleList = 2;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 9: Kiểm Tra Điều Kiện Thăng Chức\r\nViết chương trình kiểm tra xem nhân viên có đủ điều kiện thăng chức không nếu họ **đã làm việc trên 5 năm**, **đạt chỉ tiêu công việc hàng năm**, và **không vi phạm kỷ luật**.\r\n";
        CanvasCtrl.Instance.PlaceholderText[0].text = "số năm làm việc";
        CanvasCtrl.Instance.ToggleListText[0].text = "đạt chỉ tiêu công việc hàng năm?";
        CanvasCtrl.Instance.ToggleListText[1].text = "không vi phạm kỷ luật?";
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
