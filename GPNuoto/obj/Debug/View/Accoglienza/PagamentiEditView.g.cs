﻿#pragma checksum "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "897E5818B294C242226866D701E8A2926966B495877FA3BAA22976837B1C4A86"
//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

using GPNuoto.Converters;
using GPNuoto.Model;
using GPNuoto.Report;
using MaterialDesignThemes.MahApps;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace GPNuoto {
    
    
    /// <summary>
    /// PagamentiEditView
    /// </summary>
    public partial class PagamentiEditView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 45 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Descrizione;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotalePagamentoTextbox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ScontoTextbox;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TotaleRicevutaTextbox;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GPNuoto.Report.StpRicevuta Ricevuta;
        
        #line default
        #line hidden
        
        
        #line 119 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStampaRicevutaFiscale;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnStampaRicevuta;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfermaPagamento;
        
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
            System.Uri resourceLocater = new System.Uri("/GPNuoto;component/view/accoglienza/pagamentieditview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.Descrizione = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TotalePagamentoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ScontoTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TotaleRicevutaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.Ricevuta = ((GPNuoto.Report.StpRicevuta)(target));
            return;
            case 6:
            this.btnStampaRicevutaFiscale = ((System.Windows.Controls.Button)(target));
            
            #line 123 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
            this.btnStampaRicevutaFiscale.Click += new System.Windows.RoutedEventHandler(this.btnStampaRicevutaFiscale_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnStampaRicevuta = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.btnConfermaPagamento = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\..\View\Accoglienza\PagamentiEditView.xaml"
            this.btnConfermaPagamento.Click += new System.Windows.RoutedEventHandler(this.btnConfermaPagamento_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

