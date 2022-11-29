public struct MemoryBuffer // TypeDefIndex: 6953
{
	[CompilerGeneratedAttribute] 
	private byte[] <Data>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <Length>k__BackingField; 
	private readonly bool _fromPool; 

	public byte[] Data { get; set; }
	public int Length { get; set; }


	[CompilerGeneratedAttribute] 
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] 
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] 
	public int get_Length() { }

	[CompilerGeneratedAttribute] 
	private void set_Length(int value) { }

	internal void .ctor(byte[] data, int length, bool fromPool = True) { }

	public void Dispose() { }

	public static Span<byte> op_Implicit(MemoryBuffer buffer) { }

}

