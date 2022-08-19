internal class ResourceFallbackManager : IEnumerable<CultureInfo>, IEnumerable // TypeDefIndex: 489
{	// Fields
	private CultureInfo m_startingCulture; // 0x10
	private CultureInfo m_neutralResourcesCulture; // 0x18
	private bool m_useParents; // 0x20

	// Methods

	// RVA: 0xFE7410 Offset: 0xFE6810 VA: 0x180FE7410
	internal void .ctor(CultureInfo startingCulture, CultureInfo neutralResourcesCulture, bool useParents) { }

	// RVA: 0xFE73A0 Offset: 0xFE67A0 VA: 0x180FE73A0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IteratorStateMachineAttribute] // RVA: 0x95D70 Offset: 0x95170 VA: 0x180095D70
	// RVA: 0xFE73A0 Offset: 0xFE67A0 VA: 0x180FE73A0 Slot: 4
	public IEnumerator<CultureInfo> GetEnumerator() { }

}

private sealed class ResourceFallbackManager.<GetEnumerator>d__5 : IEnumerator<CultureInfo>, IDisposable, IEnumerator // TypeDefIndex: 490
{	// Fields
	private int <>1__state; // 0x10
	private CultureInfo <>2__current; // 0x18
	public ResourceFallbackManager <>4__this; // 0x20
	private CultureInfo <currentCulture>5__1; // 0x28
	private bool <reachedNeutralResourcesCulture>5__2; // 0x30

	// Properties
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFF16C0 Offset: 0xFF0AC0 VA: 0x180FF16C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private CultureInfo System.Collections.Generic.IEnumerator<System.Globalization.CultureInfo>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xFF1900 Offset: 0xFF0D00 VA: 0x180FF1900 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

