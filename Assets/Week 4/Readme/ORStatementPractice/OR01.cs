using TMPro;

public class OR01 : TMPInputHandler<int>
{
    //### Bài Tập 1: Kiểm Tra Vé Vào Cửa

    //Viết chương trình kiểm tra xem một người có thể vào một sự kiện không nếu họ** có vé hợp lệ**, **là thành viên VIP**, hoặc **được người tổ chức mời**.

    protected override void Exercise()
    {
        if (CanvasCtrl.Instance.ToggleList[0].isOn == true || CanvasCtrl.Instance.ToggleList[1].isOn == true || CanvasCtrl.Instance.ToggleList[2].isOn == true)
        {
            CanvasCtrl.Instance.Result.text = "có thể vào sự kiện";
            return;
        }
        CanvasCtrl.Instance.Result.text = "Không thể vào sự kiện";
    }
    protected override void OnEnable()
    {
        this.indexMaxInputFieldList = 0;
        this.indexMaxToggleList = 3;
        base.OnEnable();
    }

    protected override void PrintQuestionAndText()
    {
        CanvasCtrl.Instance.Question.text = "### Bài Tập 1: Kiểm Tra Vé Vào Cửa\r\nViết chương trình kiểm tra xem một người có thể vào một sự kiện không nếu họ **có vé hợp lệ**, **là thành viên VIP**, hoặc **được người tổ chức mời**.\r\n";

        CanvasCtrl.Instance.ToggleListText[0].text = "có vé hợp lệ?";
        CanvasCtrl.Instance.ToggleListText[1].text = "là thành viên VIP?";
        CanvasCtrl.Instance.ToggleListText[2].text = "người tổ chức mời?";
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
