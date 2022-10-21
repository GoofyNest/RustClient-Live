public sealed class OnDeleteSnapshotCallback : MulticastDelegate // TypeDefIndex: 8799
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeleteSnapshotCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DeleteSnapshotCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeleteSnapshotCallbackInfo data, IAsyncResult result) { }

}

