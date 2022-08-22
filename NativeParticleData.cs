internal struct NativeParticleData // TypeDefIndex: 4551
{	internal int count; // 0x0
	internal NativeParticleData.Array3 positions; // 0x8
	internal NativeParticleData.Array3 velocities; // 0x20
	internal NativeParticleData.Array3 rotations; // 0x38
	internal NativeParticleData.Array3 rotationalSpeeds; // 0x50
	internal NativeParticleData.Array3 sizes; // 0x68
	internal void* startColors; // 0x80
	internal void* aliveTimePercent; // 0x88
	internal void* inverseStartLifetimes; // 0x90
	internal void* randomSeeds; // 0x98
	internal NativeParticleData.Array4 customData1; // 0xA0
	internal NativeParticleData.Array4 customData2; // 0xC0

}

internal struct NativeParticleData.Array3 // TypeDefIndex: 4552
{	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10

}

internal struct NativeParticleData.Array4 // TypeDefIndex: 4553
{	internal float* x; // 0x0
	internal float* y; // 0x8
	internal float* z; // 0x10
	internal float* w; // 0x18

}

