using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR02 : TMPInputHandler<int>
{
    //### Bài Tập 2: Điều Kiện Trúng Thưởng

    //Viết chương trình kiểm tra xem một người có trúng thưởng hay không nếu **số vé trúng thưởng** của họ đúng với bất kỳ một trong ba giải thưởng nào: **giải nhất**, **giải nhì**, hoặc **giải ba**.


    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "trúng thưởng";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không trúng thưởng";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 2: Điều Kiện Trúng Thưởng\r\nViết chương trình kiểm tra xem một người có trúng thưởng hay không nếu **số vé trúng thưởng** của họ đúng với bất kỳ một trong ba giải thưởng nào: **giải nhất**, **giải nhì**, hoặc **giải ba**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "giải nhất";
        CanvasCtrl.Instance.ToggleListText[1].text = "giải nhì";
        CanvasCtrl.Instance.ToggleListText[2].text = "giải ba";
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
