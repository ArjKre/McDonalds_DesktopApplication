﻿#pragma checksum "..\..\Sandwich.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2BEDB7F5858D3D08484FE05F5861771403C4AA6A0786B82B79647A245CA86B74"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FastFoodManagmentSystem;
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


namespace FastFoodManagmentSystem {
    
    
    /// <summary>
    /// Menu_1_
    /// </summary>
    public partial class Menu_1_ : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image close;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image minimize;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homebtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menubtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cartbtn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label burger;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sandwiches;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Beverages;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label happyMeal;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Sandwich.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Treats;
        
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
            System.Uri resourceLocater = new System.Uri("/FastFoodManagmentSystem;component/sandwich.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Sandwich.xaml"
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
            
            #line 12 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.close = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\Sandwich.xaml"
            this.close.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.close_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.minimize = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\Sandwich.xaml"
            this.minimize.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.minimize_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homebtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Sandwich.xaml"
            this.homebtn.Click += new System.Windows.RoutedEventHandler(this.homebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Menubtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Sandwich.xaml"
            this.Menubtn.Click += new System.Windows.RoutedEventHandler(this.Menubtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cartbtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Sandwich.xaml"
            this.Cartbtn.Click += new System.Windows.RoutedEventHandler(this.Cartbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.burger = ((System.Windows.Controls.Label)(target));
            
            #line 66 "..\..\Sandwich.xaml"
            this.burger.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.burger_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Sandwiches = ((System.Windows.Controls.Label)(target));
            
            #line 68 "..\..\Sandwich.xaml"
            this.Sandwiches.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Sandwiches_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Beverages = ((System.Windows.Controls.Label)(target));
            
            #line 69 "..\..\Sandwich.xaml"
            this.Beverages.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Beverages_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.happyMeal = ((System.Windows.Controls.Label)(target));
            
            #line 70 "..\..\Sandwich.xaml"
            this.happyMeal.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.happyMeal_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Treats = ((System.Windows.Controls.Label)(target));
            
            #line 71 "..\..\Sandwich.xaml"
            this.Treats.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Treats_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 100 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 120 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 139 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 158 "..\..\Sandwich.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

