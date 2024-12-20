﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HanumanInstitute.MvvmDialogs;
using HanumanInstitute.MvvmDialogs.FrameworkDialogs;

namespace HKW.MVVMDialogs;

/// <summary>
/// 对话框窗口接口
/// </summary>
public interface IDialogViewModel : IModalDialogViewModel, IViewClosing
{
    /// <summary>
    /// 标题
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 提示
    /// </summary>
    public string ToolTip { get; set; }

    /// <summary>
    /// 按钮
    /// </summary>
    public MessageBoxButton Button { get; set; }

    /// <summary>
    /// 默认按钮
    /// </summary>
    public DefeatMessageBoxButton DefeatButton { get; set; }

    /// <summary>
    /// 标题栏按钮
    /// </summary>
    public CaptionButtons CaptionButtons { get; set; }

    /// <summary>
    /// 调整大小模式
    /// </summary>
    public ResizeMode ResizeMode { get; set; }

    /// <summary>
    /// 关闭时
    /// </summary>
    public event CancelEventHandler? Closing;
}
