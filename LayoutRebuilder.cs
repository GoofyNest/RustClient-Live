public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4979
{	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	public Transform transform { get; }


	private void Initialize(RectTransform controller) { }

	private void Clear() { }

	private static void .cctor() { }

	private static void ReapplyDrivenProperties(RectTransform driven) { }

	public Transform get_transform() { }

	public bool IsDestroyed() { }

	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	public void Rebuild(CanvasUpdate executing) { }

	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	public static void MarkLayoutForRebuild(RectTransform rect) { }

	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	public void LayoutComplete() { }

	public void GraphicUpdateComplete() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public override string ToString() { }

	public void .ctor() { }

}

private sealed class LayoutRebuilder.<>c // TypeDefIndex: 4980
{	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>b__5_0(LayoutRebuilder x) { }

	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	internal void <Rebuild>b__12_0(Component e) { }

	internal void <Rebuild>b__12_1(Component e) { }

	internal void <Rebuild>b__12_2(Component e) { }

	internal void <Rebuild>b__12_3(Component e) { }

}

