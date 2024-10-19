using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasCtrl : MSingleton<CanvasCtrl>
{
    public int indexInputFieldList = default;
    public int indexToggleList = default;

    public int indexInputFieldList1 = default;
    public int indexToggleList1 = default;

    [SerializeField] protected Button bton;
    public Button Bton => bton;

    [SerializeField] protected TMP_InputField question;
    public TMP_InputField Question => question;

    [SerializeField] protected TMP_InputField result;
    public TMP_InputField Result => result;

    [SerializeField] protected List<TMP_InputField> inputFieldList = new();
    public List<TMP_InputField> InputFieldList => inputFieldList;

    [SerializeField] protected List<TextMeshProUGUI> placeholderText = new();
    public List<TextMeshProUGUI> PlaceholderText => placeholderText;

    [SerializeField] protected List<Toggle> toggleList = new();
    public List<Toggle> ToggleList => toggleList;

    [SerializeField] protected List<Text> toggleListText = new();
    public List<Text> ToggleListText => toggleListText;



    protected void Update()
    {
        this.UpdateAndSet();
    }

    protected override void GetComponent()
    {
        this.GetInputField();
        this.GetButton();
        this.GetToggle();
        this.GetQuestion();
        this.GetResult();
    }

    private void GetResult()
    {
        if (result != null) return;
        Debug.Log("Load Component", gameObject);
        result = transform.Find("Result").GetComponentInChildren<TMP_InputField>();
    }

    private void GetQuestion()
    {
        if (question != null) return;
        Debug.Log("Load Component", gameObject);
        question = transform.Find("Question").GetComponentInChildren<TMP_InputField>();
    }

    protected virtual void GetInputField()
    {
        if (inputFieldList.Count == indexInputFieldList && placeholderText.Count == indexInputFieldList) return;
        Debug.Log("Load Component", gameObject);
        Transform inputField = transform.Find("InputField");
        this.inputFieldList.Clear();
        this.placeholderText.Clear();
        for (int i = 0; i < inputField.childCount; i++)
        {
            if (i < indexInputFieldList)
            {
                if (inputField.GetChild(i).gameObject.activeSelf)
                {
                    this.inputFieldList.Add(inputField.GetChild(i).GetComponent<TMP_InputField>());
                    this.placeholderText.Add(inputField.GetChild(i).Find("Text Area").Find("Placeholder").GetComponent<TextMeshProUGUI>());
                    continue;
                }
                inputField.GetChild(i).gameObject.SetActive(true);

                this.inputFieldList.Add(inputField.GetChild(i).GetComponent<TMP_InputField>());
                this.placeholderText.Add(inputField.GetChild(i).Find("Text Area").Find("Placeholder").GetComponent<TextMeshProUGUI>());
                continue;
            }
            if (!inputField.GetChild(i).gameObject.activeSelf) continue;
            inputField.GetChild(i).gameObject.SetActive(false);
        }
    }
    protected virtual void GetToggle()
    {
        if (toggleList.Count == indexToggleList && toggleListText.Count == indexToggleList) return;
        Debug.Log("Load Component", gameObject);
        Transform Toggle = transform.Find("Track");
        this.toggleList.Clear();
        this.toggleListText.Clear();
        for (int i = 0; i < Toggle.childCount; i++)
        {
            if (i < indexToggleList)
            {
                if (Toggle.GetChild(i).gameObject.activeSelf)
                {
                    this.toggleList.Add(Toggle.GetChild(i).GetComponent<Toggle>());
                    this.toggleListText.Add(Toggle.GetChild(i).GetComponentInChildren<Text>());
                    continue;
                }
                Toggle.GetChild(i).gameObject.SetActive(true);

                this.toggleList.Add(Toggle.GetChild(i).GetComponent<Toggle>());
                this.toggleListText.Add(Toggle.GetChild(i).GetComponentInChildren<Text>());
                continue;
            }
            Toggle.GetChild(i).gameObject.SetActive(false);

        }
    }

    protected virtual void GetButton()
    {
        if (bton != null) return;
        Debug.Log("Load Component", gameObject);
        this.bton = GetComponentInChildren<Button>();
    }

    private void UpdateAndSet()
    {
        if (indexInputFieldList1 == indexInputFieldList && indexToggleList1 == indexToggleList) return;
        this.GetComponent();
        indexInputFieldList1 = indexInputFieldList;
        indexToggleList1 = indexToggleList;
    }
}
