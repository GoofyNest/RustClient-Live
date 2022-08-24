internal struct StyleValue // TypeDefIndex: 4726
{
	public StylePropertyID id; 
	public StyleKeyword keyword; 
	public float number; 
	public Length length; 
	public Color color; 
	public GCHandle resource; 


public static StyleValue Create(StylePropertyID id) { }

public static StyleValue Create(StylePropertyID id, StyleKeyword keyword) { }

public static StyleValue Create(StylePropertyID id, float number) { }

public static StyleValue Create(StylePropertyID id, int number) { }

public static StyleValue Create(StylePropertyID id, Color color) { }

}

