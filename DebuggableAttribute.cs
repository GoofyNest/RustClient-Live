public sealed class DebuggableAttribute : Attribute // TypeDefIndex: 1495
{
	private DebuggableAttribute.DebuggingModes m_debuggingModes;


	public void .ctor(DebuggableAttribute.DebuggingModes modes) { }

}

public enum DebuggableAttribute.DebuggingModes // TypeDefIndex: 1496
{
	public int value__;
	public const DebuggableAttribute.DebuggingModes None = 0;
	public const DebuggableAttribute.DebuggingModes Default = 1;
	public const DebuggableAttribute.DebuggingModes DisableOptimizations = 256;
	public const DebuggableAttribute.DebuggingModes IgnoreSymbolStoreSequencePoints = 2;
	public const DebuggableAttribute.DebuggingModes EnableEditAndContinue = 4;

}

