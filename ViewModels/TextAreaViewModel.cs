﻿// -
// <copyright file="TextAreaViewModel.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using ReciCam.Windows.App.Data;

namespace ReciCam.Windows.App.ViewModels
{
    using Windows.App.Data;
    using Windows.App.Utils;

    /// <summary>
    /// View Model that is used by the TextArea user control.
    /// </summary>
    public class TextAreaViewModel : OcrViewModelBase
    {
        /// <summary>
        /// Text mode of the text area
        /// </summary>
        private TextViewMode textViewMode;    // Wrapped by this.TextViewMode

        /// <summary>
        /// Initializes a new instance of the TextAreaViewModel class.
        /// </summary>
        /// <param name="ocrData">
        /// A reference to the OcrData instance that stores the 
        /// photo stream and the text obtained after the OCR conversion.
        /// </param>
        /// <param name="ocrConversionStateManager">
        /// A reference to the OcrConversionStateManager instance that stores the 
        /// status of the last OCR conversion.
        /// </param>
        public TextAreaViewModel(OcrData ocrData, OcrConversionStateManager ocrConversionStateManager)
            : base(ocrData, ocrConversionStateManager)
        {
        }

        /// <summary>
        /// Gets or sets the flag that Specifies the view mode for 
        /// the screen that shows the result of the OCR conversion.
        /// </summary>
        public TextViewMode TextViewMode
        {
            get
            {
                return this.textViewMode;
            }

            set
            {
                if (!object.ReferenceEquals(this.textViewMode, value))
                {
                    this.textViewMode = value;
                    this.OnPropertyChanged("TextViewMode");
                }
            }
        }
    }
}
