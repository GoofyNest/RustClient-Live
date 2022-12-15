internal sealed class OnJoinSessionCallbackInternal : MulticastDelegate // TypeDefIndex: 8513
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinSessionCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinSessionCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinSessionCallbackInfoInternal data, IAsyncResult result) { }

}

