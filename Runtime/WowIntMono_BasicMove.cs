using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Eloi.Wow
{
    public class WowIntMono_BasicMove : MonoBehaviour
    {


        public WowIntegerMono m_player;
        public IntWowEnum m_moveForwardStart = IntWowEnum.Numpad8_P;
        public IntWowEnum m_moveForwardStop = IntWowEnum.Numpad8_R;

        public IntWowEnum m_moveBackStart = IntWowEnum.Numpad5_P;
        public IntWowEnum m_moveBackStop = IntWowEnum.Numpad5_R;

        public IntWowEnum m_moveLeftStart = IntWowEnum.Numpad1_P;
        public IntWowEnum m_moveLeftStop = IntWowEnum.Numpad1_R;

        public IntWowEnum m_moveRightStart = IntWowEnum.Numpad3_P;
        public IntWowEnum m_moveRightStop = IntWowEnum.Numpad3_R;

        public IntWowEnum m_rotateLeftStart = IntWowEnum.Numpad4_P;
        public IntWowEnum m_rotateLeftStop = IntWowEnum.Numpad4_R;

        public IntWowEnum m_rotateRightStart = IntWowEnum.Numpad6_P;
        public IntWowEnum m_rotateRightStop = IntWowEnum.Numpad6_R;

        public IntWowEnum m_moveUpStart = IntWowEnum.Numpad2_P;
        public IntWowEnum m_moveUpStop = IntWowEnum.Numpad2_R;

        public IntWowEnum m_moveDownStart = IntWowEnum.Numpad0_P;
        public IntWowEnum m_moveDownStop = IntWowEnum.Numpad0_R;

        public IntWowEnum m_tabStart = IntWowEnum.Tab_P;
        public IntWowEnum m_tabStop = IntWowEnum.Tab_R;

        public IntWowEnum m_interactionStart = IntWowEnum.Numpad7_P; // 
        public IntWowEnum m_interactionStop = IntWowEnum.Numpad7_R; // Numpad 7

        public IntWowEnum m_autoRunStart = IntWowEnum.Numpad8_P; // 
        public IntWowEnum m_autoRunStop = IntWowEnum.Numpad8_R; // 


        public IntWowEnum m_targetNearestEnemyStart = IntWowEnum.Multiply_P; // 
        public IntWowEnum m_targetNearestEnemyStop = IntWowEnum.Multiply_R; // 

        public IntWowEnum m_targetPreviousEnemyStart = IntWowEnum.Divide_P; // 
        public IntWowEnum m_targetPreviousEnemyStop = IntWowEnum.Divide_R; // 

        public IntWowEnum m_scanEnemyHoldStart = IntWowEnum.Subtract_P; // 
        public IntWowEnum m_scanEnemyHoldStop = IntWowEnum.Subtract_R; // 

        public IntWowEnum m_lastTargetStart = IntWowEnum.Add_P; // 
        public IntWowEnum m_lastTargetStop = IntWowEnum.Add_R; // 

        public IntWowEnum m_targetSelfStart = IntWowEnum.Decimal_P; // 
        public IntWowEnum m_targetSelfStop = IntWowEnum.Decimal_R; // 

        public IntWowEnum m_followTargetStart = 0;
        public IntWowEnum m_followTargetStop = 0;

        //Tab Numpad * Target Nearest enemy 
        //Tab Numpad / Previous Enemy
        //Tab Numpad - Scane Enemy Hold
        //Tab Numpad + Interact
        //Tab Numpad . Last target    


        public void TargetNearestEnemyStart() => m_player.SendIntegerToTarget((int)m_targetNearestEnemyStart);
        public void TargetNearestEnemyStop() => m_player.SendIntegerToTarget((int)m_targetNearestEnemyStop);
        public void TargetPreviousEnemyStart() => m_player.SendIntegerToTarget((int)m_targetPreviousEnemyStart);
        public void TargetPreviousEnemyStop() => m_player.SendIntegerToTarget((int)m_targetPreviousEnemyStop);
        public void ScanEnemyHoldStart() => m_player.SendIntegerToTarget((int)m_scanEnemyHoldStart);
        public void ScanEnemyHoldStop() => m_player.SendIntegerToTarget((int)m_scanEnemyHoldStop);
        public void LastTargetStart() => m_player.SendIntegerToTarget((int)m_lastTargetStart);
        public void LastTargetStop() => m_player.SendIntegerToTarget((int)m_lastTargetStop);
        public void InteractionStart() => m_player.SendIntegerToTarget((int)m_interactionStart);
        public void InteractionStop() => m_player.SendIntegerToTarget((int)m_interactionStop);
        public void AutoRunStart() => m_player.SendIntegerToTarget((int)m_autoRunStart);
        public void AutoRunStop() => m_player.SendIntegerToTarget((int)m_autoRunStop);
        public void FollowTargetStart() => m_player.SendIntegerToTarget((int)m_followTargetStart);
        public void FollowTargetStop() => m_player.SendIntegerToTarget((int)m_followTargetStop);




        public IntWowEnum m_power1Start = IntWowEnum.Key1_P;
        public IntWowEnum m_power1Stop = IntWowEnum.Key1_R;
        public IntWowEnum m_power2Start = IntWowEnum.Key2_P;
        public IntWowEnum m_power2Stop = IntWowEnum.Key2_R;
        public IntWowEnum m_power3Start = IntWowEnum.Key3_P;
        public IntWowEnum m_power3Stop = IntWowEnum.Key3_R;
        public IntWowEnum m_power4Start = IntWowEnum.Key4_P;
        public IntWowEnum m_power4Stop = IntWowEnum.Key4_R;
        public IntWowEnum m_power5Start = IntWowEnum.Key5_P;
        public IntWowEnum m_power5Stop = IntWowEnum.Key5_R;
        public IntWowEnum m_power6Start = IntWowEnum.Key6_P;
        public IntWowEnum m_power6Stop = IntWowEnum.Key6_R;
        public IntWowEnum m_power7Start = IntWowEnum.Key7_P;
        public IntWowEnum m_power7Stop = IntWowEnum.Key7_R;
        public IntWowEnum m_power8Start = IntWowEnum.Key8_P;
        public IntWowEnum m_power8Stop = IntWowEnum.Key8_R;
        public IntWowEnum m_power9Start = IntWowEnum.Key9_P;
        public IntWowEnum m_power9Stop = IntWowEnum.Key9_R;
        public IntWowEnum m_power0Start = IntWowEnum.Key0_P;
        public IntWowEnum m_power0Stop = IntWowEnum.Key0_R;



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
        public void StartJump() => m_player.SendIntegerToTarget(m_moveUpStart);
        public void StopJump() => m_player.SendIntegerToTarget(m_moveUpStop);
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
        public void StartPower0() => m_player.SendIntegerToTarget(m_power0Start);
        public void StopPower0() => m_player.SendIntegerToTarget(m_power0Stop);



        public void TriggerPower1() { StartPower1(); StopPower1(); }
        public void TriggerTab() { StartTab(); StopTab(); }
        public void TriggerJump() { StartJump(); StopJump(); }

        public void StartMovingDown() => m_player.SendIntegerToTarget(m_moveDownStart);
        public void StopMovingDown() => m_player.SendIntegerToTarget(m_moveDownStop);
        public void StartMovingUp() => m_player.SendIntegerToTarget(m_moveUpStart);
        public void StopMovingUp() => m_player.SendIntegerToTarget(m_moveUpStop);


    }



}
