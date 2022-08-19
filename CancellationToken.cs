public struct CancellationToken // TypeDefIndex: 749
{	// Fields
	private CancellationTokenSource m_source; // 0x0
	private static readonly Action<object> s_ActionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x513D80 Offset: 0x513180 VA: 0x180513D80
	public static CancellationToken get_None() { }

	// RVA: 0x1F0520 Offset: 0x1EF920 VA: 0x1801F0520
	public bool get_IsCancellationRequested() { }

	// RVA: 0x1F04F0 Offset: 0x1EF8F0 VA: 0x1801F04F0
	public bool get_CanBeCanceled() { }

	// RVA: 0xF1380 Offset: 0xF0780 VA: 0x1800F1380
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x1F0470 Offset: 0x1EF870 VA: 0x1801F0470
	public void .ctor(bool canceled) { }

	// RVA: 0x148C7A0 Offset: 0x148BBA0 VA: 0x18148C7A0
	private static void ActionToActionObjShunt(object obj) { }

	// RVA: 0x1F02B0 Offset: 0x1EF6B0 VA: 0x1801F02B0
	public CancellationTokenRegistration Register(Action<object> callback, object state) { }

	// RVA: 0x1F0260 Offset: 0x1EF660 VA: 0x1801F0260
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x1F0380 Offset: 0x1EF780 VA: 0x1801F0380
	private CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x1F0180 Offset: 0x1EF580 VA: 0x1801F0180
	public bool Equals(CancellationToken other) { }

	// RVA: 0x1F00F0 Offset: 0x1EF4F0 VA: 0x1801F00F0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1F0190 Offset: 0x1EF590 VA: 0x1801F0190 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x148CED0 Offset: 0x148C2D0 VA: 0x18148CED0
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x148CEF0 Offset: 0x148C2F0 VA: 0x18148CEF0
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x1F03C0 Offset: 0x1EF7C0 VA: 0x1801F03C0
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x1F0400 Offset: 0x1EF800 VA: 0x1801F0400
	internal void ThrowIfSourceDisposed() { }

	// RVA: 0x1F0460 Offset: 0x1EF860 VA: 0x1801F0460
	private void ThrowOperationCanceledException() { }

	// RVA: 0x148CC90 Offset: 0x148C090 VA: 0x18148CC90
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x148CD80 Offset: 0x148C180 VA: 0x18148CD80
	private static void .cctor() { }

}

