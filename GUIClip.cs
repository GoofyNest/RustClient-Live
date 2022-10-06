internal sealed class GUIClip // TypeDefIndex: 4036
{
	internal static Rect visibleRect { get; }


	[FreeFunctionAttribute] 
	internal static Rect get_visibleRect() { }

	[VisibleToOtherModulesAttribute] 
	internal static void Internal_Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset) { }

	[VisibleToOtherModulesAttribute] 
	internal static void Internal_Pop() { }

	[FreeFunctionAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal static int Internal_GetCount() { }

	[FreeFunctionAttribute] 
	private static Vector2 Unclip_Vector2(Vector2 pos) { }

	[VisibleToOtherModulesAttribute] 
	[FreeFunctionAttribute] 
	internal static Matrix4x4 GetMatrix() { }

	[VisibleToOtherModulesAttribute] 
	internal static void SetMatrix(Matrix4x4 m) { }

	[VisibleToOtherModulesAttribute] 
	internal static void Internal_PushParentClip(Matrix4x4 objectTransform, Rect clipRect) { }

	[VisibleToOtherModulesAttribute] 
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

internal struct GUIClip.ParentClipScope : IDisposable // TypeDefIndex: 4037
{
	private bool m_Disposed; 


	public void .ctor(Matrix4x4 objectTransform, Rect clipRect) { }

	public void Dispose() { }

}

