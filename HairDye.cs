public class HairDye // TypeDefIndex: 10728
{	[ColorUsageAttribute] // RVA: 0x76690 Offset: 0x75A90 VA: 0x180076690
	public Color capBaseColor; // 0x10
	public Material sourceMaterial; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public HairDye.CopyPropertyMask copyProperties; // 0x28
	private static MaterialPropertyDesc[] transferableProps; // 0x0
	private static int _HairBaseColorUV1; // 0x8
	private static int _HairBaseColorUV2; // 0xC
	private static int _HairPackedMapUV1; // 0x10
	private static int _HairPackedMapUV2; // 0x14


	public void Apply(HairDyeCollection collection, MaterialPropertyBlock block) { }

	public void ApplyCap(HairDyeCollection collection, HairType type, MaterialPropertyBlock block) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum HairDye.CopyProperty // TypeDefIndex: 10729
{	public int value__; // 0x0
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

public enum HairDye.CopyPropertyMask // TypeDefIndex: 10730
{	public int value__; // 0x0
	public const HairDye.CopyPropertyMask DyeColor = 1;
	public const HairDye.CopyPropertyMask RootColor = 2;
	public const HairDye.CopyPropertyMask TipColor = 4;
	public const HairDye.CopyPropertyMask Brightness = 8;
	public const HairDye.CopyPropertyMask DyeRoughness = 16;
	public const HairDye.CopyPropertyMask DyeScatter = 32;
	public const HairDye.CopyPropertyMask Specular = 64;
	public const HairDye.CopyPropertyMask Roughness = 128;

}

