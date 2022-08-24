public sealed class StateChangeEventHandler : MulticastDelegate // TypeDefIndex: 4309
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, StateChangeEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, StateChangeEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

