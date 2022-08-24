public struct BatchCullingContext // TypeDefIndex: 3844
{
	public readonly NativeArray<Plane> cullingPlanes; 
	public NativeArray<BatchVisibility> batchVisibility; 
	public NativeArray<int> visibleIndices; 
	public readonly LODParameters lodParameters; 


public void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<BatchVisibility> inOutBatchVisibility, NativeArray<int> outVisibleIndices, LODParameters inLodParameters) { }

}

