internal struct NativeParticleData // TypeDefIndex: 4556
{
	internal int count; 
	internal NativeParticleData.Array3 positions; 
	internal NativeParticleData.Array3 velocities; 
	internal NativeParticleData.Array3 rotations; 
	internal NativeParticleData.Array3 rotationalSpeeds; 
	internal NativeParticleData.Array3 sizes; 
	internal void* startColors; 
	internal void* aliveTimePercent; 
	internal void* inverseStartLifetimes; 
	internal void* randomSeeds; 
	internal NativeParticleData.Array4 customData1; 
	internal NativeParticleData.Array4 customData2; 

}

internal struct NativeParticleData.Array3 // TypeDefIndex: 4557
{
	internal float* x; 
	internal float* y; 
	internal float* z; 

}

internal struct NativeParticleData.Array4 // TypeDefIndex: 4558
{
	internal float* x; 
	internal float* y; 
	internal float* z; 
	internal float* w; 

}

