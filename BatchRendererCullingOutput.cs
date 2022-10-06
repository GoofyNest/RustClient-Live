internal struct BatchRendererCullingOutput // TypeDefIndex: 3847
{
	public JobHandle cullingJobsFence; 
	public Plane* cullingPlanes; 
	public BatchVisibility* batchVisibility; 
	public int* visibleIndices; 
	public int cullingPlanesCount; 
	public int batchVisibilityCount; 
	public int visibleIndicesCount; 

}

