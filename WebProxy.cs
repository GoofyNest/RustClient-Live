public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 2978
{
	private bool _UseRegistry; 
	private bool _BypassOnLocal; 
	private bool m_EnableAutoproxy; 
	private Uri _ProxyAddress; 
	private ArrayList _BypassList; 
	private ICredentials _Credentials; 
	private Regex[] _RegExBypassList; 
	private Hashtable _ProxyHostAddresses; 
	private AutoWebProxyScriptEngine m_ScriptEngine; 

	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }


	public void .ctor() { }

	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	public ICredentials get_Credentials() { }

	public bool get_UseDefaultCredentials() { }

	public void set_UseDefaultCredentials(bool value) { }

	public Uri GetProxy(Uri destination) { }

	private void UpdateRegExList(bool canThrow) { }

	private bool IsMatchInBypassList(Uri input) { }

	private bool IsLocal(Uri host) { }

	private bool IsLocalInProxyHash(Uri host) { }

	public bool IsBypassed(Uri host) { }

	private bool IsBypassedManual(Uri host) { }

	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	public static IWebProxy CreateDefaultProxy() { }

	internal void .ctor(bool enableAutoproxy) { }

	internal void UnsafeUpdateFromRegistry() { }

	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	private static Uri ProxyUri(string proxyName) { }

}

