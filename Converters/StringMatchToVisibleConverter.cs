﻿// -
// <copyright file="StringMatchToVisibleConverter.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ReciCam.Windows.App.Converters
{
    using System;

    /// <summary>
    /// Converter that transforms a string match to a Visibility.
    /// This is particularly useful when we need to match the value of an enum in a converter.
    /// Example:
    ///     Visibility="{Binding SomeEnumField, Converter={StaticResource StringMatchToVisibleConverter}, ConverterParameter=MatchingValueCorrespondingToVisible}">.
    /// </summary>
    public class StringMatchToVisibleConverter : IValueConverter
    {
        /// <summary>
        /// Converts the source data (value) to Visibility before passing it 
        /// to the target of a data binding for display in the UI.
        /// </summary>
        /// <param name="value">
        /// The source data being passed to the target.
        /// </param>
        /// <param name="targetType">
        /// The type of data expected by the target dependency property.
        /// </param>
        /// <param name="parameter">
        /// The string that is matched against value.ToString. 
        /// This will be provided in the converter parameter in the data binding syntax.
        /// </param>
        /// <param name="language">
        /// The language of the conversion. Ignored by this converter.
        /// </param>
        /// <returns>
        /// Returns Visibility.Visible if value.ToString() and parameter.ToString() 
        /// are equal. The comparison is case sensitive but using invariant culture.
        /// </returns>
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (string.Compare(value.ToString(), parameter.ToString(), StringComparison.Ordinal) == 0)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Collapsed;
            }
        }

        /// <summary>
        /// The ConvertBack is not implemented for this converter. 
        /// ConvertBack will throw NotImplementedException if invoked.
        /// </summary>
        /// <param name="value">
        /// The source data being passed to the target.
        /// </param>
        /// <param name="targetType">
        /// The type of data expected by the target dependency property.
        /// </param>
        /// <param name="parameter">
        /// The string that is matched against value.ToString. 
        /// This will be provided in the converter parameter in the data binding syntax.
        /// </param>
        /// <param name="language">
        /// The language of the conversion. Ignored by this converter.
        /// </param>
        /// <returns>
        /// Returns Visibility.Visible if value.ToString() and parameter.ToString() 
        /// are equal. The comparison is case sensitive but using invariant culture.
        /// </returns>
        /// <exception cref="NotImplementedException">not implemented</exception>
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
