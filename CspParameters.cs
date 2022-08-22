public sealed class CspParameters // TypeDefIndex: 947
{	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	public CspProviderFlags Flags { get; set; }


	public CspProviderFlags get_Flags() { }

	public void set_Flags(CspProviderFlags value) { }

	public void .ctor() { }

	public void .ctor(int dwTypeIn) { }

	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

