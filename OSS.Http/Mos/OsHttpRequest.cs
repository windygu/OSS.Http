﻿#region Copyright (C) 2016 Kevin (OSS开源系列) 公众号：osscoder

/***************************************************************************
*　　	文件功能描述：Http请求 == 请求实体
*
*　　	创建人： Kevin
*       创建人Email：1985088337@qq.com
*       
*****************************************************************************/

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace OSS.Http.Mos
{
    /// <summary>
    /// 请求实体
    /// </summary>
    public class OsHttpRequest
    {
        public OsHttpRequest()
        {
            FormParameters = new List<FormParameter>();
            FileParameterList = new List<FileParameter>();
        }

        /// <summary>
        /// 请求地址信息
        /// </summary>
        public Uri Uri{ get; set; }

        /// <summary>
        /// 请求方式
        /// </summary>
        public HttpMothed HttpMothed { get; set; }

        ///// <summary>
        /////  是否允许自动重定向
        ///// 默认为true  最大可重定向次数为 5
        ///// </summary>
        //public bool AllowAutoRedirect { get; set; } = true;

        ///// <summary>
        /////   是否使用压缩
        ///// </summary>
        //public bool AutoDecompres { get; set; }

        ///// <summary>
        /////   是否使用cookie 
        ///// </summary>
        //public bool UseCookies { get; set; }

        /// <summary>
        ///   reqMessage 设置方法
        ///    如果当前的设置不能满足需求，可以通过这里再次设置
        /// </summary>
        public Action<HttpRequestMessage> RequestSet { get; set; }

        #region   请求的内容参数

        /// <summary>
        /// 文件参数列表
        /// </summary>
        public List<FileParameter> FileParameterList { get; set; }

        /// <summary>
        /// 是否存在文件
        /// </summary>
        public bool HasFile => FileParameterList.Any();

        /// <summary>
        /// 非文件参数列表
        /// </summary>
        public List<FormParameter> FormParameters { get; set; }

        #endregion

        /// <summary>
        /// 自定义内容实体
        /// eg:当上传文件时，无法自定义内容
        /// </summary>
        public string CustomBody { get; set; }

        /// <summary>
        ///    超时时间（毫秒）
        /// </summary>
        public int TimeOutMilSeconds { get; set; }
    }
}
