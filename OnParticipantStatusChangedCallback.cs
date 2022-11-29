public sealed class OnParticipantStatusChangedCallback : MulticastDelegate // TypeDefIndex: 8786
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref ParticipantStatusChangedCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref ParticipantStatusChangedCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref ParticipantStatusChangedCallbackInfo data, IAsyncResult result) { }

}

