public static class Assert // TypeDefIndex: 3904
{	// Fields
	[ObsoleteAttribute] // RVA: 0x85A10 Offset: 0x84E10 VA: 0x180085A10
	public static bool raiseExceptions; // 0x12690

	// Methods

	// RVA: 0x1818930 Offset: 0x1817D30 VA: 0x181818930
	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818ED0 Offset: 0x18182D0 VA: 0x181818ED0
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818FE0 Offset: 0x18183E0 VA: 0x181818FE0
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818AE0 Offset: 0x1817EE0 VA: 0x181818AE0
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818BE0 Offset: 0x1817FE0 VA: 0x181818BE0
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2E60 Offset: 0x5E2260 VA: 0x1805E2E60
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5E3190 Offset: 0x5E2590 VA: 0x1805E3190
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2DB0 Offset: 0x5E21B0 VA: 0x1805E2DB0
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5E2EE0 Offset: 0x5E22E0 VA: 0x1805E2EE0
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5E3210 Offset: 0x5E2610 VA: 0x1805E3210
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: -1 Offset: -1
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E2B00 Offset: 0x5E1F00 VA: 0x1805E2B00
	|-Assert.AreEqual<int>
	|
	|-RVA: 0x5E2F90 Offset: 0x5E2390 VA: 0x1805E2F90
	|-Assert.AreEqual<object>
	|
	|-RVA: 0x5E32C0 Offset: 0x5E26C0 VA: 0x1805E32C0
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818870 Offset: 0x1817C70 VA: 0x181818870
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E3570 Offset: 0x5E2970 VA: 0x1805E3570
	|-Assert.IsNotNull<Manifest>
	|-Assert.IsNotNull<Dictionary<IPEndPoint, int>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<Type>
	|-Assert.IsNotNull<AnimationCurve>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	|-Assert.IsNotNull<PostProcessResources>
	|-Assert.IsNotNull<Texture>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: -1 Offset: -1
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x5E35E0 Offset: 0x5E29E0 VA: 0x1805E35E0
	|-Assert.IsNotNull<InputState>
	|-Assert.IsNotNull<Client>
	|-Assert.IsNotNull<NetWrite>
	|-Assert.IsNotNull<PlayerInput>
	|-Assert.IsNotNull<List<PostProcessVolume>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818CC0 Offset: 0x18180C0 VA: 0x181818CC0
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818800 Offset: 0x1817C00 VA: 0x181818800
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	// RVA: 0x1818790 Offset: 0x1817B90 VA: 0x181818790
	public static void AreEqual(uint expected, uint actual) { }

	// RVA: 0x18190C0 Offset: 0x18184C0 VA: 0x1818190C0
	private static void .cctor() { }

}

