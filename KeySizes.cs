public sealed class KeySizes // TypeDefIndex: 943
{	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_MinSize() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_MaxSize() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_SkipSize() { }

	// RVA: 0xEA6E10 Offset: 0xEA6210 VA: 0x180EA6E10
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x16FD720 Offset: 0x16FCB20 VA: 0x1816FD720
	internal bool IsLegal(int keySize) { }

	// RVA: 0x16FD680 Offset: 0x16FCA80 VA: 0x1816FD680
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

