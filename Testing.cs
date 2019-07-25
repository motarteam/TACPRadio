using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Testing : MonoBehaviour
{
    #region Variables

    public GameObject m_ControlPanel;
    public bool m_ControlPanelHidden;  // For testing only *REMOVE*


    public bool m_ProgramMode;
    public bool m_AlphabetMode;
    public bool m_NumericMode;
    public bool m_FrequencyMode;

    public Text m_PresetOutputTest; // For Testing *REMOVE*

    public float m_ButtonTimer = 0.0f;

    public int m_ProgramModeSelected;
    public int m_SubProgramModeSelected;
    public int m_SubSubProgramModeSelected;

    public List<Sprite> m_MainMenuSprites;
    public List<Sprite> m_ModeMenuSprites;
    public List<Sprite> m_ModenMenuSubSprites;
    public List<Sprite> m_SquelchMenuSprites;
    public List<Sprite> m_SquelchSubMenuSprites;
    public List<Sprite> m_ZeroizeMenuSprites;
    public List<Sprite> m_ZeroizeSubMenuSprites;
    public List<Sprite> m_OptionsMenuSprites;
    public List<Sprite> m_OptionsSubMenuSprites;
    public List<Sprite> m_OptionsSubSubMenuSprites;
    public List<Sprite> m_ProgramMenuSprites;
    public List<Sprite> m_ProgramSubMenuSprites;
    public List<Sprite> m_ProgramSubSubMenuSprites;

    public Image m_DisplayScreenImage;

    public int m_MainMenuScreen;
    public int m_ModeMenuScreen;
    public int m_ModeMenuSubScreen;
    public int m_SquelchMenuScreen;
    public int m_SquelchMenuSubScreen;
    public int m_ZeroizeMenuScreen;
    public int m_ZeroizeMenuSubScreen;
    public int m_OptionsMenuScreen;
    public int m_OptionsMenuSubScreen;
    public int m_ProgramMenuScreen;
    public int m_PtrogramMenuSubScreen;

    public bool m_ModeMenu;
    public bool m_SquelchMenu;
    public bool m_ZeroizeMenu;
    public bool m_OptionsMenu;
    public bool m_ProgramMenu;

    public int m_RadioMode; // identifies What button was pressed
    public int m_RadioSubMode;  // sub menu modes

    // ----------------------------------------------------- KTC - L500 ------------------------------------------------------------------

    public Image m_KTC500Panel;
    public Sprite[] m_KTC500ImageArray;
    public int m_KTCL500Image;
    public bool m_KTC500Displayed;

    // ------------------------------------------------Alphabet / Description mode Variables -----------------------------------------------------------

    public bool m_IDRequired;
    public bool m_DescriptionRequired;

    public Text m_DescriptionText1;
    public Text m_DescriptionText2;
    public Text m_DescriptionText3;
    public Text m_DescriptionText4;
    public Text m_DescriptionText5;
    public Text m_DescriptionText6;
    public Text m_DescriptionText7;
    public Text m_DescriptionText8;
    public Text m_DescriptionText9;

    public GameObject m_DescritpionCursor1;
    public GameObject m_DescritpionCursor2;
    public GameObject m_DescritpionCursor3;
    public GameObject m_DescritpionCursor4;
    public GameObject m_DescritpionCursor5;
    public GameObject m_DescritpionCursor6;
    public GameObject m_DescritpionCursor7;
    public GameObject m_DescritpionCursor8;
    public GameObject m_DescritpionCursor9;

    string[] m_AvailableChar = new string[] { "1", "A", "B", "C", "2", "D", "E", "F", "3","G", "H", "I", "4", "J", "K", "L", "5", "M", "N", "O", "6", "P", "Q", "R", "7", "S", "T", "U", "8", "V", "W", "X", "9", "Y", "Z", "?"};
    public List<string> m_DescriptionList;
    public List<string> m_listDescricptionStringSeperated;

    public string m_CombineDescriptionInput;

    private int m_CharSelected;
    private int m_LastButtonPressed = 0;  // Resets when another Button is pressed.

    private bool m_FirstPressButton;

    // ------------------------------------------------frequency mode Variables-----------------------------------------------------------
    public Text m_FreqText1;
    public Text m_FreqText2;
    public Text m_FreqText3;
    public Text m_FreqText4;
    public Text m_FreqText5;
    public Text m_FreqText6;
    public Text m_FreqText7;
    public Text m_FreqPeriodText;

    public GameObject m_Freq1panel;
    public GameObject m_Freq2panel;
    public GameObject m_Freq3panel;
    public GameObject m_Freq4panel;
    public GameObject m_Freq5panel;
    public GameObject m_Freq6panel;
    public GameObject m_Freq7panel;

    public List<string> m_FreqList;
    public List<string> m_listFreqStringSeperated;

    public string m_ButtonOutput;
    public string m_CombineFreqInput;
    public string m_CurrentFreq;
    public string m_NextCharacterText;

    public int m_ListNumber;
    public int m_SelectedInputCharacter = 1;

    public bool m_FreqInputReq;

    public Color m_GreenColor = new Color(133, 176, 72, 255);
    public Color m_BlackColor = new Color(0, 0, 0, 255);



    public Text m_NextTextItem;



    // ------------------------------------------------Channel ID mode Variables-----------------------------------------------------------

    public Text m_IDNumber1;
    public Text m_IDNumber2;

    public GameObject m_IDCursor1;
    public GameObject m_IDCursor2;

    public List<string> m_IDList;
    public List<string> m_IDlistItemStringSeperated;

    public int m_IDListNumber;

    public string m_CombineIDInput;

    #endregion


    // Start is called before the first frame update
    void Start()
    {
        FullModeReset();
        HideCursorPanels();
        HideFreqInputCharacters();
        HideIDInputCharacters();
        HideDescriptionCharacters();
    }



    // Update is called once per frame
    void Update()
    {
        if (m_FreqList.Count > 0)
        {
            m_PresetOutputTest.text = " (" + m_IDList[0] +")      (" + m_DescriptionList[0] + ")       ( " + m_FreqList[0] + ")";
        }

        if (m_ProgramMode == true)
        {



        }






        if (m_AlphabetMode == true)
        {
         
            if (m_DescriptionRequired == true)
            {
                ShowDescriptionCharacters();
                ShowCursorOnSelectedDescriptionInput();
            }
            else
            {
                HideDescriptionCharacters();
            }

        }







        if (m_NumericMode == true)
        {

            if (m_FreqInputReq == true)
            {
                ShowFreqInputCharacters();
                ShowCursorOnSelectedInput();
            }
            else
            {
                HideFreqInputCharacters();
            }


            if (m_IDRequired == true)
            {
                ShowIDInputCharacters();
                ShowCursorOnIDInput();
            }
            else
            {
                HideIDInputCharacters();
            }

          

        }
  
    }




    #region Button Functions

    public void ButtonOnePressed()
    {
        if (m_NumericMode == true)
        {
            m_ButtonOutput = "1";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 1)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 1;
            UpdateCharOutput(m_LastButtonPressed);

        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonTwoPressed()
    {
       
        if (m_NumericMode == true)
        {
            m_ButtonOutput = "2";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 2)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 2;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonThreePressed()
    {

        if (m_NumericMode == true)
        {
            m_ButtonOutput = "3";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 3)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 3;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {
            m_RadioMode = 3;
            ChangeToModeMenu(0);
        }
    }

    public void ButtonFourPressed()
    {
        
        if (m_NumericMode == true)
        {
            m_ButtonOutput = "4";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 4)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 4;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonFivePressed()
    {

        if (m_NumericMode == true)
        {
            m_ButtonOutput = "5";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 5)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 5;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonSixPressed()
    {

        if (m_NumericMode == true)
        {
            m_ButtonOutput = "6";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 6)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 6;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonSevenPressed()
    {

        if (m_NumericMode == true)
        {
            m_ButtonOutput = "7";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 7)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 7;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonEightPressed()
    {
        
        if (m_NumericMode == true)
        {
            m_ButtonOutput = "8";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 8)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 8;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonNinePressed()
    {

        if (m_NumericMode == true)
        {
            m_ButtonOutput = "9";
        }

        if (m_AlphabetMode == true)
        {
            if (m_LastButtonPressed == 9)
            {
                m_CharSelected += 1;
            }
            else
            {
                m_CharSelected = 0;
            }

            m_LastButtonPressed = 9;
            UpdateCharOutput(m_LastButtonPressed);
        }

        if (m_ProgramMode == true)
        {

        }
    }

    public void ButtonZeroPressed()
    {
       


        if (m_NumericMode == true)
        {
            m_ButtonOutput = "0";
        }

        if (m_AlphabetMode == true)
        {
            m_ButtonOutput = "0";
        }

        if (m_ProgramMode == true)
        {
            ScrollPresets();
        }
    }

    public void ButtonEnterPressed()
    {

        // FREQ--->

        if (m_NumericMode == true)
        {
            if (m_FreqInputReq == true)
            {
                int MinFreq = 300000;
                int MaxFreq = 5119950;
                int EnteredFreq;

                m_CombineFreqInput = m_FreqText1.text + m_FreqText2.text + m_FreqText3.text + m_FreqText4.text + m_FreqText5.text + m_FreqText6.text + m_FreqText7.text;

                int.TryParse(m_CombineFreqInput, out EnteredFreq);
                if (EnteredFreq < MinFreq || EnteredFreq > MaxFreq)
                {
                    Debug.Log("Frequency is not allowed.  Entered : " + EnteredFreq);
                }
                else
                {
                    m_FreqList.Add(m_CombineFreqInput);
                    ClearFreqInputCharacters();
                }
            }


            // ID --->

            if (m_IDRequired == true)
            {
                int MinID = 0;
                int MaxID = 99;
                int EnteredID;

                m_CombineIDInput = m_IDNumber1.text + m_IDNumber2.text;

                int.TryParse(m_CombineIDInput, out EnteredID);
                if (EnteredID < MinID || EnteredID > MaxID)
                {
                    Debug.Log("ID is not allowed.  Entered : " + EnteredID);
                }
                else
                {
                    m_IDList.Add(m_CombineIDInput);
                    ClearIDCharacters();
                }
            }


            // Channel Description --->


        }

        if (m_AlphabetMode == true)
        {
            if (m_DescriptionRequired == true)
            {
                m_CombineDescriptionInput = m_DescriptionText1.text + m_DescriptionText2.text + m_DescriptionText3.text + m_DescriptionText4.text + m_DescriptionText5.text + m_DescriptionText6.text + m_DescriptionText7.text + m_DescriptionText8.text + m_DescriptionText9.text;
                m_DescriptionList.Add(m_CombineDescriptionInput);
                ClearDescriptionCharacters();
                
            }
        }

        if (m_ProgramMode == true)
        {

        }

 
    }

    public void ButtonClearPressed()
    {


        if (m_NumericMode == true)
        {
            if (m_FreqInputReq == true)
            {
                ClearFreqInputCharacters();
            }

            if (m_IDRequired == true)
            {
                ClearIDCharacters();
            }
        }

        if (m_AlphabetMode == true)
        {
            m_ButtonOutput = " ";
        }

        if (m_ProgramMode == true)
        {

        }


    }

    public void ButtonPresetUpPressed()
    {


        if (m_NumericMode == true)
        {

        }

        if (m_AlphabetMode == true)
        {
            
        }

        if (m_ProgramMode == true)
        {
            if (m_MainMenuScreen <= 0)
            {
                m_MainMenuScreen = 0;
            }
            else
            {
                m_MainMenuScreen -= 1;
            }

            ChangeScreenMain(m_MainMenuScreen);
        }

        Debug.Log("Preset Up Was Pressed but the programmer is to lazy to put in the ChangeImage()... ");

    }

    public void ButtonPresetDownPressed()
    {


        if (m_NumericMode == true)
        {

        }

        if (m_AlphabetMode == true)
        {

        }

        if (m_ProgramMode == true)
        {
            if (m_MainMenuScreen > m_MainMenuSprites.Count -1)
            {
                m_MainMenuScreen = m_MainMenuSprites.Count - 1;
            }
            else
            {
                m_MainMenuScreen += 1;
            }

            ChangeScreenMain(m_MainMenuScreen);
        }

        Debug.Log("Preset Up Was Pressed but the programmer is to lazy to put in the ChangeImage()... ");
    }

    public void ButtonRightArrowPressed()
    {


        if (m_NumericMode == true)
        {
            if (m_FreqInputReq == true)
            {
                if (m_SelectedInputCharacter < 7)
                {
                    m_NextTextItem = GameObject.Find("FreqText" + (m_SelectedInputCharacter + 1)).GetComponentInChildren<Text>();
                    Debug.Log("Next Character = " + m_NextTextItem.text);
                    m_ButtonOutput = m_NextTextItem.text;
                    m_SelectedInputCharacter += 1;

                }
                else
                {
                    m_SelectedInputCharacter = 7;
                }
            }

            if (m_IDRequired == true)
            {
                if (m_SelectedInputCharacter < 2)
                {
                    m_NextTextItem = GameObject.Find("IDNumber2").GetComponentInChildren<Text>();
                    Debug.Log("Next Character = " + m_NextTextItem.text);
                    m_ButtonOutput = m_NextTextItem.text;
                    m_SelectedInputCharacter += 1;

                }
                else
                {
                    m_SelectedInputCharacter = 2;
                }

                Debug.Log("m_SelectedInputCharter = " + m_SelectedInputCharacter);
            }
        }

        if (m_AlphabetMode == true)
        {
            if (m_DescriptionRequired == true)
            {
                if (m_SelectedInputCharacter < 9)
                {
                     m_NextTextItem = GameObject.Find("PresetDescription" + (m_SelectedInputCharacter + 1)).GetComponentInChildren<Text>();
                     Debug.Log("Next Character = " + m_NextTextItem.text);
                     m_ButtonOutput = m_NextTextItem.text;
                     m_SelectedInputCharacter += 1;

                }
                else
                {
                     m_SelectedInputCharacter = 9;
                }
                
            }
        }

        if (m_ProgramMode == true)
        {

        }

    }

    public void ButtonLeftArrowPressed()
    {


        if (m_NumericMode == true)
        {
            if (m_FreqInputReq == true)
            {
                if (m_SelectedInputCharacter > 1)
                {
                    m_NextTextItem = GameObject.Find("FreqText1").GetComponentInChildren<Text>();
                    Debug.Log("Next Character = " + m_NextTextItem.text);
                    m_ButtonOutput = m_NextTextItem.text;
                    m_SelectedInputCharacter -= 1;
                }
                else
                {
                    m_SelectedInputCharacter = 1;
                }
            }


            if (m_IDRequired == true)
            {
                if (m_SelectedInputCharacter > 1)
                {
                    m_NextTextItem = GameObject.Find("IDNumber" + (m_SelectedInputCharacter - 1)).GetComponentInChildren<Text>();
                    Debug.Log("Next Character = " + m_NextTextItem.text);
                    m_ButtonOutput = m_NextTextItem.text;
                    m_SelectedInputCharacter -= 1;
                }
                else
                {
                   // m_SelectedInputCharacter = 1;
                }
            }

            Debug.Log("m_SelectedInputCharter = " + m_SelectedInputCharacter);
        }

        if (m_AlphabetMode == true)
        {
            if (m_DescriptionRequired == true)
            {
                if (m_SelectedInputCharacter > 1)
                {
                    m_NextTextItem = GameObject.Find("PresetDescription" + (m_SelectedInputCharacter - 1)).GetComponentInChildren<Text>();
                    Debug.Log("Next Character = " + m_NextTextItem.text);
                    m_ButtonOutput = m_NextTextItem.text;
                    m_SelectedInputCharacter -= 1;
                }
                else
                {
                    m_SelectedInputCharacter = 1;
                }
            }
        }

        if (m_ProgramMode == true)
        {

        }

       
    }

    #endregion

    #region ID Number Required

    public void ShowIDInputCharacters()
    {
        m_IDNumber1.enabled = true;
        m_IDNumber2.enabled = true;

    }

    public void HideIDInputCharacters()
    {
        m_IDNumber1.enabled = false;
        m_IDNumber2.enabled = false;

        m_IDCursor1.SetActive(false);
        m_IDCursor2.SetActive(false);

    }

    public void ShowCursorOnIDInput()
    {
        
        // ID item 1 selected
        if (m_SelectedInputCharacter == 1)
        {
            m_IDNumber1.color = m_GreenColor;
            m_IDCursor1.SetActive(true);
            m_IDNumber1.text = m_ButtonOutput;
        }
        else
        {
            m_IDNumber1.color = m_BlackColor;
            m_IDCursor1.SetActive(false);
        }

        // ID item 2 selected
        if (m_SelectedInputCharacter == 2)
        {
            m_IDNumber2.color = m_GreenColor;
            m_IDCursor2.SetActive(true);
            m_IDNumber2.text = m_ButtonOutput;
        }
        else
        {
            m_IDNumber2.color = m_BlackColor;
            m_IDCursor2.SetActive(false);
        }

    }

    public void ClearIDCharacters()
    {
        m_ButtonOutput = "0";
        m_IDNumber1.text = "0";
        m_IDNumber2.text = "0";
        m_SelectedInputCharacter = 1;
    }

    #endregion

    #region Description Required

    public void ShowCursorOnSelectedDescriptionInput()
    {
        // Description Line 1 selected
        if (m_SelectedInputCharacter == 1)
        {
            m_DescriptionText1.color = m_GreenColor;
            m_DescritpionCursor1.SetActive(true);
            m_DescriptionText1.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText1.color = m_BlackColor;
            m_DescritpionCursor1.SetActive(false);
        }

        // Description Line 2 selected
        if (m_SelectedInputCharacter == 2)
        {
            m_DescriptionText2.color = m_GreenColor;
            m_DescritpionCursor2.SetActive(true);
            m_DescriptionText2.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText2.color = m_BlackColor;
            m_DescritpionCursor2.SetActive(false);
        }


        // Description Line 3 selected
        if (m_SelectedInputCharacter == 3)
        {
            m_DescriptionText3.color = m_GreenColor;
            m_DescritpionCursor3.SetActive(true);
            m_DescriptionText3.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText3.color = m_BlackColor;
            m_DescritpionCursor3.SetActive(false);
        }


        // Description Line 4 selected
        if (m_SelectedInputCharacter == 4)
        {
            m_DescriptionText4.color = m_GreenColor;
            m_DescritpionCursor4.SetActive(true);
            m_DescriptionText4.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText4.color = m_BlackColor;
            m_DescritpionCursor4.SetActive(false);
        }


        // Description Line 5 selected
        if (m_SelectedInputCharacter == 5)
        {
            m_DescriptionText5.color = m_GreenColor;
            m_DescritpionCursor5.SetActive(true);
            m_DescriptionText5.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText5.color = m_BlackColor;
            m_DescritpionCursor5.SetActive(false);
        }


        // Description Line 6 selected
        if (m_SelectedInputCharacter == 6)
        {
            m_DescriptionText6.color = m_GreenColor;
            m_DescritpionCursor6.SetActive(true);
            m_DescriptionText6.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText6.color = m_BlackColor;
            m_DescritpionCursor6.SetActive(false);
        }


        // Description Line 7 selected
        if (m_SelectedInputCharacter == 7)
        {
            m_DescriptionText7.color = m_GreenColor;
            m_DescritpionCursor7.SetActive(true);
            m_DescriptionText7.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText7.color = m_BlackColor;
            m_DescritpionCursor7.SetActive(false);
        }


        // Description Line 8 selected
        if (m_SelectedInputCharacter == 8)
        {
            m_DescriptionText8.color = m_GreenColor;
            m_DescritpionCursor8.SetActive(true);
            m_DescriptionText8.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText8.color = m_BlackColor;
            m_DescritpionCursor8.SetActive(false);
        }


        // Description Line 9 selected
        if (m_SelectedInputCharacter == 9)
        {
            m_DescriptionText9.color = m_GreenColor;
            m_DescritpionCursor9.SetActive(true);
            m_DescriptionText9.text = m_ButtonOutput;
        }
        else
        {
            m_DescriptionText9.color = m_BlackColor;
            m_DescritpionCursor9.SetActive(false);
        }


    }

    public void ShowDescriptionCharacters()
    {
        m_DescriptionText1.enabled = true;
        m_DescriptionText2.enabled = true;
        m_DescriptionText3.enabled = true;
        m_DescriptionText4.enabled = true;
        m_DescriptionText5.enabled = true;
        m_DescriptionText6.enabled = true;
        m_DescriptionText7.enabled = true;
        m_DescriptionText8.enabled = true;
        m_DescriptionText9.enabled = true;

    }

    public void HideDescriptionCharacters()
    {
        m_DescriptionText1.enabled = false;
        m_DescriptionText2.enabled = false;
        m_DescriptionText3.enabled = false;
        m_DescriptionText4.enabled = false;
        m_DescriptionText5.enabled = false;
        m_DescriptionText6.enabled = false;
        m_DescriptionText7.enabled = false;
        m_DescriptionText8.enabled = false;
        m_DescriptionText9.enabled = false;


        m_DescritpionCursor1.SetActive(false);
        m_DescritpionCursor2.SetActive(false);
        m_DescritpionCursor3.SetActive(false);
        m_DescritpionCursor4.SetActive(false);
        m_DescritpionCursor5.SetActive(false);
        m_DescritpionCursor6.SetActive(false);
        m_DescritpionCursor7.SetActive(false);
        m_DescritpionCursor8.SetActive(false);
        m_DescritpionCursor9.SetActive(false);
    }

    public void ClearDescriptionCharacters()
    {
        m_ButtonOutput = "0";
        m_DescriptionText1.text = "E";
        m_DescriptionText2.text = "N";
        m_DescriptionText3.text = "T";
        m_DescriptionText4.text = " ";
        m_DescriptionText5.text = "D";
        m_DescriptionText6.text = "E";
        m_DescriptionText7.text = "S";
        m_DescriptionText8.text = "C";
        m_DescriptionText9.text = "R";
        m_SelectedInputCharacter = 1;
    }

    #endregion

    #region Alphabet Input Functions

    public void UpdateCharOutput(int ButtonNumber)
    {
        if (ButtonNumber == 1)
        {
            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected];
            }
        }

        if (ButtonNumber == 2)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 4];
            }
        }

        if (ButtonNumber == 3)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 8];
            }
        }

        if (ButtonNumber == 4)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 12];
            }
        }

        if (ButtonNumber == 5)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 16];
            }
        }

        if (ButtonNumber == 6)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 20];
            }
        }

        if (ButtonNumber == 7)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 24];
            }
        }

        if (ButtonNumber == 8)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 28];
            }
        }

        if (ButtonNumber == 9)
        {

            if (m_DescriptionRequired == true)
            {
                if (m_CharSelected > 3)
                {
                    m_CharSelected = 0;
                }

                m_ButtonOutput = m_AvailableChar[m_CharSelected + 32];
            }
        }

    }

    #endregion

    #region Cursor and Freq Input Functions

    public void ShowCursorOnSelectedInput()
    {
        // Freq Line 1 selected
        if (m_SelectedInputCharacter == 1)
        {
            m_FreqText1.color = m_GreenColor;
            m_Freq1panel.SetActive(true);
            m_FreqText1.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText1.color = m_BlackColor;
            m_Freq1panel.SetActive(false);
        }


        // Freq Line 2 selected
        if (m_SelectedInputCharacter == 2)
        {
            m_FreqText2.color = m_GreenColor;
            m_Freq2panel.SetActive(true);
            m_FreqText2.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText2.color = m_BlackColor;
            m_Freq2panel.SetActive(false);
        }


        // Freq Line 3 selected
        if (m_SelectedInputCharacter == 3)
        {
            m_FreqText3.color = m_GreenColor;
            m_Freq3panel.SetActive(true);
            m_FreqText3.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText3.color = m_BlackColor;
            m_Freq3panel.SetActive(false);
        }


        // Freq Line 4 selected
        if (m_SelectedInputCharacter == 4)
        {
            m_FreqText4.color = m_GreenColor;
            m_Freq4panel.SetActive(true);
            m_FreqText4.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText4.color = m_BlackColor;
            m_Freq4panel.SetActive(false);
        }


        // Freq Line 5 selected
        if (m_SelectedInputCharacter == 5)
        {
            m_FreqText5.color = m_GreenColor;
            m_Freq5panel.SetActive(true);
            m_FreqText5.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText5.color = m_BlackColor;
            m_Freq5panel.SetActive(false);
        }

        // Freq Line 6 selected
        if (m_SelectedInputCharacter == 6)
        {
            m_FreqText6.color = m_GreenColor;
            m_Freq6panel.SetActive(true);
            m_FreqText6.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText6.color = m_BlackColor;
            m_Freq6panel.SetActive(false);
        }

        // Freq Line 7 selected
        if (m_SelectedInputCharacter == 7)
        {
            m_FreqText7.color = m_GreenColor;
            m_Freq7panel.SetActive(true);
            m_FreqText7.text = m_ButtonOutput;
        }
        else
        {
            m_FreqText7.color = m_BlackColor;
            m_Freq7panel.SetActive(false);
        }

    }

    public void ShowFreqInputCharacters()
    {
        m_FreqText1.enabled = true;
        m_FreqText2.enabled = true;
        m_FreqText3.enabled = true;
        m_FreqText4.enabled = true;
        m_FreqText5.enabled = true;
        m_FreqText6.enabled = true;
        m_FreqText7.enabled = true;
        m_FreqPeriodText.enabled = true;
    }

    public void HideFreqInputCharacters()
    {
        m_FreqText1.enabled = false;
        m_FreqText2.enabled = false;
        m_FreqText3.enabled = false;
        m_FreqText4.enabled = false;
        m_FreqText5.enabled = false;
        m_FreqText6.enabled = false;
        m_FreqText7.enabled = false;
        m_FreqPeriodText.enabled = false;
        m_Freq1panel.SetActive(false);
        m_Freq2panel.SetActive(false);
        m_Freq3panel.SetActive(false);
        m_Freq4panel.SetActive(false);
        m_Freq5panel.SetActive(false);
        m_Freq6panel.SetActive(false);
        m_Freq7panel.SetActive(false);
    }

    public void HideCursorPanels()
    {
        m_Freq1panel.SetActive(false);
        m_Freq2panel.SetActive(false);
        m_Freq3panel.SetActive(false);
        m_Freq4panel.SetActive(false);
        m_Freq5panel.SetActive(false);
        m_Freq6panel.SetActive(false);
        m_Freq7panel.SetActive(false);
        m_IDCursor1.SetActive(false);
        m_IDCursor2.SetActive(false);
        m_DescritpionCursor1.SetActive(false);
        m_DescritpionCursor2.SetActive(false);
        m_DescritpionCursor3.SetActive(false);
        m_DescritpionCursor4.SetActive(false);
        m_DescritpionCursor5.SetActive(false);
        m_DescritpionCursor6.SetActive(false);
        m_DescritpionCursor7.SetActive(false);
        m_DescritpionCursor8.SetActive(false);
        m_DescritpionCursor9.SetActive(false);
    }

    public void ClearFreqInputCharacters()
    {
        m_ButtonOutput = "0";
        m_FreqText1.text = "0";
        m_FreqText2.text = "0";
        m_FreqText3.text = "0";
        m_FreqText4.text = "0";
        m_FreqText5.text = "0";
        m_FreqText6.text = "0";
        m_FreqText7.text = "0";
        m_SelectedInputCharacter = 1;
    }




    #endregion

    #region Seperating list to Strings and Seperating String components - Loading Presets

    // --------------------------------------------------------------- Pull Current Freq --------------------------------------------------------

    public void GetFreqListItem()
    {
        char[] gatherString;
        gatherString = m_FreqList[m_ListNumber].ToCharArray();
        
        if (m_listFreqStringSeperated.Count > 1)
        {
           m_listFreqStringSeperated.Clear();
        }

        for (int i = 0; i < gatherString.Length ; i++)
        {
            m_listFreqStringSeperated.Add(gatherString[i].ToString());
        }

        if (m_listFreqStringSeperated.Count > 1)
        {
            UpdateFreqText();
        }

    }

    public void UpdateFreqText()
    {
        m_ButtonOutput = m_listFreqStringSeperated[m_SelectedInputCharacter - 1];
        Debug.Log("Current Cursor # should be - " + m_ButtonOutput);
        m_FreqText1.text = m_listFreqStringSeperated[0];
        m_FreqText2.text = m_listFreqStringSeperated[1];
        m_FreqText3.text = m_listFreqStringSeperated[2];
        m_FreqText4.text = m_listFreqStringSeperated[3];
        m_FreqText5.text = m_listFreqStringSeperated[4];
        m_FreqText6.text = m_listFreqStringSeperated[5];
        m_FreqText7.text = m_listFreqStringSeperated[6];
    }



    // --------------------------------------------------------------- Pull Current ID ----------------------------------------------------------

    public void GetIDListItem()
    {
        char[] gatherString;
        gatherString = m_FreqList[m_ListNumber].ToCharArray();
       
        if (m_IDlistItemStringSeperated.Count > 1)
        {
            m_IDlistItemStringSeperated.Clear();
        }

        for (int i = 0; i < gatherString.Length; i++)
        {
            m_IDlistItemStringSeperated.Add(gatherString[i].ToString());
        }

        if (m_IDlistItemStringSeperated.Count > 1)
        {
            UpdateIDText();
        }

    }


    public void UpdateIDText()
    {
        m_ButtonOutput = m_IDlistItemStringSeperated[m_SelectedInputCharacter - 1];
        Debug.Log("Current Cursor # should be - " + m_ButtonOutput);
        m_IDNumber1.text = m_IDlistItemStringSeperated[0];
        m_IDNumber2.text = m_IDlistItemStringSeperated[1];
    }

    // -----------------------------------------------------------  Pull Current Description ----------------------------------------------------

    public void GetDescriptionListItem()
    {
        char[] gatherString;
        gatherString = m_DescriptionList[m_ListNumber].ToCharArray();

        if (m_listDescricptionStringSeperated.Count > 1)
        {
            m_listDescricptionStringSeperated.Clear();
        }

        for (int i = 0; i < gatherString.Length; i++)
        {
            m_listDescricptionStringSeperated.Add(gatherString[i].ToString());
        }

        if (m_listDescricptionStringSeperated.Count > 1)
        {
            UpdateDescriptionText();
        }

    }

    public void UpdateDescriptionText()
    {
        m_ButtonOutput = m_listDescricptionStringSeperated[m_SelectedInputCharacter - 1];
        Debug.Log("Current Cursor # should be - " + m_ButtonOutput);
        m_DescriptionText1.text = m_listDescricptionStringSeperated[0];
        m_DescriptionText2.text = m_listDescricptionStringSeperated[1];
        m_DescriptionText3.text = m_listDescricptionStringSeperated[2];
        m_DescriptionText4.text = m_listDescricptionStringSeperated[3];
        m_DescriptionText5.text = m_listDescricptionStringSeperated[4];
        m_DescriptionText6.text = m_listDescricptionStringSeperated[5];
        m_DescriptionText7.text = m_listDescricptionStringSeperated[6];
        m_DescriptionText8.text = m_listDescricptionStringSeperated[7];
        m_DescriptionText9.text = m_listDescricptionStringSeperated[8];
    }

    #endregion

    #region Preset ID, Description and Freq functions

    public void ScrollPresets()
    {


    }

    #endregion

    #region Mode and function Resets

    public void FullModeReset()
    {
        m_ProgramMode = true;
        m_AlphabetMode = false;
        m_NumericMode = false;
        m_FrequencyMode = false;
        m_FreqInputReq = false;
        m_IDRequired = false;
        m_DescriptionRequired = false;
    }

    #endregion

    #region Control Panel, On/OFF Button, KTC- L500 Sheet and Return to Main Menu Buttons

    public void ShowControlPanel()
    {
        m_ControlPanel.SetActive(true);
        m_ControlPanelHidden = false;
    }

    public void HideControlPanel()
    {
        if (m_ControlPanelHidden == false)
        {
            m_ControlPanel.SetActive(false);
            m_ControlPanelHidden = true;
        }
        else
        {
            ShowControlPanel();
        }
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("courseSelectionScene", LoadSceneMode.Single);
    }

    public void KTCL500Sheet()
    {
        if (m_KTC500Displayed == true && m_KTCL500Image == 1)
        {
            m_KTCL500Image = 0;
            m_KTC500Panel.enabled = false;
            m_KTC500Panel.sprite = m_KTC500ImageArray[m_KTCL500Image];
            return;
        }

        if (m_KTC500Displayed == true && m_KTCL500Image == 0)
        {
            m_KTCL500Image = 2;
            m_KTC500Panel.sprite = m_KTC500ImageArray[m_KTCL500Image];
            return;
        }


        if (m_KTC500Displayed == false)
        {
            m_KTCL500Image = 0;
            m_KTC500Panel.enabled = true;
            m_KTC500Panel.sprite = m_KTC500ImageArray[m_KTCL500Image];
            return;
        }



    }

    #endregion


    #region Program Mode / Changing Screens

    public void  ChangeScreenMain(int MenuNumber)
    {
        m_DisplayScreenImage.sprite = m_MainMenuSprites[MenuNumber];
    }

    public void ChangeToModeMenu(int ModeMenuNumber)
    {
        m_DisplayScreenImage.sprite = m_ModeMenuSprites[m_ModeMenuScreen];
    }

    public void ChangeToSquelchMenu(int SquelchMenuNumber)
    {
        m_DisplayScreenImage.sprite = m_SquelchMenuSprites[m_SquelchMenuScreen];
    }

    public void ChangeToZeroizeMenu(int ZeroizeMenuNumber)
    {
        m_DisplayScreenImage.sprite = m_ZeroizeMenuSprites[m_ZeroizeMenuScreen];
    }

    public void ChangeToOptionsMenu(int OptionsMenuNumber)
    {
        m_DisplayScreenImage.sprite = m_OptionsMenuSprites[m_OptionsMenuScreen];
    }

    public void ChangeToProgramMenu(int ProgramMenuNumber)
    {
        m_DisplayScreenImage.sprite = m_ProgramMenuSprites[m_ProgramMenuScreen];
    }
    #endregion


}
