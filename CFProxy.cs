internal class CFProxy // TypeDefIndex: 2523
{	// Fields
	private static IntPtr kCFProxyAutoConfigurationJavaScriptKey; // 0x0
	private static IntPtr kCFProxyAutoConfigurationURLKey; // 0x8
	private static IntPtr kCFProxyHostNameKey; // 0x10
	private static IntPtr kCFProxyPasswordKey; // 0x18
	private static IntPtr kCFProxyPortNumberKey; // 0x20
	private static IntPtr kCFProxyTypeKey; // 0x28
	private static IntPtr kCFProxyUsernameKey; // 0x30
	private static IntPtr kCFProxyTypeAutoConfigurationURL; // 0x38
	private static IntPtr kCFProxyTypeAutoConfigurationJavaScript; // 0x40
	private static IntPtr kCFProxyTypeFTP; // 0x48
	private static IntPtr kCFProxyTypeHTTP; // 0x50
	private static IntPtr kCFProxyTypeHTTPS; // 0x58
	private static IntPtr kCFProxyTypeSOCKS; // 0x60
	private CFDictionary settings; // 0x10

	// Properties
	public IntPtr AutoConfigurationJavaScript { get; }
	public IntPtr AutoConfigurationUrl { get; }
	public string HostName { get; }
	public string Password { get; }
	public int Port { get; }
	public CFProxyType ProxyType { get; }
	public string Username { get; }

	// Methods

	// RVA: 0x120DD10 Offset: 0x120D110 VA: 0x18120DD10
	private static void .cctor() { }

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(CFDictionary settings) { }

	// RVA: 0x120DB10 Offset: 0x120CF10 VA: 0x18120DB10
	private static CFProxyType CFProxyTypeToEnum(IntPtr type) { }

	// RVA: 0x120DF30 Offset: 0x120D330 VA: 0x18120DF30
	public IntPtr get_AutoConfigurationJavaScript() { }

	// RVA: 0x120DFF0 Offset: 0x120D3F0 VA: 0x18120DFF0
	public IntPtr get_AutoConfigurationUrl() { }

	// RVA: 0x120E0B0 Offset: 0x120D4B0 VA: 0x18120E0B0
	public string get_HostName() { }

	// RVA: 0x120E180 Offset: 0x120D580 VA: 0x18120E180
	public string get_Password() { }

	// RVA: 0x120E250 Offset: 0x120D650 VA: 0x18120E250
	public int get_Port() { }

	// RVA: 0x120E3F0 Offset: 0x120D7F0 VA: 0x18120E3F0
	public CFProxyType get_ProxyType() { }

	// RVA: 0x120E4C0 Offset: 0x120D8C0 VA: 0x18120E4C0
	public string get_Username() { }

}

