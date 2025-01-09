//这是一个很重要的文件
//任何涉及到4级界面按钮的操作
//都需要set和get这里面的变量来决定
//到底是在用什么
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private int firstLevel;
    private int secondLevel;
    private int thirdLevel;
    private int fourthLevel;

    // 获取 firstLevel 的方法
    public int GetFirstLevel()
    {
        return firstLevel;
    }

    // 设置 firstLevel 的方法
    public void SetFirstLevel(int value)
    {
        firstLevel = value;
    }

    // 获取 secondLevel 的方法
    public int GetSecondLevel()
    {
        return secondLevel;
    }

    // 设置 secondLevel 的方法
    public void SetSecondLevel(int value)
    {
        secondLevel = value;
    }

    // 获取 thirdLevel 的方法
    public int GetThirdLevel()
    {
        return thirdLevel;
    }

    // 设置 thirdLevel 的方法
    public void SetThirdLevel(int value)
    {
        thirdLevel = value;
    }

    // 获取 fourthLevel 的方法
    public int GetFourthLevel()
    {
        return fourthLevel;
    }

    // 设置 fourthLevel 的方法
    public void SetFourthLevel(int value)
    {
        fourthLevel = value;
    }
}