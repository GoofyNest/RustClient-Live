public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 2978
{	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x1187F20 Offset: 0x1187320 VA: 0x181187F20
	public void .ctor() { }

	// RVA: 0x1187BA0 Offset: 0x1186FA0 VA: 0x181187BA0
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x1187F80 Offset: 0x1187380 VA: 0x181187F80
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x1188000 Offset: 0x1187400 VA: 0x181188000
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1186D30 Offset: 0x1186130 VA: 0x181186D30 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x11879D0 Offset: 0x1186DD0 VA: 0x1811879D0
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x11877A0 Offset: 0x1186BA0 VA: 0x1811877A0
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x1187620 Offset: 0x1186A20 VA: 0x181187620
	private bool IsLocal(Uri host) { }

	// RVA: 0x1187520 Offset: 0x1186920 VA: 0x181187520
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x11873E0 Offset: 0x11867E0 VA: 0x1811873E0 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1186FC0 Offset: 0x11863C0 VA: 0x181186FC0
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1187CA0 Offset: 0x11870A0 VA: 0x181187CA0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x11879A0 Offset: 0x1186DA0 VA: 0x1811879A0 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1186A40 Offset: 0x1185E40 VA: 0x181186A40 Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x4B9440 Offset: 0x4B8840 VA: 0x1804B9440
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x11869F0 Offset: 0x1185DF0 VA: 0x1811869F0
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x1187C70 Offset: 0x1187070 VA: 0x181187C70
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x101B920 Offset: 0x101AD20 VA: 0x18101B920
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x1186B60 Offset: 0x1185F60 VA: 0x181186B60
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x1186EF0 Offset: 0x11862F0 VA: 0x181186EF0
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x1186840 Offset: 0x1185C40 VA: 0x181186840
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x1187920 Offset: 0x1186D20 VA: 0x181187920
	private static Uri ProxyUri(string proxyName) { }

}

