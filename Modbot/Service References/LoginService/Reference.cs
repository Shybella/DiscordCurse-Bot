﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modbot.LoginService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginRequest", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class LoginRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EncryptedPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EncryptedPassword {
            get {
                return this.EncryptedPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.EncryptedPasswordField, value) != true)) {
                    this.EncryptedPasswordField = value;
                    this.RaisePropertyChanged("EncryptedPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LoginResponse", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class LoginResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Modbot.LoginService.AuthenticationSession SessionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Modbot.LoginService.AuthenticationStatus StatusField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modbot.LoginService.AuthenticationSession Session {
            get {
                return this.SessionField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionField, value) != true)) {
                    this.SessionField = value;
                    this.RaisePropertyChanged("Session");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modbot.LoginService.AuthenticationStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationSession", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class AuthenticationSession : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActualPremiumStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EffectivePremiumStatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SubscriptionTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ActualPremiumStatus {
            get {
                return this.ActualPremiumStatusField;
            }
            set {
                if ((this.ActualPremiumStatusField.Equals(value) != true)) {
                    this.ActualPremiumStatusField = value;
                    this.RaisePropertyChanged("ActualPremiumStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EffectivePremiumStatus {
            get {
                return this.EffectivePremiumStatusField;
            }
            set {
                if ((this.EffectivePremiumStatusField.Equals(value) != true)) {
                    this.EffectivePremiumStatusField = value;
                    this.RaisePropertyChanged("EffectivePremiumStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionID {
            get {
                return this.SessionIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIDField, value) != true)) {
                    this.SessionIDField = value;
                    this.RaisePropertyChanged("SessionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SubscriptionToken {
            get {
                return this.SubscriptionTokenField;
            }
            set {
                if ((this.SubscriptionTokenField.Equals(value) != true)) {
                    this.SubscriptionTokenField = value;
                    this.RaisePropertyChanged("SubscriptionToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationStatus", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    public enum AuthenticationStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unsuccessful = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidSession = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnauthorizedLogin = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidPassword = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownUsername = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownEmail = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownError = 100,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IncorrectTime = 101,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        CorruptLibrary = 102,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OutdatedClient = 103,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SubscriptionMismatch = 104,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SubscriptionExpired = 105,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InsufficientAccessLevel = 106,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidApiKey = 107,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        MissingGrant = 108,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterRequest", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class RegisterRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool NewsletterOptInField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool NewsletterOptIn {
            get {
                return this.NewsletterOptInField;
            }
            set {
                if ((this.NewsletterOptInField.Equals(value) != true)) {
                    this.NewsletterOptInField = value;
                    this.RaisePropertyChanged("NewsletterOptIn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterUserResult", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class RegisterUserResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Modbot.LoginService.RegisterUserStatus StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionID {
            get {
                return this.SessionIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionIDField, value) != true)) {
                    this.SessionIDField = value;
                    this.RaisePropertyChanged("SessionID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Modbot.LoginService.RegisterUserStatus Status {
            get {
                return this.StatusField;
            }
            set {
                if ((this.StatusField.Equals(value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RegisterUserStatus", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    public enum RegisterUserStatus : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Successful = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        EmailInUse = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UsernameInUse = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InsufficientPermissions = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidProfile = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidUsername = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidNetworkSite = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InvalidPassword = 7,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        UnknownError = 8,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CheckUsernameAvailabilityRequest", Namespace="http://schemas.datacontract.org/2004/07/Curse.ServiceAuthentication.Models")]
    [System.SerializableAttribute()]
    public partial class CheckUsernameAvailabilityRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://clientservice.curse.com/", ConfigurationName="LoginService.IClientLoginService")]
    public interface IClientLoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/Login", ReplyAction="http://clientservice.curse.com/IClientLoginService/LoginResponse")]
        Modbot.LoginService.LoginResponse Login(Modbot.LoginService.LoginRequest loginRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/Login", ReplyAction="http://clientservice.curse.com/IClientLoginService/LoginResponse")]
        System.Threading.Tasks.Task<Modbot.LoginService.LoginResponse> LoginAsync(Modbot.LoginService.LoginRequest loginRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/Register", ReplyAction="http://clientservice.curse.com/IClientLoginService/RegisterResponse")]
        Modbot.LoginService.RegisterUserResult Register(Modbot.LoginService.RegisterRequest registerRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/Register", ReplyAction="http://clientservice.curse.com/IClientLoginService/RegisterResponse")]
        System.Threading.Tasks.Task<Modbot.LoginService.RegisterUserResult> RegisterAsync(Modbot.LoginService.RegisterRequest registerRequest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/CheckUsernameAvailability", ReplyAction="http://clientservice.curse.com/IClientLoginService/CheckUsernameAvailabilityRespo" +
            "nse")]
        bool CheckUsernameAvailability(Modbot.LoginService.CheckUsernameAvailabilityRequest username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://clientservice.curse.com/IClientLoginService/CheckUsernameAvailability", ReplyAction="http://clientservice.curse.com/IClientLoginService/CheckUsernameAvailabilityRespo" +
            "nse")]
        System.Threading.Tasks.Task<bool> CheckUsernameAvailabilityAsync(Modbot.LoginService.CheckUsernameAvailabilityRequest username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IClientLoginServiceChannel : Modbot.LoginService.IClientLoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClientLoginServiceClient : System.ServiceModel.ClientBase<Modbot.LoginService.IClientLoginService>, Modbot.LoginService.IClientLoginService {
        
        public ClientLoginServiceClient() {
        }
        
        public ClientLoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClientLoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientLoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClientLoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Modbot.LoginService.LoginResponse Login(Modbot.LoginService.LoginRequest loginRequest) {
            return base.Channel.Login(loginRequest);
        }
        
        public System.Threading.Tasks.Task<Modbot.LoginService.LoginResponse> LoginAsync(Modbot.LoginService.LoginRequest loginRequest) {
            return base.Channel.LoginAsync(loginRequest);
        }
        
        public Modbot.LoginService.RegisterUserResult Register(Modbot.LoginService.RegisterRequest registerRequest) {
            return base.Channel.Register(registerRequest);
        }
        
        public System.Threading.Tasks.Task<Modbot.LoginService.RegisterUserResult> RegisterAsync(Modbot.LoginService.RegisterRequest registerRequest) {
            return base.Channel.RegisterAsync(registerRequest);
        }
        
        public bool CheckUsernameAvailability(Modbot.LoginService.CheckUsernameAvailabilityRequest username) {
            return base.Channel.CheckUsernameAvailability(username);
        }
        
        public System.Threading.Tasks.Task<bool> CheckUsernameAvailabilityAsync(Modbot.LoginService.CheckUsernameAvailabilityRequest username) {
            return base.Channel.CheckUsernameAvailabilityAsync(username);
        }
    }
}
