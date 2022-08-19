public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4979
{	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x170CD40 Offset: 0x170C140 VA: 0x18170CD40
	private void Initialize(RectTransform controller) { }

	// RVA: 0x170CBC0 Offset: 0x170BFC0 VA: 0x18170CBC0
	private void Clear() { }

	// RVA: 0x170E180 Offset: 0x170D580 VA: 0x18170E180
	private static void .cctor() { }

	// RVA: 0x170DA50 Offset: 0x170CE50 VA: 0x18170DA50
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x170CD90 Offset: 0x170C190 VA: 0x18170CD90 Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x170DDE0 Offset: 0x170D1E0 VA: 0x18170DDE0
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x170CC50 Offset: 0x170C050 VA: 0x18170CC50
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x170DAB0 Offset: 0x170CEB0 VA: 0x18170DAB0 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x170D7B0 Offset: 0x170CBB0 VA: 0x18170D7B0
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x170D530 Offset: 0x170C930 VA: 0x18170D530
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x170CE70 Offset: 0x170C270 VA: 0x18170CE70
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x170DF20 Offset: 0x170D320 VA: 0x18170DF20
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x170D3C0 Offset: 0x170C7C0 VA: 0x18170D3C0
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x170CDF0 Offset: 0x170C1F0 VA: 0x18170CDF0 Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x170CBF0 Offset: 0x170BFF0 VA: 0x18170CBF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x170DEE0 Offset: 0x170D2E0 VA: 0x18170DEE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class LayoutRebuilder.<>c // TypeDefIndex: 4980
{	// Fields
	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x17226E0 Offset: 0x1721AE0 VA: 0x1817226E0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x17226A0 Offset: 0x1721AA0 VA: 0x1817226A0
	internal void <.cctor>b__5_0(LayoutRebuilder x) { }

	// RVA: 0x1722590 Offset: 0x1721990 VA: 0x181722590
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x17223D0 Offset: 0x17217D0 VA: 0x1817223D0
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1722440 Offset: 0x1721840 VA: 0x181722440
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x17224B0 Offset: 0x17218B0 VA: 0x1817224B0
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1722520 Offset: 0x1721920 VA: 0x181722520
	internal void <Rebuild>b__12_3(Component e) { }

}

