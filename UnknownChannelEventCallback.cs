public sealed class UnknownChannelEventCallback : MulticastDelegate // TypeDefIndex: 7605
{
	public void .ctor(object object, IntPtr method) { }

	public virtual UnknownChannelEventAction Invoke(FourBitNumber statusByte, FourBitNumber channel) { }

	public virtual IAsyncResult BeginInvoke(FourBitNumber statusByte, FourBitNumber channel, AsyncCallback callback, object object) { }

	public virtual UnknownChannelEventAction EndInvoke(IAsyncResult result) { }

}

