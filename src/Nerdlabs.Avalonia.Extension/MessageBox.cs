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

using Nerdlabs.Avalonia.Extension.DtObject;
using Nerdlabs.Avalonia.Extension.Controls;
using Nerdlabs.Avalonia.Extension.ViewModels;
using Nerdlabs.Avalonia.Extension.Views;

namespace Nerdlabs.Avalonia.Extension
{
    public static class MessageBox
    {
        public static IMessageBox<UserResult> Create(MessageBoxOptions @params)
        {
            if (@params.Style == MessageBoxStyle.None)
            {
                BorderlessMessageBox bWindow = new BorderlessMessageBox(@params.Style);
                bWindow.DataContext = new BorderlessMessageBoxViewModel(@params, bWindow);
                return bWindow;
            }

            MessageBoxWindow window = new MessageBoxWindow(@params.Style);
            window.DataContext = new MessageBoxViewModel(@params, window);
            return window;
        }
    }
}
