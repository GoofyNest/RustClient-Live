public class ContentRangeHeaderValue : ICloneable // TypeDefIndex: 5764
{	// Fields
	private string unit; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<long> <From>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<long> <Length>k__BackingField; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<long> <To>k__BackingField; // 0x38

	// Properties
	public Nullable<long> From { get; set; }
	public Nullable<long> Length { get; set; }
	public Nullable<long> To { get; set; }
	public string Unit { get; }

	// Methods

	// RVA: 0x10829D0 Offset: 0x1081DD0 VA: 0x1810829D0
	private void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9C0 Offset: 0xB0BDC0 VA: 0x180B0C9C0
	public Nullable<long> get_From() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1082A20 Offset: 0x1081E20 VA: 0x181082A20
	private void set_From(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public Nullable<long> get_Length() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081470 Offset: 0x1080870 VA: 0x181081470
	private void set_Length(Nullable<long> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x715940 Offset: 0x714D40 VA: 0x180715940
	public Nullable<long> get_To() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1082A30 Offset: 0x1081E30 VA: 0x181082A30
	private void set_To(Nullable<long> value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Unit() { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1081F00 Offset: 0x1081300 VA: 0x181081F00 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1082050 Offset: 0x1081450 VA: 0x181082050 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1082360 Offset: 0x1081760 VA: 0x181082360
	public static bool TryParse(string input, out ContentRangeHeaderValue parsedValue) { }

	// RVA: 0x1082150 Offset: 0x1081550 VA: 0x181082150 Slot: 3
	public override string ToString() { }

}

