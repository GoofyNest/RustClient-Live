public sealed class UnknownChannelEventCallback : MulticastDelegate // TypeDefIndex: 7605
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x13A5880 Offset: 0x13A4C80 VA: 0x1813A5880 Slot: 12
	public virtual UnknownChannelEventAction Invoke(FourBitNumber statusByte, FourBitNumber channel) { }

	// RVA: 0x13A57F0 Offset: 0x13A4BF0 VA: 0x1813A57F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(FourBitNumber statusByte, FourBitNumber channel, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual UnknownChannelEventAction EndInvoke(IAsyncResult result) { }

}

