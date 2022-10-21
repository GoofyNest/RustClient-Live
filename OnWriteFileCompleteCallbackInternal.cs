internal sealed class OnWriteFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8898
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref WriteFileCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref WriteFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref WriteFileCallbackInfoInternal data, IAsyncResult result) { }

}

