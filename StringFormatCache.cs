public static class StringFormatCache // TypeDefIndex: 12537
{
	private static Dictionary<StringFormatCache.Key1, string> dict1;
	private static Dictionary<StringFormatCache.Key2, string> dict2;
	private static Dictionary<StringFormatCache.Key3, string> dict3;
	private static Dictionary<StringFormatCache.Key4, string> dict4;


	public static string Get(string format, string value1) { }

	public static string Get(string format, string value1, string value2) { }

	public static string Get(string format, string value1, string value2, string value3) { }

	public static string Get(string format, string value1, string value2, string value3, string value4) { }

	private static void .cctor() { }

}

private struct StringFormatCache.Key1 : IEquatable<StringFormatCache.Key1> // TypeDefIndex: 12538
{
	public string format;
	public string value1;


	public void .ctor(string format, string value1) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key1 other) { }

}

private struct StringFormatCache.Key2 : IEquatable<StringFormatCache.Key2> // TypeDefIndex: 12539
{
	public string format;
	public string value1;
	public string value2;


	public void .ctor(string format, string value1, string value2) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key2 other) { }

}

private struct StringFormatCache.Key3 : IEquatable<StringFormatCache.Key3> // TypeDefIndex: 12540
{
	public string format;
	public string value1;
	public string value2;
	public string value3;


	public void .ctor(string format, string value1, string value2, string value3) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key3 other) { }

}

private struct StringFormatCache.Key4 : IEquatable<StringFormatCache.Key4> // TypeDefIndex: 12541
{
	public string format;
	public string value1;
	public string value2;
	public string value3;
	public string value4;


	public void .ctor(string format, string value1, string value2, string value3, string value4) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(StringFormatCache.Key4 other) { }

}

