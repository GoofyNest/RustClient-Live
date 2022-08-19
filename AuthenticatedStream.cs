public abstract class AuthenticatedStream : Stream // TypeDefIndex: 3067
{	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0xFF1BD0 Offset: 0xFF0FD0 VA: 0x180FF1BD0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	protected Stream get_InnerStream() { }

	// RVA: 0xFF1AD0 Offset: 0xFF0ED0 VA: 0x180FF1AD0 Slot: 17
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool get_IsAuthenticated();

}

