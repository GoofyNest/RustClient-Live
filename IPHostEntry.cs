public class IPHostEntry // TypeDefIndex: 2884
{	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }


	public string get_HostName() { }

	public void set_HostName(string value) { }

	public void set_Aliases(string[] value) { }

	public IPAddress[] get_AddressList() { }

	public void set_AddressList(IPAddress[] value) { }

	public void .ctor() { }

}

