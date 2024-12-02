using System.ComponentModel;
using System.Diagnostics;
using HanumanInstitute.MvvmDialogs;
using HanumanInstitute.MvvmDialogs.FrameworkDialogs;
using HKW.HKWReactiveUI;
using HKW.HKWUtils.Observable;

namespace HKW.MVVMDialogs;

/// <summary>
/// 对话框窗口视图模型
/// </summary>
public partial class DialogViewModel : ReactiveObjectX, IDialogViewModel
{
    /// <inheritdoc/>
    public DialogViewModel() { }

    /// <inheritdoc/>
    [ReactiveProperty]
    public string Title { get; set; } = string.Empty;

    /// <inheritdoc/>
    [ReactiveProperty]
    public string ToolTip { get; set; } = string.Empty;

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

    /// <summary>
    /// 关闭时
    /// </summary>
    public event CancelEventHandler? Closing;

    /// <summary>
    /// 当关闭时
    /// </summary>
    /// <param name="e">可取消事件</param>
    public void OnClosing(CancelEventArgs e)
    {
        Closing?.Invoke(this, e);
    }

    /// <summary>
    /// 当异步关闭时
    /// </summary>
    /// <param name="e">可取消事件</param>
    /// <returns>任务</returns>
    public async Task OnClosingAsync(CancelEventArgs e)
    {
        await Task.Run(() => Closing?.Invoke(this, e));
    }

    #region Command

    #endregion
}
