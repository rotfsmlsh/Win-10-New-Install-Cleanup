﻿#pragma checksum "..\..\RunConfirmation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4F76400FE2476DFE8C3702C8F0754814DE941B4CEC3056FB4077232D26FFF1C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using New_Install_Cleanup;
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


namespace New_Install_Cleanup {
    
    
    /// <summary>
    /// RunConfirmation
    /// </summary>
    public partial class RunConfirmation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\RunConfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal New_Install_Cleanup.RunConfirmation window_runConfirmation;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\RunConfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkbox_understand;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\RunConfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_executeOperation;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\RunConfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox grpBox_summary;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\RunConfirmation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox txtBlock_summary;
        
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
            System.Uri resourceLocater = new System.Uri("/New_Install_Cleanup;component/runconfirmation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RunConfirmation.xaml"
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
            this.window_runConfirmation = ((New_Install_Cleanup.RunConfirmation)(target));
            return;
            case 2:
            this.checkbox_understand = ((System.Windows.Controls.CheckBox)(target));
            
            #line 10 "..\..\RunConfirmation.xaml"
            this.checkbox_understand.Checked += new System.Windows.RoutedEventHandler(this.checkbox_understand_Checked);
            
            #line default
            #line hidden
            
            #line 10 "..\..\RunConfirmation.xaml"
            this.checkbox_understand.Unchecked += new System.Windows.RoutedEventHandler(this.checkbox_understand_unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_executeOperation = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\RunConfirmation.xaml"
            this.btn_executeOperation.Click += new System.Windows.RoutedEventHandler(this.btn_executeOperation_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.grpBox_summary = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.txtBlock_summary = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

