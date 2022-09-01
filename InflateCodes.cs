internal sealed class InflateCodes // TypeDefIndex: 6950
{
	internal int mode; 
	internal int len; 
	internal int[] tree; 
	internal int tree_index; 
	internal int need; 
	internal int lit; 
	internal int bitsToGet; 
	internal int dist; 
	internal byte lbits; 
	internal byte dbits; 
	internal int[] ltree; 
	internal int ltree_index; 
	internal int[] dtree; 
	internal int dtree_index; 


	internal void .ctor() { }

	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index) { }

	internal int Process(InflateBlocks blocks, int r) { }

	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z) { }

}

