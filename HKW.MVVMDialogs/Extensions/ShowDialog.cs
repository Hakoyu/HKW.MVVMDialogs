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
    ///// <summary>
    ///// 显示对话框
    ///// </summary>
    ///// <typeparam name="TViewModel">对话框视图模型类型</typeparam>
    ///// <param name="dialogService">对话框服务</param>
    ///// <param name="ownerViewModel">所有者视图模型</param>
    ///// <returns>对话框视图模型</returns>
    //public static TViewModel ShowDialogX<TViewModel>(
    //    this IDialogService dialogService,
    //    INotifyPropertyChanged ownerViewModel
    //)
    //    where TViewModel : DialogViewModel, new()
    //{
    //    var vm = new TViewModel();
    //    dialogService.ShowDialogAsync(ownerViewModel, vm).Wait();
    //    return vm;
    //}

    ///// <summary>
    ///// 显示对话框
    ///// </summary>
    ///// <typeparam name="TViewModel">对话框视图模型类型</typeparam>
    ///// <param name="dialogService">对话框服务</param>
    ///// <param name="ownerViewModel">所有者视图模型</param>
    ///// <param name="viewModel">对话框视图模型</param>
    ///// <returns>对话框视图模型</returns>
    //public static TViewModel ShowDialogX<TViewModel>(
    //    this IDialogService dialogService,
    //    INotifyPropertyChanged ownerViewModel,
    //    TViewModel viewModel
    //)
    //    where TViewModel : DialogViewModel
    //{
    //    dialogService.ShowDialogAsync(ownerViewModel, viewModel).Wait();
    //    return viewModel;
    //}

    /// <summary>
    /// 异步显示对话框
    /// </summary>
    /// <typeparam name="TViewModel">对话框视图模型类型</typeparam>
    /// <param name="dialogService">对话框服务</param>
    /// <param name="ownerViewModel">所有者视图模型</param>
    /// <returns>对话框视图模型任务</returns>
    public static async Task<TViewModel> ShowDialogAsyncX<TViewModel>(
        this IDialogService dialogService,
        INotifyPropertyChanged ownerViewModel
    )
        where TViewModel : DialogViewModel, new()
    {
        var vm = new TViewModel();
        await dialogService.ShowDialogAsync(ownerViewModel, vm);
        return vm;
    }

    /// <summary>
    /// 异步显示对话框
    /// </summary>
    /// <typeparam name="TViewModel">对话框视图模型类型</typeparam>
    /// <param name="dialogService">对话框服务</param>
    /// <param name="ownerViewModel">所有者视图模型</param>
    /// <param name="viewModel">对话框视图模型</param>
    /// <returns>对话框视图模型任务</returns>
    public static async Task<TViewModel> ShowDialogAsyncX<TViewModel>(
        this IDialogService dialogService,
        INotifyPropertyChanged ownerViewModel,
        TViewModel viewModel
    )
        where TViewModel : DialogViewModel
    {
        await dialogService.ShowDialogAsync(ownerViewModel, viewModel);
        return viewModel;
    }
}
