﻿// -
// <copyright file="ModelBase.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

namespace ReciCam.Windows.App.Utils
{
    using System.ComponentModel;

    /// <summary>
    /// ModelBase is used as base class used where we need to implement INotifyPropertyChanged.
    /// </summary>
    public class ModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Inherited from INotifyPropertyChanged. Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Invokes the PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">
        /// The name of the property that was changed.
        /// </param>
        protected void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
