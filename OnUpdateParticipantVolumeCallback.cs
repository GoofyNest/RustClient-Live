public sealed class OnUpdateParticipantVolumeCallback : MulticastDelegate // TypeDefIndex: 8644
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref UpdateParticipantVolumeCallbackInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref UpdateParticipantVolumeCallbackInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref UpdateParticipantVolumeCallbackInfo data, IAsyncResult result) { }

}

