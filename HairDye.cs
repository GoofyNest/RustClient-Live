public class HairDye // TypeDefIndex: 10739
{
	[ColorUsageAttribute] 
	public Color capBaseColor; 
	public Material sourceMaterial; 
	[InspectorFlagsAttribute] 
	public HairDye.CopyPropertyMask copyProperties; 
	private static MaterialPropertyDesc[] transferableProps; 
	private static int _HairBaseColorUV1; 
	private static int _HairBaseColorUV2; 
	private static int _HairPackedMapUV1; 
	private static int _HairPackedMapUV2; 


	public void Apply(HairDyeCollection collection, MaterialPropertyBlock block) { }

	public void ApplyCap(HairDyeCollection collection, HairType type, MaterialPropertyBlock block) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum HairDye.CopyProperty // TypeDefIndex: 10740
{
	public int value__; 
	public const HairDye.CopyProperty DyeColor = 0;
	public const HairDye.CopyProperty RootColor = 1;
	public const HairDye.CopyProperty TipColor = 2;
	public const HairDye.CopyProperty Brightness = 3;
	public const HairDye.CopyProperty DyeRoughness = 4;
	public const HairDye.CopyProperty DyeScatter = 5;
	public const HairDye.CopyProperty Specular = 6;
	public const HairDye.CopyProperty Roughness = 7;
	public const HairDye.CopyProperty Count = 8;

}

public enum HairDye.CopyPropertyMask // TypeDefIndex: 10741
{
	public int value__; 
	public const HairDye.CopyPropertyMask DyeColor = 1;
	public const HairDye.CopyPropertyMask RootColor = 2;
	public const HairDye.CopyPropertyMask TipColor = 4;
	public const HairDye.CopyPropertyMask Brightness = 8;
	public const HairDye.CopyPropertyMask DyeRoughness = 16;
	public const HairDye.CopyPropertyMask DyeScatter = 32;
	public const HairDye.CopyPropertyMask Specular = 64;
	public const HairDye.CopyPropertyMask Roughness = 128;

}

