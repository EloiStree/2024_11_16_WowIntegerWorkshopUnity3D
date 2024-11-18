using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Eloi.Wow
{

    public class WowIntMono_AxisToIntWowEnumAction : MonoBehaviour
{

    public WowIntegerMono m_player;
    [Header("Configuration")]
    [Range(-1, 1)]
    public float m_deathZone = 0.8f;
    public IntWowEnum m_enterLeftZone = 0;
    public IntWowEnum m_exitLeftZone = 0;
    public IntWowEnum m_enterRightZone = 0;
    public IntWowEnum m_exitRightZone = 0;

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
                m_lastSentInteger = (int)m_enterLeftZone;
                m_player.SendIntegerToTarget((int)m_enterLeftZone);
            }
            else
            {
                m_lastSentInteger = (int)m_enterLeftZone;
                m_player.SendIntegerToTarget((int)m_exitLeftZone);
            }
        }

        m_isRightStatePrevious = m_isRightState;
        m_isRightState = m_axisValue > m_deathZone;
        if (m_isRightStatePrevious != m_isRightState)
        {
            if (m_isRightState)
            {
                m_lastSentInteger = (int)m_enterLeftZone;
                m_player.SendIntegerToTarget((int)m_enterRightZone);
            }
            else
            {
                m_lastSentInteger = (int)m_enterLeftZone;
                m_player.SendIntegerToTarget((int)m_exitRightZone);
            }
        }
    }
}

}