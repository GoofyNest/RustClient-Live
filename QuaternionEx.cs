public static class QuaternionEx // TypeDefIndex: 11701
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Quaternion AlignToNormal(Quaternion rot, Vector3 normal) { }

	public static Quaternion LookRotationWithOffset(Vector3 offset, Vector3 forward, Vector3 up) { }

	public static Quaternion LookRotationForcedUp(Vector3 forward, Vector3 up) { }

	public static Quaternion LookRotationGradient(Vector3 normal, Vector3 up) { }

	public static Quaternion LookRotationNormal(Vector3 normal, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Quaternion EnsureValid(Quaternion rot, float epsilon = 1,401298E-45) { }

}

