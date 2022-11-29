internal sealed class OnBlockParticipantCallbackInternal : MulticastDelegate // TypeDefIndex: 8779
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref BlockParticipantCallbackInfoInternal data) { }

	public virtual IAsyncResult BeginInvoke(ref BlockParticipantCallbackInfoInternal data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref BlockParticipantCallbackInfoInternal data, IAsyncResult result) { }

}

