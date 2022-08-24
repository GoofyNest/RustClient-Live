public class ReverbSettings : ScriptableObject // TypeDefIndex: 9017
{
	[RangeAttribute] 
	public int room; 
	[RangeAttribute] 
	public int roomHF; 
	[RangeAttribute] 
	public int roomLF; 
	[RangeAttribute] 
	public float decayTime; 
	[RangeAttribute] 
	public float decayHFRatio; 
	[RangeAttribute] 
	public int reflections; 
	[RangeAttribute] 
	public float reflectionsDelay; 
	[RangeAttribute] 
	public int reverb; 
	[RangeAttribute] 
	public float reverbDelay; 
	[RangeAttribute] 
	public float HFReference; 
	[RangeAttribute] 
	public float LFReference; 
	[RangeAttribute] 
	public float diffusion; 
	[RangeAttribute] 
	public float density; 


public void .ctor() { }

}

