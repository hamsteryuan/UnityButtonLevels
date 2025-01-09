using UnityEngine;
using UnityEngine.UI;
//这是第一层的界面按钮点击事件集
public class ButtonToggle : MonoBehaviour
{
    // 存储按钮的选中状态
    public LevelManager levelManager;
    public ButtonTextUpdater buttonTextUpdater;
    public Atomospheres atomosphere;
    private bool button1Selected = false;
    private bool button2Selected = false;
    private bool button3Selected = false;

    public GameObject secondlevelgroup;
    public GameObject thirdlevelgroup;
    public GameObject fifthlevelgroup;
    public GameObject fourthlevelgroup;
    public SecondListener secondlister;

    

    // 存储上一个选中的按钮
    private int lastSelectedButton = -1;  // -1表示没有按钮被选中

    // 按钮引用
    public Button button1; //建设
    public Button button2; //运营
    public Button button3;

    void Start()
    {
        // 为按钮添加点击事件监听器
        button1.onClick.AddListener(() => ToggleButton(1));
        button2.onClick.AddListener(() => ToggleButton(2));
        button3.onClick.AddListener(() => ToggleButton(3));
        HideSecondLevelGroup();
        lastSelectedButton=-1;
        levelManager.SetFirstLevel(0);
        levelManager.SetSecondLevel(0);
        levelManager.SetThirdLevel(0);
        levelManager.SetFourthLevel(0);

    }

    private void ShowSecondLevelGroup()
    {
        if (secondlevelgroup != null)
        {
            secondlevelgroup.SetActive(true);
        }

    }

    private void HideSecondLevelGroup()
    {
        secondlister.SecondClearButtons();
        if (secondlevelgroup != null)
        {
            secondlevelgroup.SetActive(false);
        }
        if (thirdlevelgroup != null)
        {
            thirdlevelgroup.SetActive(false);
        }
        if (fourthlevelgroup != null)
        {
            fourthlevelgroup.SetActive(false);
        }
        if (fifthlevelgroup != null)
        {
            fifthlevelgroup.SetActive(false);
        }
    }

    // 切换按钮状态并调用相应的函数
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
            // case 3:
            //     button3Selected = !button3Selected;
            //     if (button3Selected)
            //         Button3Selected();
            //     else
            //         Button3Unselected();
            //     break;
        }

        // 更新上一个选中的按钮
        lastSelectedButton = buttonNumber;
    }

    // 取消上一个选中的按钮的选中状态
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

    // 按钮1被选中时调用的函数
    private void Button1Selected()
    {
        levelManager.SetFirstLevel(1);
        ShowSecondLevelGroup();
        atomosphere.ShowImage1();//氛围灯插入，当然这里也可以加别的触发的函数
        buttonTextUpdater.UpdateButtonTexts("AAA",  "BBB", "CCC", "DDD", "");
    }

    // 按钮1取消选中时调用的函数
    private void Button1Unselected()
    {
        levelManager.SetFirstLevel(0);
        HideSecondLevelGroup();
        atomosphere.HideAllImages();
    }

    // 按钮2被选中时调用的函数
    private void Button2Selected()
    {   
        levelManager.SetFirstLevel(2);
        ShowSecondLevelGroup();
        buttonTextUpdater.UpdateButtonTexts("AAA", "BBB", "CCC", "DDD", "");
        //这里有个空代表会有一个按钮不显示
        atomosphere.ShowImage2();
        //Debug.Log("FirstLevel is set to: " + levelManager.GetFirstLevel());
    }

    // 按钮2取消选中时调用的函数
    private void Button2Unselected()
    {   
        levelManager.SetFirstLevel(0);
        HideSecondLevelGroup();
        atomosphere.HideAllImages();
    }
    //其它按钮点击中和取消也相应如上

}