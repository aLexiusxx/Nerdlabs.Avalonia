using Avalonia.Controls;
using System.Threading.Tasks;

namespace Nerdlabs.Avalonia.Extension.Controls
{
    public abstract class _MessageBox : Window, IMessageBox<UserResult>
    {
        public UserResult UserResult { get; set; } = UserResult.None;

        public Task<UserResult> AsyncShow()
        {
            TaskCompletionSource<UserResult> tcSource = new TaskCompletionSource<UserResult>();
            Closed += delegate { tcSource.TrySetResult(UserResult); };
            Show();
            return tcSource.Task;
        }

        public Task<UserResult> AsyncShowDialog(Window owner)
        {
            TaskCompletionSource<UserResult> tcSource = new TaskCompletionSource<UserResult>();
            Closed += delegate { tcSource.TrySetResult(UserResult); };
            ShowDialog(owner);
            return tcSource.Task;
        }
    }
}