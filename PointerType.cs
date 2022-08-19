public enum PointerType // TypeDefIndex: 4028
{	// Fields
	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;

}

public static class PointerType // TypeDefIndex: 4687
{	// Fields
	public static readonly string mouse; // 0x0
	public static readonly string touch; // 0x8
	public static readonly string pen; // 0x10
	public static readonly string unknown; // 0x18

	// Methods

	// RVA: 0xECC790 Offset: 0xECBB90 VA: 0x180ECC790
	internal static string GetPointerType(int pointerId) { }

	// RVA: 0xECC860 Offset: 0xECBC60 VA: 0x180ECC860
	internal static bool IsDirectManipulationDevice(string pointerType) { }

	// RVA: 0xECC8C0 Offset: 0xECBCC0 VA: 0x180ECC8C0
	private static void .cctor() { }

}

