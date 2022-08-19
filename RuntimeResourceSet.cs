internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 499
{	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0xFEFF00 Offset: 0xFEF300 VA: 0x180FEFF00
	internal void .ctor(string fileName) { }

	// RVA: 0xFEFE00 Offset: 0xFEF200 VA: 0x180FEFE00
	internal void .ctor(Stream stream) { }

	// RVA: 0xFEEF00 Offset: 0xFEE300 VA: 0x180FEEF00 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0xFEF110 Offset: 0xFEE510 VA: 0x180FEF110 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0xFEF110 Offset: 0xFEE510 VA: 0x180FEF110 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xFEF070 Offset: 0xFEE470 VA: 0x180FEF070
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0xFEFB90 Offset: 0xFEEF90 VA: 0x180FEFB90 Slot: 8
	public override string GetString(string key) { }

	// RVA: 0xFEFB00 Offset: 0xFEEF00 VA: 0x180FEFB00 Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0xFEF120 Offset: 0xFEE520 VA: 0x180FEF120 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0xFEF140 Offset: 0xFEE540 VA: 0x180FEF140 Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0xFEF160 Offset: 0xFEE560 VA: 0x180FEF160
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0xFEFC10 Offset: 0xFEF010 VA: 0x180FEFC10
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }

}

