internal struct Win32_FIXED_INFO // TypeDefIndex: 3083
{
	public string HostName; 
	public string DomainName; 
	public IntPtr CurrentDnsServer; 
	public Win32_IP_ADDR_STRING DnsServerList; 
	public NetBiosNodeType NodeType; 
	public string ScopeId; 
	public uint EnableRouting; 
	public uint EnableProxy; 
	public uint EnableDns; 

}

internal struct Win32_IP_ADDR_STRING // TypeDefIndex: 3084
{
	public IntPtr Next; 
	public string IpAddress; 
	public string IpMask; 
	public uint Context; 

}

