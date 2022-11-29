public sealed class OnCustomInviteReceivedCallback : MulticastDelegate // TypeDefIndex: 9534
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnCustomInviteReceivedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnCustomInviteReceivedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnCustomInviteReceivedCallbackInfo data, IAsyncResult result) { }

}

