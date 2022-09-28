public sealed class OnClientActionRequiredCallback : MulticastDelegate // TypeDefIndex: 9687
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientActionRequiredCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientActionRequiredCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientActionRequiredCallbackInfo data, IAsyncResult result) { }

}

