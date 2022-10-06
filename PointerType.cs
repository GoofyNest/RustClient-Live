public enum PointerType // TypeDefIndex: 4031
{
	public int value__; 
	public const PointerType Mouse = 0;
	public const PointerType Touch = 1;
	public const PointerType Pen = 2;

}

public static class PointerType // TypeDefIndex: 4690
{
	public static readonly string mouse; 
	public static readonly string touch; 
	public static readonly string pen; 
	public static readonly string unknown; 


	internal static string GetPointerType(int pointerId) { }

	internal static bool IsDirectManipulationDevice(string pointerType) { }

	private static void .cctor() { }

}

