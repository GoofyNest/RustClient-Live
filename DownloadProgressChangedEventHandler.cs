public sealed class DownloadProgressChangedEventHandler : MulticastDelegate // TypeDefIndex: 2974
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DownloadProgressChangedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DownloadProgressChangedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

