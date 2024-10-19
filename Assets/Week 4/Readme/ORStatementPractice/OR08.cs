using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OR08 : TMPInputHandler<int>
{
    //### Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học

    //Viết chương trình kiểm tra xem một học sinh có thể tham gia khóa học đặc biệt không nếu họ **có thư giới thiệu từ giáo viên**, **đã hoàn thành bài kiểm tra đầu vào**, hoặc **có kinh nghiệm liên quan**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể tham gia khóa học đặc biệt";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể tham gia khóa học đặc biệt";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học\r\nViết chương trình kiểm tra xem một học sinh có thể tham gia khóa học đặc biệt không nếu họ **có thư giới thiệu từ giáo viên**, **đã hoàn thành bài kiểm tra đầu vào**, hoặc **có kinh nghiệm liên quan**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có thư giới thiệu từ giáo viên";
        CanvasCtrl.Instance.ToggleListText[1].text = "đã hoàn thành bài kiểm tra đầu vào";
        CanvasCtrl.Instance.ToggleListText[2].text = "có kinh nghiệm liên quan";
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
