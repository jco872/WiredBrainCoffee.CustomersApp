﻿#pragma checksum "C:\Users\jco87\source\repos\WiredBrainCoffee.CustomersApp\WiredBrainCoffee.CustomersApp\Controls\CustomerDetailControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A9A8E9CBAD206BE732A4491860418A0B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WiredBrainCoffee.CustomersApp.Controls
{
    partial class CustomerDetailControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Controls\CustomerDetailControl.xaml line 14
                {
                    this.txtFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtFirstName).TextChanged += this.TextBox_TextChanged;
                }
                break;
            case 3: // Controls\CustomerDetailControl.xaml line 16
                {
                    this.txtLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.txtLastName).TextChanged += this.TextBox_TextChanged;
                }
                break;
            case 4: // Controls\CustomerDetailControl.xaml line 18
                {
                    this.chkIsDeveloper = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.chkIsDeveloper).Checked += this.CheckBox_IsCheckedChanged;
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.chkIsDeveloper).Unchecked += this.CheckBox_IsCheckedChanged;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

