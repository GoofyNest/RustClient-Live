internal sealed class RegexPrefix // TypeDefIndex: 2615
{	// Fields
	internal string _prefix; // 0x10
	internal bool _caseInsensitive; // 0x18
	internal static RegexPrefix _empty; // 0x0

	// Properties
	internal string Prefix { get; }
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }

	// Methods

	// RVA: 0x14613B0 Offset: 0x14607B0 VA: 0x1814613B0
	internal void .ctor(string prefix, bool ci) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal string get_Prefix() { }

	// RVA: 0x95B2D0 Offset: 0x95A6D0 VA: 0x18095B2D0
	internal bool get_CaseInsensitive() { }

	// RVA: 0x16B1E20 Offset: 0x16B1220 VA: 0x1816B1E20
	internal static RegexPrefix get_Empty() { }

	// RVA: 0x16B1D90 Offset: 0x16B1190 VA: 0x1816B1D90
	private static void .cctor() { }

}

