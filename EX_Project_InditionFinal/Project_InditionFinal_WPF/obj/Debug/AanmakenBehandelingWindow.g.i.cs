﻿#pragma checksum "..\..\AanmakenBehandelingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E69F78773B5B4FB600917D0347CACAE639E4D33758CDCEAF82048A01C1B5900"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Project_InditionFinal_WPF;
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


namespace Project_InditionFinal_WPF {
    
    
    /// <summary>
    /// AanmakenBehandelingWindow
    /// </summary>
    public partial class AanmakenBehandelingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblBehandelingAanmaken;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVoorKlant;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxBehandelingen;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNota;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnWijzigen;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuleren;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\AanmakenBehandelingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGeschiedenis;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_InditionFinal_WPF;component/aanmakenbehandelingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AanmakenBehandelingWindow.xaml"
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
            this.lblBehandelingAanmaken = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.lblVoorKlant = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.cbxBehandelingen = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.txtNota = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnWijzigen = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\AanmakenBehandelingWindow.xaml"
            this.btnWijzigen.Click += new System.Windows.RoutedEventHandler(this.btnWijzigen_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAnnuleren = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AanmakenBehandelingWindow.xaml"
            this.btnAnnuleren.Click += new System.Windows.RoutedEventHandler(this.btnAnnuleren_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblGeschiedenis = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

