public struct OSPlatform : IEquatable<OSPlatform> // TypeDefIndex: 1319
{
	private readonly string _osPlatform; 
	[CompilerGeneratedAttribute] 
	private static readonly OSPlatform <Linux>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static readonly OSPlatform <OSX>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private static readonly OSPlatform <Windows>k__BackingField; 

	public static OSPlatform Linux { get; }
	public static OSPlatform OSX { get; }
	public static OSPlatform Windows { get; }


	[CompilerGeneratedAttribute] 
	public static OSPlatform get_Linux() { }

	[CompilerGeneratedAttribute] 
	public static OSPlatform get_OSX() { }

	[CompilerGeneratedAttribute] 
	public static OSPlatform get_Windows() { }

	private void .ctor(string osPlatform) { }

	public bool Equals(OSPlatform other) { }

	internal bool Equals(string other) { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	public static bool op_Equality(OSPlatform left, OSPlatform right) { }

	private static void .cctor() { }

}

