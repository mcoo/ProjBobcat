﻿using System;
using ProjBobcat.Event;

namespace ProjBobcat.Class.Model
{
    /// <summary>
    /// 下载文件信息类
    /// </summary>
    public class DownloadFile
    {
        /// <summary>
        /// 下载Uri
        /// </summary>
        public string DownloadUri { get; set; }
        /// <summary>
        /// 下载路径
        /// </summary>
        public string DownloadPath { get; set; }
        /// <summary>
        /// 保存的文件名
        /// </summary>
        public string FileName { get; set; }
        /// <summary>
        /// 最大重试计数
        /// </summary>
        public int RetryCount { get; set; }
        /// <summary>
        /// 文件类型（仅在Lib/Asset补全时可用）
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// 文件大小
        /// </summary>
        public long FileSize { get; set; }
        /// <summary>
        /// 下载完成事件
        /// </summary>
        public EventHandler<DownloadFileCompletedEventArgs> Completed { get; set; }
        /// <summary>
        /// 下载改变事件
        /// </summary>
        public EventHandler<DownloadFileChangedEventArgs> Changed { get; set; }
    }
}