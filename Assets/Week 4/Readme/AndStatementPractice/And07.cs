using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And07 : TMPInputHandler<int>
{
    //### Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng

    //Viết chương trình kiểm tra xem người dùng có thể mua một sản phẩm không nếu họ** có đủ tiền**, **có hàng trong kho**, và **đủ điều kiện tham gia chương trình khuyến mãi**.


    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true && CanvasCtrl.Instance.ToggleList[1].isOn == true && CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể mua sản phẩm";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể mua sản phẩm";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 7: Kiểm Tra Điều Kiện Mua Hàng\r\n Viết chương trình kiểm tra xem người dùng có thể mua một sản phẩm không nếu họ **có đủ tiền**, **có hàng trong kho**, và **đủ điều kiện tham gia chương trình khuyến mãi**.\r\n";
        CanvasCtrl.Instance.ToggleListText[0].text = "có đủ tiền?";
        CanvasCtrl.Instance.ToggleListText[1].text = "có hàng trong kho?";
        CanvasCtrl.Instance.ToggleListText[2].text = "đủ điều kiện tham gia chương trình khuyến mãi?";
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
