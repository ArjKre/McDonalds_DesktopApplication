﻿#pragma checksum "..\..\Menu(1).xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B072BE56E9FCD43FFCF90471B2488CD7CEAB1FB3E0B1681542283C82A41A88F3"
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
        
        
        #line 22 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image close;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image minimize;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button homebtn;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Menubtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cartbtn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label burger;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Sandwiches;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Beverages;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\Menu(1).xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label happyMeal;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Menu(1).xaml"
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
            System.Uri resourceLocater = new System.Uri("/FastFoodManagmentSystem;component/menu(1).xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Menu(1).xaml"
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
            
            #line 12 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.close = ((System.Windows.Controls.Image)(target));
            
            #line 22 "..\..\Menu(1).xaml"
            this.close.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.close_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.minimize = ((System.Windows.Controls.Image)(target));
            
            #line 23 "..\..\Menu(1).xaml"
            this.minimize.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.minimize_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.homebtn = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\Menu(1).xaml"
            this.homebtn.Click += new System.Windows.RoutedEventHandler(this.homebtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Menubtn = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Menu(1).xaml"
            this.Menubtn.Click += new System.Windows.RoutedEventHandler(this.Menubtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cartbtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\Menu(1).xaml"
            this.Cartbtn.Click += new System.Windows.RoutedEventHandler(this.Cartbtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.burger = ((System.Windows.Controls.Label)(target));
            
            #line 66 "..\..\Menu(1).xaml"
            this.burger.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.burger_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 67 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Label)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Sandwiches = ((System.Windows.Controls.Label)(target));
            
            #line 68 "..\..\Menu(1).xaml"
            this.Sandwiches.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Sandwiches_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Beverages = ((System.Windows.Controls.Label)(target));
            
            #line 69 "..\..\Menu(1).xaml"
            this.Beverages.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Beverages_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 11:
            this.happyMeal = ((System.Windows.Controls.Label)(target));
            
            #line 70 "..\..\Menu(1).xaml"
            this.happyMeal.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.happyMeal_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Treats = ((System.Windows.Controls.Label)(target));
            
            #line 71 "..\..\Menu(1).xaml"
            this.Treats.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Treats_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 100 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 120 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 139 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 158 "..\..\Menu(1).xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
