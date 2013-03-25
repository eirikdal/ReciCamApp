// -
// <copyright file="TextArea.xaml.cs" company="Microsoft Corporation">
//    Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
// -

using ReciCam.Windows.App.Data;
using ReciCam.Windows.App.ViewModels;
using Windows.UI.Xaml.Controls;

namespace ReciCam.Windows.App.Controls
{
    /// <summary>
    /// TextArea class contains the code behind for the TextArea user control.
    /// The TextArea user control shows to the user the text resulted from the OCR conversion.
    /// </summary>
    public partial class TextArea : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the TextArea class.
        /// </summary>
        public TextArea()
        {
            this.InitializeComponent();
            this.DataContext = new TextAreaViewModel(OcrData.Instance, OcrConversionStateManager.Instance);
        }
    }
}
