/*
 * Based on Raffael Zica's MessageBoxSlim.Avalonia
 * 
 * Copyright (C) 2021  Alexis Justine Ang.
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Affero General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU Affero General Public License for more details.
 *
 * You should have received a copy of the GNU Affero General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Nerdlabs.Avalonia.Extension.Controls;

using System.Threading.Tasks;

namespace Nerdlabs.Avalonia.Extension.Views
{
    public partial class BorderlessMessageBox : Window, IMessageBox<UserResult>
    {
        public BorderlessMessageBox()
        {
            InitializeComponent();
        }

        public BorderlessMessageBox(MessageBoxStyle style)
        {
            this.SetStyle(style);
            InitializeComponent();
        }

        public UserResult UserResult { get; set; } = UserResult.None;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

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
