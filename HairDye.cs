public class HairDye // TypeDefIndex: 10728
{	// Fields
	[ColorUsageAttribute] // RVA: 0x76690 Offset: 0x75A90 VA: 0x180076690
	public Color capBaseColor; // 0x10
	public Material sourceMaterial; // 0x20
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public HairDye.CopyPropertyMask copyProperties; // 0x28
	private static MaterialPropertyDesc[] transferableProps; // 0x0
	private static int _HairBaseColorUV1; // 0x8
	private static int _HairBaseColorUV2; // 0xC
	private static int _HairPackedMapUV1; // 0x10
	private static int _HairPackedMapUV2; // 0x14

	// Methods

	// RVA: 0x74DBB0 Offset: 0x74CFB0 VA: 0x18074DBB0
	public void Apply(HairDyeCollection collection, MaterialPropertyBlock block) { }

	// RVA: 0x74D9E0 Offset: 0x74CDE0 VA: 0x18074D9E0
	public void ApplyCap(HairDyeCollection collection, HairType type, MaterialPropertyBlock block) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x74DDD0 Offset: 0x74D1D0 VA: 0x18074DDD0
	private static void .cctor() { }

}

public enum HairDye.CopyProperty // TypeDefIndex: 10729
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	public int value__; // 0x0
	public const HairDye.CopyPropertyMask DyeColor = 1;
	public const HairDye.CopyPropertyMask RootColor = 2;
	public const HairDye.CopyPropertyMask TipColor = 4;
	public const HairDye.CopyPropertyMask Brightness = 8;
	public const HairDye.CopyPropertyMask DyeRoughness = 16;
	public const HairDye.CopyPropertyMask DyeScatter = 32;
	public const HairDye.CopyPropertyMask Specular = 64;
	public const HairDye.CopyPropertyMask Roughness = 128;

}

