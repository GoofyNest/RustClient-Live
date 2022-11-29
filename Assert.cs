public static class Assert // TypeDefIndex: 3909
{
	[ObsoleteAttribute] 
	public static bool raiseExceptions; 


	private static void Fail(string message, string userMessage) { }

	[ConditionalAttribute] 
	public static void IsTrue(bool condition) { }

	[ConditionalAttribute] 
	public static void IsTrue(bool condition, string message) { }

	[ConditionalAttribute] 
	public static void IsFalse(bool condition) { }

	[ConditionalAttribute] 
	public static void IsFalse(bool condition, string message) { }

	[ConditionalAttribute] 
	public static void AreEqual<T>(T expected, T actual) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<RendererGrid>
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] 
	public static void AreEqual<T>(T expected, T actual, string message) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<int>
	|
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] 
	public static void AreEqual<T>(T expected, T actual, string message, IEqualityComparer<T> comparer) { }
	/* GenericInstMethod :
	|
	|-Assert.AreEqual<int>
	|
	|-Assert.AreEqual<object>
	|
	|-Assert.AreEqual<uint>
	*/

	[ConditionalAttribute] 
	public static void AreEqual(Object expected, Object actual, string message) { }

	[ConditionalAttribute] 
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

	[ConditionalAttribute] 
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

	[ConditionalAttribute] 
	public static void IsNotNull(Object value, string message) { }

	[ConditionalAttribute] 
	public static void AreEqual(int expected, int actual) { }

	[ConditionalAttribute] 
	public static void AreEqual(uint expected, uint actual) { }

	private static void .cctor() { }

}

