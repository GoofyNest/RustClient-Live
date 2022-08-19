internal class CodePointIndexer // TypeDefIndex: 29
{	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x16373B0 Offset: 0x16367B0 VA: 0x1816373B0
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x1637330 Offset: 0x1636730 VA: 0x181637330
	public int ToIndex(int cp) { }

}

internal struct CodePointIndexer.TableRange // TypeDefIndex: 30
{	// Fields
	public readonly int Start; // 0x0
	public readonly int End; // 0x4
	public readonly int Count; // 0x8
	public readonly int IndexStart; // 0xC
	public readonly int IndexEnd; // 0x10

	// Methods

	// RVA: 0x1F6AD0 Offset: 0x1F5ED0 VA: 0x1801F6AD0
	public void .ctor(int start, int end, int indexStart) { }

}

