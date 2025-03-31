

using System;
using System.Runtime.CompilerServices;
using ReArch.Core.Utils;

namespace ReArch.Core;
public partial class World
{
    

	[SkipLocalsInit]
	[StructuralChange]
	public void Remove<T0, T1>(Entity entity)
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
	{
		var oldArchetype = EntityInfo.GetArchetype(entity.Id);
		var signature = Component<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>.Signature;
		var newSignature = Signature.Remove(oldArchetype.Signature, signature);
		var newArchetype = GetOrCreateArchetype(newSignature);
		
		Move(entity, oldArchetype, newArchetype, out _);
	}

   
    }
