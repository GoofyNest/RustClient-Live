public class DeferredDecalSystem // TypeDefIndex: 10651
{	internal static bool IsDirty; // 0x0
	internal const int QueueSize = 2;
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] DiffuseDecals; // 0x8
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] SpecularDecals; // 0x10
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] NormalsDecals; // 0x18
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] EmissionDecals; // 0x20
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] CombinedDecals; // 0x28
	internal static int DiffusePass; // 0x30
	internal static int SpecularPass; // 0x34
	internal static int NormalsPass; // 0x38
	internal static int EmissionPass; // 0x3C
	internal static int CombinedPass; // 0x40
	internal static RenderTargetIdentifier[] DiffuseRenderTarget; // 0x48
	internal static RenderTargetIdentifier[] SpecularRenderTarget; // 0x50
	internal static RenderTargetIdentifier[] NormalsRenderTarget; // 0x58
	internal static RenderTargetIdentifier[] EmissionRenderTarget; // 0x60
	internal static RenderTargetIdentifier[] CombinedRenderTarget; // 0x68

	public static bool IsEmpty { get; }


	public static bool get_IsEmpty() { }

	public static void Clear() { }

	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass) { }

	public static void AddDecal(DeferredDecal decal) { }

	public static void RemoveDecal(DeferredDecal decal) { }

	public static void RefreshDecal(DeferredDecal decal) { }

	public void .ctor() { }

	private static void .cctor() { }

}

