using QFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_BoxSwich : MonoBehaviour
{
    public Button butSwith;

    void Start()
    {
        butSwith = GetComponent<Button>();
        Text butText = butSwith.GetComponentInChildren<Text>();
        butSwith.onClick.AddListener(() =>
        {
            if (butText.text == "Open")
            {
                UI_BoxView.Instance.Show();
            }
            else
            {
                UI_BoxView.Instance.Hide();
            }
            butText.text = butText.text == "Open" ? "Close" : "Open";
        });
        UI_BoxView.Instance.Hide();
    }

}
