using CommunityToolkit.Mvvm.Input;
using MyAwesomeMauiApp.Models;

namespace MyAwesomeMauiApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}