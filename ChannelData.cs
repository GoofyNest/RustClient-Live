internal class ChannelData // TypeDefIndex: 1139
{	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }


	internal ArrayList get_ServerProviders() { }

	public ArrayList get_ClientProviders() { }

	public Hashtable get_CustomProperties() { }

	public void CopyFrom(ChannelData other) { }

	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7409
{	internal GranuleInfo[] Granules; // 0x10
	internal int[] ScaleFactorBits; // 0x18


	internal void .ctor() { }

}

