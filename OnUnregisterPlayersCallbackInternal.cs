internal sealed class OnUnregisterPlayersCallbackInternal : MulticastDelegate // TypeDefIndex: 8515
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UnregisterPlayersCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref UnregisterPlayersCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UnregisterPlayersCallbackInfoInternal data, IAsyncResult result) { }

}
