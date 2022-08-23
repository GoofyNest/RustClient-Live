public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339
{
[RequiredByNativeCodeAttribute] // RVA: 0xE0D10 Offset: 0xE0110 VA: 0x1800E0D10
[AttributeUsageAttribute] // RVA: 0xE0D10 Offset: 0xE0110 VA: 0x1800E0D10
public sealed class NativeSetClassTypeToNullOnScheduleAttribute : Attribute // TypeDefIndex: 3338

[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
public static class NativeArrayUnsafeUtility // TypeDefIndex: 3339

	public static NativeArray<T> ConvertExistingDataToNativeArray<T>(void* dataPointer, int length, Allocator allocator) { }
	/* GenericInstMethod :
	|
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BoneState>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ColliderData>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<ColliderState>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<byte>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<int>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<uint>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<JobHandle>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float3>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<half2>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Color32>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<LightDataGI>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Plane>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RaycastCommand>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<RaycastHit>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<BatchVisibility>
	|-NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<Vector4>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void* GetUnsafePtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-NativeArrayUnsafeUtility.GetUnsafePtr<BoneState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<ColliderState>
	|-NativeArrayUnsafeUtility.GetUnsafePtr<float3>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void* GetUnsafeReadOnlyPtr<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneData>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<BoneState>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ColliderData>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<ColliderState>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<uint>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<JobHandle>
	|-NativeArrayUnsafeUtility.GetUnsafeReadOnlyPtr<Vector4>
	*/

	public static void* GetUnsafeBufferPointerWithoutChecks<T>(NativeArray<T> nativeArray) { }
	/* GenericInstMethod :
	|
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastCommand>
	|-NativeArrayUnsafeUtility.GetUnsafeBufferPointerWithoutChecks<RaycastHit>
	*/

}

