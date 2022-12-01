internal sealed class OnUpdateSessionCallbackInternal : MulticastDelegate // TypeDefIndex: 8529
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateSessionCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateSessionCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateSessionCallbackInfoInternal data, IAsyncResult result) { }

}

