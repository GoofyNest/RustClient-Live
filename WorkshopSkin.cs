public class WorkshopSkin : MonoBehaviour // TypeDefIndex: 7723
{	public static bool AllowApply; // 0x0
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

	public static int QueuedCount { get; }
	public static int LoadedCount { get; }


	public static string GetStatus() { }

	public static int get_QueuedCount() { }

	public static int get_LoadedCount() { }

	public static Skin GetSkin(ulong workshopId) { }

	public static IWorkshopContent GetItem(ulong workshopId) { }

	public static void Apply(GameObject gameobj, ulong workshopId, Action callback) { }

	public static void Reset(GameObject gameobj) { }

	public static void Prepare(GameObject gameobj) { }

	protected void OnDestroy() { }

	private void Apply(ulong workshopId, Action callback) { }

	private void EnqueueSkinRefresh(ulong workshopId) { }

	private static void LoadFromWorkshop(ulong workshopId) { }

	private void DequeueSkinRefresh(ulong workshopId) { }

	private static void LoadOrUnloadSkinAssets(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC8D90 Offset: 0xC8190 VA: 0x1800C8D90
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC8F20 Offset: 0xC8320 VA: 0x1800C8F20
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] // RVA: 0xC9020 Offset: 0xC8420 VA: 0x1800C9020
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] // RVA: 0xC93F0 Offset: 0xC87F0 VA: 0x1800C93F0
	private static IEnumerator LoadSkin(ulong workshopId) { }

	private static int GetBundleIndex(ulong workshopId) { }

	private void ApplySkin(Skin skin, ulong workshopId) { }

	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopSkin.<ItemQueueCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7724
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<SkinQueueCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7725
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadItem>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7726
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private int <index>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private bool <itemInstallStarted>5__4; // 0x38
	private Stopwatch <sw>5__5; // 0x40

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadSkin>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7727
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ulong workshopId; // 0x20
	private AssetBundle <bundle>5__2; // 0x28
	private IWorkshopContent <item>5__3; // 0x30
	private Skin <skin>5__4; // 0x38
	private ListHashSet<WorkshopSkin> <instances>5__5; // 0x40

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 10778
{
	public void .ctor() { }

}

