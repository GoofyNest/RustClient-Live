public class FrankensteinTableVisuals : MonoBehaviour // TypeDefIndex: 8695
{	public GameObject FXReady; // 0x18
	public GameObject FXNotReady; // 0x20
	public GameObject FXWake; // 0x28
	public Transform HeadVisualAnchor; // 0x30
	public Transform TorsoVisualAnchor; // 0x38
	public Transform LegsVisualAnchor; // 0x40
	public Animator Animator; // 0x48


	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	private void DisableAllReadyFX() { }

	private void SetReadyFX(bool ready) { }

	public void Clear() { }

	private void DestroyAnchorChildren(Transform t) { }

	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	public void StartWaking() { }

	[IteratorStateMachineAttribute] // RVA: 0xBBA60 Offset: 0xBAE60 VA: 0x1800BBA60
	private IEnumerator Wake() { }

	private void SetTableUp(bool flag) { }

	private void SetLeverUp(bool flag) { }

	public void .ctor() { }

}

private sealed class FrankensteinTableVisuals.<Wake>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 8696
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public FrankensteinTableVisuals <>4__this; // 0x20

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

