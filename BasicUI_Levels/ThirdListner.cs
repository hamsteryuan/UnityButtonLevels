using UnityEngine;
using UnityEngine.UI;
//这是第三层的界面按钮点击事件集
public class ThirdListener : MonoBehaviour
{
    public LevelManager levelManager;
    public ThirdButtonTextUpdater thirdbuttonTextUpdater;

    private bool button1Selected = false;
    private bool button2Selected = false;
    public GameObject fourthlevelgroup;

    public GameObject fifthlevelgroup;
    private int lastSelectedButton = -1;  // -1表示没有按钮被选中

    public Button ThirdButton1; 
    public Button ThirdButton2; 

    private int PageOneCondition; //第一层的序号是多少
    private int PageTwoCondition;
    public FourthListner fourthlistner;

    //这些按钮实际意思是要看第一层给的定义
    //这里留地方作为目录注释
    void Start()
    {
        // 为按钮添加点击事件监听器
        ThirdButton1.onClick.AddListener(() => ToggleButton(1));
        ThirdButton2.onClick.AddListener(() => ToggleButton(2));
        HideFourthLevelGroup();
       
    }
    private void ShowFourthLevelGroup()
    {
        if (fourthlevelgroup != null)
        {
            fourthlevelgroup.SetActive(true);
        }
       
    }

    private void HideFourthLevelGroup()
    {   
        fourthlistner.FourthClearButtons();

        if (fourthlevelgroup != null)
        {
            fourthlevelgroup.SetActive(false);
        }
        if (fifthlevelgroup != null)
        {
            fifthlevelgroup.SetActive(false);
        }
    }
    
    private void ToggleButton(int buttonNumber)
    {
        // 如果当前点击的按钮与上一个点击的按钮不相同，先取消上一个按钮的选中状态
        if (lastSelectedButton != -1 && lastSelectedButton != buttonNumber)
        {
            CancelLastSelectedButton(lastSelectedButton);
        }

        // 切换当前按钮的状态
        switch (buttonNumber)
        {
            case 1:
                button1Selected = !button1Selected;
                if (button1Selected)
                    Button1Selected();
                else
                    Button1Unselected();
                break;
            case 2:
                button2Selected = !button2Selected;
                if (button2Selected)
                    Button2Selected();
                else
                    Button2Unselected();
                break;
            
        }
        lastSelectedButton = buttonNumber;
    }

    private void CancelLastSelectedButton(int buttonNumber)
    {
        switch (buttonNumber)
        {
            case 1:
                button1Selected = false;
                Button1Unselected();
                break;
            case 2:
                button2Selected = false;
                Button2Unselected();
                break;
  
        }
    }
    private void Button1Selected()
    {
        levelManager.SetThirdLevel(1);
        ShowFourthLevelGroup();
        PageOneCondition=levelManager.GetFirstLevel();
        PageTwoCondition=levelManager.GetSecondLevel();
        if(PageOneCondition==1&&PageTwoCondition==1){
            thirdbuttonTextUpdater.UpdateButtonTexts("其", "qita", "其它", "", "");
        }
        if(PageOneCondition==1&&PageTwoCondition==2){
            thirdbuttonTextUpdater.UpdateButtonTexts("待定", "待定", "", "", "");
        }
    }
    private void Button1Unselected()
    {
        levelManager.SetThirdLevel(0);
        HideFourthLevelGroup();
    }

    private void Button2Selected()
    {   
        levelManager.SetThirdLevel(2);
        ShowFourthLevelGroup();
        PageOneCondition=levelManager.GetFirstLevel();
        PageTwoCondition=levelManager.GetSecondLevel();
        if(PageOneCondition==1&&PageTwoCondition==1){
            thirdbuttonTextUpdater.UpdateButtonTexts("112", "112", "112", "112", "112");
        }
        if(PageOneCondition==1&&PageTwoCondition==2){
            thirdbuttonTextUpdater.UpdateButtonTexts("122", "122", "122", "", "");
        }
    }
    private void Button2Unselected()
    {   
        levelManager.SetThirdLevel(0);
        HideFourthLevelGroup();
    }

    public void ThirdClearButtons()
    {
        button1Selected=false;
        button2Selected=false;
        lastSelectedButton=-1;
        fourthlistner.FourthClearButtons();
    }
    
}