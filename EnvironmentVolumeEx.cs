public static class EnvironmentVolumeEx // TypeDefIndex: 9863
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8BA970 Offset: 0x8B9D70 VA: 0x1808BA970
	public static bool CheckEnvironmentVolumes(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8BA8A0 Offset: 0x8B9CA0 VA: 0x1808BA8A0
	public static bool CheckEnvironmentVolumes(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B9B80 Offset: 0x8B8F80 VA: 0x1808B9B80
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8BA130 Offset: 0x8B9530 VA: 0x1808BA130
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8BA2F0 Offset: 0x8B96F0 VA: 0x1808BA2F0
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8BA210 Offset: 0x8B9610 VA: 0x1808BA210
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, EnvironmentType type) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass2_0 // TypeDefIndex: 9864
{	// Fields
	public float max; // 0x10
	public bool fail; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C94B0 Offset: 0x8C88B0 VA: 0x1808C94B0
	internal void <CheckEnvironmentVolumesInsideTerrain>b__0(int x, int z) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass4_0 // TypeDefIndex: 9865
{	// Fields
	public float min; // 0x10
	public bool fail; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x8C9590 Offset: 0x8C8990 VA: 0x1808C9590
	internal void <CheckEnvironmentVolumesOutsideTerrain>b__0(int x, int z) { }

}

