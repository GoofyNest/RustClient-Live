public static class QuaternionEx // TypeDefIndex: 11701
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DCD40 Offset: 0x9DC140 VA: 0x1809DCD40
	public static Quaternion AlignToNormal(Quaternion rot, Vector3 normal) { }

	// RVA: 0x9DD600 Offset: 0x9DCA00 VA: 0x1809DD600
	public static Quaternion LookRotationWithOffset(Vector3 offset, Vector3 forward, Vector3 up) { }

	// RVA: 0x9DCF10 Offset: 0x9DC310 VA: 0x1809DCF10
	public static Quaternion LookRotationForcedUp(Vector3 forward, Vector3 up) { }

	// RVA: 0x9DD0E0 Offset: 0x9DC4E0 VA: 0x1809DD0E0
	public static Quaternion LookRotationGradient(Vector3 normal, Vector3 up) { }

	// RVA: 0x9DD2A0 Offset: 0x9DC6A0 VA: 0x1809DD2A0
	public static Quaternion LookRotationNormal(Vector3 normal, Vector3 up) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9DCE50 Offset: 0x9DC250 VA: 0x1809DCE50
	public static Quaternion EnsureValid(Quaternion rot, float epsilon = 1,401298E-45) { }

}

