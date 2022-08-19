internal static class CFNetwork // TypeDefIndex: 2525
{	// Fields
	private static object lock_obj; // 0x0
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue; // 0x8
	private static AutoResetEvent proxy_event; // 0x10

	// Methods

	// RVA: 0x120B2E0 Offset: 0x120A6E0 VA: 0x18120B2E0
	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x120BBA0 Offset: 0x120AFA0 VA: 0x18120BBA0
	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	// RVA: 0x120B380 Offset: 0x120A780 VA: 0x18120B380
	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	// RVA: 0x120B6C0 Offset: 0x120AAC0 VA: 0x18120B6C0
	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	// RVA: 0x120BC50 Offset: 0x120B050 VA: 0x18120BC50
	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x120C430 Offset: 0x120B830 VA: 0x18120C430
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	// RVA: 0x120C2E0 Offset: 0x120B6E0 VA: 0x18120C2E0
	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	// RVA: 0x120BE50 Offset: 0x120B250 VA: 0x18120BE50
	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	// RVA: 0x120BAA0 Offset: 0x120AEA0 VA: 0x18120BAA0
	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	// RVA: 0x120BD20 Offset: 0x120B120 VA: 0x18120BD20
	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	// RVA: 0x120C7B0 Offset: 0x120BBB0 VA: 0x18120C7B0
	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	// RVA: 0x120CB90 Offset: 0x120BF90 VA: 0x18120CB90
	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	// RVA: 0x120BB30 Offset: 0x120AF30 VA: 0x18120BB30
	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	// RVA: 0x120CCB0 Offset: 0x120C0B0 VA: 0x18120CCB0
	public static CFProxySettings GetSystemProxySettings() { }

	// RVA: 0x120C290 Offset: 0x120B690 VA: 0x18120C290
	public static IWebProxy GetDefaultProxy() { }

	// RVA: 0x120CDC0 Offset: 0x120C1C0 VA: 0x18120CDC0
	private static void .cctor() { }

}

private class CFNetwork.GetProxyData : IDisposable // TypeDefIndex: 2526
{	// Fields
	public IntPtr script; // 0x10
	public IntPtr targetUri; // 0x18
	public IntPtr error; // 0x20
	public IntPtr result; // 0x28
	public ManualResetEvent evt; // 0x30

	// Methods

	// RVA: 0x1211770 Offset: 0x1210B70 VA: 0x181211770 Slot: 4
	public void Dispose() { }

	// RVA: 0x12117A0 Offset: 0x1210BA0 VA: 0x1812117A0
	public void .ctor() { }

}

private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2527
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x120D690 Offset: 0x120CA90 VA: 0x18120D690 Slot: 12
	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	// RVA: 0x120D5F0 Offset: 0x120C9F0 VA: 0x18120D5F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

private class CFNetwork.CFWebProxy : IWebProxy // TypeDefIndex: 2528
{	// Fields
	private ICredentials credentials; // 0x10
	private bool userSpecified; // 0x18

	// Properties
	public ICredentials Credentials { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x120F690 Offset: 0x120EA90 VA: 0x18120F690
	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	// RVA: 0x120F4E0 Offset: 0x120E8E0 VA: 0x18120F4E0
	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x120F460 Offset: 0x120E860 VA: 0x18120F460
	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x1210040 Offset: 0x120F440 VA: 0x181210040
	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	// RVA: 0x120FB90 Offset: 0x120EF90 VA: 0x18120FB90 Slot: 4
	public Uri GetProxy(Uri targetUri) { }

	// RVA: 0x120FF60 Offset: 0x120F360 VA: 0x18120FF60 Slot: 5
	public bool IsBypassed(Uri targetUri) { }

}

private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2529
{	// Fields
	public CFProxy[] proxies; // 0x10
	public CFRunLoop runLoop; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1218790 Offset: 0x1217B90 VA: 0x181218790
	internal void <ExecuteProxyAutoConfigurationURL>b__0(IntPtr client, IntPtr proxyList, IntPtr error) { }

}

