public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 5865
{

[PreserveAttribute] 
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, NotifyCollectionChangedEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

