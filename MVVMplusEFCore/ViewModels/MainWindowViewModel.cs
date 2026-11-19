using System.Windows;
using System.Windows.Input;
using MVVMplusEFCore.Infrastructure.Commands;
using MVVMplusEFCore.ViewModels.Base;

namespace MVVMplusEFCore.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    #region Заголовок окна
    private string _title = "Анализ статистики CV19";
    /// <summary> Заголовок окна </summary>
    public string Title
    {
        get => _title;
        // set
        // {
        //     // if (Equals(_title, value)) return;
        //     // _title = value;
        //     // OnPropertyChanged();
        //     Set(ref _title, value);
        // }
        set => Set(ref _title, value);
    }
    #endregion

    #region Ststus : string - Статус программы

    /// <summary> Статус программы </summary>
    private string _status = "Готов!";
    
    /// <summary> Статус программы </summary>
    public string Status
    {
        get => _status;
        set => Set(ref _status, value);
    }

    #endregion

    #region Команды

    public ICommand CloseApplicationCommand { get; }

    #region CloseApplicationCommand

    private bool CanCloseApplicationCommandExecute(object p) => true;
    private void OnCloseApplicationCommandExecuted(object p)
    {
        Application.Current.Shutdown();
    }

    #endregion
    
    #endregion

    public MainWindowViewModel()
    {
        #region Команды

        CloseApplicationCommand =
            new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

        #endregion
    }
}