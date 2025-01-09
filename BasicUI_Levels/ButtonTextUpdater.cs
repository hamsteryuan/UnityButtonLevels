using UnityEngine;
using TMPro;  // 引入TextMeshPro命名空间
using UnityEngine.UI;
//这个是用来控制点击一级界面后二级界面的改变
public class ButtonTextUpdater : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;

    // 五个按钮对应的TextMeshPro文本
    public TextMeshProUGUI buttonText1;
    public TextMeshProUGUI buttonText2;
    public TextMeshProUGUI buttonText3;
    public TextMeshProUGUI buttonText4;
    public TextMeshProUGUI buttonText5;

    // 更新按钮文本并控制其显示或隐藏
    public void UpdateButtonTexts(string text1, string text2, string text3, string text4, string text5)
    {
        // 处理第一个按钮
        if (!string.IsNullOrEmpty(text1))
        {
            buttonText1.text = text1;
            button1.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button1.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第二个按钮
        if (!string.IsNullOrEmpty(text2))
        {
            buttonText2.text = text2;
            button2.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button2.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第三个按钮
        if (!string.IsNullOrEmpty(text3))
        {
            buttonText3.text = text3;
            button3.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button3.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第四个按钮
        if (!string.IsNullOrEmpty(text4))
        {
            buttonText4.text = text4;
            button4.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button4.gameObject.SetActive(false);  // 隐藏按钮
        }

        // 处理第五个按钮
        if (!string.IsNullOrEmpty(text5))
        {
            buttonText5.text = text5;
            button5.gameObject.SetActive(true);  // 显示按钮
        }
        else
        {
            button5.gameObject.SetActive(false);  // 隐藏按钮
        }
    }
}