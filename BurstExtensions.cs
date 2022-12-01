internal static class BurstExtensions // TypeDefIndex: 7327
{

	[ExtensionAttribute]
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute]
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-BurstExtensions.Get<BoneState>
	|
	|-BurstExtensions.Get<ColliderState>
	|
	|-BurstExtensions.Get<float3>
	*/

}

