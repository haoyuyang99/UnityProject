using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDataBind : MonoBehaviour
{
    public List<UI_BoxItemData> uI_BoxItemDatas = new List<UI_BoxItemData>();
    
    public List<UI_BoxItemData> Init()
    {
        
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("2003-9-6"), Director = "Gerald Freedman", Location = "Williamstown Theatre Festival", SceneName = "S0102 An Enemy of the People", ImageName = "S0102 An Enemy of the People" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1989-9-6"), Director = "Gerald Freedman", Location = "New York Shakespeare Festival Public Theater", SceneName = "S02026 Loves Labours Lost", ImageName = "S02026 Loves Labours Lost" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1111-1-1"), Director = "director", Location = "USA", SceneName = "S02022 A Funny Thing Happened on the Way to the Forum", ImageName = "S02022 A Funny Thing Happened on the Way to the Forum" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1111-1-1"), Director = "director", Location = "USA", SceneName = "S02027 A Midsummer Nights Dream", ImageName = "S02027 A Midsummer Nights Dream" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1991-1-1"), Director = "David Schechter", Location = "Repertory Theatre of St. Louis", SceneName = "S02011 Almost September", ImageName = "S02011 Almost September" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1996-1-1"), Director = "Victoria Bussert", Location = "Great Lakes Theater Festival", SceneName = "S02013 Blithe Spirit", ImageName = "S02013 Blithe Spirit" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1981-1-1"), Director = "James Assad", Location = "Missouri Repertory Theater", SceneName = "S02035 Tallys Folly", ImageName = "S02035 Tallys Folly" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("2004-1-1"), Director = "Victoria Bussert", Location = "Repertory Theatre of St. Louis", SceneName = "S0106 The Mystery of Edwin Drood", ImageName = "S0106 The Mystery of Edwin Drood" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1990-1-1"), Director = "Gerald Freedman", Location = "Great Lakes Theater Festival Cleveland and the Roger Stevens Theatre", SceneName = "S02016 Dividing the Estate", ImageName = "S02016 Dividing the Estate" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1111-1-1"), Director = "director", Location = "USA", SceneName = "S02028 The Miracle Woker", ImageName = "S02028 The Miracle Woker" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("2000-1-1"), Director = "James Bundy", Location = "Great Lakes Theater Festival", SceneName = "S02038 Travels with my Aunt Act One", ImageName = "S02038 Travels with my Aunt Act One" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("2000-1-1"), Director = "James Bundy", Location = "Great Lakes Theater Festival", SceneName = "S02039 Travels with my Aunt Act Two", ImageName = "S02039 Travels with my Aunt Act Two" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1111-1-1"), Director = "director", Location = "USA", SceneName = "S02030 Othello", ImageName = "S02030 Othello" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1988-1-1"), Director = "Brent Wagner", Location = "The University of Michigan School of Music", SceneName = "S02017 Dragons", ImageName = "S02017 Dragons" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1985-1-1"), Director = "Edward Stern", Location = "Repertory Theatre of St. Louis", SceneName = "S02032 The Price", ImageName = "S02032 The Price" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1992-1-1"), Director = "George Keathley", Location = "Missouri Repertory Theatre", SceneName = "S02033 Rough Crossing", ImageName = "S02033 Rough Crossing" });
        uI_BoxItemDatas.Add(new UI_BoxItemData() { CTime = DateTime.Parse("1111-1-1"), Director = "director", Location = "USA", SceneName = "S02034 Slowdance on the Killing Ground", ImageName = "S02034 Slowdance on the Killing Ground" });

        return uI_BoxItemDatas;
    }

    
}
