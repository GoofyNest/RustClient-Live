internal sealed class OnParticipantStatusChangedCallbackInternal : MulticastDelegate // TypeDefIndex: 8789
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref ParticipantStatusChangedCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref ParticipantStatusChangedCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref ParticipantStatusChangedCallbackInfoInternal data, IAsyncResult result) { }

}

