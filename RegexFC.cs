internal sealed class RegexFC // TypeDefIndex: 2614
{	// Fields
	internal RegexCharClass _cc; // 0x10
	internal bool _nullable; // 0x18
	internal bool _caseInsensitive; // 0x19

	// Methods

	// RVA: 0x14CE2B0 Offset: 0x14CD6B0 VA: 0x1814CE2B0
	internal void .ctor(bool nullable) { }

	// RVA: 0x14CE1B0 Offset: 0x14CD5B0 VA: 0x1814CE1B0
	internal void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CE330 Offset: 0x14CD730 VA: 0x1814CE330
	internal void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x14CDFD0 Offset: 0x14CD3D0 VA: 0x1814CDFD0
	internal bool AddFC(RegexFC fc, bool concatenate) { }

	// RVA: 0x14CE060 Offset: 0x14CD460 VA: 0x1814CE060
	internal string GetFirstChars(CultureInfo culture) { }

	// RVA: 0xFA2050 Offset: 0xFA1450 VA: 0x180FA2050
	internal bool IsCaseInsensitive() { }

}

