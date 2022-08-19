public struct MemoryBuffer // TypeDefIndex: 6915
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private byte[] <Data>k__BackingField; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <Length>k__BackingField; // 0x8
	private readonly bool _fromPool; // 0xC

	// Properties
	public byte[] Data { get; set; }
	public int Length { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFC6D0 Offset: 0xFBAD0 VA: 0x1800FC6D0
	public byte[] get_Data() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	private void set_Data(byte[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x122CA0 Offset: 0x1220A0 VA: 0x180122CA0
	public int get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DDE0 Offset: 0x19D1E0 VA: 0x18019DDE0
	private void set_Length(int value) { }

	// RVA: 0x237140 Offset: 0x236540 VA: 0x180237140
	internal void .ctor(byte[] data, int length, bool fromPool = True) { }

	// RVA: 0x237130 Offset: 0x236530 VA: 0x180237130
	public void Dispose() { }

	// RVA: 0x22022E0 Offset: 0x22016E0 VA: 0x1822022E0
	public static Span<byte> op_Implicit(MemoryBuffer buffer) { }

}

