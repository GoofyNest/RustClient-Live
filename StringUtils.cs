internal static class StringUtils // TypeDefIndex: 5969
{

	[ExtensionAttribute] 
public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[ExtensionAttribute] 
public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[ExtensionAttribute] 
public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[ExtensionAttribute] 
public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[ExtensionAttribute] 
private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

public static StringWriter CreateStringWriter(int capacity) { }

public static Nullable<int> GetLength(string value) { }

public static void ToCharAsUnicode(char c, char[] buffer) { }

	[ExtensionAttribute] 
public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
/* GenericInstMethod :
|
|-StringUtils.ForgivingCaseSensitiveFind<JsonProperty>
|-StringUtils.ForgivingCaseSensitiveFind<object>
*/

public static string ToCamelCase(string s) { }

public static bool IsHighSurrogate(char c) { }

public static bool IsLowSurrogate(char c) { }

	[ExtensionAttribute] 
public static bool StartsWith(string source, char value) { }

	[ExtensionAttribute] 
public static bool EndsWith(string source, char value) { }

}

private sealed class StringUtils.<>c__DisplayClass15_0<TSource> // TypeDefIndex: 5970
{
	public Func<TSource, string> valueSelector; 
	public string testValue; 


public void .ctor() { }
/* GenericInstMethod :
|
|-StringUtils.<>c__DisplayClass15_0<object>..ctor
*/

internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
/* GenericInstMethod :
|
|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__0
*/

internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
/* GenericInstMethod :
|
|-StringUtils.<>c__DisplayClass15_0<object>.<ForgivingCaseSensitiveFind>b__1
*/

}

