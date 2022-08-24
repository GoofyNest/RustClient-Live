public class EnvironmentVolumePropertiesCollection : ScriptableObject // TypeDefIndex: 10671
{
	public float TransitionSpeed; 
	[HorizontalAttribute] 
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] ReflectionMultipliers; 
	public float DefaultReflectionMultiplier; 
	[HorizontalAttribute] 
	public EnvironmentVolumePropertiesCollection.EnvironmentMultiplier[] AmbientMultipliers; 
	public float DefaultAmbientMultiplier; 
	public EnvironmentVolumePropertiesCollection.OceanParameters OceanOverrides; 


public float FindReflectionMultiplier(EnvironmentType type) { }

public float FindAmbientMultiplier(EnvironmentType type) { }

public LayerMask FindReflectionCullingFlags() { }

public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.EnvironmentMultiplier // TypeDefIndex: 10672
{
	public EnvironmentType Type; 
	public float Multiplier; 


public void .ctor() { }

}

public class EnvironmentVolumePropertiesCollection.OceanParameters // TypeDefIndex: 10673
{
	public AnimationCurve TransitionCurve; 
	[RangeAttribute] 
	public float DirectionalLightMultiplier; 
	[RangeAttribute] 
	public float AmbientLightMultiplier; 
	[RangeAttribute] 
	public float ReflectionMultiplier; 
	[RangeAttribute] 
	public float SunMeshBrightnessMultiplier; 
	[RangeAttribute] 
	public float MoonMeshBrightnessMultiplier; 
	[RangeAttribute] 
	public float AtmosphereBrightnessMultiplier; 
	[RangeAttribute] 
	public float LightColorMultiplier; 
	public Color LightColor; 
	[RangeAttribute] 
	public float SunRayColorMultiplier; 
	public Color SunRayColor; 
	[RangeAttribute] 
	public float MoonRayColorMultiplier; 
	public Color MoonRayColor; 


public void .ctor() { }

}

