public sealed class OnWriteFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8908
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref WriteFileCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref WriteFileCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref WriteFileCallbackInfo data, IAsyncResult result) { }

}

