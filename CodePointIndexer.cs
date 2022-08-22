internal class CodePointIndexer // TypeDefIndex: 29
{	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20


	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	public int ToIndex(int cp) { }

}

internal struct CodePointIndexer.TableRange // TypeDefIndex: 30
{	public readonly int Start; // 0x0
	public readonly int End; // 0x4
	public readonly int Count; // 0x8
	public readonly int IndexStart; // 0xC
	public readonly int IndexEnd; // 0x10


	public void .ctor(int start, int end, int indexStart) { }

}

