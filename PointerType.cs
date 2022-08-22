public enum PointerType // TypeDefIndex: 4028
{	public int value__; // 0x0
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;

}

public static class PointerType // TypeDefIndex: 4687
{	public static readonly string mouse; // 0x0
	public static readonly string touch; // 0x8
	public static readonly string pen; // 0x10
	public static readonly string unknown; // 0x18


	internal static string GetPointerType(int pointerId) { }

	internal static bool IsDirectManipulationDevice(string pointerType) { }

	private static void .cctor() { }

}

