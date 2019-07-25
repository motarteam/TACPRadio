using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StudentStatsManager : MonoBehaviour
{
    #region

    public Text m_UserInfoTextOutput;
    public GameObject m_ResetPanel;
    public InputField m_PasswordInput;
    public Button m_HomeButton;
    public Button m_ResetButton;
    public Button m_InstructorResetButton;
    public Text m_ResetText;
    public Text m_AchievementsTextOutput;

    private bool m_ResetSelected;
    private int m_TotalAchievements;
    private string m_PasswordInputString;
    private string m_UserName;
    private string m_UserID;
    private string m_PasswordRequired = "159753";

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        m_ResetPanel.SetActive(false);
        GetUserInfo();
    }

    // Update is called once per frame
    void Update()
    {


    }


    // Change back to course selection scene.
    public void ChangeToCourseSelectionScene()
    {

        SceneManager.LoadScene("courseSelectionScene", LoadSceneMode.Single);

    }

    // Get User Info
   public void GetUserInfo()
    {
        userInformationManager.controller.load();

        if (userInformationManager.controller.fileFound == true)
        {
            m_UserName = userInformationManager.controller.m_UserName;
            m_UserID = userInformationManager.controller.m_UserID;
            m_TotalAchievements = userInformationManager.controller.m_AchievmentsUnlocked;
            

            m_UserInfoTextOutput.text = m_UserName + " - " + m_UserID;
            m_AchievementsTextOutput.text ="Achievments Completed = " + m_TotalAchievements;
            return;
        }

        else
        {
            m_UserInfoTextOutput.text = "No User Data Found";
            m_TotalAchievements = 0;
            m_AchievementsTextOutput.text = "Achievments Completed = " + m_TotalAchievements;
        }

    } 

    public void UpdateUserInfoBars()
    {


    }

    public void ShowResetPanel()
    {
        m_ResetPanel.SetActive(true);
        m_PasswordInput.text = "";
        m_ResetText.text = "Reset User Data";


    }

    public void InstructorReset()
    {

        if (m_PasswordInput.text == m_PasswordRequired)
        {
            userInformationManager.controller.m_AchievmentsUnlocked = 0;
            userInformationManager.controller.m_HighScoreAchievment = 0;
            userInformationManager.controller.m_AlmostHighScoreAchievment = 0;
            userInformationManager.controller.m_GoldShieldAchievment = 0;
            userInformationManager.controller.m_SilverShieldAchievment = 0;
            userInformationManager.controller.m_BronzeShieldAchievment = 0;
            userInformationManager.controller.m_LinkShieldAchievment = 0;
            userInformationManager.controller.m_MetalMedelAchievment = 0;
            userInformationManager.controller.m_ParticipationTrophydAchievment = 0;
            userInformationManager.controller.m_TrainingTrophyAchievment = 0;
            userInformationManager.controller.m_UserID = null;
            userInformationManager.controller.m_UserName = null;
            userInformationManager.controller.m_UserPerformanceList.Clear();
            userInformationManager.controller.Save();
            Debug.Log("User Info Reset. Returning to Login Screen");
            SceneManager.LoadScene("userLoginScreen", LoadSceneMode.Single);
        }
        else
        {
            m_ResetText.text = "Wrong Password";
        }
    }

    public void CancelInstructorReset()
    {

        m_ResetPanel.SetActive(false);

    }
}
