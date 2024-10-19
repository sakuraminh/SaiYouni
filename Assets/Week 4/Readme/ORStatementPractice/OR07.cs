using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class OR07 : TMPInputHandler<int>
{
    //### Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu

    //Viết chương trình kiểm tra xem một người có thể truy cập tài liệu mật không nếu họ **là quản trị viên**, **được cấp quyền truy cập từ quản lý**, hoặc **có mã xác thực**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể truy cập tài liệu mật";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể truy cập tài liệu mật";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu\r\nViết chương trình kiểm tra xem một người có thể truy cập tài liệu mật không nếu họ **là quản trị viên**, **được cấp quyền truy cập từ quản lý**, hoặc **có mã xác thực**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "là quản trị viên";
        CanvasCtrl.Instance.ToggleListText[1].text = "được cấp quyền truy cập từ quản lý";
        CanvasCtrl.Instance.ToggleListText[2].text = "có mã xác thực";
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
