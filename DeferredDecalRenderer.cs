public class DeferredDecalRenderer : BaseCommandBuffer // TypeDefIndex: 10649
{
	private static ListDictionary<InstancingKey, InstancingBuffer>[] DiffuseBuffer; 
	private static ListDictionary<InstancingKey, InstancingBuffer>[] SpecularBuffer; 
	private static ListDictionary<InstancingKey, InstancingBuffer>[] NormalsBuffer; 
	private static ListDictionary<InstancingKey, InstancingBuffer>[] EmissionBuffer; 
	private static ListDictionary<InstancingKey, InstancingBuffer>[] CombinedBuffer; 
	private static MaterialPropertyBlock block; 


private void RefreshCommandBuffer(Camera camera) { }

private void Clear(ListDictionary<InstancingKey, InstancingBuffer> dict) { }

private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListDictionary<InstancingKey, ListHashSet<DeferredDecal>> src, ListDictionary<InstancingKey, InstancingBuffer> dst, MaterialPropertyBlock block) { }

private void Apply(CommandBuffer buf, RenderTargetIdentifier[] target, int pass, ListHashSet<DeferredDecal> src, InstancingBuffer dst, MaterialPropertyBlock block) { }

private InstancingBuffer GetBuffer(ListDictionary<InstancingKey, InstancingBuffer> dict, InstancingKey key) { }

protected void OnPreRender() { }

public void .ctor() { }

private static void .cctor() { }

}

