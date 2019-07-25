using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class userLogin : MonoBehaviour
{

    
    public string logonUserId;
    public string logonUserName;
    public InputField userIDInput;
    public InputField userNameInput;

    private TouchScreenKeyboard m_Keyboard;
    private bool m_UserInfoFound;
    private string m_UserNameInput;
    private string m_UserIDInput;
    private bool m_KeyboardActive = false;

    // Start is called before the first frame update
    void Awake()
    {



    }

    // Update is called once per frame
    void Update()
    {


        try
        {
            userInformationManager.controller.load();
        }
        catch
        {
            Debug.Log("UserInformationManager.controller.Load() is not running");
        }

        if (userInformationManager.controller.fileFound == false)
        {

            Debug.Log("No User Info Found");
        }

        if (userInformationManager.controller.fileFound == true)
        {
            changeToCourseSelectionScene();
        }

        
        

    }

    // Get user info from user id and user name field -- send to userInfoManager class for other scripts

    public void getUserInfoAndSwitchToCourseList()
    {

       

        if (logonUserId == null)
        {
            m_UserInfoFound = true;
            userIDInput.image.color = Color.red;

        }
        else
        {
            userInformationManager.controller.m_UserID = userIDInput.text;
            
            
        }


        if (logonUserName == null)
        {

            userNameInput.image.color = Color.red;
            m_UserInfoFound = true;
        }
        else
        {

            userInformationManager.controller.m_UserName = userNameInput.text;
            

        }

        if(logonUserId != null && logonUserName != null)
        {
            userInformationManager.controller.Save();
            changeToCourseSelectionScene();
            m_UserInfoFound = false;
        }


    }

    public void changeToCourseSelectionScene()
    {
        if (m_UserInfoFound == false)
        SceneManager.LoadScene("courseSelectionScene", LoadSceneMode.Single);
    }

    public void ExitApplication()
    {
        Application.Quit();
    }


}
