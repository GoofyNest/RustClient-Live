public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10649
{	// Fields
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; // 0x0
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; // 0x8
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; // 0x10
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; // 0x18
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; // 0x20
	private static MaterialPropertyBlock block; // 0x28

	// Methods

	// RVA: 0x8EB3B0 Offset: 0x8EA7B0 VA: 0x1808EB3B0
	private void RefreshCommandBuffer(Camera camera) { }

	// RVA: 0x8EB0F0 Offset: 0x8EA4F0 VA: 0x1808EB0F0
	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

	// RVA: 0x8EAAE0 Offset: 0x8E9EE0 VA: 0x1808EAAE0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

	// RVA: 0x8EADD0 Offset: 0x8EA1D0 VA: 0x1808EADD0
	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

	// RVA: 0x8EB190 Offset: 0x8EA590 VA: 0x1808EB190
	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

	// RVA: 0x8EB2C0 Offset: 0x8EA6C0 VA: 0x1808EB2C0
	protected void OnPreRender() { }

	// RVA: 0x8EC0E0 Offset: 0x8EB4E0 VA: 0x1808EC0E0
	public void .ctor() { }

	// RVA: 0x8EBB00 Offset: 0x8EAF00 VA: 0x1808EBB00
	private static void .cctor() { }

}

