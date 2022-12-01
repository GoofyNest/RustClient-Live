internal sealed class OnDestroySessionCallbackInternal : MulticastDelegate // TypeDefIndex: 8505
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DestroySessionCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref DestroySessionCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DestroySessionCallbackInfoInternal data, IAsyncResult result) { }

}

