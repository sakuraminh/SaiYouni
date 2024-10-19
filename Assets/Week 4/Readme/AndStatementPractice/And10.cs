using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class And10 : TMPInputHandler<int>
{
    //### Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí

    //Viết chương trình kiểm tra xem một người có được nhận vé miễn phí không nếu họ** trên 60 tuổi**, **đang là thành viên VIP**, và** đã mua vé ít nhất 3 lần trong năm**.

    protected override void Exercise()
    {
        if (valuesOutput[0] > 60 && valuesOutput[1] > 2 && CanvasCtrl.Instance.ToggleList[0].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "được nhận vé miễn phí";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không được nhận vé miễn phí";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 2;
        this.indexMaxToggleList = 1;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 10: Điều Kiện Nhận Vé Miễn Phí\r\nViết chương trình kiểm tra xem một người có được nhận vé miễn phí không nếu họ **trên 60 tuổi**, **đang là thành viên VIP**, và **đã mua vé ít nhất 3 lần trong năm**.\r\n";
        CanvasCtrl.Instance.PlaceholderText[0].text = "tuổi";
        CanvasCtrl.Instance.PlaceholderText[1].text = "số lần mua trong năm";
        CanvasCtrl.Instance.ToggleListText[0].text = "là thành viên VIP?";

    }
    protected override void CheckConditions()
    {
        if (valuesOutput.Count == 0) return;

        if (valuesOutput[1] < 0)
        {
            this.PrintInvalidData();
            this.ClearList();
            return;
        }

        if (valuesOutput[0] < 0 && valuesOutput[0] > 101)
        {
            this.PrintInvalidData();
            this.ClearList();
            return;
        }

        this.Exercise();

        foreach (TMP_InputField inputField in CanvasCtrl.Instance.InputFieldList)
        {
            inputField.text = null;
        }

        this.ClearList();
    }
}
