public static class UnsafeUtility // TypeDefIndex: 3340
{	// Methods

	// RVA: -1 Offset: -1
	public static bool IsBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEFBE0 Offset: 0xBEEFE0 VA: 0x180BEFBE0
	|-UnsafeUtility.IsBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182F980 Offset: 0x182ED80 VA: 0x18182F980
	public static void* Malloc(long size, int alignment, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182F5D0 Offset: 0x182E9D0 VA: 0x18182F5D0
	public static void Free(void* memory, Allocator allocator) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182FA20 Offset: 0x182EE20 VA: 0x18182FA20
	public static void MemCpy(void* destination, void* source, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182FA80 Offset: 0x182EE80 VA: 0x18182FA80
	public static void MemSet(void* destination, byte value, long size) { }

	// RVA: 0x182F9D0 Offset: 0x182EDD0 VA: 0x18182F9D0
	public static void MemClear(void* destination, long size) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182FAE0 Offset: 0x182EEE0 VA: 0x18182FAE0
	public static int SizeOf(Type type) { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x182F940 Offset: 0x182ED40 VA: 0x18182F940
	public static bool IsBlittable(Type type) { }

	// RVA: 0x182F8E0 Offset: 0x182ECE0 VA: 0x18182F8E0
	private static bool IsBlittableValueType(Type t) { }

	// RVA: 0x182F670 Offset: 0x182EA70 VA: 0x18182F670
	private static string GetReasonForTypeNonBlittableImpl(Type t, string name) { }

	// RVA: 0x182F850 Offset: 0x182EC50 VA: 0x18182F850
	internal static bool IsArrayBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static bool IsGenericListBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBEFC50 Offset: 0xBEF050 VA: 0x180BEFC50
	|-UnsafeUtility.IsGenericListBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: 0x182F610 Offset: 0x182EA10 VA: 0x18182F610
	internal static string GetReasonForArrayNonBlittable(Array arr) { }

	// RVA: -1 Offset: -1
	internal static string GetReasonForGenericListNonBlittable<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84E60 Offset: 0xE84260 VA: 0x180E84E60
	|-UnsafeUtility.GetReasonForGenericListNonBlittable<FoliageGridMeshData.FoliageVertex>
	*/

	// RVA: -1 Offset: -1
	public static int AlignOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84DF0 Offset: 0xE841F0 VA: 0x180E84DF0
	|-UnsafeUtility.AlignOf<BoneData>
	|-UnsafeUtility.AlignOf<BoneState>
	|-UnsafeUtility.AlignOf<ColliderData>
	|-UnsafeUtility.AlignOf<ColliderState>
	|-UnsafeUtility.AlignOf<byte>
	|-UnsafeUtility.AlignOf<int>
	|-UnsafeUtility.AlignOf<float>
	|-UnsafeUtility.AlignOf<uint>
	|-UnsafeUtility.AlignOf<JobHandle>
	|-UnsafeUtility.AlignOf<float3>
	|-UnsafeUtility.AlignOf<half2>
	|-UnsafeUtility.AlignOf<Color32>
	|-UnsafeUtility.AlignOf<LightDataGI>
	|-UnsafeUtility.AlignOf<Plane>
	|-UnsafeUtility.AlignOf<RaycastCommand>
	|-UnsafeUtility.AlignOf<RaycastHit>
	|-UnsafeUtility.AlignOf<BatchVisibility>
	|-UnsafeUtility.AlignOf<Vector4>
	*/

	// RVA: -1 Offset: -1
	public static void CopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDE40 Offset: 0x5ED240 VA: 0x1805EDE40
	|-UnsafeUtility.CopyPtrToStructure<IntPtr>
	*/

	// RVA: -1 Offset: -1
	private static void InternalCopyPtrToStructure<T>(void* ptr, out T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDE50 Offset: 0x5ED250 VA: 0x1805EDE50
	|-UnsafeUtility.InternalCopyPtrToStructure<IntPtr>
	*/

	// RVA: -1 Offset: -1
	public static T ReadArrayElement<T>(void* source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1060 Offset: 0x14C0460 VA: 0x1814C1060
	|-UnsafeUtility.ReadArrayElement<BoneData>
	|
	|-RVA: 0x14C10C0 Offset: 0x14C04C0 VA: 0x1814C10C0
	|-UnsafeUtility.ReadArrayElement<BoneState>
	|
	|-RVA: 0x14C1100 Offset: 0x14C0500 VA: 0x1814C1100
	|-UnsafeUtility.ReadArrayElement<ColliderData>
	|
	|-RVA: 0x14C1130 Offset: 0x14C0530 VA: 0x1814C1130
	|-UnsafeUtility.ReadArrayElement<ColliderState>
	|
	|-RVA: 0x14C10F0 Offset: 0x14C04F0 VA: 0x1814C10F0
	|-UnsafeUtility.ReadArrayElement<byte>
	|
	|-RVA: 0x14C1150 Offset: 0x14C0550 VA: 0x1814C1150
	|-UnsafeUtility.ReadArrayElement<int>
	|-UnsafeUtility.ReadArrayElement<uint>
	|-UnsafeUtility.ReadArrayElement<half2>
	|-UnsafeUtility.ReadArrayElement<Color32>
	|
	|-RVA: 0x14C1240 Offset: 0x14C0640 VA: 0x1814C1240
	|-UnsafeUtility.ReadArrayElement<object>
	|
	|-RVA: 0x14C1250 Offset: 0x14C0650 VA: 0x1814C1250
	|-UnsafeUtility.ReadArrayElement<float>
	|
	|-RVA: 0x14C1160 Offset: 0x14C0560 VA: 0x1814C1160
	|-UnsafeUtility.ReadArrayElement<JobHandle>
	|-UnsafeUtility.ReadArrayElement<Plane>
	|-UnsafeUtility.ReadArrayElement<Vector4>
	|
	|-RVA: 0x14C1040 Offset: 0x14C0440 VA: 0x1814C1040
	|-UnsafeUtility.ReadArrayElement<float3>
	|-UnsafeUtility.ReadArrayElement<BatchVisibility>
	|
	|-RVA: 0x14C1180 Offset: 0x14C0580 VA: 0x1814C1180
	|-UnsafeUtility.ReadArrayElement<LightDataGI>
	|
	|-RVA: 0x14C11D0 Offset: 0x14C05D0 VA: 0x1814C11D0
	|-UnsafeUtility.ReadArrayElement<RaycastCommand>
	|
	|-RVA: 0x14C1200 Offset: 0x14C0600 VA: 0x1814C1200
	|-UnsafeUtility.ReadArrayElement<RaycastHit>
	*/

	// RVA: -1 Offset: -1
	public static void WriteArrayElement<T>(void* destination, int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDE90 Offset: 0x5ED290 VA: 0x1805EDE90
	|-UnsafeUtility.WriteArrayElement<BoneData>
	|
	|-RVA: 0x5EDEF0 Offset: 0x5ED2F0 VA: 0x1805EDEF0
	|-UnsafeUtility.WriteArrayElement<BoneState>
	|
	|-RVA: 0x5EDF30 Offset: 0x5ED330 VA: 0x1805EDF30
	|-UnsafeUtility.WriteArrayElement<ColliderData>
	|
	|-RVA: 0x5EDF60 Offset: 0x5ED360 VA: 0x1805EDF60
	|-UnsafeUtility.WriteArrayElement<ColliderState>
	|
	|-RVA: 0x5EDF20 Offset: 0x5ED320 VA: 0x1805EDF20
	|-UnsafeUtility.WriteArrayElement<byte>
	|
	|-RVA: 0x5EDF80 Offset: 0x5ED380 VA: 0x1805EDF80
	|-UnsafeUtility.WriteArrayElement<int>
	|-UnsafeUtility.WriteArrayElement<uint>
	|-UnsafeUtility.WriteArrayElement<half2>
	|-UnsafeUtility.WriteArrayElement<Color32>
	|
	|-RVA: 0x5EE050 Offset: 0x5ED450 VA: 0x1805EE050
	|-UnsafeUtility.WriteArrayElement<object>
	|
	|-RVA: 0x5EE070 Offset: 0x5ED470 VA: 0x1805EE070
	|-UnsafeUtility.WriteArrayElement<float>
	|
	|-RVA: 0x5EDF90 Offset: 0x5ED390 VA: 0x1805EDF90
	|-UnsafeUtility.WriteArrayElement<JobHandle>
	|-UnsafeUtility.WriteArrayElement<Plane>
	|-UnsafeUtility.WriteArrayElement<Vector4>
	|
	|-RVA: 0x5EDE70 Offset: 0x5ED270 VA: 0x1805EDE70
	|-UnsafeUtility.WriteArrayElement<float3>
	|-UnsafeUtility.WriteArrayElement<BatchVisibility>
	|
	|-RVA: 0x5EDFA0 Offset: 0x5ED3A0 VA: 0x1805EDFA0
	|-UnsafeUtility.WriteArrayElement<LightDataGI>
	|
	|-RVA: 0x5EDFF0 Offset: 0x5ED3F0 VA: 0x1805EDFF0
	|-UnsafeUtility.WriteArrayElement<RaycastCommand>
	|
	|-RVA: 0x5EE020 Offset: 0x5ED420 VA: 0x1805EE020
	|-UnsafeUtility.WriteArrayElement<RaycastHit>
	*/

	// RVA: -1 Offset: -1
	public static void* AddressOf<T>(ref T output) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80
	|-UnsafeUtility.AddressOf<InitializeBoneStateJob>
	|-UnsafeUtility.AddressOf<InitializeColliderStateJob>
	|-UnsafeUtility.AddressOf<SimulatePositionsJob>
	|-UnsafeUtility.AddressOf<UpdateTransformsJob>
	|-UnsafeUtility.AddressOf<MeshPaintable3D.DrawTextureJob>
	|-UnsafeUtility.AddressOf<ParticleSystemIK.ParticleSystemIKJob>
	|-UnsafeUtility.AddressOf<BatchQueryJob<RaycastCommand, RaycastHit>>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84F80 Offset: 0xE84380 VA: 0x180E84F80
	|-UnsafeUtility.SizeOf<BoneData>
	|
	|-RVA: 0xE84F70 Offset: 0xE84370 VA: 0x180E84F70
	|-UnsafeUtility.SizeOf<BoneState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastCommand>>
	|
	|-RVA: 0xE84F10 Offset: 0xE84310 VA: 0x180E84F10
	|-UnsafeUtility.SizeOf<ColliderData>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderState>>
	|
	|-RVA: 0xE84F30 Offset: 0xE84330 VA: 0x180E84F30
	|-UnsafeUtility.SizeOf<ColliderState>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<JobHandle>>
	|
	|-RVA: 0xE84F90 Offset: 0xE84390 VA: 0x180E84F90
	|-UnsafeUtility.SizeOf<FoliageGridMeshData.FoliageVertex>
	|
	|-RVA: 0x5CB140 Offset: 0x5CA540 VA: 0x1805CB140
	|-UnsafeUtility.SizeOf<byte>
	|
	|-RVA: 0xE32BD0 Offset: 0xE31FD0 VA: 0x180E32BD0
	|-UnsafeUtility.SizeOf<int>
	|-UnsafeUtility.SizeOf<float>
	|-UnsafeUtility.SizeOf<uint>
	|-UnsafeUtility.SizeOf<half2>
	|-UnsafeUtility.SizeOf<Color32>
	|
	|-RVA: 0xE84F60 Offset: 0xE84360 VA: 0x180E84F60
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneData>>
	|
	|-RVA: 0xE84F00 Offset: 0xE84300 VA: 0x180E84F00
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BoneState>>
	|-UnsafeUtility.SizeOf<RaycastHit>
	|
	|-RVA: 0xE84F20 Offset: 0xE84320 VA: 0x180E84F20
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<ColliderData>>
	|
	|-RVA: 0x54B2D0 Offset: 0x54A6D0 VA: 0x18054B2D0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<byte>>
	|
	|-RVA: 0x8B0DD0 Offset: 0x8B01D0 VA: 0x1808B0DD0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<int>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<uint>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Color32>>
	|
	|-RVA: 0xE84F40 Offset: 0xE84340 VA: 0x180E84F40
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<float3>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<BatchVisibility>>
	|-UnsafeUtility.SizeOf<JobHandle>
	|-UnsafeUtility.SizeOf<Plane>
	|-UnsafeUtility.SizeOf<Vector4>
	|
	|-RVA: 0x8E3F40 Offset: 0x8E3340 VA: 0x1808E3F40
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<half2>>
	|
	|-RVA: 0xE84F50 Offset: 0xE84350 VA: 0x180E84F50
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<LightDataGI>>
	|
	|-RVA: 0xE84EF0 Offset: 0xE842F0 VA: 0x180E84EF0
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Plane>>
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<Vector4>>
	|
	|-RVA: 0x7F2080 Offset: 0x7F1480 VA: 0x1807F2080
	|-UnsafeUtility.SizeOf<UnsafeUtility.AlignOfHelper<RaycastHit>>
	|
	|-RVA: 0xB9AAF0 Offset: 0xB99EF0 VA: 0x180B9AAF0
	|-UnsafeUtility.SizeOf<float3>
	|-UnsafeUtility.SizeOf<BatchVisibility>
	|
	|-RVA: 0xE84FA0 Offset: 0xE843A0 VA: 0x180E84FA0
	|-UnsafeUtility.SizeOf<LightDataGI>
	|
	|-RVA: 0xE84FB0 Offset: 0xE843B0 VA: 0x180E84FB0
	|-UnsafeUtility.SizeOf<RaycastCommand>
	*/

	// RVA: -1 Offset: -1
	public static int EnumToInt<T>(T enumValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE84E30 Offset: 0xE84230 VA: 0x180E84E30
	|-UnsafeUtility.EnumToInt<Int32Enum>
	*/

	// RVA: -1 Offset: -1
	private static void InternalEnumToInt<T>(ref T enumValue, ref int intValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5EDE60 Offset: 0x5ED260 VA: 0x1805EDE60
	|-UnsafeUtility.InternalEnumToInt<Int32Enum>
	|-UnsafeUtility.InternalEnumToInt<object>
	*/

}

private struct UnsafeUtility.AlignOfHelper<T> // TypeDefIndex: 3341
{	// Fields
	public byte dummy; // 0x0
	public T data; // 0x0

}

