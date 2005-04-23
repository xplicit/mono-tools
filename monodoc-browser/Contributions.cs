// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 1.1.4322.573
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------


/// <remarks/>
/// <remarks>
/// Web service for the MonoDoc contribution system
/// </remarks>
[System.Web.Services.WebServiceBinding(Name="ContributionsSoap",Namespace="http://tempuri.org/"),
System.Diagnostics.DebuggerStepThroughAttribute(),
System.ComponentModel.DesignerCategoryAttribute("code")]
public class ContributionsSoap : System.Web.Services.Protocols.SoapHttpClientProtocol {

    public ContributionsSoap () {
        this.Url = "http://localhost:8080/server.asmx";
    }

    /// <remarks>
    /// Check the client/server version;  0 means that the server can consume your data
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/CheckVersion",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual int CheckVersion(int version) {
        System.Object[] results = this.Invoke("CheckVersion", new object[] {
            version});
        return ((int)(results[0]));
    }

    public virtual System.IAsyncResult BeginCheckVersion(int version, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("CheckVersion", new object[] {
            version}, callback, asyncState);
    }

    public virtual int EndCheckVersion(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks>
    /// Requests a registration for a login
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Register",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual int Register(string login) {
        System.Object[] results = this.Invoke("Register", new object[] {
            login});
        return ((int)(results[0]));
    }

    public virtual System.IAsyncResult BeginRegister(string login, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Register", new object[] {
            login}, callback, asyncState);
    }

    public virtual int EndRegister(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks>
    /// Returns the latest serial number used for a change on the server
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetSerial",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual int GetSerial(string login, string password) {
        System.Object[] results = this.Invoke("GetSerial", new object[] {
            login,
            password});
        return ((int)(results[0]));
    }

    public virtual System.IAsyncResult BeginGetSerial(string login, string password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetSerial", new object[] {
            login,
            password}, callback, asyncState);
    }

    public virtual int EndGetSerial(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks>
    /// Submits a GlobalChangeSet as a contribution
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Submit",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual int Submit(string login, string password, System.Xml.XmlElement node) {
        System.Object[] results = this.Invoke("Submit", new object[] {
            login,
            password,
            node});
        return ((int)(results[0]));
    }

    public virtual System.IAsyncResult BeginSubmit(string login, string password, System.Xml.XmlElement node, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("Submit", new object[] {
            login,
            password,
            node}, callback, asyncState);
    }

    public virtual int EndSubmit(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((int)(results[0]));
    }

    /// <remarks>
    /// Obtains the list of pending contributions
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetPendingChanges",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual PendingChange[] GetPendingChanges(string login, string password) {
        System.Object[] results = this.Invoke("GetPendingChanges", new object[] {
            login,
            password});
        return ((PendingChange[])(results[0]));
    }

    public virtual System.IAsyncResult BeginGetPendingChanges(string login, string password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetPendingChanges", new object[] {
            login,
            password}, callback, asyncState);
    }

    public virtual PendingChange[] EndGetPendingChanges(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((PendingChange[])(results[0]));
    }

    /// <remarks>
    /// Obtains a change set for a user
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/FetchContribution",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual System.Xml.XmlElement FetchContribution(string login, string password, int person_id, int serial) {
        System.Object[] results = this.Invoke("FetchContribution", new object[] {
            login,
            password,
            person_id,
            serial});
        return ((System.Xml.XmlElement)(results[0]));
    }

    public virtual System.IAsyncResult BeginFetchContribution(string login, string password, int person_id, int serial, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("FetchContribution", new object[] {
            login,
            password,
            person_id,
            serial}, callback, asyncState);
    }

    public virtual System.Xml.XmlElement EndFetchContribution(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((System.Xml.XmlElement)(results[0]));
    }

    /// <remarks>
    /// ADMIN: Obtains the number of pending commits
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetStatus",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual Status GetStatus(string login, string password) {
        System.Object[] results = this.Invoke("GetStatus", new object[] {
            login,
            password});
        return ((Status)(results[0]));
    }

    public virtual System.IAsyncResult BeginGetStatus(string login, string password, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("GetStatus", new object[] {
            login,
            password}, callback, asyncState);
    }

    public virtual Status EndGetStatus(System.IAsyncResult asyncResult) {
        System.Object[] results = this.EndInvoke(asyncResult);
        return ((Status)(results[0]));
    }

    /// <remarks>
    /// ADMIN: Updates the status of a contribution
    /// </remarks>
    [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/UpdateStatus",RequestNamespace="http://tempuri.org/",ResponseNamespace="http://tempuri.org/",ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped,Use=System.Web.Services.Description.SoapBindingUse.Literal)]
    public virtual void UpdateStatus(string login, string password, int person_id, int contrib_id, int status) {
        this.Invoke("UpdateStatus", new object[] {
            login,
            password,
            person_id,
            contrib_id,
            status});
    }

    public virtual System.IAsyncResult BeginUpdateStatus(string login, string password, int person_id, int contrib_id, int status, System.AsyncCallback callback, object asyncState) {
        return this.BeginInvoke("UpdateStatus", new object[] {
            login,
            password,
            person_id,
            contrib_id,
            status}, callback, asyncState);
    }

    public virtual void EndUpdateStatus(System.IAsyncResult asyncResult) {
        this.EndInvoke(asyncResult);
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlType(Namespace="http://tempuri.org/")]
public class PendingChange {

    /// <remarks/>
    public string Login;

    /// <remarks/>
    public int ID;

    /// <remarks/>
    public int Serial;
}

/// <remarks/>
[System.Xml.Serialization.XmlType(Namespace="http://tempuri.org/")]
public class Status {

    /// <remarks/>
    public int Contributions;

    /// <remarks/>
    public int Commited;

    /// <remarks/>
    public int Pending;
}

