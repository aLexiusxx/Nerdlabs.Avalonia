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

using Avalonia.Controls;
using Avalonia.Media.Imaging;

using Nerdlabs.Avalonia.Extension.Controls;

namespace Nerdlabs.Avalonia.Extension.DtObject
{
    public class MessageBoxOptions
    {
        /// <summary>
        /// Gets or sets the image or icon content of the
        /// <c>MessageBox</c> that denotes its context.
        /// </summary>
        public Bitmap? Icon { get; set; } = null;

        /// <summary>
        /// Gets or sets the window style of the <c>MessageBox</c>.
        /// </summary>
        public MessageBoxStyle Style { get; set; } = MessageBoxStyle.None;

        /// <summary>
        /// Gets or sets the text that appears on the title bar of
        /// <c>MessageBox</c> for bordered windows.
        /// </summary>
        public string Title { get; set; } = "MessageBox";

        /// <summary>
        /// Gets or sets the text that appear on the <c>MessageBox</c>.
        /// </summary>
        public string Message { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the maximum width the <c>MessageBox</c> can take.
        /// </summary>
        public int? MaxWidth { get; set; } = null;

        /// <summary>
        /// Gets or sets the startup location of the <c>MessageBox</c>.
        /// </summary>
        public WindowStartupLocation Location { get; set; } = WindowStartupLocation.CenterOwner;

        /// <summary>
        /// Gets or sets the button controls of the <c>MessageBox</c>.
        /// </summary>
        public MessageBoxButton Button { get; set; } = MessageBoxButton.OK;
    }
}
