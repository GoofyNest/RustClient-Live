public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 5861
{
// Namespace: System.ComponentModel
[PreserveAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 5861
	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xADFD50 Offset: 0xADF150 VA: 0x180ADFD50 Slot: 12
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }

	// RVA: 0xADFD10 Offset: 0xADF110 VA: 0x180ADFD10 Slot: 13
	public virtual IAsyncResult BeginInvoke(object sender, NotifyCollectionChangedEventArgs e, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

