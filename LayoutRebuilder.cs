public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 4985
{
	private RectTransform m_ToRebuild; 
	private int m_CachedHashFromTransform; 
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; 

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

private sealed class LayoutRebuilder.<>c // TypeDefIndex: 4986
{
	public static readonly LayoutRebuilder.<>c <>9; 
	public static Predicate<Component> <>9__10_0; 
	public static UnityAction<Component> <>9__12_0; 
	public static UnityAction<Component> <>9__12_1; 
	public static UnityAction<Component> <>9__12_2; 
	public static UnityAction<Component> <>9__12_3; 


	private static void .cctor() { }

	public void .ctor() { }

	internal void <.cctor>

	internal bool <StripDisabledBehavioursFromList>

	internal void <Rebuild>

	internal void <Rebuild>

	internal void <Rebuild>

	internal void <Rebuild>

}

