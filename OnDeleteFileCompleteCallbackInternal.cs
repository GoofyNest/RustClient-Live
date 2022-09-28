internal sealed class OnDeleteFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8849
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeleteFileCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref DeleteFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeleteFileCallbackInfoInternal data, IAsyncResult result) { }

}

