public sealed class RectTransformUtility // TypeDefIndex: 4733
{	// Fields
	private static readonly Vector3[] s_Corners; // 0x12810

	// Methods

	// RVA: 0x2304530 Offset: 0x2303930 VA: 0x182304530
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x2304630 Offset: 0x2303A30 VA: 0x182304630
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x2304730 Offset: 0x2303B30 VA: 0x182304730
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam) { }

	// RVA: 0x23047C0 Offset: 0x2303BC0 VA: 0x1823047C0
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x2304BF0 Offset: 0x2303FF0 VA: 0x182304BF0
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x23048A0 Offset: 0x2303CA0 VA: 0x1823048A0
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x2304A20 Offset: 0x2303E20 VA: 0x182304A20
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x2304F90 Offset: 0x2304390 VA: 0x182304F90
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x23041B0 Offset: 0x23035B0 VA: 0x1823041B0
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x2303F00 Offset: 0x2303300 VA: 0x182303F00
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x2304480 Offset: 0x2303880 VA: 0x182304480
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x23050C0 Offset: 0x23044C0 VA: 0x1823050C0
	private static void .cctor() { }

	// RVA: 0x23044C0 Offset: 0x23038C0 VA: 0x1823044C0
	private static void PixelAdjustPoint_Injected(ref Vector2 point, Transform elementTransform, Canvas canvas, out Vector2 ret) { }

	// RVA: 0x23045D0 Offset: 0x23039D0 VA: 0x1823045D0
	private static void PixelAdjustRect_Injected(RectTransform rectTransform, Canvas canvas, out Rect ret) { }

	// RVA: 0x23046D0 Offset: 0x2303AD0 VA: 0x1823046D0
	private static bool PointInRectangle_Injected(ref Vector2 screenPoint, RectTransform rect, Camera cam) { }

}

