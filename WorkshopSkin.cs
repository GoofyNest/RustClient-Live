public class WorkshopSkin : MonoBehaviour // TypeDefIndex: 7723
{	// Fields
	public static bool AllowApply; // 0x0
	public static bool AllowUnload; // 0x1
	public static float DownloadTimeout; // 0x4
	private static WaitForSeconds waitForSeconds; // 0x8
	private static AssetBundleCreateRequest[] bundleRequests; // 0x10
	private static AssetBundle[] bundles; // 0x18
	private static ListDictionary<ulong, ListHashSet<WorkshopSkin>> RefreshQueue; // 0x20
	private static Queue<ulong> ItemQueue; // 0x28
	private static Queue<ulong> SkinQueue; // 0x30
	private static ListDictionary<ulong, IWorkshopContent> ItemCache; // 0x38
	private static ListDictionary<ulong, Skin> SkinCache; // 0x40
	private ulong RequestedWorkshopID; // 0x18
	private ulong AppliedWorkshopID; // 0x20
	private Action OnRefresh; // 0x28
	private Skin AppliedSkin; // 0x30

	// Properties
	public static int QueuedCount { get; }
	public static int LoadedCount { get; }

	// Methods

	// RVA: 0xE99BF0 Offset: 0xE98FF0 VA: 0x180E99BF0
	public static string GetStatus() { }

	// RVA: 0xE9B230 Offset: 0xE9A630 VA: 0x180E9B230
	public static int get_QueuedCount() { }

	// RVA: 0xE9B190 Offset: 0xE9A590 VA: 0x180E9B190
	public static int get_LoadedCount() { }

	// RVA: 0xE99B70 Offset: 0xE98F70 VA: 0x180E99B70
	public static Skin GetSkin(ulong workshopId) { }

	// RVA: 0xE99AF0 Offset: 0xE98EF0 VA: 0x180E99AF0
	public static IWorkshopContent GetItem(ulong workshopId) { }

	// RVA: 0xE993C0 Offset: 0xE987C0 VA: 0x180E993C0
	public static void Apply(GameObject gameobj, ulong workshopId, Action callback) { }

	// RVA: 0xE9ACD0 Offset: 0xE9A0D0 VA: 0x180E9ACD0
	public static void Reset(GameObject gameobj) { }

	// RVA: 0xE9AC30 Offset: 0xE9A030 VA: 0x180E9AC30
	public static void Prepare(GameObject gameobj) { }

	// RVA: 0xE9ABB0 Offset: 0xE99FB0 VA: 0x180E9ABB0
	protected void OnDestroy() { }

	// RVA: 0xE994E0 Offset: 0xE988E0 VA: 0x180E994E0
	private void Apply(ulong workshopId, Action callback) { }

	// RVA: 0xE99940 Offset: 0xE98D40 VA: 0x180E99940
	private void EnqueueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE9A6A0 Offset: 0xE99AA0 VA: 0x180E9A6A0
	private static void LoadFromWorkshop(ulong workshopId) { }

	// RVA: 0xE99820 Offset: 0xE98C20 VA: 0x180E99820
	private void DequeueSkinRefresh(ulong workshopId) { }

	// RVA: 0xE9AA20 Offset: 0xE99E20 VA: 0x180E9AA20
	private static void LoadOrUnloadSkinAssets(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC8D90 Offset: 0xC8190 VA: 0x1800C8D90
	// RVA: 0xE9A650 Offset: 0xE99A50 VA: 0x180E9A650
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC8F20 Offset: 0xC8320 VA: 0x1800C8F20
	// RVA: 0xE9AD70 Offset: 0xE9A170 VA: 0x180E9AD70
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC9020 Offset: 0xC8420 VA: 0x1800C9020
	// RVA: 0xE9A9C0 Offset: 0xE99DC0 VA: 0x180E9A9C0
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC93F0 Offset: 0xC87F0 VA: 0x1800C93F0
	// RVA: 0xE9AB50 Offset: 0xE99F50 VA: 0x180E9AB50
	private static IEnumerator LoadSkin(ulong workshopId) { }

	// RVA: 0xE99AB0 Offset: 0xE98EB0 VA: 0x180E99AB0
	private static int GetBundleIndex(ulong workshopId) { }

	// RVA: 0xE99280 Offset: 0xE98680 VA: 0x180E99280
	private void ApplySkin(Skin skin, ulong workshopId) { }

	// RVA: 0xE9ADC0 Offset: 0xE9A1C0 VA: 0x180E9ADC0
	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0xE9AF70 Offset: 0xE9A370 VA: 0x180E9AF70
	private static void .cctor() { }

}

private sealed class WorkshopSkin.<ItemQueueCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7724
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE8E4B0 Offset: 0xE8D8B0 VA: 0x180E8E4B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE8E630 Offset: 0xE8DA30 VA: 0x180E8E630 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<SkinQueueCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7725
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE93B40 Offset: 0xE92F40 VA: 0x180E93B40 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE93CC0 Offset: 0xE930C0 VA: 0x180E93CC0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadItem>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7726
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private int <index>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private bool <itemInstallStarted>5__4; // 0x38
	private Stopwatch <sw>5__5; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE904C0 Offset: 0xE8F8C0 VA: 0x180E904C0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE90C70 Offset: 0xE90070 VA: 0x180E90C70 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadSkin>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7727
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private AssetBundle <bundle>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private Skin <skin>5__4; // 0x38
	private ListHashSet<WorkshopSkin> <instances>5__5; // 0x40

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xE912B0 Offset: 0xE906B0 VA: 0x180E912B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE917A0 Offset: 0xE90BA0 VA: 0x180E917A0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 10778
{	// Methods

	// RVA: 0x8A8570 Offset: 0x8A7970 VA: 0x1808A8570
	public void .ctor() { }

}

