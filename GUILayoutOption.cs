public sealed class GUILayoutOption // TypeDefIndex: 4039
{
	internal GUILayoutOption.Type type; 
	internal object value; 


internal void .ctor(GUILayoutOption.Type type, object value) { }

}

internal enum GUILayoutOption.Type // TypeDefIndex: 4040
{
	public int value__; 
public const GUILayoutOption.Type fixedWidth = 0;
public const GUILayoutOption.Type fixedHeight = 1;
public const GUILayoutOption.Type minWidth = 2;
public const GUILayoutOption.Type maxWidth = 3;
public const GUILayoutOption.Type minHeight = 4;
public const GUILayoutOption.Type maxHeight = 5;
public const GUILayoutOption.Type stretchWidth = 6;
public const GUILayoutOption.Type stretchHeight = 7;
public const GUILayoutOption.Type alignStart = 8;
public const GUILayoutOption.Type alignMiddle = 9;
public const GUILayoutOption.Type alignEnd = 10;
public const GUILayoutOption.Type alignJustify = 11;
public const GUILayoutOption.Type equalSize = 12;
public const GUILayoutOption.Type spacing = 13;

}

