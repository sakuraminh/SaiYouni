using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And04 : TMPInputHandler<float>
{
    //### Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ

    //Viết chương trình kiểm tra xem một đơn đăng ký sự kiện có hợp lệ không nếu người đăng ký **có email hợp lệ**, **đã xác nhận qua điện thoại**, và **đã thanh toán phí tham gia**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true && CanvasCtrl.Instance.ToggleList[1].isOn == true && CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "Đăng Ký Hợp Lệ";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Đăng Ký Không Hợp Lệ";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 4: Kiểm Tra Đăng Ký Hợp Lệ\r\nViết chương trình kiểm tra xem một đơn đăng ký sự kiện có hợp lệ không nếu người đăng ký **có email hợp lệ**, **đã xác nhận qua điện thoại**, và **đã thanh toán phí tham gia**..";
        CanvasCtrl.Instance.ToggleListText[0].text = "có email hợp lệ?";
        CanvasCtrl.Instance.ToggleListText[1].text = "đã xác nhận qua điện thoại?";
        CanvasCtrl.Instance.ToggleListText[2].text = "đã thanh toán phí tham gia?";
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
