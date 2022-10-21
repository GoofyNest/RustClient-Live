public class DeferredDecalSystem // TypeDefIndex: 12382
{
	internal static bool IsDirty; 
	internal const int QueueSize = 2;
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] DiffuseDecals; 
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] SpecularDecals; 
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] NormalsDecals; 
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] EmissionDecals; 
	internal static ListDictionary<InstancingKey, ListHashSet<DeferredDecal>>[] CombinedDecals; 
	internal static int DiffusePass; 
	internal static int SpecularPass; 
	internal static int NormalsPass; 
	internal static int EmissionPass; 
	internal static int CombinedPass; 
	internal static RenderTargetIdentifier[] DiffuseRenderTarget; 
	internal static RenderTargetIdentifier[] SpecularRenderTarget; 
	internal static RenderTargetIdentifier[] NormalsRenderTarget; 
	internal static RenderTargetIdentifier[] EmissionRenderTarget; 
	internal static RenderTargetIdentifier[] CombinedRenderTarget; 

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

