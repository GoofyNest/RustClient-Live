public static class EnvironmentVolumeEx // TypeDefIndex: 9863
{

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumes(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type) { }

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumes(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumesInsideTerrain(Transform transform, EnvironmentType type) { }

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, Vector3 pos, Quaternion rot, Vector3 scale, EnvironmentType type, float padding = 0) { }

	[ExtensionAttribute] 
	public static bool CheckEnvironmentVolumesOutsideTerrain(Transform transform, EnvironmentType type) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass2_0 // TypeDefIndex: 9864
{
	public float max; 
	public bool fail; 


	public void .ctor() { }

	internal void <CheckEnvironmentVolumesInsideTerrain>b__0(int x, int z) { }

}

private sealed class EnvironmentVolumeEx.<>c__DisplayClass4_0 // TypeDefIndex: 9865
{
	public float min; 
	public bool fail; 


	public void .ctor() { }

	internal void <CheckEnvironmentVolumesOutsideTerrain>b__0(int x, int z) { }

}

