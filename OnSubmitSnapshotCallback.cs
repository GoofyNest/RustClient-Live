public sealed class OnSubmitSnapshotCallback : MulticastDelegate // TypeDefIndex: 8800
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref SubmitSnapshotCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref SubmitSnapshotCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref SubmitSnapshotCallbackInfo data, IAsyncResult result) { }

}

