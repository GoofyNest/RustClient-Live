public class FrankensteinTableVisuals : MonoBehaviour // TypeDefIndex: 10406
{
	public GameObject FXReady; 
	public GameObject FXNotReady; 
	public GameObject FXWake; 
	public Transform HeadVisualAnchor; 
	public Transform TorsoVisualAnchor; 
	public Transform LegsVisualAnchor; 
	public Animator Animator; 


	public void Refresh(List<ItemDefinition> items, FrankensteinTable table) { }

	private void DisableAllReadyFX() { }

	private void SetReadyFX(bool ready) { }

	public void Clear() { }

	private void DestroyAnchorChildren(Transform t) { }

	public void DisplayItem(ItemDefinition item, FrankensteinTable table) { }

	public void DisplayItem(ItemDefinition item, Transform anchor) { }

	public void StartWaking() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator Wake() { }

	private void SetTableUp(bool flag) { }

	private void SetLeverUp(bool flag) { }

	public void .ctor() { }

}

private sealed class FrankensteinTableVisuals.<Wake>d__15 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10407
{
	private int <>1__state; 
	private object <>2__current; 
	public FrankensteinTableVisuals <>4__this; 

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

