public sealed class OnIncomingPacketQueueFullCallback : MulticastDelegate // TypeDefIndex: 8972
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ref OnIncomingPacketQueueFullInfo data) { }

	public virtual IAsyncResult BeginInvoke(ref OnIncomingPacketQueueFullInfo data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(ref OnIncomingPacketQueueFullInfo data, IAsyncResult result) { }

}

