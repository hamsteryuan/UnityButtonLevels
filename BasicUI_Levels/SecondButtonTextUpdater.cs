using UnityEngine;
using TMPro;  // 引入TextMeshPro命名空间
using UnityEngine.UI;
//这个是用来控制点击二级界面后三级界面的改变
public class SecondButtonTextUpdater : MonoBehaviour
{
    public Button button1_third;
    public Button button2_third;
    public Button button3_third;
    public Button button4_third;
    public Button button5_third;

    // 五个按钮对应的TextMeshPro文本
    public TextMeshProUGUI buttonText1_third;
    public TextMeshProUGUI buttonText2_third;
    public TextMeshProUGUI buttonText3_third;
    public TextMeshProUGUI buttonText4_third;
    public TextMeshProUGUI buttonText5_third;

    // 更新按钮文本并控制其显示或隐藏
    public void UpdateButtonTexts(string text1, string text2, string text3, string text4, string text5)
    {
        // 处理第一个按钮
        if (!string.IsNullOrEmpty(text1))
        {
            buttonText1_third.text = text1;
            button1_third.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button1_third.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第二个按钮
        if (!string.IsNullOrEmpty(text2))
        {
            buttonText2_third.text = text2;
            button2_third.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button2_third.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第三个按钮
        if (!string.IsNullOrEmpty(text3))
        {
            buttonText3_third.text = text3;
            button3_third.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button3_third.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第四个按钮
        if (!string.IsNullOrEmpty(text4))
        {
            buttonText4_third.text = text4;
            button4_third.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button4_third.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第五个按钮
        if (!string.IsNullOrEmpty(text5))
        {
            buttonText5_third.text = text5;
            button5_third.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button5_third.gameObject.SetActive(false);  // 隐藏按钮
        }
    }
}
