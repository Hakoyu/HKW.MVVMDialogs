namespace HKW.MVVMDialogs;

/// <summary>
/// 对话框页面接口
/// </summary>
public interface IDialogPage<TWindow>
{
    /// <summary>
    /// 对话框窗口
    /// </summary>
    public TWindow DialogWindow { get; set; }
}
