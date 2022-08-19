internal class EraInfo // TypeDefIndex: 703
{	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	internal string eraName; // 0x30
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	internal string abbrevEraName; // 0x38
	[OptionalFieldAttribute] // RVA: 0x7B5F0 Offset: 0x7A9F0 VA: 0x18007B5F0
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x16ECBE0 Offset: 0x16EBFE0 VA: 0x1816ECBE0
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x16ECB10 Offset: 0x16EBF10 VA: 0x1816ECB10
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }

}

