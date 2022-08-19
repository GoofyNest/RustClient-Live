public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 3852
{	// Fields
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x222B40 Offset: 0x221F40 VA: 0x180222B40
	private int GetNumberOfCameras_Internal() { }

	// RVA: 0x222AE0 Offset: 0x221EE0 VA: 0x180222AE0
	private Camera GetCamera_Internal(int index) { }

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x222B40 Offset: 0x221F40 VA: 0x180222B40
	internal int GetNumberOfCameras() { }

	// RVA: 0x222AE0 Offset: 0x221EE0 VA: 0x180222AE0
	internal Camera GetCamera(int index) { }

	// RVA: 0x2229C0 Offset: 0x221DC0 VA: 0x1802229C0 Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x222A20 Offset: 0x221E20 VA: 0x180222A20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x222B30 Offset: 0x221F30 VA: 0x180222B30 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x19AFC30 Offset: 0x19AF030 VA: 0x1819AFC30
	private static int GetNumberOfCameras_Internal_Injected(ref ScriptableRenderContext _unity_self) { }

	// RVA: 0x19AFBF0 Offset: 0x19AEFF0 VA: 0x1819AFBF0
	private static Camera GetCamera_Internal_Injected(ref ScriptableRenderContext _unity_self, int index) { }

}

