internal class ChannelData // TypeDefIndex: 1139
{	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0xFD89E0 Offset: 0xFD7DE0 VA: 0x180FD89E0
	internal ArrayList get_ServerProviders() { }

	// RVA: 0xFD8900 Offset: 0xFD7D00 VA: 0x180FD8900
	public ArrayList get_ClientProviders() { }

	// RVA: 0xFD8970 Offset: 0xFD7D70 VA: 0x180FD8970
	public Hashtable get_CustomProperties() { }

	// RVA: 0xFD8020 Offset: 0xFD7420 VA: 0x180FD8020
	public void CopyFrom(ChannelData other) { }

	// RVA: 0xFD8840 Offset: 0xFD7C40 VA: 0x180FD8840
	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7409
{	// Fields
	internal GranuleInfo[] Granules; // 0x10
	internal int[] ScaleFactorBits; // 0x18

	// Methods

	// RVA: 0x5F5B40 Offset: 0x5F4F40 VA: 0x1805F5B40
	internal void .ctor() { }

}

