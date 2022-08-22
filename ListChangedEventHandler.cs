public sealed class ListChangedEventHandler : MulticastDelegate // TypeDefIndex: 2726
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, ListChangedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, ListChangedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

