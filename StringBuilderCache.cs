internal static class StringBuilderCache // TypeDefIndex: 464
{
	[ThreadStaticAttribute] 
	private static StringBuilder CachedInstance; 


public static StringBuilder Acquire(int capacity = 16) { }

public static void Release(StringBuilder sb) { }

public static string GetStringAndRelease(StringBuilder sb) { }

}

