using System.Collections;
using UnityEngine;


namespace Eloi.Wow
{
    public class WowIntMono_SampleJumpMove : MonoBehaviour {


        public WowIntegerMono m_player;

        public int m_jumpStart = 1032;
        public int m_jumpEnd = 2032;

        public int m_moveForwardStart = 1038;
        public int m_moveForwardStop = 2038;

        public int m_moveBackStart = 1040;
        public int m_moveBackStop = 2040;


        public void OnEnable()
        {
            StartCoroutine(MoveAndJumpInLoop());
        }

        public float m_walkForwardTiming = 1;
        public float m_walkBackwardTiming = 2;

        private IEnumerator MoveAndJumpInLoop()
        {

            while (true)
            { 

                yield return new WaitForSeconds(1f);
                m_player.SendIntegerToTarget(m_jumpStart);
                yield return new WaitForSeconds(1f);
                m_player.SendIntegerToTarget(m_jumpEnd);
                yield return new WaitForSeconds(1f);
                m_player.SendIntegerToTarget(m_moveForwardStart);
                yield return new WaitForSeconds(m_walkForwardTiming);
                m_player.SendIntegerToTarget(m_moveForwardStop);
                yield return new WaitForSeconds(1f);
                m_player.SendIntegerToTarget(m_moveBackStart);  
                yield return new WaitForSeconds(m_walkBackwardTiming);
                m_player.SendIntegerToTarget(m_moveBackStop);
                yield return new WaitForEndOfFrame();
            }

        }
    }
}