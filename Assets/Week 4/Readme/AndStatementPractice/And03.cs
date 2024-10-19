using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And03 : TMPInputHandler<float>
{
    //### Bài Tập 3: Điều Kiện Đạt Học Bổng

    //Viết chương trình kiểm tra xem học sinh có đạt học bổng không nếu **điểm trung bình >= 9.0**, **điểm hoạt động ngoại khóa >= 8.0**, và** không vi phạm kỷ luật trong năm học**.


    protected override void Exercise()
    {
        if (this.valuesOutput[0] >= 9.0f && this.valuesOutput[1] >= 8.0f && CanvasCtrl.Instance.ToggleList[0].isOn == false)
        {
            CanvasCtrl.Instance.Result.text = "Đạt Học Bổng";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không đạt Học Bổng";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 2;
        this.indexMaxToggleList = 1;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 3: Điều Kiện Đạt Học Bổng\r\nViết chương trình kiểm tra xem học sinh có đạt học bổng không nếu **điểm trung bình >= 9.0**, **điểm hoạt động ngoại khóa >= 8.0**, và** không vi phạm kỷ luật trong năm học**.";
        CanvasCtrl.Instance.PlaceholderText[0].text = "Điểm trung bình";
        CanvasCtrl.Instance.PlaceholderText[1].text = "Điểm hoạt động ngoại khóa";
        CanvasCtrl.Instance.ToggleListText[0].text = "Có vi phạm kỷ luật trong năm học?";
    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        if (valuesOutput[0] > 10 || valuesOutput[0] < 0 || valuesOutput[1] > 10 || valuesOutput[1] < 0)
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
