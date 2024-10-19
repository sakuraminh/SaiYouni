using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And05 : TMPInputHandler<float>
{
    //### Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại

    //Viết chương trình kiểm tra xem học sinh có được phép thi lại không nếu họ **điểm tổng kết< 5.0**, **không quá 2 môn thi trượt**, và**điểm chuyên cần> 75%**.

    protected override void Exercise()
    {
        if (this.valuesOutput[0] < 5.0f && this.valuesOutput[1] < 3.0f && this.valuesOutput[2] > 75)
        {
            CanvasCtrl.Instance.Result.text = "được phép thi lại";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không được phép thi lại";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 3;
        this.indexMaxToggleList = 0;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 5: Kiểm Tra Điều Kiện Thi Lại\r\nViết chương trình kiểm tra xem học sinh có được phép thi lại không nếu họ **điểm tổng kết< 5.0**, **không quá 2 môn thi trượt**, và**điểm chuyên cần> 75%**.";
        CanvasCtrl.Instance.PlaceholderText[0].text = "điểm tổng kết";
        CanvasCtrl.Instance.PlaceholderText[1].text = "Số môn thi trượt";
        CanvasCtrl.Instance.PlaceholderText[2].text = "điểm chuyên cần";
    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        //Is int 
        if (valuesOutput[1] % 1 != 0)
        {
            Debug.Log("Invalid data");
        }


        if (valuesOutput[0] > 10 || valuesOutput[0] < 0 || valuesOutput[2] > 100 || valuesOutput[2] < 0)
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