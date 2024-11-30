using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Eloi.Wow;

public class WowIntMono_EnumList : MonoBehaviour
{

    [Header("Enum To Integer")]
    public IntWowEnum m_selected;
    public int m_pressed;
    public int m_released;

    [Header("Integer To Enum")]
    public int m_integerValue;
    public IntWowEnum m_enumValue;

    private void OnValidate()
    {
        int value = (int)m_selected;
        if (value==0)
        {
            m_pressed = 0;
            m_released = 0;
        }
        else if(((int)value/1000)==1)
        {
            m_pressed = value;
            m_released = value+1000;

        }
        else
        {
            m_pressed = value-1000;
            m_released = value;
        }

        try { 
        m_enumValue = (IntWowEnum)m_integerValue;
        }catch(System.Exception)
        {
            m_enumValue= IntWowEnum.None;
        }

    }
    
}
