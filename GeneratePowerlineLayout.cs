public class GeneratePowerlineLayout : ProceduralComponent // TypeDefIndex: 10475
{	// Fields
	private const int MaxDepth = 100000;

	// Methods

	// RVA: 0xC94A80 Offset: 0xC93E80 VA: 0x180C94A80 Slot: 5
	public override void Process(uint seed) { }

	// RVA: 0x5954A0 Offset: 0x5948A0 VA: 0x1805954A0
	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathNode // TypeDefIndex: 10476
{	// Fields
	public MonumentInfo monument; // 0x10
	public PathFinder.Node node; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private class GeneratePowerlineLayout.PathSegment // TypeDefIndex: 10477
{	// Fields
	public PathFinder.Node start; // 0x10
	public PathFinder.Node end; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_0 // TypeDefIndex: 10478
{	// Fields
	public GeneratePowerlineLayout.PathSegment segment; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA22D0 Offset: 0xCA16D0 VA: 0x180CA22D0
	internal bool <Process>b__4(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_1 // TypeDefIndex: 10479
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA2920 Offset: 0xCA1D20 VA: 0x180CA2920
	internal bool <Process>b__2(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xCA29A0 Offset: 0xCA1DA0 VA: 0x180CA29A0
	internal bool <Process>b__3(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c__DisplayClass3_2 // TypeDefIndex: 10480
{	// Fields
	public GeneratePowerlineLayout.PathNode copy; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA2A20 Offset: 0xCA1E20 VA: 0x180CA2A20
	internal bool <Process>b__5(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xCA2AA0 Offset: 0xCA1EA0 VA: 0x180CA2AA0
	internal bool <Process>b__6(GeneratePowerlineLayout.PathNode x) { }

}

private sealed class GeneratePowerlineLayout.<>c // TypeDefIndex: 10481
{	// Fields
	public static readonly GeneratePowerlineLayout.<>c <>9; // 0x0
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_0; // 0x8
	public static Func<GeneratePowerlineLayout.PathNode, PathFinder.Point> <>9__3_1; // 0x10

	// Methods

	// RVA: 0xCA2E90 Offset: 0xCA2290 VA: 0x180CA2E90
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xCA1A50 Offset: 0xCA0E50 VA: 0x180CA1A50
	internal PathFinder.Point <Process>b__3_0(GeneratePowerlineLayout.PathNode x) { }

	// RVA: 0xCA1A50 Offset: 0xCA0E50 VA: 0x180CA1A50
	internal PathFinder.Point <Process>b__3_1(GeneratePowerlineLayout.PathNode x) { }

}

