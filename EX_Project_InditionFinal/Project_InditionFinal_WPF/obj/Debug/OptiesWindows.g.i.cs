﻿#pragma checksum "..\..\OptiesWindows.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1F46F085B4436FB5FC6D977BC2612171E0F39C9BE4D7074387F2B8BC1D397A9B"
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
    /// OptiesWindows
    /// </summary>
    public partial class OptiesWindows : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataKleur;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataPermanent;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeleteKleur;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNieuwKleur;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDeletePermanent;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNieuwPermanent;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\OptiesWindows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSluiten;
        
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
            System.Uri resourceLocater = new System.Uri("/Project_InditionFinal_WPF;component/optieswindows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\OptiesWindows.xaml"
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
            this.dataKleur = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.dataPermanent = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.btnDeleteKleur = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\OptiesWindows.xaml"
            this.btnDeleteKleur.Click += new System.Windows.RoutedEventHandler(this.btnDeleteKleur_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnNieuwKleur = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\OptiesWindows.xaml"
            this.btnNieuwKleur.Click += new System.Windows.RoutedEventHandler(this.btnNieuwKleur_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnDeletePermanent = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\OptiesWindows.xaml"
            this.btnDeletePermanent.Click += new System.Windows.RoutedEventHandler(this.btnDeletePermanent_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnNieuwPermanent = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\OptiesWindows.xaml"
            this.btnNieuwPermanent.Click += new System.Windows.RoutedEventHandler(this.btnNieuwPermanent_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSluiten = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\OptiesWindows.xaml"
            this.btnSluiten.Click += new System.Windows.RoutedEventHandler(this.btnSluiten_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

