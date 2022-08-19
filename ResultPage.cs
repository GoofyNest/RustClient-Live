public struct ResultPage : IDisposable // TypeDefIndex: 5281
{	// Fields
	internal UGCQueryHandle_t Handle; // 0x0
	public int ResultCount; // 0x8
	public int TotalCount; // 0xC
	public bool CachedData; // 0x10
	internal bool ReturnsKeyValueTags; // 0x11
	internal bool ReturnsDefaultStats; // 0x12
	internal bool ReturnsMetadata; // 0x13
	internal bool ReturnsChildren; // 0x14
	internal bool ReturnsAdditionalPreviews; // 0x15

	// Properties
	public IEnumerable<Item> Entries { get; }

	// Methods

	[IteratorStateMachineAttribute] // RVA: 0x9F630 Offset: 0x9EA30 VA: 0x18009F630
	// RVA: 0x2249C0 Offset: 0x223DC0 VA: 0x1802249C0
	public IEnumerable<Item> get_Entries() { }

	// RVA: 0x2249B0 Offset: 0x223DB0 VA: 0x1802249B0
	private ulong GetStat(uint index, ItemStatistic stat) { }

	// RVA: 0x224960 Offset: 0x223D60 VA: 0x180224960 Slot: 4
	public void Dispose() { }

}

private sealed class ResultPage.<get_Entries>d__10 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IEnumerator, IDisposable // TypeDefIndex: 5282
{	// Fields
	private int <>1__state; // 0x10
	private Item <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x150
	public ResultPage <>4__this; // 0x158
	public ResultPage <>3__<>4__this; // 0x170
	private SteamUGCDetails_t <details>5__2; // 0x188
	private uint <i>5__3; // 0x210

	// Properties
	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DBD00 Offset: 0x19DB100 VA: 0x1819DBD00
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19DB360 Offset: 0x19DA760 VA: 0x1819DB360 Slot: 8
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x17681C0 Offset: 0x17675C0 VA: 0x1817681C0 Slot: 6
	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DBBE0 Offset: 0x19DAFE0 VA: 0x1819DBBE0 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DBC30 Offset: 0x19DB030 VA: 0x1819DBC30 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DBB30 Offset: 0x19DAF30 VA: 0x1819DBB30 Slot: 4
	private IEnumerator<Item> System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item>.GetEnumerator() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19DBB30 Offset: 0x19DAF30 VA: 0x1819DBB30 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

