using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR10 : TMPInputHandler<int>
{
    //### Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt

    //Viết chương trình kiểm tra xem một khách hàng có thể sử dụng dịch vụ đặc biệt không nếu họ **đã chi tiêu trên mức yêu cầu**, **là khách hàng thân thiết**, hoặc** đang có chương trình khuyến mãi cho dịch vụ đó**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể sử dụng dịch vụ đặc biệt";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể sử dụng dịch vụ đặc biệt";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt\r\nViết chương trình kiểm tra xem một khách hàng có thể sử dụng dịch vụ đặc biệt không nếu họ **đã chi tiêu trên mức yêu cầu**, **là khách hàng thân thiết**, hoặc **đang có chương trình khuyến mãi cho dịch vụ đó**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "là khách hàng thân thiết";
        CanvasCtrl.Instance.ToggleListText[1].text = "đang có chương trình khuyến mãi cho dịch vụ đó";
        CanvasCtrl.Instance.ToggleListText[2].text = "đã chi tiêu trên mức yêu cầu";
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
