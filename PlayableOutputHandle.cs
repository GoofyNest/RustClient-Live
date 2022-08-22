public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 3872
{	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	public static PlayableOutputHandle Null { get; }


	public static PlayableOutputHandle get_Null() { }

	public override int GetHashCode() { }

	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableOutputHandle other) { }

	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	private static void .cctor() { }

}

