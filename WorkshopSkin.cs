public class WorkshopSkin : MonoBehaviour // TypeDefIndex: 7730
{
	public static bool AllowApply; 
	public static bool AllowUnload; 
	public static float DownloadTimeout; 
	private static WaitForSeconds waitForSeconds; 
	private static AssetBundleCreateRequest[] bundleRequests; 
	private static AssetBundle[] bundles; 
	private static ListDictionary<ulong, ListHashSet<WorkshopSkin>> RefreshQueue; 
	private static Queue<ulong> ItemQueue; 
	private static Queue<ulong> SkinQueue; 
	private static ListDictionary<ulong, IWorkshopContent> ItemCache; 
	private static ListDictionary<ulong, Skin> SkinCache; 
	private ulong RequestedWorkshopID; 
	private ulong AppliedWorkshopID; 
	private Action OnRefresh; 
	private Skin AppliedSkin; 

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

	[IteratorStateMachineAttribute] 
	private static IEnumerator ItemQueueCoroutine() { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator SkinQueueCoroutine() { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator LoadItem(ulong workshopId) { }

	[IteratorStateMachineAttribute] 
	private static IEnumerator LoadSkin(ulong workshopId) { }

	private static int GetBundleIndex(ulong workshopId) { }

	private void ApplySkin(Skin skin, ulong workshopId) { }

	private void UpdateSkinReference(Skin skin, ulong workshopId) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private sealed class WorkshopSkin.<ItemQueueCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7731
{
	private int <>1__state; 
	private object <>2__current; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<SkinQueueCoroutine>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7732
{
	private int <>1__state; 
	private object <>2__current; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadItem>d__33 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7733
{
	private int <>1__state; 
	private object <>2__current; 
	public ulong workshopId; 
	private int <index>5__2; 
	private IWorkshopContent <item>5__3; 
	private bool <itemInstallStarted>5__4; 
	private Stopwatch <sw>5__5; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class WorkshopSkin.<LoadSkin>d__34 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7734
{
	private int <>1__state; 
	private object <>2__current; 
	public ulong workshopId; 
	private AssetBundle <bundle>5__2; 
	private IWorkshopContent <item>5__3; 
	private Skin <skin>5__4; 
	private ListHashSet<WorkshopSkin> <instances>5__5; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

public class WorkshopSkin : WorkshopSkinBase // TypeDefIndex: 12497
{

	public void .ctor() { }

}

