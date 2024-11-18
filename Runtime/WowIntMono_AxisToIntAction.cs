using Eloi.Wow;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.Wow
{

    public class WowIntMono_AxisToIntAction : MonoBehaviour
{

    public WowIntegerMono m_player;
    [Header("Configuration")]
    [Range(-1, 1)]
    public float m_deathZone = 0.8f;
    public int m_enterLeftZone = 1081;
    public int m_exitLeftZone = 2081;
    public int m_enterRightZone = 1068;
    public int m_exitRightZone = 2068;

    [Header("Debug")]
    [Range(-1, 1)]
    public float m_axisValue = 0;
    public bool m_isLeftState = false;
    public bool m_isLeftStatePrevious = false;
    public bool m_isRightState = false;
    public bool m_isRightStatePrevious = false;

    public int m_lastSentInteger = 0;

    public void SetAxisValue(float value)
    {

        m_axisValue = value;
        CheckAxisState();
    }

    private void CheckAxisState()
    {
        m_isLeftStatePrevious = m_isLeftState;
        m_isLeftState = m_axisValue < -m_deathZone;
        if (m_isLeftStatePrevious != m_isLeftState)
        {
            if (m_isLeftState)
            {
                m_lastSentInteger = m_enterLeftZone;
                m_player.SendIntegerToTarget(m_enterLeftZone);
            }
            else
            {
                m_lastSentInteger = m_enterLeftZone;
                m_player.SendIntegerToTarget(m_exitLeftZone);
            }
        }

        m_isRightStatePrevious = m_isRightState;
        m_isRightState = m_axisValue > m_deathZone;
        if (m_isRightStatePrevious != m_isRightState)
        {
            if (m_isRightState)
            {
                m_lastSentInteger = m_enterLeftZone;
                m_player.SendIntegerToTarget(m_enterRightZone);
            }
            else
            {
                m_lastSentInteger = m_enterLeftZone;
                m_player.SendIntegerToTarget(m_exitRightZone);
            }
        }
    }
}

}