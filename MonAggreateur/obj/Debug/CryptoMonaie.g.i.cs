﻿#pragma checksum "..\..\CryptoMonaie.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3518BC15D11B1998714028DD0E65A57B1681F4B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MonAggreateur;
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


namespace MonAggreateur {
    
    
    /// <summary>
    /// CryptoMonaie
    /// </summary>
    public partial class CryptoMonaie : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Accueil;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Nouvelle;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Meteo;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pokemon;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cryptomonaie;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CryptoMonaie.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Slack;
        
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
            System.Uri resourceLocater = new System.Uri("/MonAggreateur;component/cryptomonaie.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CryptoMonaie.xaml"
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
            this.Accueil = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\CryptoMonaie.xaml"
            this.Accueil.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nouvelle = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\CryptoMonaie.xaml"
            this.Nouvelle.Click += new System.Windows.RoutedEventHandler(this.Nouvelle_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Meteo = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\CryptoMonaie.xaml"
            this.Meteo.Click += new System.Windows.RoutedEventHandler(this.Meteo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Pokemon = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\CryptoMonaie.xaml"
            this.Pokemon.Click += new System.Windows.RoutedEventHandler(this.Pokemon_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Cryptomonaie = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\CryptoMonaie.xaml"
            this.Cryptomonaie.Click += new System.Windows.RoutedEventHandler(this.Cryptomonaie_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Slack = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\CryptoMonaie.xaml"
            this.Slack.Click += new System.Windows.RoutedEventHandler(this.Slack_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

