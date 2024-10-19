using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And02 : TMPInputHandler<int>
{
    //### Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí

    //Viết chương trình kiểm tra xem một người có được vào công viên giải trí không nếu họ **có vé**, **đã đăng ký trước** và** không có tiền sử bệnh tim**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true && CanvasCtrl.Instance.ToggleList[1].isOn == true && CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "Được vào công viên giải trí";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không được vào công viên giải trí";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 2: Kiểm Tra Điều Kiện Vào Công Viên Giải Trí\r\nViết chương trình kiểm tra xem một người có được vào công viên giải trí không nếu họ **có vé**, **đã đăng ký trước** và** không có tiền sử bệnh tim**.";
        CanvasCtrl.Instance.ToggleListText[0].text = "Có vé?";
        CanvasCtrl.Instance.ToggleListText[1].text = "Đã đăng ký trước?";
        CanvasCtrl.Instance.ToggleListText[2].text = "Không có tiền sử bệnh tim?";
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
