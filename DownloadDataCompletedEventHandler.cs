public sealed class DownloadDataCompletedEventHandler : MulticastDelegate // TypeDefIndex: 2964
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, DownloadDataCompletedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, DownloadDataCompletedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

