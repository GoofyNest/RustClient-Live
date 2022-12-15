internal struct UpdateTransformsJob : IJobParallelForTransform // TypeDefIndex: 7337
{
	[ReadOnlyAttribute]
	[NativeMatchesParallelForLengthAttribute]
	public NativeArray<BoneData> Data;
	[ReadOnlyAttribute]
	[NativeMatchesParallelForLengthAttribute]
	public NativeArray<BoneState> State;


	public void Execute(int index, TransformAccess transform) { }

}

