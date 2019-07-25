using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getUserInfo : MonoBehaviour
{

    public userInformationManager userInfo;
    public courseListScreenManager courseListScrene;
    public Text userIDTextOutput;
    public Text userNameTextOutput;
    public Button courseOne;

    private string userID;
    private string userName;


    // Start is called before the first frame update
    void Start()
    {
        userID = userInfo.m_UserID;
        userName = userInfo.m_UserName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
