﻿

#pragma checksum "C:\Users\Seungmin\documents\visual studio 2013\Projects\Debtor\Debtor\DebtPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7789D2B788DE7E26657CB3874368DA8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Debtor
{
    partial class DebtPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 67 "..\..\DebtPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.debtButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 64 "..\..\DebtPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.amountTextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 59 "..\..\DebtPage.xaml"
                ((global::Windows.UI.Xaml.Controls.TextBox)(target)).TextChanged += this.friendLiveIdTextBox_TextChanged;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 60 "..\..\DebtPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.friendRegisterButton_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


