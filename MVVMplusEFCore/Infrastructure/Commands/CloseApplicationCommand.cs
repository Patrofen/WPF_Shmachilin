using System.Windows;
using MVVMplusEFCore.Infrastructure.Commands.Base;

namespace MVVMplusEFCore.Infrastructure.Commands;

internal class CloseApplicationCommand : Command
{
    public override bool CanExecute(object? parameter) => true;

    public override void Execute(object? parameter) => Application.Current.Shutdown();
}