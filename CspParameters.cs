public sealed class CspParameters // TypeDefIndex: 947
{
	public int ProviderType; 
	public string ProviderName; 
	public string KeyContainerName; 
	public int KeyNumber; 
	private int m_flags; 

	public CspProviderFlags Flags { get; set; }


	public CspProviderFlags get_Flags() { }

	public void set_Flags(CspProviderFlags value) { }

	public void .ctor() { }

	public void .ctor(int dwTypeIn) { }

	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

