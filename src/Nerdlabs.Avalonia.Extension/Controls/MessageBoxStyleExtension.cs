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
using Avalonia.Markup.Xaml.Styling;

namespace Nerdlabs.Avalonia.Extension.Controls
{
    internal static class MessageBoxStyleExtension
    {
        internal static void SetStyle(this Window window, MessageBoxStyle style)
        {
            global::Avalonia.Styling.Styles styles = window.Styles;
            switch (style)
            {
            case MessageBoxStyle.Windows:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Windows/Windwows.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Windows/Windwows.xaml")
                        });
                    break;
                }
            case MessageBoxStyle.MacOS:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/MacOS/MacOS.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/MacOS/MacOS.xaml")
                        });
                    break;
                }
            case MessageBoxStyle.Ubuntu:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Ubuntu/Ubuntu.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Ubuntu/Ubuntu.xaml")
                        });
                    break;
                }
            case MessageBoxStyle.Mint:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Mint/Mint.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/Mint/Mint.xaml")
                        });
                    break;
                }
            case MessageBoxStyle.RoundedButtons:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/RoundedButtons/RoundedButtons.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/RoundedButtons/RoundedButtons.xaml")
                        });
                    break;
                }
            case MessageBoxStyle.DarkMode:
                {
                    styles
                        .Add(new StyleInclude(new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/DarkMode/DarkMode.xaml"))
                        {
                            Source = new Uri("avares://Nerdlabs.Avalonia.Extension/Styles/DarkMode/DarkMode.xaml")
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
