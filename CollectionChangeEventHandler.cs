public sealed class CollectionChangeEventHandler : MulticastDelegate // TypeDefIndex: 2675
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, CollectionChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

