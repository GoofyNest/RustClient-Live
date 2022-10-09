internal class UVTextureAnimator : MonoBehaviour // TypeDefIndex: 13214
{
	public int Rows; 
	public int Columns; 
	public float Fps; 
	public int OffsetMat; 
	public bool IsLoop; 
	public float StartDelay; 
	private bool isInizialised; 
	private int index; 
	private int count; 
	private int allCount; 
	private float deltaFps; 
	private bool isVisible; 
	private bool isCorutineStarted; 
	private Renderer currentRenderer; 
	private Material instanceMaterial; 


	private void Start() { }

	private void InitDefaultVariables() { }

	private void Play() { }

	private void PlayDelay() { }

	private void OnEnable() { }

	private void OnDisable() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCorutine() { }

	private void UpdateCorutineFrame() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

private sealed class UVTextureAnimator.<UpdateCorutine>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13215
{
	private int <>1__state; 
	private object <>2__current; 
	public UVTextureAnimator <>4__this; 

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

