public class RetryConditionHeaderValue : ICloneable // TypeDefIndex: 5806
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<TimeSpan> <Delta>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public Nullable<TimeSpan> Delta { get; set; }

	// Methods

	// RVA: 0x1091B20 Offset: 0x1090F20 VA: 0x181091B20
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1091A70 Offset: 0x1090E70 VA: 0x181091A70
	public void .ctor(TimeSpan delta) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10900B0 Offset: 0x108F4B0 VA: 0x1810900B0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10900D0 Offset: 0x108F4D0 VA: 0x1810900D0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public Nullable<TimeSpan> get_Delta() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1081470 Offset: 0x1080870 VA: 0x181081470
	private void set_Delta(Nullable<TimeSpan> value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1091470 Offset: 0x1090870 VA: 0x181091470 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10915F0 Offset: 0x10909F0 VA: 0x1810915F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10917A0 Offset: 0x1090BA0 VA: 0x1810917A0
	public static bool TryParse(string input, out RetryConditionHeaderValue parsedValue) { }

	// RVA: 0x1091670 Offset: 0x1090A70 VA: 0x181091670 Slot: 3
	public override string ToString() { }

}

