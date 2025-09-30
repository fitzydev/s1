using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace ScheduleOne.NPCs
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	public class NPCPathCache
	{
		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000698")]
		public List<NPCPathCache.PathCache> Paths
		{
			[Token(Token = "0x60029BE")]
			[Address(RVA = "0x42FFD0", Offset = "0x42E9D0", VA = "0x18042FFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60029BF")]
			[Address(RVA = "0x4A4990", Offset = "0x4A3390", VA = "0x1804A4990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C0")]
		[Address(RVA = "0x724A90", Offset = "0x723490", VA = "0x180724A90")]
		public NavMeshPath GetPath(Vector3 start, Vector3 end, float sqrMaxDistance)
		{
			return null;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C1")]
		[Address(RVA = "0x724970", Offset = "0x723370", VA = "0x180724970")]
		public void AddPath(Vector3 start, Vector3 end, NavMeshPath path)
		{
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C2")]
		[Address(RVA = "0x724C70", Offset = "0x723670", VA = "0x180724C70")]
		public NPCPathCache()
		{
		}

		// Token: 0x02000670 RID: 1648
		[Token(Token = "0x2000670")]
		[Serializable]
		public class PathCache
		{
			// Token: 0x060029C3 RID: 10691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60029C3")]
			[Address(RVA = "0x72B380", Offset = "0x729D80", VA = "0x18072B380")]
			public PathCache(Vector3 start, Vector3 end, NavMeshPath path)
			{
			}

			// Token: 0x04001F4F RID: 8015
			[Token(Token = "0x4001F4F")]
			[FieldOffset(Offset = "0x10")]
			public Vector3 Start;

			// Token: 0x04001F50 RID: 8016
			[Token(Token = "0x4001F50")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 End;

			// Token: 0x04001F51 RID: 8017
			[Token(Token = "0x4001F51")]
			[FieldOffset(Offset = "0x28")]
			public NavMeshPath Path;
		}
	}
}
