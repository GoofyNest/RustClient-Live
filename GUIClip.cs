internal sealed class GUIClip // TypeDefIndex: 4033
{	// Properties
	internal static Rect visibleRect { get; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xCB2D0 Offset: 0xCA6D0 VA: 0x1800CB2D0
	// RVA: 0x1A5D280 Offset: 0x1A5C680 VA: 0x181A5D280
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB3E0 Offset: 0xCA7E0 VA: 0x1800CB3E0
	// RVA: 0x1A5D010 Offset: 0x1A5C410 VA: 0x181A5D010
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB800 Offset: 0xCAC00 VA: 0x1800CB800
	// RVA: 0x1A5CED0 Offset: 0x1A5C2D0 VA: 0x181A5CED0
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBAB0 Offset: 0xCAEB0 VA: 0x1800CBAB0
	[VisibleToOtherModulesAttribute] // RVA: 0xCBAB0 Offset: 0xCAEB0 VA: 0x1800CBAB0
	// RVA: 0x1A5CE70 Offset: 0x1A5C270 VA: 0x181A5CE70
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBD90 Offset: 0xCB190 VA: 0x1800CBD90
	// RVA: 0x1A5D1A0 Offset: 0x1A5C5A0 VA: 0x181A5D1A0
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	[FreeFunctionAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	// RVA: 0x1A5CE20 Offset: 0x1A5C220 VA: 0x181A5CE20
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC1D0 Offset: 0xCB5D0 VA: 0x1800CC1D0
	// RVA: 0x1A5D110 Offset: 0x1A5C510 VA: 0x181A5D110
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC430 Offset: 0xCB830 VA: 0x1800CC430
	// RVA: 0x1A5CF50 Offset: 0x1A5C350 VA: 0x181A5CF50
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC6D0 Offset: 0xCBAD0 VA: 0x1800CC6D0
	// RVA: 0x1A5CEA0 Offset: 0x1A5C2A0 VA: 0x181A5CEA0
	internal static void Internal_PopParentClip() { }

	// RVA: 0x1A5D070 Offset: 0x1A5C470 VA: 0x181A5D070
	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A5D1F0 Offset: 0x1A5C5F0 VA: 0x181A5D1F0
	public static Vector2 Unclip(Vector2 pos) { }

	// RVA: 0x1A5D240 Offset: 0x1A5C640 VA: 0x181A5D240
	private static void get_visibleRect_Injected(out Rect ret) { }

	// RVA: 0x1A5CFA0 Offset: 0x1A5C3A0 VA: 0x181A5CFA0
	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	// RVA: 0x1A5D150 Offset: 0x1A5C550 VA: 0x181A5D150
	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	// RVA: 0x1A5CDE0 Offset: 0x1A5C1E0 VA: 0x181A5CDE0
	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	// RVA: 0x1A5D0D0 Offset: 0x1A5C4D0 VA: 0x181A5D0D0
	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	// RVA: 0x1A5CF00 Offset: 0x1A5C300 VA: 0x181A5CF00
	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	// Fields
	private bool m_Disposed; // 0x0

	// Methods

	// RVA: 0x22ABE0 Offset: 0x229FE0 VA: 0x18022ABE0
	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	// RVA: 0x22ABA0 Offset: 0x229FA0 VA: 0x18022ABA0 Slot: 4
	public void Dispose() { }

}

