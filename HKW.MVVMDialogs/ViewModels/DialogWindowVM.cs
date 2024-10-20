﻿using System.ComponentModel;
using System.Diagnostics;
using HanumanInstitute.MvvmDialogs;
using HanumanInstitute.MvvmDialogs.FrameworkDialogs;
using HKW.HKWReactiveUI;
using HKW.HKWUtils.Observable;

namespace HKW.MVVMDialogs;

/// <summary>
/// 对话框窗口视图模型
/// </summary>
public partial class DialogWindowVM : ReactiveObjectX, IDialogViewModel, IModalDialogViewModel
{
    /// <inheritdoc/>
    public DialogWindowVM() { }

    /// <inheritdoc/>
    [ReactiveProperty]
    public string Title { get; set; } = string.Empty;

    /// <inheritdoc/>
    [ReactiveProperty]
    public string? ToolTip { get; set; } = null;

    /// <inheritdoc/>
    [ReactiveProperty]
    public bool? DialogResult { get; set; }

    /// <inheritdoc/>
    [ReactiveProperty]
    [DefaultValue(MessageBoxButton.YesNo)]
    public MessageBoxButton Button { get; set; } = MessageBoxButton.YesNo;

    /// <inheritdoc/>
    [ReactiveProperty]
    [DefaultValue(DefeatMessageBoxButton.None)]
    public DefeatMessageBoxButton DefeatButton { get; set; } = DefeatMessageBoxButton.None;

    /// <inheritdoc/>
    [ReactiveProperty]
    [DefaultValue(CaptionButtons.Close)]
    public CaptionButtons CaptionButtons { get; set; } = CaptionButtons.Close;

    /// <inheritdoc/>
    [ReactiveProperty]
    [DefaultValue(ResizeMode.NoResize)]
    public ResizeMode ResizeMode { get; set; } = ResizeMode.NoResize;

    #region Command

    #endregion
}