internal class CFProxy // TypeDefIndex: 2523
{
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; 
	private static IntPtr kCFProxyAutoConfigurationURLKey; 
	private static IntPtr kCFProxyHostNameKey; 
	private static IntPtr kCFProxyPasswordKey; 
	private static IntPtr kCFProxyPortNumberKey; 
	private static IntPtr kCFProxyTypeKey; 
	private static IntPtr kCFProxyUsernameKey; 
	private static IntPtr kCFProxyTypeAutoConfigurationURL; 
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; 
	private static IntPtr kCFProxyTypeFTP; 
	private static IntPtr kCFProxyTypeHTTP; 
	private static IntPtr kCFProxyTypeHTTPS; 
	private static IntPtr kCFProxyTypeSOCKS; 
	private CFDictionary settings; 

	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public string HostName { get; }
	public string Password { get; }
	public int Port { get; }
	public CFProxyType ProxyType { get; }
	public string Username { get; }


	private static void .cctor() { }

	internal void .ctor(CFDictionary settings) { }

	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	public IntPtr get_AutoConfigurationJavaScript() { }

	public IntPtr get_AutoConfigurationUrl() { }

	public string get_HostName() { }

	public string get_Password() { }

	public int get_Port() { }

	public CFProxyType get_ProxyType() { }

	public string get_Username() { }

}

