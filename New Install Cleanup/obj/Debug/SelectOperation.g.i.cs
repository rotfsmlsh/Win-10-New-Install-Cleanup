﻿#pragma checksum "..\..\SelectOperation.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AD0A7DA7046EB70FC2BD9B79F071BBB880689E465B22ADCB69EF889F180EBF7B"
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
    /// SelectOperation
    /// </summary>
    public partial class SelectOperation : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox group_removeDefaults;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_customRemoval;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_typicalRemoval;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox group_privacySettings;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_privacySettings;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SelectOperation.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_typicalPrivacySettings;
        
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
            System.Uri resourceLocater = new System.Uri("/New_Install_Cleanup;component/selectoperation.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectOperation.xaml"
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
            this.group_removeDefaults = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 2:
            this.btn_customRemoval = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\SelectOperation.xaml"
            this.btn_customRemoval.Click += new System.Windows.RoutedEventHandler(this.btn_customRemoval_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btn_typicalRemoval = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\SelectOperation.xaml"
            this.btn_typicalRemoval.Click += new System.Windows.RoutedEventHandler(this.btn_typicalRemoval_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.group_privacySettings = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 5:
            this.btn_privacySettings = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\SelectOperation.xaml"
            this.btn_privacySettings.Click += new System.Windows.RoutedEventHandler(this.btn_privacySettings_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_typicalPrivacySettings = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

