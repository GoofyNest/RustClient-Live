public sealed class OnDeleteFileCompleteCallback : MulticastDelegate // TypeDefIndex: 8894
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeleteFileCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DeleteFileCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeleteFileCallbackInfo data, IAsyncResult result) { }

}

