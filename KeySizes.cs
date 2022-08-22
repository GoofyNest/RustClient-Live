public sealed class KeySizes // TypeDefIndex: 943
{	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }


	public int get_MinSize() { }

	public int get_MaxSize() { }

	public int get_SkipSize() { }

	public void .ctor(int minSize, int maxSize, int skipSize) { }

	internal bool IsLegal(int keySize) { }

	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }

}

