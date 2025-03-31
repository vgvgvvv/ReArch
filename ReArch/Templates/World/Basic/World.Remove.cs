

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>(Entity entity)
        where T0 : unmanaged
        where T1 : unmanaged
        where T2 : unmanaged
        where T3 : unmanaged
        where T4 : unmanaged
        where T5 : unmanaged
        where T6 : unmanaged
        where T7 : unmanaged
        where T8 : unmanaged
        where T9 : unmanaged
        where T10 : unmanaged
        where T11 : unmanaged
        where T12 : unmanaged
        where T13 : unmanaged
        where T14 : unmanaged
        where T15 : unmanaged
        where T16 : unmanaged
        where T17 : unmanaged
        where T18 : unmanaged
        where T19 : unmanaged
        where T20 : unmanaged
        where T21 : unmanaged
        where T22 : unmanaged
        where T23 : unmanaged
        where T24 : unmanaged
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    }
