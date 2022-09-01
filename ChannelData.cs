internal class ChannelData // TypeDefIndex: 1139
{
	internal string Ref; 
	internal string Type; 
	internal string Id; 
	internal string DelayLoadAsClientChannel; 
	private ArrayList _serverProviders; 
	private ArrayList _clientProviders; 
	private Hashtable _customProperties; 

	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }


	internal ArrayList get_ServerProviders() { }

	public ArrayList get_ClientProviders() { }

	public Hashtable get_CustomProperties() { }

	public void CopyFrom(ChannelData other) { }

	public void .ctor() { }

}

public class ChannelData // TypeDefIndex: 7410
{
	internal GranuleInfo[] Granules; 
	internal int[] ScaleFactorBits; 


	internal void .ctor() { }

}

