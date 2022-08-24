public class TextBuffer // TypeDefIndex: 6595
{
	private Queue<string> buffer; 
	private StringBuilder builder; 
	private string text; 
	private bool dirty; 
	private int curlines; 
	private int maxlines; 
	private int curchars; 
	private int maxchars; 

public int Count { get; }


public int get_Count() { }

public void .ctor(int maxlines, int maxchars = 2147483647) { }

public void Add(string text) { }

public void Remove() { }

public void Clear() { }

public string Get(int index) { }

public override string ToString() { }

}

