public sealed class RectTransform : Transform // TypeDefIndex: 3565
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x13A90

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector3 anchoredPosition3D { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A76C0 Offset: 0x19A6AC0 VA: 0x1819A76C0
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A7E10 Offset: 0x19A7210 VA: 0x1819A7E10
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x19A7D20 Offset: 0x19A7120 VA: 0x1819A7D20
	public Rect get_rect() { }

	// RVA: 0x19A7860 Offset: 0x19A6C60 VA: 0x1819A7860
	public Vector2 get_anchorMin() { }

	// RVA: 0x19A7FA0 Offset: 0x19A73A0 VA: 0x1819A7FA0
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x19A77C0 Offset: 0x19A6BC0 VA: 0x1819A77C0
	public Vector2 get_anchorMax() { }

	// RVA: 0x19A7F10 Offset: 0x19A7310 VA: 0x1819A7F10
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x19A79B0 Offset: 0x19A6DB0 VA: 0x1819A79B0
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x19A8110 Offset: 0x19A7510 VA: 0x1819A8110
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x19A7DC0 Offset: 0x19A71C0 VA: 0x1819A7DC0
	public Vector2 get_sizeDelta() { }

	// RVA: 0x19A8710 Offset: 0x19A7B10 VA: 0x1819A8710
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x19A7C80 Offset: 0x19A7080 VA: 0x1819A7C80
	public Vector2 get_pivot() { }

	// RVA: 0x19A8680 Offset: 0x19A7A80 VA: 0x1819A8680
	public void set_pivot(Vector2 value) { }

	// RVA: 0x19A78B0 Offset: 0x19A6CB0 VA: 0x1819A78B0
	public Vector3 get_anchoredPosition3D() { }

	// RVA: 0x19A7FE0 Offset: 0x19A73E0 VA: 0x1819A7FE0
	public void set_anchoredPosition3D(Vector3 value) { }

	// RVA: 0x19A7B30 Offset: 0x19A6F30 VA: 0x1819A7B30
	public Vector2 get_offsetMin() { }

	// RVA: 0x19A83C0 Offset: 0x19A77C0 VA: 0x1819A83C0
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x19A7A00 Offset: 0x19A6E00 VA: 0x1819A7A00
	public Vector2 get_offsetMax() { }

	// RVA: 0x19A8150 Offset: 0x19A7550 VA: 0x1819A8150
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x19A6BD0 Offset: 0x19A5FD0 VA: 0x1819A6BD0
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19A6F50 Offset: 0x19A6350 VA: 0x1819A6F50
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x19A7120 Offset: 0x19A6520 VA: 0x1819A7120
	public void SetInsetAndSizeFromParentEdge(RectTransform.Edge edge, float inset, float size) { }

	// RVA: 0x19A7440 Offset: 0x19A6840 VA: 0x1819A7440
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x19A70D0 Offset: 0x19A64D0 VA: 0x1819A70D0
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x19A6E40 Offset: 0x19A6240 VA: 0x1819A6E40
	private Vector2 GetParentSize() { }

	// RVA: 0x19A7CD0 Offset: 0x19A70D0 VA: 0x1819A7CD0
	private void get_rect_Injected(out Rect ret) { }

	// RVA: 0x19A7810 Offset: 0x19A6C10 VA: 0x1819A7810
	private void get_anchorMin_Injected(out Vector2 ret) { }

	// RVA: 0x19A7F50 Offset: 0x19A7350 VA: 0x1819A7F50
	private void set_anchorMin_Injected(ref Vector2 value) { }

	// RVA: 0x19A7770 Offset: 0x19A6B70 VA: 0x1819A7770
	private void get_anchorMax_Injected(out Vector2 ret) { }

	// RVA: 0x19A7EC0 Offset: 0x19A72C0 VA: 0x1819A7EC0
	private void set_anchorMax_Injected(ref Vector2 value) { }

	// RVA: 0x19A7960 Offset: 0x19A6D60 VA: 0x1819A7960
	private void get_anchoredPosition_Injected(out Vector2 ret) { }

	// RVA: 0x19A80C0 Offset: 0x19A74C0 VA: 0x1819A80C0
	private void set_anchoredPosition_Injected(ref Vector2 value) { }

	// RVA: 0x19A7D70 Offset: 0x19A7170 VA: 0x1819A7D70
	private void get_sizeDelta_Injected(out Vector2 ret) { }

	// RVA: 0x19A86C0 Offset: 0x19A7AC0 VA: 0x1819A86C0
	private void set_sizeDelta_Injected(ref Vector2 value) { }

	// RVA: 0x19A7C30 Offset: 0x19A7030 VA: 0x1819A7C30
	private void get_pivot_Injected(out Vector2 ret) { }

	// RVA: 0x19A8630 Offset: 0x19A7A30 VA: 0x1819A8630
	private void set_pivot_Injected(ref Vector2 value) { }

}

public enum RectTransform.Edge // TypeDefIndex: 3566
{	// Fields
	public int value__; // 0x0
	public const RectTransform.Edge Left = 0;
	public const RectTransform.Edge Right = 1;
	public const RectTransform.Edge Top = 2;
	public const RectTransform.Edge Bottom = 3;

}

public enum RectTransform.Axis // TypeDefIndex: 3567
{	// Fields
	public int value__; // 0x0
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;

}

public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 3568
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DD910 Offset: 0x12DCD10 VA: 0x1812DD910 Slot: 12
	public virtual void Invoke(RectTransform driven) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(RectTransform driven, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

