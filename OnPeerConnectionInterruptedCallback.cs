public sealed class OnPeerConnectionInterruptedCallback : MulticastDelegate // TypeDefIndex: 8969
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnPeerConnectionInterruptedInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionInterruptedInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnPeerConnectionInterruptedInfo data, IAsyncResult result) { }

}

