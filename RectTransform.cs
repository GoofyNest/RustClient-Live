public sealed class RectTransform : Transform // TypeDefIndex: 3568
{
	[CompilerGeneratedAttribute] 
	[DebuggerBrowsableAttribute] 
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; 

	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }


	[CompilerGeneratedAttribute] 
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] 
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	public Rect get_rect() { }

	public Vector2 get_anchorMin() { }

	public void set_anchorMin(Vector2 value) { }

	public Vector2 get_anchorMax() { }

	public void set_anchorMax(Vector2 value) { }

	public Vector2 get_anchoredPosition() { }

	public void set_anchoredPosition(Vector2 value) { }

	public Vector2 get_sizeDelta() { }

	public void set_sizeDelta(Vector2 value) { }

	public Vector2 get_pivot() { }

	public void set_pivot(Vector2 value) { }

	public Vector3 get_anchoredPosition3D() { }

	public void set_anchoredPosition3D(Vector3 value) { }

	public Vector2 get_offsetMin() { }

	public void set_offsetMin(Vector2 value) { }

	public Vector2 get_offsetMax() { }

	public void set_offsetMax(Vector2 value) { }

	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] 
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	private Vector2 GetParentSize() { }

	private void get_rect_Injected(out Rect ret) { }

	private void get_anchorMin_Injected(out Vector2 ret) { }

	private void set_anchorMin_Injected(ref Vector2 value) { }

	private void get_anchorMax_Injected(out Vector2 ret) { }

	private void set_anchorMax_Injected(ref Vector2 value) { }

	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	private void get_sizeDelta_Injected(out Vector2 ret) { }

	private void set_sizeDelta_Injected(ref Vector2 value) { }

	private void get_pivot_Injected(out Vector2 ret) { }

	private void set_pivot_Injected(ref Vector2 value) { }

}

public enum RectTransform.Edge // TypeDefIndex: 3569
{
	public int value__; 
	public const RectTransform.Edge Left = 0;
	public const RectTransform.Edge Right = 1;
	public const RectTransform.Edge Top = 2;
	public const RectTransform.Edge Bottom = 3;

}

public enum RectTransform.Axis // TypeDefIndex: 3570
{
	public int value__; 
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;

}

public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 3571
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(RectTransform driven) { }

	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

