public sealed class OnBlockParticipantCallback : MulticastDelegate // TypeDefIndex: 8769
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref BlockParticipantCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref BlockParticipantCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref BlockParticipantCallbackInfo data, IAsyncResult result) { }

}

