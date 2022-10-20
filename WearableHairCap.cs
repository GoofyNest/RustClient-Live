public class WearableHairCap : MonoBehaviour // TypeDefIndex: 10972
{
	public HairType Type; 
	[ColorUsageAttribute] 
	public Color BaseColor; 
	public Texture Mask; 
	private static MaterialPropertyBlock block; 
	private static int _HairBaseColorUV1; 
	private static int _HairBaseColorUV2; 
	private static int _HairPackedMapUV1; 
	private static int _HairPackedMapUV2; 


	public void ApplyHairCap(MaterialPropertyBlock block) { }

	public void .ctor() { }

	private static void .cctor() { }

}

