internal static class BurstExtensions // TypeDefIndex: 7313
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T GetReadonly<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3F90 Offset: 0x14A3390 VA: 0x1814A3F90
	|-BurstExtensions.GetReadonly<BoneData>
	|
	|-RVA: 0x14A3FC0 Offset: 0x14A33C0 VA: 0x1814A3FC0
	|-BurstExtensions.GetReadonly<BoneState>
	|
	|-RVA: 0x14A4000 Offset: 0x14A3400 VA: 0x1814A4000
	|-BurstExtensions.GetReadonly<ColliderData>
	|
	|-RVA: 0x14A4030 Offset: 0x14A3430 VA: 0x1814A4030
	|-BurstExtensions.GetReadonly<ColliderState>
	*/

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static ref T Get<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A3FC0 Offset: 0x14A33C0 VA: 0x1814A3FC0
	|-BurstExtensions.Get<BoneState>
	|
	|-RVA: 0x14A4030 Offset: 0x14A3430 VA: 0x1814A4030
	|-BurstExtensions.Get<ColliderState>
	|
	|-RVA: 0x14A4070 Offset: 0x14A3470 VA: 0x1814A4070
	|-BurstExtensions.Get<float3>
	*/

}

