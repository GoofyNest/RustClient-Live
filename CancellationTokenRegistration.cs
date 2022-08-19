public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x1F0090 Offset: 0x1EF490 VA: 0x1801F0090
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F0080 Offset: 0x1EF480 VA: 0x1801F0080
	internal bool TryDeregister() { }

	// RVA: 0x1EFE60 Offset: 0x1EF260 VA: 0x1801EFE60 Slot: 5
	public void Dispose() { }

	// RVA: 0x1EFE70 Offset: 0x1EF270 VA: 0x1801EFE70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EFF50 Offset: 0x1EF350 VA: 0x1801EFF50 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x1EFFE0 Offset: 0x1EF3E0 VA: 0x1801EFFE0 Slot: 2
	public override int GetHashCode() { }

}

