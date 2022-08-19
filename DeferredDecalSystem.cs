public class DeferredDecalSystem // TypeDefIndex: 10651
{	// Fields
	internal static bool IsDirty; // 0x0
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

	// Properties
	public static bool IsEmpty { get; }

	// Methods

	// RVA: 0x8ED460 Offset: 0x8EC860 VA: 0x1808ED460
	public static bool get_IsEmpty() { }

	// RVA: 0x8EC4B0 Offset: 0x8EB8B0 VA: 0x1808EC4B0
	public static void Clear() { }

	// RVA: 0x8EC690 Offset: 0x8EBA90 VA: 0x1808EC690
	private static ListHashSet<DeferredDecal> GetList(DeferredDecal decal, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> dict, int pass) { }

	// RVA: 0x8EC0F0 Offset: 0x8EB4F0 VA: 0x1808EC0F0
	public static void AddDecal(DeferredDecal decal) { }

	// RVA: 0x8EC850 Offset: 0x8EBC50 VA: 0x1808EC850
	public static void RemoveDecal(DeferredDecal decal) { }

	// RVA: 0x8EC7F0 Offset: 0x8EBBF0 VA: 0x1808EC7F0
	public static void RefreshDecal(DeferredDecal decal) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8ECAC0 Offset: 0x8EBEC0 VA: 0x1808ECAC0
	private static void .cctor() { }

}

