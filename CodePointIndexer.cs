internal class CodePointIndexer // TypeDefIndex: 29
{
	private readonly CodePointIndexer.TableRange[] ranges; 
	public readonly int TotalCount; 
	private int defaultIndex; 
	private int defaultCP; 


public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

public int ToIndex(int cp) { }

}

internal struct CodePointIndexer.TableRange // TypeDefIndex: 30
{
	public readonly int Start; 
	public readonly int End; 
	public readonly int Count; 
	public readonly int IndexStart; 
	public readonly int IndexEnd; 


public void .ctor(int start, int end, int indexStart) { }

}

