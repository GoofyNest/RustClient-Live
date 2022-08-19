public class RangeConditionHeaderValue : ICloneable // TypeDefIndex: 5803
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Nullable<DateTimeOffset> <Date>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private EntityTagHeaderValue <EntityTag>k__BackingField; // 0x28

	// Properties
	public Nullable<DateTimeOffset> Date { get; set; }
	public EntityTagHeaderValue EntityTag { get; set; }

	// Methods

	// RVA: 0x108FF90 Offset: 0x108F390 VA: 0x18108FF90
	public void .ctor(DateTimeOffset date) { }

	// RVA: 0x1090020 Offset: 0x108F420 VA: 0x181090020
	public void .ctor(EntityTagHeaderValue entityTag) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10900B0 Offset: 0x108F4B0 VA: 0x1810900B0
	public Nullable<DateTimeOffset> get_Date() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10900D0 Offset: 0x108F4D0 VA: 0x1810900D0
	private void set_Date(Nullable<DateTimeOffset> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public EntityTagHeaderValue get_EntityTag() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	private void set_EntityTag(EntityTagHeaderValue value) { }

	// RVA: 0xD6C080 Offset: 0xD6B480 VA: 0x180D6C080 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x108F9A0 Offset: 0x108EDA0 VA: 0x18108F9A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x108FAF0 Offset: 0x108EEF0 VA: 0x18108FAF0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x108FC20 Offset: 0x108F020 VA: 0x18108FC20
	public static bool TryParse(string input, out RangeConditionHeaderValue parsedValue) { }

	// RVA: 0x108FB60 Offset: 0x108EF60 VA: 0x18108FB60 Slot: 3
	public override string ToString() { }

}

