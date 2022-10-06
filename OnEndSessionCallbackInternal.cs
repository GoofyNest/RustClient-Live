internal sealed class OnEndSessionCallbackInternal : MulticastDelegate // TypeDefIndex: 8495
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref EndSessionCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref EndSessionCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref EndSessionCallbackInfoInternal data, IAsyncResult result) { }

}

