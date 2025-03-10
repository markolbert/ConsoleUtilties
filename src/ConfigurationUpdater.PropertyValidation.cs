﻿#region copyright

// Copyright (c) 2021, 2022, 2023 Mark A. Olbert 
// https://www.JumpForJoySoftware.com
// ConfigurationUpdater.PropertyValidation.cs
//
// This file is part of JumpForJoy Software's ConsoleUtilities.
// 
// ConsoleUtilities is free software: you can redistribute it and/or modify it 
// under the terms of the GNU General Public License as published by the 
// Free Software Foundation, either version 3 of the License, or 
// (at your option) any later version.
// 
// ConsoleUtilities is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
// or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License 
// for more details.
// 
// You should have received a copy of the GNU General Public License along 
// with ConsoleUtilities. If not, see <https://www.gnu.org/licenses/>.

#endregion

using System.Reflection;

namespace J4JSoftware.ConsoleUtilities;

public partial class ConfigurationUpdater<TConfig>
{
    private class PropertyValidation( PropertyInfo propInfo, IPropertyUpdater updater )
    {
        public PropertyInfo PropertyInfo { get; } = propInfo;
        public IPropertyUpdater Updater { get; } = updater;
    }
}
