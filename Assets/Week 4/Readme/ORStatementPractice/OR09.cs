using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR09 : TMPInputHandler<int>
{
    //### Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí

    //Viết chương trình kiểm tra xem một người có thể tải ứng dụng miễn phí không nếu họ **có mã khuyến mãi**, **là thành viên VIP**, hoặc **ứng dụng đang trong thời gian miễn phí**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể tải App miễn phí";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể tải App miễn phí";
    }
    protected override void OnEnable()
    {
        indexMaxInputFieldList = 0;
        indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 9: Điều Kiện Tải App Miễn Phí\r\nViết chương trình kiểm tra xem một người có thể tải App miễn phí không nếu họ **có mã khuyến mãi**, **là thành viên VIP**, hoặc **App đang trong thời gian miễn phí**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có mã khuyến mãi";
        CanvasCtrl.Instance.ToggleListText[1].text = "là thành viên VIP";
        CanvasCtrl.Instance.ToggleListText[2].text = "App đang trong thời gian miễn phí";
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
