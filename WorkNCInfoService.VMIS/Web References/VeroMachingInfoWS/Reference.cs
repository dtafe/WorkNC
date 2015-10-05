﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace WorkNCInfoService.VMIS.VeroMachingInfoWS {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="VeroMachingInfoWSSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseDomainOfWorkZoneDetail))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseDomainOfWorkZone))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BaseDomainOfMachine))]
    public partial class VeroMachingInfoWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetListMachineFromUserOperationCompleted;
        
        private System.Threading.SendOrPostCallback UploadWorkZoneOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public VeroMachingInfoWS() {
            this.Url = global::WorkNCInfoService.VMIS.Properties.Settings.Default.WorkNCInfoService_VMIS_VeroMachingInfoWS_VeroMachingInfoWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetListMachineFromUserCompletedEventHandler GetListMachineFromUserCompleted;
        
        /// <remarks/>
        public event UploadWorkZoneCompletedEventHandler UploadWorkZoneCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetListMachineFromUser", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Machine[] GetListMachineFromUser(string userName, string password) {
            object[] results = this.Invoke("GetListMachineFromUser", new object[] {
                        userName,
                        password});
            return ((Machine[])(results[0]));
        }
        
        /// <remarks/>
        public void GetListMachineFromUserAsync(string userName, string password) {
            this.GetListMachineFromUserAsync(userName, password, null);
        }
        
        /// <remarks/>
        public void GetListMachineFromUserAsync(string userName, string password, object userState) {
            if ((this.GetListMachineFromUserOperationCompleted == null)) {
                this.GetListMachineFromUserOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetListMachineFromUserOperationCompleted);
            }
            this.InvokeAsync("GetListMachineFromUser", new object[] {
                        userName,
                        password}, this.GetListMachineFromUserOperationCompleted, userState);
        }
        
        private void OnGetListMachineFromUserOperationCompleted(object arg) {
            if ((this.GetListMachineFromUserCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetListMachineFromUserCompleted(this, new GetListMachineFromUserCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UploadWorkZone", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void UploadWorkZone(WorkZone workZoneInfo, WorkZoneDetail[] listWorkZoneDetail) {
            this.Invoke("UploadWorkZone", new object[] {
                        workZoneInfo,
                        listWorkZoneDetail});
        }
        
        /// <remarks/>
        public void UploadWorkZoneAsync(WorkZone workZoneInfo, WorkZoneDetail[] listWorkZoneDetail) {
            this.UploadWorkZoneAsync(workZoneInfo, listWorkZoneDetail, null);
        }
        
        /// <remarks/>
        public void UploadWorkZoneAsync(WorkZone workZoneInfo, WorkZoneDetail[] listWorkZoneDetail, object userState) {
            if ((this.UploadWorkZoneOperationCompleted == null)) {
                this.UploadWorkZoneOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUploadWorkZoneOperationCompleted);
            }
            this.InvokeAsync("UploadWorkZone", new object[] {
                        workZoneInfo,
                        listWorkZoneDetail}, this.UploadWorkZoneOperationCompleted, userState);
        }
        
        private void OnUploadWorkZoneOperationCompleted(object arg) {
            if ((this.UploadWorkZoneCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UploadWorkZoneCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Machine : BaseDomainOfMachine {
        
        private int machineIdField;
        
        private int companyIdField;
        
        private int factoryIdField;
        
        private string noField;
        
        private string nameField;
        
        private bool isDeletedField;
        
        private System.DateTime createDateField;
        
        private string createAccountField;
        
        private System.DateTime modifiedDateField;
        
        private string modifiedAccountField;
        
        /// <remarks/>
        public int MachineId {
            get {
                return this.machineIdField;
            }
            set {
                this.machineIdField = value;
            }
        }
        
        /// <remarks/>
        public int CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public int FactoryId {
            get {
                return this.factoryIdField;
            }
            set {
                this.factoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public bool isDeleted {
            get {
                return this.isDeletedField;
            }
            set {
                this.isDeletedField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreateDate {
            get {
                return this.createDateField;
            }
            set {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        public string CreateAccount {
            get {
                return this.createAccountField;
            }
            set {
                this.createAccountField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ModifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        public string ModifiedAccount {
            get {
                return this.modifiedAccountField;
            }
            set {
                this.modifiedAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Machine))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseDomainOfMachine {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkZoneDetail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseDomainOfWorkZoneDetail {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class WorkZoneDetail : BaseDomainOfWorkZoneDetail {
        
        private string base64DataField;
        
        private int workZoneIdField;
        
        private int workZoneDetailIdField;
        
        private string noField;
        
        private string pathTypeField;
        
        private System.Nullable<double> toolLenthField;
        
        private System.Nullable<double> tnoField;
        
        private System.Nullable<double> stockAllowanceField;
        
        private System.Nullable<double> toleranceField;
        
        private string nCFileNameField;
        
        private string machineTimeField;
        
        private System.Nullable<double> machineDistanceField;
        
        private string toolShapeField;
        
        private System.Nullable<double> toolDiaField;
        
        private System.Nullable<double> toolConerRField;
        
        private string holderNameField;
        
        private System.Nullable<double> spindleField;
        
        private System.Nullable<double> cuttingFeedRateField;
        
        private System.Nullable<double> approachFeedRateField;
        
        private string commentField;
        
        private int statusField;
        
        private string imageFileField;
        
        private System.DateTime createDateField;
        
        private string createAccountField;
        
        private System.DateTime modifiedDateField;
        
        private string modifiedAccountField;
        
        /// <remarks/>
        public string Base64Data {
            get {
                return this.base64DataField;
            }
            set {
                this.base64DataField = value;
            }
        }
        
        /// <remarks/>
        public int WorkZoneId {
            get {
                return this.workZoneIdField;
            }
            set {
                this.workZoneIdField = value;
            }
        }
        
        /// <remarks/>
        public int WorkZoneDetailId {
            get {
                return this.workZoneDetailIdField;
            }
            set {
                this.workZoneDetailIdField = value;
            }
        }
        
        /// <remarks/>
        public string No {
            get {
                return this.noField;
            }
            set {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        public string PathType {
            get {
                return this.pathTypeField;
            }
            set {
                this.pathTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> ToolLenth {
            get {
                return this.toolLenthField;
            }
            set {
                this.toolLenthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> Tno {
            get {
                return this.tnoField;
            }
            set {
                this.tnoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> StockAllowance {
            get {
                return this.stockAllowanceField;
            }
            set {
                this.stockAllowanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> Tolerance {
            get {
                return this.toleranceField;
            }
            set {
                this.toleranceField = value;
            }
        }
        
        /// <remarks/>
        public string NCFileName {
            get {
                return this.nCFileNameField;
            }
            set {
                this.nCFileNameField = value;
            }
        }
        
        /// <remarks/>
        public string MachineTime {
            get {
                return this.machineTimeField;
            }
            set {
                this.machineTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> MachineDistance {
            get {
                return this.machineDistanceField;
            }
            set {
                this.machineDistanceField = value;
            }
        }
        
        /// <remarks/>
        public string ToolShape {
            get {
                return this.toolShapeField;
            }
            set {
                this.toolShapeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> ToolDia {
            get {
                return this.toolDiaField;
            }
            set {
                this.toolDiaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> ToolConerR {
            get {
                return this.toolConerRField;
            }
            set {
                this.toolConerRField = value;
            }
        }
        
        /// <remarks/>
        public string HolderName {
            get {
                return this.holderNameField;
            }
            set {
                this.holderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> Spindle {
            get {
                return this.spindleField;
            }
            set {
                this.spindleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> CuttingFeedRate {
            get {
                return this.cuttingFeedRateField;
            }
            set {
                this.cuttingFeedRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<double> ApproachFeedRate {
            get {
                return this.approachFeedRateField;
            }
            set {
                this.approachFeedRateField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string ImageFile {
            get {
                return this.imageFileField;
            }
            set {
                this.imageFileField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreateDate {
            get {
                return this.createDateField;
            }
            set {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        public string CreateAccount {
            get {
                return this.createAccountField;
            }
            set {
                this.createAccountField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ModifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        public string ModifiedAccount {
            get {
                return this.modifiedAccountField;
            }
            set {
                this.modifiedAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkZone))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BaseDomainOfWorkZone {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34230")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class WorkZone : BaseDomainOfWorkZone {
        
        private string base64DataField;
        
        private int workZoneIdField;
        
        private int companyIdField;
        
        private string companyNameField;
        
        private int factoryIdField;
        
        private string factoryNameField;
        
        private int machineIdField;
        
        private string nameField;
        
        private string workZonePathField;
        
        private string modelDataProgramerField;
        
        private string nCDataProgramerField;
        
        private System.Nullable<System.DateTime> programDateField;
        
        private string modelNameField;
        
        private string partsField;
        
        private string partNameField;
        
        private string machiningTimeTotalField;
        
        private string commentField;
        
        private int statusField;
        
        private string imageFileField;
        
        private System.DateTime createDateField;
        
        private string createAccountField;
        
        private System.DateTime modifiedDateField;
        
        private string modifiedAccountField;
        
        /// <remarks/>
        public string Base64Data {
            get {
                return this.base64DataField;
            }
            set {
                this.base64DataField = value;
            }
        }
        
        /// <remarks/>
        public int WorkZoneId {
            get {
                return this.workZoneIdField;
            }
            set {
                this.workZoneIdField = value;
            }
        }
        
        /// <remarks/>
        public int CompanyId {
            get {
                return this.companyIdField;
            }
            set {
                this.companyIdField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public int FactoryId {
            get {
                return this.factoryIdField;
            }
            set {
                this.factoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string FactoryName {
            get {
                return this.factoryNameField;
            }
            set {
                this.factoryNameField = value;
            }
        }
        
        /// <remarks/>
        public int MachineId {
            get {
                return this.machineIdField;
            }
            set {
                this.machineIdField = value;
            }
        }
        
        /// <remarks/>
        public string Name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string WorkZonePath {
            get {
                return this.workZonePathField;
            }
            set {
                this.workZonePathField = value;
            }
        }
        
        /// <remarks/>
        public string ModelDataProgramer {
            get {
                return this.modelDataProgramerField;
            }
            set {
                this.modelDataProgramerField = value;
            }
        }
        
        /// <remarks/>
        public string NCDataProgramer {
            get {
                return this.nCDataProgramerField;
            }
            set {
                this.nCDataProgramerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public System.Nullable<System.DateTime> ProgramDate {
            get {
                return this.programDateField;
            }
            set {
                this.programDateField = value;
            }
        }
        
        /// <remarks/>
        public string ModelName {
            get {
                return this.modelNameField;
            }
            set {
                this.modelNameField = value;
            }
        }
        
        /// <remarks/>
        public string Parts {
            get {
                return this.partsField;
            }
            set {
                this.partsField = value;
            }
        }
        
        /// <remarks/>
        public string PartName {
            get {
                return this.partNameField;
            }
            set {
                this.partNameField = value;
            }
        }
        
        /// <remarks/>
        public string MachiningTimeTotal {
            get {
                return this.machiningTimeTotalField;
            }
            set {
                this.machiningTimeTotalField = value;
            }
        }
        
        /// <remarks/>
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        public int Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        public string ImageFile {
            get {
                return this.imageFileField;
            }
            set {
                this.imageFileField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime CreateDate {
            get {
                return this.createDateField;
            }
            set {
                this.createDateField = value;
            }
        }
        
        /// <remarks/>
        public string CreateAccount {
            get {
                return this.createAccountField;
            }
            set {
                this.createAccountField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime ModifiedDate {
            get {
                return this.modifiedDateField;
            }
            set {
                this.modifiedDateField = value;
            }
        }
        
        /// <remarks/>
        public string ModifiedAccount {
            get {
                return this.modifiedAccountField;
            }
            set {
                this.modifiedAccountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void GetListMachineFromUserCompletedEventHandler(object sender, GetListMachineFromUserCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetListMachineFromUserCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetListMachineFromUserCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Machine[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Machine[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void UploadWorkZoneCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591