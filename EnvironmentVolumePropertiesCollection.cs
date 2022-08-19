public class EnvironmentVolumePropertiesCollection : ScriptableObject // TypeDefIndex: 10671
{	// Fields
	public float TransitionSpeed; // 0x18
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] ReflectionMultipliers; // 0x20
	public float DefaultReflectionMultiplier; // 0x28
	[HorizontalAttribute] // RVA: 0xAA1B0 Offset: 0xA95B0 VA: 0x1800AA1B0
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] AmbientMultipliers; // 0x30
	public float DefaultAmbientMultiplier; // 0x38
	public EnvironmentVolumePropertiesCollection.OceanParameters OceanOverrides; // 0x40

	// Methods

	// RVA: 0x8BAEB0 Offset: 0x8BA2B0 VA: 0x1808BAEB0
	public float FindReflectionMultiplier(EnvironmentType type) { }

	// RVA: 0x8BADA0 Offset: 0x8BA1A0 VA: 0x1808BADA0
	public float FindAmbientMultiplier(EnvironmentType type) { }

	// RVA: 0x8BAE10 Offset: 0x8BA210 VA: 0x1808BAE10
	public LayerMask FindReflectionCullingFlags() { }

	// RVA: 0x8BAFA0 Offset: 0x8BA3A0 VA: 0x1808BAFA0
	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.EnvironmentMultiplier // TypeDefIndex: 10672
{	// Fields
	public EnvironmentType Type; // 0x10
	public float Multiplier; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.OceanParameters // TypeDefIndex: 10673
{	// Fields
	public AnimationCurve TransitionCurve; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float DirectionalLightMultiplier; // 0x18
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float AmbientLightMultiplier; // 0x1C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float ReflectionMultiplier; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float SunMeshBrightnessMultiplier; // 0x24
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float MoonMeshBrightnessMultiplier; // 0x28
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float AtmosphereBrightnessMultiplier; // 0x2C
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float LightColorMultiplier; // 0x30
	public Color LightColor; // 0x34
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float SunRayColorMultiplier; // 0x44
	public Color SunRayColor; // 0x48
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float MoonRayColorMultiplier; // 0x58
	public Color MoonRayColor; // 0x5C

	// Methods

	// RVA: 0x8C6460 Offset: 0x8C5860 VA: 0x1808C6460
	public void .ctor() { }

}

