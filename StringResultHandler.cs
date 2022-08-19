internal class StringResultHandler : SearchResultHandler<string> // TypeDefIndex: 630
{	// Fields
	private bool _includeFiles; // 0x10
	private bool _includeDirs; // 0x11

	// Methods

	// RVA: 0x162F180 Offset: 0x162E580 VA: 0x18162F180
	internal void .ctor(bool includeFiles, bool includeDirs) { }

	// RVA: 0x162F0B0 Offset: 0x162E4B0 VA: 0x18162F0B0 Slot: 4
	internal override bool IsResultIncluded(SearchResult result) { }

	// RVA: 0x936440 Offset: 0x935840 VA: 0x180936440 Slot: 5
	internal override string CreateObject(SearchResult result) { }

}

