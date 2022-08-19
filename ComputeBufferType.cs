public enum ComputeBufferType // TypeDefIndex: 3413
{	// Fields
	public int value__; // 0x0
	public const ComputeBufferType Default = 0;
	public const ComputeBufferType Raw = 1;
	public const ComputeBufferType Append = 2;
	public const ComputeBufferType Counter = 4;
	public const ComputeBufferType Constant = 8;
	public const ComputeBufferType Structured = 16;
	[ObsoleteAttribute] // RVA: 0x95C00 Offset: 0x95000 VA: 0x180095C00
	public const ComputeBufferType DrawIndirect = 256;
	public const ComputeBufferType IndirectArguments = 256;
	[ObsoleteAttribute] // RVA: 0x95CC0 Offset: 0x950C0 VA: 0x180095CC0
	public const ComputeBufferType GPUMemory = 512;

}

