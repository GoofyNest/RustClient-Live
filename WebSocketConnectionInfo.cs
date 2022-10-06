public class WebSocketConnectionInfo : IWebSocketConnectionInfo // TypeDefIndex: 6961
{
	[CompilerGeneratedAttribute] 
	private string <SubProtocol>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Origin>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Host>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <Path>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IPAddress <ClientIpAddress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ClientPort>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Guid <Id>k__BackingField; 

	private string SubProtocol { set; }
	private string Origin { set; }
	private string Host { set; }
	public string Path { get; set; }
	public IPAddress ClientIpAddress { get; set; }
	public int ClientPort { set; }
	public Guid Id { set; }


	public static WebSocketConnectionInfo Create(WebSocketHttpRequest request, IPAddress clientIp, int clientPort) { }

	private void .ctor() { }

	[CompilerGeneratedAttribute] 
	private void set_SubProtocol(string value) { }

	[CompilerGeneratedAttribute] 
	private void set_Origin(string value) { }

	[CompilerGeneratedAttribute] 
	private void set_Host(string value) { }

	[CompilerGeneratedAttribute] 
	public string get_Path() { }

	[CompilerGeneratedAttribute] 
	private void set_Path(string value) { }

	[CompilerGeneratedAttribute] 
	public IPAddress get_ClientIpAddress() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientIpAddress(IPAddress value) { }

	[CompilerGeneratedAttribute] 
	public void set_ClientPort(int value) { }

	[CompilerGeneratedAttribute] 
	public void set_Id(Guid value) { }

}

