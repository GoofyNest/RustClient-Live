internal sealed class InflateCodes // TypeDefIndex: 6949
{	// Fields
	internal int mode; // 0x10
	internal int len; // 0x14
	internal int[] tree; // 0x18
	internal int tree_index; // 0x20
	internal int need; // 0x24
	internal int lit; // 0x28
	internal int bitsToGet; // 0x2C
	internal int dist; // 0x30
	internal byte lbits; // 0x34
	internal byte dbits; // 0x35
	internal int[] ltree; // 0x38
	internal int ltree_index; // 0x40
	internal int[] dtree; // 0x48
	internal int dtree_index; // 0x50

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	internal void .ctor() { }

	// RVA: 0x21CDD70 Offset: 0x21CD170 VA: 0x1821CDD70
	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index) { }

	// RVA: 0x21CDDD0 Offset: 0x21CD1D0 VA: 0x1821CDDD0
	internal int Process(InflateBlocks blocks, int r) { }

	// RVA: 0x21CD1A0 Offset: 0x21CC5A0 VA: 0x1821CD1A0
	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z) { }

}

