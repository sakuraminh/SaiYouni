using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR04 : TMPInputHandler<int>
{
    //### Bài Tập 4: Điều Kiện Nhận Học Bổng

    //Viết chương trình kiểm tra xem học sinh có thể nhận học bổng không nếu họ **có thành tích học tập xuất sắc**, **hoạt động ngoại khóa tốt**, hoặc** gia đình khó khăn**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "được nhận học bổng";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không được nhận học bổng";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 4: Điều Kiện Nhận Học Bổng\r\nViết chương trình kiểm tra xem học sinh có thể nhận học bổng không nếu họ **có thành tích học tập xuất sắc**, **hoạt động ngoại khóa tốt**, hoặc **gia đình khó khăn**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có thành tích học tập xuất sắc";
        CanvasCtrl.Instance.ToggleListText[1].text = "hoạt động ngoại khóa tốt";
        CanvasCtrl.Instance.ToggleListText[2].text = "gia đình khó khăn";
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
