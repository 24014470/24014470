using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject[] panel;
    private int  index;
    private int i;
    private GameObject TruePanel;
    void NextPanel()
    {
       
    }

     public void PanelActive(int index)
    {
        for (i = 0; i < transform.childCount; i++)
        {
            panel[i].SetActive(false);
        }
        ButtonNum.PanelValue.TryGetValue(index,out TruePanel);
        TruePanel.SetActive(true);
    }
    void PrevPanel()
    {
        for(i=0;i<transform.childCount;i++)
        {
            panel[i].SetActive(false);
        }

    }
    public void End()
    {
        //�˳���Ϸ
#if UNITY_EDITOR  //��  �༭��ģʽ���˳���Ϸ
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif

    }
}
