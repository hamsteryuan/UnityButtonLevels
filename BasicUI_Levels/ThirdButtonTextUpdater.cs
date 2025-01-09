using UnityEngine;
using TMPro;  // 引入TextMeshPro命名空间
using UnityEngine.UI;
//这个是用来控制点击三级界面后四级界面的改变
public class ThirdButtonTextUpdater : MonoBehaviour
{
    public Button button1_fourth;
    public Button button2_fourth;
    public Button button3_fourth;
    public Button button4_fourth;
    public Button button5_fourth;

    // 五个按钮对应的TextMeshPro文本
    public TextMeshProUGUI buttonText1_fourth;
    public TextMeshProUGUI buttonText2_fourth;
    public TextMeshProUGUI buttonText3_fourth;
    public TextMeshProUGUI buttonText4_fourth;
    public TextMeshProUGUI buttonText5_fourth;

    // 更新按钮文本并控制其显示或隐藏
    public void UpdateButtonTexts(string text1, string text2, string text3, string text4, string text5)
    {
        // 处理第一个按钮
        if (!string.IsNullOrEmpty(text1))
        {
            buttonText1_fourth.text = text1;
            button1_fourth.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button1_fourth.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第二个按钮
        if (!string.IsNullOrEmpty(text2))
        {
            buttonText2_fourth.text = text2;
            button2_fourth.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button2_fourth.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第三个按钮
        if (!string.IsNullOrEmpty(text3))
        {
            buttonText3_fourth.text = text3;
            button3_fourth.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button3_fourth.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第四个按钮
        if (!string.IsNullOrEmpty(text4))
        {
            buttonText4_fourth.text = text4;
            button4_fourth.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button4_fourth.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第五个按钮
        if (!string.IsNullOrEmpty(text5))
        {
            buttonText5_fourth.text = text5;
            button5_fourth.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button5_fourth.gameObject.SetActive(false);  // 隐藏按钮
        }
    }
}
