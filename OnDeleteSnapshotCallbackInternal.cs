internal sealed class OnDeleteSnapshotCallbackInternal : MulticastDelegate // TypeDefIndex: 8799
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeleteSnapshotCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref DeleteSnapshotCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeleteSnapshotCallbackInfoInternal data, IAsyncResult result) { }

}

