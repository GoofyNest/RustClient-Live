public struct ResultPage : IDisposable // TypeDefIndex: 5287
{
	internal UGCQueryHandle_t Handle; 
	public int ResultCount; 
	public int TotalCount; 
	public bool CachedData; 
	internal bool ReturnsKeyValueTags; 
	internal bool ReturnsDefaultStats; 
	internal bool ReturnsMetadata; 
	internal bool ReturnsChildren; 
	internal bool ReturnsAdditionalPreviews; 

	public IEnumerable<Item> Entries { get; }


	[IteratorStateMachineAttribute] 
	public IEnumerable<Item> get_Entries() { }

	private ulong GetStat(uint index, ItemStatistic stat) { }

	public void Dispose() { }

}

private sealed class ResultPage.<get_Entries>d__10 : IEnumerable<Item>, IEnumerable, IEnumerator<Item>, IEnumerator, IDisposable // TypeDefIndex: 5288
{
	private int <>1__state; 
	private Item <>2__current; 
	private int <>l__initialThreadId; 
	public ResultPage <>4__this; 
	public ResultPage <>3__<>4__this; 
	private SteamUGCDetails_t <details>5__2; 
	private uint <i>5__3; 

	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private Item System.Collections.Generic.IEnumerator<Steamworks.Ugc.Item>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator<Item> System.Collections.Generic.IEnumerable<Steamworks.Ugc.Item>.GetEnumerator() { }

	[DebuggerHiddenAttribute] 
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

