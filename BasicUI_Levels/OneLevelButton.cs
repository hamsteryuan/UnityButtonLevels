using UnityEngine;
using UnityEngine.UI;  // 引入UI命名空间
using TMPro;  
using UnityEngine.EventSystems;  // 引入事件系统命名空间
//有关于第一层元素的颜色与选中控制
//注意，任何函数请前往ButtonListner
public class OneLevelButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Color normalColor = Color.gray;  // 正常状态的颜色（灰色）
    public Color hoverColor = Color.yellow; // 鼠标悬停时的颜色（黄色）
    public Color selectedColor = Color.red; // 选中状态的颜色（红色）

    private Image buttonImage;  // 按钮的Image组件
    private TMP_Text buttonText;  // 按钮的文本组件（TextMesh Pro）
    private bool isSelected = false; // 选中状态
    private OneLevelButton[] allButtons; // 所有按钮的引用

    // 新增字段，用于存储按钮的点击事件
    public System.Action OnButtonClick;

    void Awake()
    {
        // 获取按钮的Image组件
        buttonImage = GetComponent<Image>();
        // 获取子物体中的 TMP_Text 组件
        buttonText = GetComponentInChildren<TMP_Text>();  

        // 错误检查：确保按钮的文本组件存在
        if (buttonText == null)
        {
            Debug.LogError("TMP_Text component not found in button prefab.");
        }

        // 获取场景中所有 OneLevelButton 组件
        allButtons = FindObjectsOfType<OneLevelButton>();

        // 初始时设置按钮颜色为正常颜色
        buttonImage.color = normalColor;
    }

    // 鼠标进入按钮区域时调用
    public void OnPointerEnter(PointerEventData eventData)
    {
        // 如果按钮未选中，鼠标悬停时改变颜色为黄色
        if (!isSelected)
        {
            buttonImage.color = hoverColor;
        }
    }

    // 鼠标离开按钮区域时调用
    public void OnPointerExit(PointerEventData eventData)
    {
        // 如果按钮未选中，恢复为正常颜色
        if (!isSelected)
        {
            buttonImage.color = normalColor;
        }
    }

    // 按钮点击时调用
    public void OnPointerClick(PointerEventData eventData)
    {
        // 点击新按钮时，首先取消所有按钮的选中状态并恢复为正常颜色
        foreach (OneLevelButton button in allButtons)
        {
            if (button != this)  // 不影响当前点击的按钮
            {
                button.isSelected = false;  // 取消选中状态
                button.buttonImage.color = normalColor;  // 恢复为正常颜色
            }
        }

        // 只有点击的按钮会变为选中状态，变红色
        if (!isSelected)
        {
            isSelected = true;
            buttonImage.color = selectedColor;  // 改为红色
        }
        else
        {
            // 如果按钮已经是选中的状态，则取消选中
            isSelected = false;
            buttonImage.color = normalColor;  // 恢复为灰色
        }

        // 执行按钮的点击事件（如果有的话）
        OnButtonClick?.Invoke();
    }

    // 设置按钮文本
    public void SetButtonText(string text)
    {
        if (buttonText != null)
        {
            buttonText.text = text;
        }
        else
        {
            Debug.LogError("TMP_Text component is not assigned.");
        }
    }
}