using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using System.Linq;

public class UI_BoxItem : MonoBehaviour
{
    private ResLoader resLoader = ResLoader.Allocate();

    #region UI
    public Image SceneImage;
    public TextMeshProUGUI SceneName;
    public TextMeshProUGUI Location;
    public TextMeshProUGUI Director;
    public TextMeshProUGUI CTime;
    public Button ui_BoxButton;
    #endregion

    public RectTransform recBox;
    public UI_BoxItemData uI_BoxItemData;

    public void Init(UI_BoxItemData _uI_BoxItemData)
    {
        recBox = GetComponent<RectTransform>();
        uI_BoxItemData = _uI_BoxItemData;
        SceneImage.sprite = resLoader.LoadSync<Sprite>(uI_BoxItemData.ImageName);
        SceneName.text = uI_BoxItemData.SceneName;
        Location.text = uI_BoxItemData.Location;
        Director.text = uI_BoxItemData.Director;
        CTime.text = uI_BoxItemData.CTime.ToShortDateString();
        ui_BoxButton.onClick.AddListener(OnBoxButtonClick);
    }

    public void ResetUIPoint()
    {
        recBox.anchoredPosition3D = Vector3.zero;
        recBox.localRotation = Quaternion.identity;
        recBox.localScale = Vector3.one;
    }

    void OnBoxButtonClick()
    {
        Debug.Log(uI_BoxItemData.SceneName);
        UI_BoxView.Instance.LoadSceneObject(uI_BoxItemData.SceneName);
    }

    private void OnDestroy()
    {
        resLoader.Recycle2Cache();
        resLoader = null;
    }
}
