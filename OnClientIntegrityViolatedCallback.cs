public sealed class OnClientIntegrityViolatedCallback : MulticastDelegate // TypeDefIndex: 9818
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnClientIntegrityViolatedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnClientIntegrityViolatedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnClientIntegrityViolatedCallbackInfo data, IAsyncResult result) { }

}

