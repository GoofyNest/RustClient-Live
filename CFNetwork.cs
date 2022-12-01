internal static class CFNetwork // TypeDefIndex: 2525
{
	private static object lock_obj;
	private static Queue<CFNetwork.GetProxyData> get_proxy_queue;
	private static AutoResetEvent proxy_event;


	private static extern IntPtr CFNetworkCopyProxiesForAutoConfigurationScriptSequential(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	private static extern IntPtr CFNetworkExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, IntPtr targetURL, CFNetwork.CFProxyAutoConfigurationResultCallback cb, ref CFStreamClientContext clientContext) { }

	private static void CFNetworkCopyProxiesForAutoConfigurationScriptThread() { }

	private static IntPtr CFNetworkCopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, IntPtr targetURL, out IntPtr error) { }

	private static CFArray CopyProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, CFUrl targetURL) { }

	public static CFProxy[] GetProxiesForAutoConfigurationScript(IntPtr proxyAutoConfigurationScript, Uri targetUri) { }

	public static CFProxy[] ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetURL) { }

	private static extern IntPtr CFNetworkCopyProxiesForURL(IntPtr url, IntPtr proxySettings) { }

	private static CFArray CopyProxiesForURL(CFUrl url, CFDictionary proxySettings) { }

	public static CFProxy[] GetProxiesForURL(CFUrl url, CFProxySettings proxySettings) { }

	public static CFProxy[] GetProxiesForUri(Uri uri, CFProxySettings proxySettings) { }

	private static extern IntPtr CFNetworkCopySystemProxySettings() { }

	public static CFProxySettings GetSystemProxySettings() { }

	public static IWebProxy GetDefaultProxy() { }

	private static void .cctor() { }

}

private class CFNetwork.GetProxyData : IDisposable // TypeDefIndex: 2526
{
	public IntPtr script;
	public IntPtr targetUri;
	public IntPtr error;
	public IntPtr result;
	public ManualResetEvent evt;


	public void Dispose() { }

	public void .ctor() { }

}

private sealed class CFNetwork.CFProxyAutoConfigurationResultCallback : MulticastDelegate // TypeDefIndex: 2527
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(IntPtr client, IntPtr proxyList, IntPtr error) { }

	public virtual IAsyncResult BeginInvoke(IntPtr client, IntPtr proxyList, IntPtr error, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private class CFNetwork.CFWebProxy : IWebProxy // TypeDefIndex: 2528
{
	private ICredentials credentials;
	private bool userSpecified;

	public ICredentials Credentials { get; }


	public void .ctor() { }

	public ICredentials get_Credentials() { }

	private static Uri GetProxyUri(CFProxy proxy, out NetworkCredential credentials) { }

	private static Uri GetProxyUriFromScript(IntPtr script, Uri targetUri, out NetworkCredential credentials) { }

	private static Uri ExecuteProxyAutoConfigurationURL(IntPtr proxyAutoConfigURL, Uri targetUri, out NetworkCredential credentials) { }

	private static Uri SelectProxy(CFProxy[] proxies, Uri targetUri, out NetworkCredential credentials) { }

	public Uri GetProxy(Uri targetUri) { }

	public bool IsBypassed(Uri targetUri) { }

}

private sealed class CFNetwork.<>c__DisplayClass13_0 // TypeDefIndex: 2529
{
	public CFProxy[] proxies;
	public CFRunLoop runLoop;


	public void .ctor() { }

	internal void <ExecuteProxyAutoConfigurationURL>

}

