public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10649
{	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; // 0x0
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; // 0x8
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; // 0x10
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; // 0x18
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; // 0x20
	private static MaterialPropertyBlock block; // 0x28


	private void RefreshCommandBuffer(Camera camera) { }

	private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

	private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

	private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

	protected void OnPreRender() { }

	public void .ctor() { }

	private static void .cctor() { }

}

