public sealed class PropertyChangingEventHandler : MulticastDelegate // TypeDefIndex: 5863
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangingEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

