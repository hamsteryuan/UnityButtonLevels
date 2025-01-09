using UnityEngine;
using UnityEngine.UI;
//这是第二层的界面按钮点击事件集
public class SecondListener : MonoBehaviour
{
    public LevelManager levelManager;
    public SecondButtonTextUpdater secondbuttonTextUpdater;

    private bool button1Selected = false;
    private bool button2Selected = false;
    public GameObject thirdlevelgroup;
    public GameObject fourthlevelgroup;
    public GameObject fifthlevelgroup;
    private int lastSelectedButton = -1;  // -1表示没有按钮被选中

    public Button SecondButton1; 
    public Button SecondButton2; 

    private int PageOneCondition; //第一层的序号是多少
    public ThirdListener thirdlistner;

    //这些按钮实际意思是要看第一层给的定义
    //这里留地方作为目录注释
    void Start()
    {
        // 为按钮添加点击事件监听器
        SecondButton1.onClick.AddListener(() => ToggleButton(1));
        SecondButton2.onClick.AddListener(() => ToggleButton(2));
        HideThirdLevelGroup();
       
    }
    private void ShowThirdLevelGroup()
    {
        if (thirdlevelgroup != null)
        {
            thirdlevelgroup.SetActive(true);
        }
    }

    private void HideThirdLevelGroup()
    {
        lastSelectedButton=-1;
        thirdlistner.ThirdClearButtons();
        if (fifthlevelgroup != null)
        {
            thirdlevelgroup.SetActive(false);
        }
        if (fourthlevelgroup != null)
        {
            fourthlevelgroup.SetActive(false);
        }
       
        if (thirdlevelgroup != null)
        {
            thirdlevelgroup.SetActive(false);
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
        levelManager.SetSecondLevel(1);
        ShowThirdLevelGroup();
        PageOneCondition=levelManager.GetFirstLevel();
        if(PageOneCondition==1){
            secondbuttonTextUpdater.UpdateButtonTexts("某某某", "耶耶耶", "hhh", "", "");
        }
        if(PageOneCondition==2){
            secondbuttonTextUpdater.UpdateButtonTexts("待定", "待定", "", "", "");
        }
    }
    private void Button1Unselected()
    {   
        
        levelManager.SetSecondLevel(0);
        HideThirdLevelGroup();
    }

    private void Button2Selected()
    {   
        levelManager.SetSecondLevel(2);
        ShowThirdLevelGroup();
        PageOneCondition=levelManager.GetFirstLevel();
        if(PageOneCondition==1){
        secondbuttonTextUpdater.UpdateButtonTexts("lucky", "lucky", "lucky!", "", "");
        //Debug.Log("SecondLevel is set to: " + levelManager.GetSecondLevel());
        }
    }
    private void Button2Unselected()
    {   
        button1Selected=false;
        levelManager.SetSecondLevel(0);
        HideThirdLevelGroup();
    }

    public void SecondClearButtons()
    {   
        button1Selected=false;
        button2Selected=false;
        lastSelectedButton=-1;
        thirdlistner.ThirdClearButtons();
    }

}