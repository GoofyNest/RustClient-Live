public sealed class OnJoinGameAcceptedCallback : MulticastDelegate // TypeDefIndex: 8835
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref JoinGameAcceptedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref JoinGameAcceptedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref JoinGameAcceptedCallbackInfo data, IAsyncResult result) { }

}

