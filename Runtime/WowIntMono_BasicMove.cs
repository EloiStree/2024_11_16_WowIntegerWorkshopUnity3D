using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.Wow
{
    public class WowIntMono_BasicMove : MonoBehaviour
{


    public WowIntegerMono m_player;

    public int m_jumpStart = 1032;
    public int m_jumpEnd = 2032;

    public int m_moveForwardStart = 1090;
    public int m_moveForwardStop = 2090;

    public int m_moveBackStart = 1083;
    public int m_moveBackStop = 2083;

    public int m_moveLeftStart = 1087;
    public int m_moveLeftStop = 2087;
    
    public int m_moveRightStart = 1088;
    public int m_moveRightStop = 2088;
    
    public int m_rotateLeftStart = 1081;
    public int m_rotateLeftStop = 2081;

    public int m_rotateRightStart = 1068;
    public int m_rotateRightStop = 2068;


    public int m_tabStart = 1009;
    public int m_tabStop = 2009;


    public int m_power1Start = 1048;
    public int m_power1Stop = 2048;



        public void StartMovingLeft() => m_player.SendIntegerToTarget(m_moveLeftStart);
        public void StopMovingLeft() => m_player.SendIntegerToTarget(m_moveLeftStop);
        public void StartMovingRight() => m_player.SendIntegerToTarget(m_moveRightStart);
        public void StopMovingRight() => m_player.SendIntegerToTarget(m_moveRightStop);
        public void StartMovingForward() => m_player.SendIntegerToTarget(m_moveForwardStart);
        public void StopMovingForward() => m_player.SendIntegerToTarget(m_moveForwardStop);
        public void StartMovingBackward() => m_player.SendIntegerToTarget(m_moveBackStart);
        public void StopMovingBackward() => m_player.SendIntegerToTarget(m_moveBackStop);
        public void StartRotatingLeft() => m_player.SendIntegerToTarget(m_rotateLeftStart);
        public void StopRotatingLeft() => m_player.SendIntegerToTarget(m_rotateLeftStop);
        public void StartRotatingRight() => m_player.SendIntegerToTarget(m_rotateRightStart);
        public void StopRotatingRight() => m_player.SendIntegerToTarget(m_rotateRightStop);
        public void StartJump() => m_player.SendIntegerToTarget(m_jumpStart);
        public void StopJump() => m_player.SendIntegerToTarget(m_jumpEnd);
        public void StartTab() => m_player.SendIntegerToTarget(m_tabStart);
        public void StopTab() => m_player.SendIntegerToTarget(m_tabStop);
        public void StartPower1() => m_player.SendIntegerToTarget(m_power1Start);
        public void StopPower1() => m_player.SendIntegerToTarget(m_power1Stop);


        public void TriggerPower1() { StartPower1(); StopPower1(); }
        public void TriggerTab() { StartTab(); StopTab(); }
        public void TriggerJump() { StartJump(); StopJump(); }
    }



}
