﻿#pragma checksum "C:\Users\didflsk\Desktop\KalAcademy\KalBootCamp\PhoneBook\PhoneBook\PhoneBook\AddContact.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "A70D94A0BFA17F0AF2F1E52C98A69FB5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneBook
{
    partial class AddContact : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // AddContact.xaml line 22
                {
                    this.nameLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // AddContact.xaml line 23
                {
                    this.nameText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // AddContact.xaml line 26
                {
                    this.titleLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5: // AddContact.xaml line 29
                {
                    this.titleText = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // AddContact.xaml line 33
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.Button_Click;
                }
                break;
            case 7: // AddContact.xaml line 35
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Back_Click;
                }
                break;
            case 8: // AddContact.xaml line 37
                {
                    this.Outpout = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

