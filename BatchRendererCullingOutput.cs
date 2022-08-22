internal struct BatchRendererCullingOutput // TypeDefIndex: 3845
{	public JobHandle cullingJobsFence; // 0x0
	public Plane* cullingPlanes; // 0x10
	public BatchVisibility* batchVisibility; // 0x18
	public int* visibleIndices; // 0x20
	public int cullingPlanesCount; // 0x28
	public int batchVisibilityCount; // 0x2C
	public int visibleIndicesCount; // 0x30

}

