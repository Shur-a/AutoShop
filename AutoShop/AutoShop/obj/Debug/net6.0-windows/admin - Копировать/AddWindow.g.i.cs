﻿#pragma checksum "..\..\..\..\admin - Копировать\AddWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41C4A2AC3041B880F7C8D746D7AEE77E7DAC07F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using AutoShop.Converters;
using AutoShop.Windows;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace AutoShop.Windows {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageAdd;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DetailName;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ModelCar;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox price;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Count;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox YearofreleaseCar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\admin - Копировать\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CarSelected;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/AutoShop;V1.0.0.0;component/admin%20-%20%d0%9a%d0%be%d0%bf%d0%b8%d1%80%d0%be%d0%" +
                    "b2%d0%b0%d1%82%d1%8c/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\admin - Копировать\AddWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ImageAdd = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            
            #line 20 "..\..\..\..\admin - Копировать\AddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addfoto);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DetailName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ModelCar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.price = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Count = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.YearofreleaseCar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CarSelected = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            
            #line 29 "..\..\..\..\admin - Копировать\AddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addbutton);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

