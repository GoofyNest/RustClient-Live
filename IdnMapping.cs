public sealed class IdnMapping // TypeDefIndex: 743
{	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x137E060 Offset: 0x137D460 VA: 0x18137E060
	public void .ctor() { }

	// RVA: 0x137D0A0 Offset: 0x137C4A0 VA: 0x18137D0A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x137D330 Offset: 0x137C730 VA: 0x18137D330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x137D240 Offset: 0x137C640 VA: 0x18137D240
	public string GetAscii(string unicode) { }

	// RVA: 0x137D120 Offset: 0x137C520 VA: 0x18137D120
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x137CE50 Offset: 0x137C250 VA: 0x18137CE50
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x137D690 Offset: 0x137CA90 VA: 0x18137D690
	private string ToAscii(string s, int offset) { }

	// RVA: 0x137DB40 Offset: 0x137CF40 VA: 0x18137DB40
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x137D560 Offset: 0x137C960 VA: 0x18137D560
	private string NamePrep(string s, int offset) { }

	// RVA: 0x137DC40 Offset: 0x137D040 VA: 0x18137DC40
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x137DE40 Offset: 0x137D240 VA: 0x18137DE40
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x137D470 Offset: 0x137C870 VA: 0x18137D470
	public string GetUnicode(string ascii) { }

	// RVA: 0x137D350 Offset: 0x137C750 VA: 0x18137D350
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x137D9A0 Offset: 0x137CDA0 VA: 0x18137D9A0
	private string ToUnicode(string s, int offset) { }

}

