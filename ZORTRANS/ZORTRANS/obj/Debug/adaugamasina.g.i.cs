﻿#pragma checksum "..\..\adaugamasina.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8968D7F05847C56D2C2C9EBED60790105DC5A98C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ZORTRANS;


namespace ZORTRANS {
    
    
    /// <summary>
    /// adaugamasina
    /// </summary>
    public partial class adaugamasina : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marca;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox model;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nrinmatriculare;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tip;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idtransport;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\adaugamasina.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button adauga;
        
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
            System.Uri resourceLocater = new System.Uri("/ZORTRANS;component/adaugamasina.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\adaugamasina.xaml"
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
            this.marca = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.model = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.nrinmatriculare = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tip = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.idtransport = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.adauga = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\adaugamasina.xaml"
            this.adauga.Click += new System.Windows.RoutedEventHandler(this.Adauga_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
