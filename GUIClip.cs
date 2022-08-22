internal sealed class GUIClip // TypeDefIndex: 4033
{	internal static Rect visibleRect { get; }


	[FreeFunctionAttribute] // RVA: 0xCB2D0 Offset: 0xCA6D0 VA: 0x1800CB2D0
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB3E0 Offset: 0xCA7E0 VA: 0x1800CB3E0
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCB800 Offset: 0xCAC00 VA: 0x1800CB800
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] // RVA: 0xCBAB0 Offset: 0xCAEB0 VA: 0x1800CBAB0
	[VisibleToOtherModulesAttribute] // RVA: 0xCBAB0 Offset: 0xCAEB0 VA: 0x1800CBAB0
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] // RVA: 0xCBD90 Offset: 0xCB190 VA: 0x1800CBD90
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	[FreeFunctionAttribute] // RVA: 0xCBEB0 Offset: 0xCB2B0 VA: 0x1800CBEB0
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC1D0 Offset: 0xCB5D0 VA: 0x1800CC1D0
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC430 Offset: 0xCB830 VA: 0x1800CC430
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] // RVA: 0xCC6D0 Offset: 0xCBAD0 VA: 0x1800CC6D0
	internal static void Internal_PopParentClip() { }

	internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	public static Vector2 Unclip(Vector2 pos) { }

	private static void get_visibleRect_Injected(out Rect ret) { }

	private static void Internal_Push_Injected(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset) { }

	private static void Unclip_Vector2_Injected(ref Vector2 pos, out Vector2 ret) { }

	private static void GetMatrix_Injected(out Matrix4x4 ret) { }

	private static void SetMatrix_Injected(ref Matrix4x4 m) { }

	private static void Internal_PushParentClip_Injected(ref Matrix4x4 objectTransform, ref Rect clipRect) { }

}

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4034
{	private bool m_Disposed; // 0x0


	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	public void Dispose() { }

}

