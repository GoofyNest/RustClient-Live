public static class Assert // TypeDefIndex: 3904
{	[ObsoleteAttribute] // RVA: 0x85A10 Offset: 0x84E10 VA: 0x180085A10
	public static bool raiseExceptions; // 0x12690


	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<int>
	|
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<int>
	|
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsNotNull<T>(T value) { }
	/* GenericInstMethod :
	|
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
	public static void IsNotNull<T>(T value, string message) { }
	/* GenericInstMethod :
	|
	|-Assert.IsNotNull<InputState>
	|-Assert.IsNotNull<Client>
	|-Assert.IsNotNull<NetWrite>
	|-Assert.IsNotNull<PlayerInput>
	|-Assert.IsNotNull<List<PostProcessVolume>>
	|-Assert.IsNotNull<object>
	|-Assert.IsNotNull<PostProcessEffectSettings>
	*/

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] // RVA: 0x7CBD0 Offset: 0x7BFD0 VA: 0x18007CBD0
	public static void AreEqual(uint expected, uint actual) { }

	private static void .cctor() { }

}

