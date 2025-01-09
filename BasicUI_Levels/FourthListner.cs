using UnityEngine;
using UnityEngine.UI;
//第四层按钮点击事件集，注意这里触发的第五层界面不是真的界面，而是非交互界面显示
public class FourthListner : MonoBehaviour
{
    public LevelManager levelManager;
    private bool button1Selected = false;
    private bool button2Selected = false;
    public GameObject fifthlevelgroup;
    private int lastSelectedButton = -1;  // -1表示没有按钮被选中
    public Button FourthButton1;
    public Button FourthButton2; 
    private int PageOneCondition; //第一层的序号是多少
    private int PageTwoCondition;
    private int PageThreeCondition;
    void Start()
    {
        // 为按钮添加点击事件监听器
        FourthButton1.onClick.AddListener(() => ToggleButton(1));
        FourthButton2.onClick.AddListener(() => ToggleButton(2));
        HideFifthLevelGroup();
       
    }
    //这里是没有fifth的，fifth是不定式的
    private void HideFifthLevelGroup()
    {
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
        levelManager.SetFourthLevel(1);
        //没有特定的show了
        PageOneCondition=levelManager.GetFirstLevel();
        PageTwoCondition=levelManager.GetSecondLevel();
        PageThreeCondition=levelManager.GetThirdLevel();
        //根据三个去决定
    }
    private void Button1Unselected()
    {
        levelManager.SetFourthLevel(0);
        HideFifthLevelGroup();
    }
    private void Button2Selected()
    {
        levelManager.SetFourthLevel(2);
        //没有特定的show了
        PageOneCondition=levelManager.GetFirstLevel();
        PageTwoCondition=levelManager.GetSecondLevel();
        PageThreeCondition=levelManager.GetThirdLevel();
        //根据三个去决定
    }
    private void Button2Unselected()
    {
        levelManager.SetFourthLevel(0);
        HideFifthLevelGroup();
    }
    
    public void FourthClearButtons()
    {
        button1Selected=false;
        button2Selected=false;
        lastSelectedButton=-1;
    }
    
}
