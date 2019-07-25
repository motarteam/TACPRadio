using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StudentGridTableManager : MonoBehaviour
{
    #region

    public Text m_userInfoText;
    public VerticalLayoutGroup m_VerticalLayout;
    public List<string> testList;
    private bool m_UserInfoAvailable = false;
    private float m_ChangeYPos = 150f;
    private string m_userOutput;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= userInformationManager.controller.m_UserPerformanceList.Count - 1; i++)
        {
            testList.Add( userInformationManager.controller.m_UserPerformanceList[i]);
            Debug.Log(testList.Count);
        }
    }

    // Update UI
    private void OnGUI()
    {
        Debug.Log(testList.Count);
        Debug.Log(testList);
        if (testList.Count >= 1)
        {
            m_UserInfoAvailable = true;
            GenerateGrid();
        }
        else
        {
            m_UserInfoAvailable = false;
            GUI.Box(new Rect(Screen.width / 2.5f, m_ChangeYPos, 575f, 75f), "No User Data Found");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // create Table
    public void GenerateGrid()
    {
        if (m_UserInfoAvailable == true)
        {
            for (int i = 0; i <= userInformationManager.controller.m_UserPerformanceList.Count - 1; i++)
            {

                Debug.Log("int i = " + i);
                Debug.Log("User Progress Info Count = " + userInformationManager.controller.m_UserPerformanceList.Count);

                m_userInfoText.text = userInformationManager.controller.m_UserPerformanceList[i];
                m_userInfoText.fontSize = 32;
                GUI.Box(new Rect(Screen.width / 2.5f, m_ChangeYPos, 550f, 30f), i + 1 + ".)  " + userInformationManager.controller.m_UserPerformanceList[i]);

                m_ChangeYPos += 30;

                if (i >= userInformationManager.controller.m_UserPerformanceList.Count - 1)
                {
                    m_ChangeYPos = 150f;
                }
            }
        }
        else
        {
            Debug.Log("User Progress Info Not Avialable");
        } 
      
    }



}
