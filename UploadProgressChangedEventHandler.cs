public sealed class UploadProgressChangedEventHandler : MulticastDelegate // TypeDefIndex: 2976
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, UploadProgressChangedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, UploadProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

