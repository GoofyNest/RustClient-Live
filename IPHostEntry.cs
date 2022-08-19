public class IPHostEntry // TypeDefIndex: 2884
{	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_HostName() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_HostName(string value) { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_Aliases(string[] value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public IPAddress[] get_AddressList() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0xA33210 Offset: 0xA32610 VA: 0x180A33210
	public void .ctor() { }

}

