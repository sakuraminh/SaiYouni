using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR06 : TMPInputHandler<int>
{
    //### Bài Tập 6: Điều Kiện Lái Xe

    //Viết chương trình kiểm tra xem một người có thể lái xe không nếu họ** có bằng lái xe**, **đã đăng ký xe hợp lệ**, hoặc **có bảo hiểm xe**.


    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể lái xe";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể lái xe";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 6: Điều Kiện Lái Xe\r\nViết chương trình kiểm tra xem một người có thể lái xe không nếu họ **có bằng lái xe**, **đã đăng ký xe hợp lệ**, hoặc **có bảo hiểm xe**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có bằng lái xe";
        CanvasCtrl.Instance.ToggleListText[1].text = "đã đăng ký xe hợp lệ";
        CanvasCtrl.Instance.ToggleListText[2].text = "có bảo hiểm xe";
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
