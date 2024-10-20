using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HanumanInstitute.MvvmDialogs;

namespace HKW.MVVMDialogs;

/// <summary>
///
/// </summary>
public static class HKWMVVMDialogExtensions
{
    /// <summary>
    /// 显示文本输入对话框
    /// </summary>
    /// <param name="dialogService">对话框服务</param>
    /// <param name="ownerViewModel">所有者视图模型</param>
    /// <param name="textInputVM">对话框视图模型</param>
    /// <returns>结果</returns>
    public static async Task<TextInputVM> ShowTextInputDialog(
        this IDialogService dialogService,
        INotifyPropertyChanged ownerViewModel,
        TextInputVM textInputVM
    )
    {
        await dialogService.ShowDialogAsync(ownerViewModel, textInputVM);
        return textInputVM;
    }

    /// <summary>
    /// 显示项目选择对话框
    /// </summary>
    /// <param name="dialogService">对话框服务</param>
    /// <param name="ownerViewModel">所有者视图模型</param>
    /// <param name="itemSelectionVM">对话框视图模型</param>
    /// <returns>结果</returns>
    public static async Task<ItemSelectionVM> ShowItemSelectionDialog(
        this IDialogService dialogService,
        INotifyPropertyChanged ownerViewModel,
        ItemSelectionVM itemSelectionVM
    )
    {
        await dialogService.ShowDialogAsync(ownerViewModel, itemSelectionVM);
        return itemSelectionVM;
    }
}
