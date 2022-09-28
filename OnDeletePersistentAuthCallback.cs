public sealed class OnDeletePersistentAuthCallback : MulticastDelegate // TypeDefIndex: 9636
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref DeletePersistentAuthCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref DeletePersistentAuthCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref DeletePersistentAuthCallbackInfo data, IAsyncResult result) { }

}

