using Eloi.Wow;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WowMacro_SkipLeveling : MonoBehaviour
{
    public WowIntegerMono m_wowIntegerMono;
    [SerializeField] private float m_timeBetweenTabPowerPower =0.1f;
    [SerializeField] private float m_timeBetweenPower = 1.9f;
    [SerializeField] private float m_timeBetweenSequence = 1;
    [SerializeField] private int m_powerAttackCount = 3;

    public void OnEnable()
    {
        StartCoroutine(SkipLeveling());
    }

    public IntWowEnum m_tabStart = IntWowEnum.Tab_P;
    public IntWowEnum m_tabEnd = IntWowEnum.Tab_R;
    public IntWowEnum m_power1Start = IntWowEnum.Key1_P;
    public IntWowEnum m_power1End = IntWowEnum.Key1_R;

    private IEnumerator SkipLeveling()
    {
        while (true)
        {
            if (m_wowIntegerMono != null) { 
                m_wowIntegerMono.SendIntegerToTarget((int)m_tabStart);
                m_wowIntegerMono.SendIntegerToTarget((int)m_tabEnd);
                yield return new WaitForSeconds(m_timeBetweenTabPowerPower);
                for (int i = 0; i < m_powerAttackCount; i++) { 
                    m_wowIntegerMono.SendIntegerToTarget((int)m_power1Start);
                    m_wowIntegerMono.SendIntegerToTarget((int)m_power1End);
                    yield return new WaitForSeconds(m_timeBetweenPower);
                }
            }
            yield return new WaitForSeconds(m_timeBetweenSequence);
        }
    }
}
