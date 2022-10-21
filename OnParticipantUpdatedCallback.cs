public sealed class OnParticipantUpdatedCallback : MulticastDelegate // TypeDefIndex: 8677
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref ParticipantUpdatedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref ParticipantUpdatedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref ParticipantUpdatedCallbackInfo data, IAsyncResult result) { }

}

