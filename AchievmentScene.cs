using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AchievmentScene : MonoBehaviour
{
    #region


    public Image m_HighScore;
    public Image m_AlmostHighScore;
    public Image m_GoldShield;
    public Image m_SilverShield;
    public Image m_BronzeShield;
    public Image m_LinkShield;
    public Image m_MetalMedal;
    public Image m_ParticipationTrophy;
    public Image m_TrainingTrophy;
    public List<Sprite> m_TrainingTrophiesList;

    public Text m_HighScoreText;
    public Text m_AlmostHighScoreText;
    public Text m_GoldShieldText;
    public Text m_SilverShieldText;
    public Text m_BronzeShieldText;
    public Text m_LinkShieldText;
    public Text m_MetalMedalText;
    public Text m_ParticipationTrophyText;
    public Text m_TrainingTrophyText;

    public int m_HighScoreTrophyAchieved = 0;
    public int m_AlmostHighScoreTrophyAchieved = 0;
    public int m_GoldShieldAchieved = 0;
    public int m_SilverShieldAchieved = 0;
    public int m_BronzeShieldAchieved = 0;
    public int m_LinkShieldAchieved = 0;
    public int m_MetalMedalAchieved = 0;
    public int m_ParticipationTrophyAchieved = 0;
    public int m_TrainingTrophyAchieved = 0;

    private Color m_BlackOut = new Color(0, 0, 0);
    private Color m_HSColor = new Color(133, 0 , 0);
    private Color m_AHSColor = new Color(255, 201, 144);
    private Color m_GSColor = new Color(255, 233, 172);
    private Color m_SSColor = new Color(219, 219, 219);
    private Color m_BSColor = new Color(231, 217, 000);
    private Color m_LSColor = new Color(123, 122, 171);
    private Color m_MMColor = new Color(226, 226, 99);
    private Color m_PTColor = new Color(149, 152, 94);
    private int m_RandomTrophie;
    private bool m_TrainingTrophyGenerated = false;

    private string m_UserName;
    private string m_UserID;
    public Text m_UserInfoTextOuput;
    
    #endregion



    // Start is called before the first frame update
    void Start()
    {
        GetUserInfo();
        DisplayTrophiesAchieved();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayTrophiesAchieved();
    }

    // display trophy data.
    public void DisplayTrophiesAchieved()
    {
        if (m_HighScoreTrophyAchieved == 1)
        {
            m_HighScore.color = m_HSColor;
            m_HighScoreText.text = "High Score";

        }
        else
        {
            m_HighScore.color = m_BlackOut;
            m_HighScoreText.text = "Locked";
        }


        if (m_AlmostHighScoreTrophyAchieved == 1)
        {
            m_AlmostHighScore.color = m_AHSColor;
            m_AlmostHighScoreText.text = "Almost High Score";

        }
        else
        {
            m_AlmostHighScore.color = m_BlackOut;
            m_AlmostHighScoreText.text = "Locked";
        }


        if (m_GoldShieldAchieved == 1)
        {
            m_GoldShield.color = m_GSColor;
            m_GoldShieldText.text = "Gold Shield";

        }
        else
        {
            m_GoldShield.color = m_BlackOut;
            m_GoldShieldText.text = "Locked";
        }

        if (m_SilverShieldAchieved == 1)
        {
            m_SilverShield.color = m_SSColor;
            m_SilverShieldText.text = "Silver Shield";

        }
        else
        {
            m_SilverShield.color = m_BlackOut;
            m_SilverShieldText.text = "Locked";
        }



        if (m_BronzeShieldAchieved == 1)
        {
            m_BronzeShield.color = m_BSColor;
            m_BronzeShieldText.text = "Bronze Shield";

        }
        else
        {
            m_BronzeShield.color = m_BlackOut;
            m_BronzeShieldText.text = "Locked";
        }


        if (m_LinkShieldAchieved == 1)
        {
            m_LinkShield.color = m_LSColor;
            m_LinkShieldText.text = "More Time Searching Than Training";

        }
        else
        {
            m_LinkShield.color = m_BlackOut;
            m_LinkShieldText.text = "Locked";
        }

        if (m_MetalMedalAchieved == 1)
        {
            m_MetalMedal.color = m_MMColor;
            m_MetalMedalText.text = "METAL Medel";

        }
        else
        {
            m_MetalMedal.color = m_BlackOut;
            m_MetalMedalText.text = "Locked";
        }

        if (m_ParticipationTrophyAchieved == 1)
        {
            m_ParticipationTrophy.color = m_PTColor;
            m_ParticipationTrophyText.text = "Participation Trophy";

        }
        else
        {
            m_ParticipationTrophy.color = m_BlackOut;
            m_ParticipationTrophyText.text = "Locked";
        }

        if (m_TrainingTrophyAchieved == 1)
        {
            GenerateTrainingTrophy();
            m_TrainingTrophy.color = new Color(255, 255, 255);
            m_TrainingTrophyText.text = "Training Completed";

        }
        else
        {
            m_TrainingTrophy.color = m_BlackOut;
            m_TrainingTrophy.sprite = m_TrainingTrophiesList[10];
            m_TrainingTrophyText.text = "Locked";
            m_TrainingTrophyGenerated = false;
        }

    }

    // pull saved trophy data.
    public void GetAchievedTrophies()
    {
        m_HighScoreTrophyAchieved = userInformationManager.controller.m_HighScoreAchievment;
        m_AlmostHighScoreTrophyAchieved = userInformationManager.controller.m_AlmostHighScoreAchievment;
        m_GoldShieldAchieved = userInformationManager.controller.m_GoldShieldAchievment;
        m_SilverShieldAchieved = userInformationManager.controller.m_SilverShieldAchievment;
        m_BronzeShieldAchieved = userInformationManager.controller.m_BronzeShieldAchievment;
        m_ParticipationTrophyAchieved = userInformationManager.controller.m_ParticipationTrophydAchievment;
        m_TrainingTrophyAchieved = userInformationManager.controller.m_TrainingTrophyAchievment;
        m_LinkShieldAchieved = userInformationManager.controller.m_LinkShieldAchievment;
        m_MetalMedalAchieved = userInformationManager.controller.m_MetalMedelAchievment;
    }

    // Change back to course selection scene.
    public void ChangeToCourseSelectionScene()
    {

        SceneManager.LoadScene("courseSelectionScene", LoadSceneMode.Single);

    }

    // Get and display user data.
    public void GetUserInfo()
    {



                m_UserName = userInformationManager.controller.m_UserName;
                m_UserID = userInformationManager.controller.m_UserID;
                m_HighScoreTrophyAchieved = userInformationManager.controller.m_HighScoreAchievment;
                m_AlmostHighScoreTrophyAchieved = userInformationManager.controller.m_AlmostHighScoreAchievment;
                m_GoldShieldAchieved = userInformationManager.controller.m_GoldShieldAchievment;
                m_SilverShieldAchieved = userInformationManager.controller.m_SilverShieldAchievment;
                m_BronzeShieldAchieved = userInformationManager.controller.m_BronzeShieldAchievment;
                m_LinkShieldAchieved = userInformationManager.controller.m_LinkShieldAchievment;
                m_MetalMedalAchieved = userInformationManager.controller.m_MetalMedelAchievment;
                m_TrainingTrophyAchieved = userInformationManager.controller.m_TrainingTrophyAchievment;
                m_ParticipationTrophyAchieved = userInformationManager.controller.m_ParticipationTrophydAchievment;

                m_UserInfoTextOuput.text = m_UserName + " - " + m_UserID;
              
        

        }

    // Generate random training trophy.
    public void GenerateTrainingTrophy()
    {
        if (m_TrainingTrophyGenerated == false)
        {
            m_RandomTrophie = Random.Range(0, 9);
            m_TrainingTrophy.sprite = m_TrainingTrophiesList[m_RandomTrophie];
            m_TrainingTrophyGenerated = true;
        }
        else
        {
            Debug.Log("Training Trophie Generated");
        }
    }
    
}
