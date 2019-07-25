using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class userInformationManager : MonoBehaviour

   
{
    public static userInformationManager controller;

    // variable to save -----------------------------------------
    #region
    public string m_UserID;
    public string m_UserName;
    public List<string> m_UserPerformanceList = new List<string>();
    public int m_HighScoreAchievment;
    public int m_AlmostHighScoreAchievment;
    public int m_GoldShieldAchievment;
    public int m_SilverShieldAchievment;
    public int m_BronzeShieldAchievment;
    public int m_LinkShieldAchievment;
    public int m_ParticipationTrophydAchievment;
    public int m_MetalMedelAchievment;
    public int m_TrainingTrophyAchievment;
    public int m_AchievmentsUnlocked;
    public string m_CourseType;
    public string m_saveCourseInfoFull;
    #endregion
    //-----------------------------------------------------------

    public bool fileFound = false;

    void Start()
    {
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;
        }
        else if (controller != this)
        {
            Destroy(gameObject);

        }

    }   
    

    public void Save()
    {
        if (File.Exists(Application.persistentDataPath + "/userInfo.dat"))
        {
            BinaryFormatter format = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + ("/userInfo.dat"), FileMode.Open);
            UserData userDatas = new UserData();
            userDatas.userId = m_UserID;
            userDatas.userName = m_UserName;
            
                userDatas.HighScoreAchievment = m_HighScoreAchievment;
                userDatas.AlmostHighScoreAchievment = m_AlmostHighScoreAchievment;
                userDatas.GoldShieldAchievment = m_GoldShieldAchievment;
                userDatas.SilverShieldAchievment = m_SilverShieldAchievment;
                userDatas.BronzeShieldAchievment = m_BronzeShieldAchievment;
                userDatas.ParticipationTrophydAchievment = m_ParticipationTrophydAchievment;
                userDatas.LinkShieldAchievment = m_LinkShieldAchievment;
                userDatas.MetalMedelAchievment = m_MetalMedelAchievment;
                userDatas.TrainingTrophyAchievment = m_TrainingTrophyAchievment;
                userDatas.TrophiesUnlocked = m_AchievmentsUnlocked;
                userDatas.UserPerformanceList.Add(m_saveCourseInfoFull);

            format.Serialize(file, userDatas);
            file.Close();
        }
        else
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + ("/userInfo.dat"));

            UserData userData = new UserData();
            userData.userId = m_UserID;
            userData.userName = m_UserName;
            userData.HighScoreAchievment = m_HighScoreAchievment;
            userData.AlmostHighScoreAchievment = m_AlmostHighScoreAchievment;
            userData.GoldShieldAchievment = m_GoldShieldAchievment;
            userData.SilverShieldAchievment = m_SilverShieldAchievment;
            userData.BronzeShieldAchievment = m_BronzeShieldAchievment;
            userData.ParticipationTrophydAchievment = m_ParticipationTrophydAchievment;
            userData.LinkShieldAchievment = m_LinkShieldAchievment;
            userData.MetalMedelAchievment = m_MetalMedelAchievment;
            userData.TrainingTrophyAchievment = m_TrainingTrophyAchievment;


            formatter.Serialize(file, userData);
            file.Close();
        }
    }

    public void load()
    {

        if (File.Exists(Application.persistentDataPath + "/userInfo.dat"))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/userInfo.dat",  FileMode.Open);
            UserData userData = (UserData)formatter.Deserialize(file);
            file.Close();

            m_UserID = userData.userId;
            m_UserName = userData.userName;
            m_HighScoreAchievment = userData.HighScoreAchievment;
            m_AlmostHighScoreAchievment = userData.AlmostHighScoreAchievment;
            m_GoldShieldAchievment = userData.GoldShieldAchievment;
            m_SilverShieldAchievment = userData.SilverShieldAchievment;
            m_BronzeShieldAchievment = userData.BronzeShieldAchievment;
            m_ParticipationTrophydAchievment = userData.ParticipationTrophydAchievment;
            m_LinkShieldAchievment = userData.LinkShieldAchievment;
            m_MetalMedelAchievment = userData.MetalMedelAchievment;
            m_TrainingTrophyAchievment = userData.TrainingTrophyAchievment;
            m_AchievmentsUnlocked = userData.TrophiesUnlocked;
            m_UserPerformanceList = userData.UserPerformanceList;
            


            fileFound = true;
        }
        else
        {
            Debug.Log("User Informatio Not Found!");
            fileFound = false;
        }


    }



    }



[System.Serializable]
public class UserData
{

    public string userId;
    public string userName;
    public List<string> UserPerformanceList = new List<string>();
    public int HighScoreAchievment;
    public int AlmostHighScoreAchievment;
    public int GoldShieldAchievment;
    public int SilverShieldAchievment;
    public int BronzeShieldAchievment;
    public int LinkShieldAchievment;
    public int ParticipationTrophydAchievment;
    public int MetalMedelAchievment;
    public int TrainingTrophyAchievment;
    public int TrophiesUnlocked;
    

}
