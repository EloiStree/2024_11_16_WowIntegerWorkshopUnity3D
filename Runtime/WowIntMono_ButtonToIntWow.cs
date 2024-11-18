using UnityEngine;

namespace Eloi.Wow
{
    public class WowIntMono_ButtonToIntWow : MonoBehaviour {     
        public WowIntegerMono m_player;
        public IntWowEnum m_downAction= 0;
        public IntWowEnum m_upAction = 0;

        public bool m_isDown = false;
        public bool m_isDownPrevious = false;
        public IntWowEnum m_lastSent = 0;

        public void SetIsDown(bool value)
        {
            m_isDownPrevious = m_isDown;
            m_isDown = value;
            if (m_isDownPrevious != m_isDown)
            {
                if (m_isDown)
                {
                    m_lastSent = m_downAction;
                    m_player.SendIntegerToTarget((int)m_downAction);
                }
                else
                {
                    m_lastSent = m_upAction;
                    m_player.SendIntegerToTarget((int)m_upAction);
                }
            }
        }
    }

}