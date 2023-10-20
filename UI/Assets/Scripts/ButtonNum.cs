using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ButtonNum : MonoBehaviour
{
    public static Dictionary<int,GameObject > PanelValue=new Dictionary<int,GameObject >();
    public  int index;
    public static int BtnNum;
    public  GameObject Panel;
    private void Start()
    {
        BtnNum = index;
        PanelValue.Add(index,Panel);
    }
}
