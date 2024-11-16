using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using UnityEngine;


namespace Eloi.Wow
{

    public class WowIntegerMono : MonoBehaviour
{
   

     [SerializeField] private string m_ipAddress = "127.0.0.1";
        [SerializeField] private int m_ipPort = 7073;
        [SerializeField] private int m_playerDefaultIndex = 1;



        public int m_lastPushedIndex = 0;
    public int m_lastPushedValue = 0;
    public string m_lastPushedDate = "";

    private UdpClient m_udpClient;
    private void Awake()
    {
        m_udpClient = new UdpClient();
    }
    private void OnDestroy()
    {
        if(m_udpClient != null)
            m_udpClient.Close();
    }



    public void SetTarget(string ipAddress, int ipPort)
    {
        m_ipAddress = ipAddress;
        m_ipPort = ipPort;
    }
    public void SetTargetIp(string ipAddress)
    {
        m_ipAddress = ipAddress;
    }
    public void SetTargetPort(string ipPort)
    {
            if(int.TryParse(ipPort, out int port))
                SetTargetPort(port);
    }
    public void SetTargetPort(int ipPort)
    {
        m_ipPort = ipPort;
    }
        public void SendIntegerToTarget(int commandValue)
        {

            SendIntegerToTarget(m_playerDefaultIndex, commandValue);
        }
        public void SendIntegerToAll(int commandValue)
        {

            SendIntegerToTarget(0, commandValue);
        }
        public void SendIntegerToTarget(int index, int commandValue)
    {
            if( m_udpClient == null)
                m_udpClient = new UdpClient();
        m_lastPushedIndex = index;
        m_lastPushedValue = commandValue;
        m_lastPushedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        byte[] value1Bytes = BitConverter.GetBytes(index);
        byte[] value2Bytes = BitConverter.GetBytes(commandValue);

        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(value1Bytes);
            Array.Reverse(value2Bytes);
        }

        // Combine the byte arrays
        byte[] message = new byte[value1Bytes.Length + value2Bytes.Length];
        Buffer.BlockCopy(value1Bytes, 0, message, 0, value1Bytes.Length);
        Buffer.BlockCopy(value2Bytes, 0, message, value1Bytes.Length, value2Bytes.Length);

        // Send the message
        IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(m_ipAddress), m_ipPort);
        m_udpClient.Send(message, message.Length, endPoint);

    }

}
}