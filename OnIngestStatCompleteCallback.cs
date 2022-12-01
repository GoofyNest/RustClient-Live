public sealed class OnIngestStatCompleteCallback : MulticastDelegate // TypeDefIndex: 8440
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref IngestStatCompleteCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref IngestStatCompleteCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref IngestStatCompleteCallbackInfo data, IAsyncResult result) { }

}

