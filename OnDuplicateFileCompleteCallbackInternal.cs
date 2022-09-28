internal sealed class OnDuplicateFileCompleteCallbackInternal : MulticastDelegate // TypeDefIndex: 8851
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DuplicateFileCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref DuplicateFileCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DuplicateFileCallbackInfoInternal data, IAsyncResult result) { }

}

