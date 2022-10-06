public sealed class OnPeerConnectionEstablishedCallback : MulticastDelegate // TypeDefIndex: 8964
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnPeerConnectionEstablishedInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnPeerConnectionEstablishedInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnPeerConnectionEstablishedInfo data, IAsyncResult result) { }

}

