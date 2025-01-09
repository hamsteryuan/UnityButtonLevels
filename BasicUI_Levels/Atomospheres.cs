using UnityEngine;
using UnityEngine.UI;


public class Atomospheres : MonoBehaviour
{
    //这里认为用一张透明程度很高的image就代表氛围灯，只是举一个按钮触发事件的例子
    void Start()
    {
        HideAllImages();
    }
    public Image image1;
    public Image image2;
    public Image image3;

    public void ShowImage1()
    {
        image1.gameObject.SetActive(true);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
    }

    public void ShowImage2()
    {
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(true);
        image3.gameObject.SetActive(false);
    }

    public void ShowImage3()
    {
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(true);
    }

    public void HideAllImages()
    {
        image1.gameObject.SetActive(false);
        image2.gameObject.SetActive(false);
        image3.gameObject.SetActive(false);
    }
}
