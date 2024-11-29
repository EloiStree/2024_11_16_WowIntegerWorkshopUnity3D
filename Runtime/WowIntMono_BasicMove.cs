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

        public int m_moveUpStart = 1032;
        public int m_moveUpStop = 2032;
        public int m_moveDownStart = 1067;
        public int m_moveDownStop = 2067;
        public int m_tabStart = 1009;
        public int m_tabStop = 2009;
        public int m_interactionStart= 1070;
        public int m_interactionStop= 2070;
        public int m_power1Start = 1048;
        public int m_power1Stop = 2048;
        public int m_power2Start = 1049;
        public int m_power2Stop = 2049;
        public int m_power3Start = 1050;
        public int m_power3Stop = 2050;
        public int m_power4Start = 1051;
        public int m_power4Stop = 2051;
        public int m_power5Start = 1052;
        public int m_power5Stop = 2052;
        public int m_power6Start = 1053;
        public int m_power6Stop = 2053;
        public int m_power7Start = 1054;
        public int m_power7Stop = 2054;
        public int m_power8Start = 1055;
        public int m_power8Stop = 2055;
        public int m_power9Start = 1056;
        public int m_power9Stop = 2056;



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
        public void StartPower2() => m_player.SendIntegerToTarget(m_power2Start);
        public void StopPower2() => m_player.SendIntegerToTarget(m_power2Stop);
        public void StartPower3() => m_player.SendIntegerToTarget(m_power3Start);
        public void StopPower3() => m_player.SendIntegerToTarget(m_power3Stop);
        public void StartPower4() => m_player.SendIntegerToTarget(m_power4Start);
        public void StopPower4() => m_player.SendIntegerToTarget(m_power4Stop);
        public void StartPower5() => m_player.SendIntegerToTarget(m_power5Start);
        public void StopPower5() => m_player.SendIntegerToTarget(m_power5Stop);
        public void StartPower6() => m_player.SendIntegerToTarget(m_power6Start);
        public void StopPower6() => m_player.SendIntegerToTarget(m_power6Stop);
        public void StartPower7() => m_player.SendIntegerToTarget(m_power7Start);
        public void StopPower7() => m_player.SendIntegerToTarget(m_power7Stop);
        public void StartPower8() => m_player.SendIntegerToTarget(m_power8Start);
        public void StopPower8() => m_player.SendIntegerToTarget(m_power8Stop);
        public void StartPower9() => m_player.SendIntegerToTarget(m_power9Start);
        public void StopPower9() => m_player.SendIntegerToTarget(m_power9Stop);



        public void TriggerPower1() { StartPower1(); StopPower1(); }
        public void TriggerTab() { StartTab(); StopTab(); }
        public void TriggerJump() { StartJump(); StopJump(); }

        public void StartMovingDown()=> m_player.SendIntegerToTarget(m_moveDownStart);
        public void StopMovingDown() => m_player.SendIntegerToTarget(m_moveDownStop);
        public void StartMovingUp() => m_player.SendIntegerToTarget(m_moveUpStart);
        public void StopMovingUp() => m_player.SendIntegerToTarget(m_moveUpStop);


    }



}
