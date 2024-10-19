using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR05 : TMPInputHandler<int>
{
    //### Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện

    //Viết chương trình kiểm tra xem một người có thể đăng ký sự kiện không nếu họ** có email hợp lệ**, **có số điện thoại xác thực**, hoặc **đã đăng ký qua trang web**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể đăng ký sự kiện";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể đăng ký sự kiện";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện\r\nViết chương trình kiểm tra xem một người có thể đăng ký sự kiện không nếu họ **có email hợp lệ**, **có số điện thoại xác thực**, hoặc **đã đăng ký qua trang web**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có email hợp lệ";
        CanvasCtrl.Instance.ToggleListText[1].text = "có số điện thoại xác thực";
        CanvasCtrl.Instance.ToggleListText[2].text = "đã đăng ký qua trang web";
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
