using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class TMPInputHandler<T> : MMonoBehaviour
{
    protected string invalidData = "Invalid data";
    protected int indexMaxInputFieldList = default;
    protected int indexMaxToggleList = default;

    protected List<T> valuesOutput = new();

    protected virtual void ConvertInput()
    {

        for (int i = 0; i < indexMaxInputFieldList; i++)
        {
            try
            {
                valuesOutput.Add((T)Convert.ChangeType(GetString(i), typeof(T)));
            }
            catch
            {
                this.PrintInvalidData();
                this.valuesOutput.Clear();
                return;
            }
        }
    }

    protected virtual void OnEnable()
    {
        Invoke(nameof(ForOnEnable), 0.1f);
    }

    protected void ForOnEnable()
    {
        CanvasCtrl.Instance.indexInputFieldList = indexMaxInputFieldList;
        CanvasCtrl.Instance.indexToggleList = indexMaxToggleList;
        this.CheckActiveSelf();
        this.ResetPrintQAT();
        CanvasCtrl.Instance.Result.text = null;
    }

    protected virtual string GetString(int index)
    {
        return CanvasCtrl.Instance.InputFieldList[index].text;
    }

    public virtual void OnClick()
    {
        if (!gameObject.activeSelf) return;
        this.ConvertInput();
        this.CheckConditions();
    }
    protected virtual void AddValueToList(T value)
    {
        valuesOutput.Add(value);
    }

    protected abstract void Exercise();
    protected abstract void CheckConditions();
    protected virtual void CheckActiveSelf()
    {
        foreach (Transform sibling in transform.parent)
        {
            if (sibling.gameObject.name == gameObject.name) continue;
            if (!sibling.gameObject.activeSelf) continue;
            sibling.gameObject.SetActive(false);
        }
    }

    protected virtual void PrintInvalidData()
    {
        CanvasCtrl.Instance.Result.text = this.invalidData;
    }

    protected virtual void ClearList()
    {
        this.valuesOutput.Clear();
    }

    protected virtual void PrintQuestionAndText()
    {
        //Override
    }

    protected virtual void ResetPrintQAT()
    {
        if (indexMaxInputFieldList == CanvasCtrl.Instance.indexInputFieldList1 && indexMaxToggleList == CanvasCtrl.Instance.indexToggleList1)
        {
            this.PrintQuestionAndText();
            return;
        }
        Invoke(nameof(ResetPrintQAT), float.Epsilon);
    }
}
