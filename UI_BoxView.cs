using QFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Toggle = UnityEngine.UI.Toggle;

public class UI_BoxView : MonoSingleton<UI_BoxView>
{
    private ResLoader resLoader = ResLoader.Allocate();

    public Transform transBoxPoint;
    public Transform transContent;
    public TestDataBind testDataBind;
    public Dictionary<string, GameObject> roomItems = new Dictionary<string, GameObject>();
    public List<UI_BoxItem> queryItems = new List<UI_BoxItem>();
    public List<UI_BoxItem> hideItems = new List<UI_BoxItem>();
    public List<UI_BoxItem> defaultItems = new List<UI_BoxItem>();
    public TMP_InputField tMP_TxtSearch;
    public ToggleGroup tOG_Group;
    public Toggle TOG_Desc;
    public string choseTOG;

    void Start()
    {
        ResKit.Init();
        testDataBind.Init().ForEach((itemData) =>
         {
             GameObject goBoxItem = resLoader.LoadSync<GameObject>("UI_BoxItem").Instantiate();
             goBoxItem.Parent(transContent);
             UI_BoxItem uI_BoxItem = goBoxItem.GetComponent<UI_BoxItem>();
             uI_BoxItem.Init(itemData);
             uI_BoxItem.ResetUIPoint();
             queryItems.Add(uI_BoxItem);
             defaultItems.Add(uI_BoxItem);
         });
        tOG_Group.GetComponentsInChildren<Toggle>().ForEach((item) =>
        {
            if (item.isOn)
                choseTOG = item.name;
            item.onValueChanged.AddListener((bool value) => OnValueChange(item));
        });
    }

    public void OnSearch()
    {
        if (tOG_Group == null && !tOG_Group.AnyTogglesOn())
        {
            OrderBydefault();
        }
        else
        {
            switch (choseTOG)
            {
                case "TOG_SceneName":
                    OrderBySceneName(TOG_Desc.isOn, tMP_TxtSearch.text.ToString());
                    break;
                case "TOG_Location":
                    OrderByLocation(TOG_Desc.isOn, tMP_TxtSearch.text.ToString());
                    break;
                case "TOG_Director":
                    OrderByDirector(TOG_Desc.isOn, tMP_TxtSearch.text.ToString());
                    break;
                case "TOG_DTime":
                    OrderByCTime(TOG_Desc.isOn, tMP_TxtSearch.text.ToString());
                    break;
                default:
                    break;
            }
        }
    }

    private void OnValueChange(Toggle t)
    {
        choseTOG = t.name;
    }

    public void OrderBySceneName(bool isDescending, string condition)
    {
        if (isDescending)
        {
            queryItems = defaultItems.Where(data => data.SceneName.text.Contains(condition)).OrderByDescending(data => data.SceneName.text[0]).ToList();
        }
        else
        {
            queryItems = defaultItems.Where(data => data.SceneName.text.Contains(condition)).OrderBy(data => data.SceneName.text[0]).ToList();
        }
        SetItems();
    }

    public void OrderByLocation(bool isDescending, string condition)
    {
        if (isDescending)
        {
            queryItems = defaultItems.Where(data => data.Location.text.Contains(condition)).OrderByDescending(data => data.Location.text[0]).ToList();
        }
        else
        {
            queryItems = defaultItems.Where(data => data.Location.text.Contains(condition)).OrderBy(data => data.Location.text[0]).ToList();
        }
        SetItems();
    }

    public void OrderByDirector(bool isDescending, string condition)
    {
        if (isDescending)
        {
            queryItems = defaultItems.Where(data => data.Director.text.Contains(condition)).OrderByDescending(data => data.Director.text[0]).ToList();
        }
        else
        {
            queryItems = defaultItems.Where(data => data.Director.text.Contains(condition)).OrderBy(data => data.Director.text[0]).ToList();
        }
        SetItems();
    }

    public void OrderByCTime(bool isDescending, string condition)
    {
        if (isDescending)
        {
            var scData = defaultItems.Where(data => data.CTime.text.Contains(condition));
            if (scData != null && scData.Count() > 0)
            {
                queryItems = scData.OrderByDescending(data => DateTime.Parse(data.CTime.text)).ToList();
            }
        }
        else
        {
            var scData = defaultItems.Where(data => data.CTime.text.Contains(condition));
            if (scData != null && scData.Count() > 0)
            {
                queryItems = scData.OrderBy(data => DateTime.Parse(data.CTime.text)).ToList();
            }
        }
        SetItems();
    }

    public void OrderBydefault()
    {
        queryItems = defaultItems;
        SetItems();
    }

    private void SetItems()
    {
        int childCount = transContent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            Transform outTrnas = transContent.GetChild(0);
            outTrnas.Parent(null);
            outTrnas.Hide();
        }
        queryItems.ForEach((uI_BoxItem) =>
        {
            uI_BoxItem.Parent(transContent);
            uI_BoxItem.ResetUIPoint();
            uI_BoxItem.Show();
        });
    }

    public GameObject nowRoomObject;

    public void LoadSceneObject(string sName)
    {
        if (!roomItems.TryGetValue(sName, out GameObject roomObj))
        {
            roomObj = resLoader.LoadSync<GameObject>(sName).Instantiate();
            roomItems.Add(sName, roomObj);
        }
        if (nowRoomObject != null)
            nowRoomObject.Hide();
        roomObj.Show();
        nowRoomObject = roomObj;
        if (transBoxPoint!=null)
        {
            nowRoomObject.Position(transBoxPoint.position);
        }
        else
        {
            nowRoomObject.Position(Vector3.zero);
        }
    }

    public override void Dispose()
    {
        resLoader.Recycle2Cache();
        resLoader = null;
    }
}
