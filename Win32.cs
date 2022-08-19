internal struct Win32_FIXED_INFO // TypeDefIndex: 3083
{	// Fields
	public string HostName; // 0x0
	public string DomainName; // 0x8
	public IntPtr CurrentDnsServer; // 0x10
	public Win32_IP_ADDR_STRING DnsServerList; // 0x18
	public NetBiosNodeType NodeType; // 0x38
	public string ScopeId; // 0x40
	public uint EnableRouting; // 0x48
	public uint EnableProxy; // 0x4C
	public uint EnableDns; // 0x50

}

internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 3084
{	// Fields
	public IntPtr Next; // 0x0
	public string IpAddress; // 0x8
	public string IpMask; // 0x10
	public uint Context; // 0x18

}

