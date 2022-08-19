public sealed class DebuggableAttribute : Attribute // TypeDefIndex: 1495
{	// Fields
	private DebuggableAttribute.DebuggingModes m_debuggingModes; // 0x10

	// Methods

	// RVA: 0xB0C8A0 Offset: 0xB0BCA0 VA: 0x180B0C8A0
	public void .ctor(DebuggableAttribute.DebuggingModes modes) { }

}

public enum DebuggableAttribute.DebuggingModes // TypeDefIndex: 1496
{	// Fields
	public int value__; // 0x0
	public const DebuggableAttribute.DebuggingModes None = 0;
	public const DebuggableAttribute.DebuggingModes Default = 1;
	public const DebuggableAttribute.DebuggingModes DisableOptimizations = 256;
	public const DebuggableAttribute.DebuggingModes IgnoreSymbolStoreSequencePoints = 2;
	public const DebuggableAttribute.DebuggingModes EnableEditAndContinue = 4;

}

