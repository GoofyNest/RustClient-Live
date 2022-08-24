public sealed class PropertyChangedEventHandler : MulticastDelegate // TypeDefIndex: 2733
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, PropertyChangedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

