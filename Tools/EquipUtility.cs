using System;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.AvatarFramework.Equipping;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x020008FA RID: 2298
	[Token(Token = "0x20008FA")]
	public class EquipUtility : MonoBehaviour
	{
		// Token: 0x06003F80 RID: 16256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F80")]
		[Address(RVA = "0x860120", Offset = "0x85EB20", VA = "0x180860120")]
		public void Update()
		{
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F81")]
		[Address(RVA = "0x860030", Offset = "0x85EA30", VA = "0x180860030")]
		[Button]
		public void Equip()
		{
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F82")]
		[Address(RVA = "0x8600A0", Offset = "0x85EAA0", VA = "0x1808600A0")]
		[Button]
		public void Unequip()
		{
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F83")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public EquipUtility()
		{
		}

		// Token: 0x04002C83 RID: 11395
		[Token(Token = "0x4002C83")]
		[FieldOffset(Offset = "0x20")]
		public AvatarEquippable Equippable;
	}
}
