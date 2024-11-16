using UnityEngine;

namespace Eloi.Wow
{
    public class WowIntMono_AxisToBasicMove : MonoBehaviour
    {
    public WowIntMono_BasicMove m_player;
    public float m_deathZone = 0.3f;

        public float m_moveLeftRightPercent = 0.5f;
    public float m_moveBackwardForwardPercent = 0.5f;
    public float m_rotateLeftRightPercent = 0.5f;

    public bool m_isMovingLeft;
    public bool m_isMovingRight;
    public bool m_isMovingForward;
    public bool m_isMovingBackward;
    public bool m_isRotatingLeft;
    public bool m_isRotatingRight;

    public void Update()
    {

        bool isMovingLeft = m_moveLeftRightPercent < -m_deathZone;
        bool isMovingRight = m_moveLeftRightPercent > m_deathZone;
        bool isMovingForward = m_moveBackwardForwardPercent > m_deathZone;
        bool isMovingBackward = m_moveBackwardForwardPercent < -m_deathZone;
        bool isRotatingLeft = m_rotateLeftRightPercent < -m_deathZone;
        bool isRotatingRight = m_rotateLeftRightPercent > m_deathZone;

        if (isMovingLeft != m_isMovingLeft)
        {
            m_isMovingLeft = isMovingLeft;
            if (m_isMovingLeft)
            {
                m_player.StartMovingLeft();
            }
            else
            {
                m_player.StopMovingLeft();
            }
        }

        if (isMovingRight != m_isMovingRight)
        {
            m_isMovingRight = isMovingRight;
            if (m_isMovingRight)
            {
                m_player.StartMovingRight();
            }
            else
            {
                m_player.StopMovingRight();
            }
        }

        if (isMovingForward != m_isMovingForward)
        {
            m_isMovingForward = isMovingForward;
            if (m_isMovingForward)
            {
                m_player.StartMovingForward();
            }
            else
            {
                m_player.StopMovingForward();
            }
        }

        if (isMovingBackward != m_isMovingBackward)
        {
            m_isMovingBackward = isMovingBackward;
            if (m_isMovingBackward)
            {
                m_player.StartMovingBackward();
            }
            else
            {
                m_player.StopMovingBackward();
            }
        }

        if (isRotatingLeft != m_isRotatingLeft)
        {
            m_isRotatingLeft = isRotatingLeft;
            if (m_isRotatingLeft)
            {
                m_player.StartRotatingLeft();
            }
            else
            {
                m_player.StopRotatingLeft();
            }
        }

        if (isRotatingRight != m_isRotatingRight)
        {
            m_isRotatingRight = isRotatingRight;
            if (m_isRotatingRight)
            {
                m_player.StartRotatingRight();
            }
            else
            {
                m_player.StopRotatingRight();
            }
        }


        
    }

    public void MoveBackwardForwardPercent(float percent11) { 
    
        m_moveBackwardForwardPercent = percent11;
    }
    public void MoveLeftRightPercent(float percent11)
    {

        m_moveLeftRightPercent = percent11;
    }
    public void RotateLeftRightPercent(float percent11)
    {

        m_rotateLeftRightPercent = percent11;
    }
}

}