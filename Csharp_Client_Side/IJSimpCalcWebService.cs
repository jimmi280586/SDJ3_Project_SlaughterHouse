﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

// 
// This source code was auto-generated by wsdl, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Web.Services.WebServiceBindingAttribute(Name="IJSimpCalcWebServiceSoap11Binding", Namespace="http://webservice")]
public partial class IJSimpCalcWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
    
    private System.Threading.SendOrPostCallback additionOperationCompleted;
    
    /// <remarks/>
    public IJSimpCalcWebService() {
        this.Url = "http://localhost:8080/axis2/services/IJSimpCalcWebService.IJSimpCalcWebServiceHtt" +
            "pSoap11Endpoint/";
    }
    
    /// <remarks/>
    public event additionCompletedEventHandler additionCompleted;
    
    /// <remarks/>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:addition", RequestNamespace="http://webservice", ResponseNamespace="http://webservice", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
    [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
    public string addition() {
        object[] results = this.Invoke("addition", new object[0]);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public System.IAsyncResult Beginaddition(System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("addition", new object[0], callback, asyncState);
    }
    
    /// <remarks/>
    public string Endaddition(System.IAsyncResult asyncResult) {
        object[] results = this.EndInvoke(asyncResult);
        return ((string)(results[0]));
    }
    
    /// <remarks/>
    public void additionAsync() {
        this.additionAsync(null);
    }
    
    /// <remarks/>
    public void additionAsync(object userState) {
        if ((this.additionOperationCompleted == null)) {
            this.additionOperationCompleted = new System.Threading.SendOrPostCallback(this.OnadditionOperationCompleted);
        }
        this.InvokeAsync("addition", new object[0], this.additionOperationCompleted, userState);
    }
    
    private void OnadditionOperationCompleted(object arg) {
        if ((this.additionCompleted != null)) {
            System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
            this.additionCompleted(this, new additionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
        }
    }
    
    /// <remarks/>
    public new void CancelAsync(object userState) {
        base.CancelAsync(userState);
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
public delegate void additionCompletedEventHandler(object sender, additionCompletedEventArgs e);

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "4.6.1055.0")]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
public partial class additionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
    
    private object[] results;
    
    internal additionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
            base(exception, cancelled, userState) {
        this.results = results;
    }
    
    /// <remarks/>
    public string Result {
        get {
            this.RaiseExceptionIfNecessary();
            return ((string)(this.results[0]));
        }
    }
}