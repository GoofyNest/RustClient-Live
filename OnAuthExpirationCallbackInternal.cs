internal sealed class OnAuthExpirationCallbackInternal : MulticastDelegate // TypeDefIndex: 9591
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref AuthExpirationCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref AuthExpirationCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref AuthExpirationCallbackInfoInternal data, IAsyncResult result) { }

}

