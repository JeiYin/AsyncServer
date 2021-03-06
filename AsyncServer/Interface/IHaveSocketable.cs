﻿using System.Net;
using System.Net.Sockets;

namespace AsyncServer.Interface
{
    /// <summary>
    /// 拥有socket的行为
    /// </summary>
    public interface IHaveSocketable
    {
        /// <summary>
        /// 获取当前所拥有的socket
        /// </summary>
        /// <returns>当前的socket</returns>
        Socket GetSocket();


        /// <summary>
        /// 获取当前socket绑定的ip地址
        /// </summary>
        /// <returns>当前绑定的ip</returns>
        string GetIp();


        /// <summary>
        /// 获取当前socket绑定的端口
        /// </summary>
        /// <returns>当前绑定的端口</returns>
        int GetPort();



        /// <summary>
        /// 获取IPEndPoint对象
        /// </summary>
        /// <returns>IPEndPoint对象</returns>
        IPEndPoint GetIpAndPoint();
    }
}
