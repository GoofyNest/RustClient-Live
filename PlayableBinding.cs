public struct PlayableBinding // TypeDefIndex: 3867
{	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x18F52E0 Offset: 0x18F46E0 VA: 0x1818F52E0
	private static void .cctor() { }

}

internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 3868
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18E4260 Offset: 0x18E3660 VA: 0x1818E4260 Slot: 12
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }

	// RVA: 0x18E41D0 Offset: 0x18E35D0 VA: 0x1818E41D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(PlayableGraph graph, string name, AsyncCallback callback, object object) { }

	// RVA: 0x121B4C0 Offset: 0x121A8C0 VA: 0x18121B4C0 Slot: 14
	public virtual PlayableOutput EndInvoke(IAsyncResult result) { }

}

