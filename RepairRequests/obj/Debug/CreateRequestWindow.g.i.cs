﻿#pragma checksum "..\..\CreateRequestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4C2D09BF92B3D6B5DF49ED4BCE116C99463144DA11109ED4C5938502286D861B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using RepairRequests;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace RepairRequests {
    
    
    /// <summary>
    /// CreateRequestWindow
    /// </summary>
    public partial class CreateRequestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RequestIdTextBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateAddedPicker;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox EquipmentTypeComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelTextBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ProblemDescriptionTextBox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ClientNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\CreateRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PhoneNumberTextBox;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RepairRequests;component/createrequestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateRequestWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.RequestIdTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.DateAddedPicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.EquipmentTypeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.ModelTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.ProblemDescriptionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.ClientNameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PhoneNumberTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 49 "..\..\CreateRequestWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

