public sealed class CspParameters // TypeDefIndex: 947
{	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0
	public CspProviderFlags get_Flags() { }

	// RVA: 0x16F78A0 Offset: 0x16F6CA0 VA: 0x1816F78A0
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x16F7770 Offset: 0x16F6B70 VA: 0x1816F7770
	public void .ctor() { }

	// RVA: 0x16F77D0 Offset: 0x16F6BD0 VA: 0x1816F77D0
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x16F7830 Offset: 0x16F6C30 VA: 0x1816F7830
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x16F76F0 Offset: 0x16F6AF0 VA: 0x1816F76F0
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }

}

