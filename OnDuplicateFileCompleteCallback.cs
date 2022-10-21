public sealed class OnDuplicateFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8885
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DuplicateFileCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DuplicateFileCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DuplicateFileCallbackInfo data, IAsyncResult result) { }

}

