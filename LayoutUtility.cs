public static class LayoutUtility // TypeDefIndex: 4981
{	// Methods

	// RVA: 0x170EA70 Offset: 0x170DE70 VA: 0x18170EA70
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x170EF50 Offset: 0x170E350 VA: 0x18170EF50
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x170E380 Offset: 0x170D780 VA: 0x18170E380
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x170EC30 Offset: 0x170E030 VA: 0x18170EC30
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x170EF70 Offset: 0x170E370 VA: 0x18170EF70
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x170E540 Offset: 0x170D940 VA: 0x18170E540
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x170E970 Offset: 0x170DD70 VA: 0x18170E970
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x170ED30 Offset: 0x170E130 VA: 0x18170ED30
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x170E280 Offset: 0x170D680 VA: 0x18170E280
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x170E640 Offset: 0x170DA40 VA: 0x18170E640
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x170E660 Offset: 0x170DA60 VA: 0x18170E660
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }

}

private sealed class LayoutUtility.<>c // TypeDefIndex: 4982
{	// Fields
	public static readonly LayoutUtility.<>c <>9; // 0x0
	public static Func<ILayoutElement, float> <>9__3_0; // 0x8
	public static Func<ILayoutElement, float> <>9__4_0; // 0x10
	public static Func<ILayoutElement, float> <>9__4_1; // 0x18
	public static Func<ILayoutElement, float> <>9__5_0; // 0x20
	public static Func<ILayoutElement, float> <>9__6_0; // 0x28
	public static Func<ILayoutElement, float> <>9__7_0; // 0x30
	public static Func<ILayoutElement, float> <>9__7_1; // 0x38
	public static Func<ILayoutElement, float> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x1722740 Offset: 0x1721B40 VA: 0x181722740
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x1722240 Offset: 0x1721640 VA: 0x181722240
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x1722330 Offset: 0x1721730 VA: 0x181722330
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x1722380 Offset: 0x1721780 VA: 0x181722380
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x17221A0 Offset: 0x17215A0 VA: 0x1817221A0
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x17221F0 Offset: 0x17215F0 VA: 0x1817221F0
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1722290 Offset: 0x1721690 VA: 0x181722290
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x17222E0 Offset: 0x17216E0 VA: 0x1817222E0
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x1722150 Offset: 0x1721550 VA: 0x181722150
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }

}

