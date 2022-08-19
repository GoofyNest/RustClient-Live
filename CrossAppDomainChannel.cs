internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 1189
{	// Fields
	private static object s_lock; // 0x131F0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0xFDFD10 Offset: 0xFDF110 VA: 0x180FDFD10
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0xFDFFB0 Offset: 0xFDF3B0 VA: 0x180FDFFB0 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x8C8BA0 Offset: 0x8C7FA0 VA: 0x1808C8BA0 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0xFDFEE0 Offset: 0xFDF2E0 VA: 0x180FDFEE0 Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0xFDFBB0 Offset: 0xFDEFB0 VA: 0x180FDFBB0 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xFDFE80 Offset: 0xFDF280 VA: 0x180FDFE80
	private static void .cctor() { }

}

