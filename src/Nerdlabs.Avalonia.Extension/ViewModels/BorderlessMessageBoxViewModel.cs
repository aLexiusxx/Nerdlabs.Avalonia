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

using System;
using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Media.Imaging;

using Nerdlabs.Avalonia.Extension.DtObject;
using Nerdlabs.Avalonia.Extension.Controls;
using Nerdlabs.Avalonia.Extension.Views;


namespace Nerdlabs.Avalonia.Extension.ViewModels
{
    public class BorderlessMessageBoxViewModel : ViewModelBase
    {
        private readonly MessageBoxOptions _dtObjOptions;

        public BorderlessMessageBoxViewModel(MessageBoxOptions @params, BorderlessMessageBox bWnd)
        {
            _dtObjOptions = @params;
            window = bWnd;
        }

        private readonly BorderlessMessageBox window;

        public bool OKButton        => _dtObjOptions.Button.HasFlag(MessageBoxButton.OK);
        public bool YesButton       => _dtObjOptions.Button.HasFlag(MessageBoxButton.Yes);
        public bool NoButton        => _dtObjOptions.Button.HasFlag(MessageBoxButton.No);
        public bool CancelButton    => _dtObjOptions.Button.HasFlag(MessageBoxButton.Cancel);
        public bool AbortButton     => _dtObjOptions.Button.HasFlag(MessageBoxButton.Abort);
        public bool NoneButton      => _dtObjOptions.Button.HasFlag(MessageBoxButton.None);
        public bool HasIcon         => _dtObjOptions.Icon != null;
        public string Title         => _dtObjOptions.Title;
        public string Message       => _dtObjOptions.Message;
        public Bitmap? Icon          => _dtObjOptions.Icon;
        public int? MaxWidth        => _dtObjOptions.MaxWidth;
        public WindowStartupLocation Location => _dtObjOptions.Location;

        public async Task CopyToClipboard()
        {
            await AvaloniaLocator
                .Current
                .GetService<IClipboard>()
                .SetTextAsync(Message);
        }

        public void ButtonClick(string param)
        {
            window.UserResult =
                (UserResult)
                Enum.Parse(
                    typeof(UserResult),
                    param.Trim(),
                    false
                );
            window.Close();
        }
    }
}
