public class GenerateRailLayout : ProceduralComponent // TypeDefIndex: 10485
{	// Fields
	public const float Width = 4;
	public const float InnerPadding = 1;
	public const float OuterPadding = 1;
	public const float InnerFade = 1;
	public const float OuterFade = 32;
	public const float RandomScale = 1;
	public const float MeshOffset = 0;
	public const float TerrainOffset = -0,125;
	private static Quaternion rot90; // 0x23F7
	private const int MaxDepth = 250000;

	// Methods

	// RVA: 0xC97C90 Offset: 0xC97090 VA: 0x180C97C90
	private PathList CreateSegment(int number, Vector3[] points) { }

	// RVA: 0xC97D80 Offset: 0xC97180 VA: 0x180C97D80 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

	// RVA: 0xC99900 Offset: 0xC98D00 VA: 0x180C99900
	private static void .cctor() { }

}

private class GenerateRailLayout.PathNode // TypeDefIndex: 10486
{	// Fields
	public MonumentInfo monument; // 0x10
	public TerrainPathConnect target; // 0x18
	public PathFinder.Node node; // 0x20

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GenerateRailLayout.PathSegment // TypeDefIndex: 10487
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18
	public TerrainPathConnect origin; // 0x20
	public TerrainPathConnect target; // 0x28

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class GenerateRailLayout.<>c__DisplayClass13_0 // TypeDefIndex: 10488
{	// Fields
	public PathList rail; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC86B60 Offset: 0xC85F60 VA: 0x180C86B60
	internal float <Process>b__0(int i) { }

}

