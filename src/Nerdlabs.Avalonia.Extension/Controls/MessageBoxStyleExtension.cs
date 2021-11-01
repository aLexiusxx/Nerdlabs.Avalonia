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

using Avalonia.Controls;
using Avalonia.Styling;
using Avalonia.Markup.Xaml.Styling;

namespace Nerdlabs.Avalonia.Extension.Controls
{
    internal static class MessageBoxStyleExtension
    {
        internal static void SetStyle(this Window window, MessageBoxStyle style)
        {
            Styles styles = window.Styles;
            switch (style)
            {
            case MessageBoxStyle.Windows:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Windows/Windows.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Windows/Windows.axaml")
                        });
                    break;
                }
            case MessageBoxStyle.MacOS:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/MacOS/MacOS.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/MacOS/MacOS.axaml")
                        });
                    break;
                }
            case MessageBoxStyle.Ubuntu:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Ubuntu/Ubuntu.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Ubuntu/Ubuntu.axaml")
                        });
                    break;
                }
            case MessageBoxStyle.Mint:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Mint/Mint.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Mint/Mint.axaml")
                        });
                    break;
                }
            case MessageBoxStyle.RoundedButtons:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/RoundedButtons/RoundedButtons.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/RoundedButtons/RoundedButtons.axaml")
                        });
                    break;
                }
            case MessageBoxStyle.DarkMode:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Dark/Dark.axaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Dark/Dark.axaml")
                        });
                    break;
                }
            default:
                {
                    break;
                }
            }
        }
    }
}
