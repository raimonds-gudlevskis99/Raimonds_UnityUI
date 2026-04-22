using UnityEngine;
using TMPro;
using System;

public class UserInfoController : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TMP_InputField birthYearInput;
    public TMP_Text resultText;

    public void ShowAge()
    {
        string userName = nameInput.text;
        int birthYear;

        if (string.IsNullOrWhiteSpace(userName))
        {
            resultText.text = "Please enter name.";
            return;
        }

        if (!int.TryParse(birthYearInput.text, out birthYear))
        {
            resultText.text = "Birth year must contain numbers only.";
            return;
        }

        int currentYear = DateTime.Now.Year;
        int age = currentYear - birthYear;

        resultText.text = userName + " is " + age + " years old!";
    }
}