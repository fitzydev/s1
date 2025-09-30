using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Properties;
using UnityEngine;

namespace ScheduleOne.Product
{
	// Token: 0x020009AC RID: 2476
	[Token(Token = "0x20009AC")]
	[CreateAssetMenu(fileName = "PropertyItemDefinition", menuName = "ScriptableObjects/PropertyItemDefinition", order = 1)]
	[Serializable]
	public class PropertyItemDefinition : StorableItemDefinition
	{
		// Token: 0x060043ED RID: 17389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x8A7EA0", Offset = "0x8A68A0", VA = "0x1808A7EA0", Slot = "5")]
		public virtual void Initialize(List<Property> properties)
		{
		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00011D30 File Offset: 0x0000FF30
		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x8A7E40", Offset = "0x8A6840", VA = "0x1808A7E40")]
		public bool HasProperty(Property property)
		{
			return default(bool);
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x8A7F00", Offset = "0x8A6900", VA = "0x1808A7F00")]
		public PropertyItemDefinition()
		{
		}

		// Token: 0x04002F75 RID: 12149
		[Token(Token = "0x4002F75")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Properties")]
		public List<Property> Properties;
	}
}
