using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR03 : TMPInputHandler<int>
{
    //### Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền

    //Viết chương trình kiểm tra xem một người có đủ điều kiện vay tiền không nếu họ** có thu nhập ổn định**, **có tài sản thế chấp**, hoặc** có người bảo lãnh**.



    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "đủ điều kiện vay tiền";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không đủ điều kiện vay tiền";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền\r\nViết chương trình kiểm tra xem một người có đủ điều kiện vay tiền không nếu họ **có thu nhập ổn định**, **có tài sản thế chấp**, hoặc **có người bảo lãnh**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có thu nhập ổn định";
        CanvasCtrl.Instance.ToggleListText[1].text = "có tài sản thế chấp";
        CanvasCtrl.Instance.ToggleListText[2].text = "có người bảo lãnh";
    }
    protected override void CheckConditions()
    {
        this.Exercise();

        foreach (TMP_InputField inputField in CanvasCtrl.Instance.InputFieldList)
        {
            inputField.text = null;
        }

        this.ClearList();
    }
}
