internal class ReadContentAsBinaryHelper // TypeDefIndex: 1860
{	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0xF5B7B0 Offset: 0xF5ABB0 VA: 0x180F5B7B0
	internal void Finish() { }

	// RVA: 0xF5BB40 Offset: 0xF5AF40 VA: 0x180F5BB40
	internal void Reset() { }

	// RVA: 0xF5BA00 Offset: 0xF5AE00 VA: 0x180F5BA00
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

}

private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 1861
{	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;

}

