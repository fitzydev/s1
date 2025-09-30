using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.Doors;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CFB RID: 3323
	[Token(Token = "0x2000CFB")]
	[DisallowMultipleComponent]
	public class NPCEnterableBuilding : MonoBehaviour, IGUIDRegisterable
	{
		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06005E00 RID: 24064 RVA: 0x00016980 File Offset: 0x00014B80
		// (set) Token: 0x06005E01 RID: 24065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D15")]
		public Guid GUID
		{
			[Token(Token = "0x6005E00")]
			[Address(RVA = "0x4A3B70", Offset = "0x4A2570", VA = "0x1804A3B70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Token(Token = "0x6005E01")]
			[Address(RVA = "0x4A3B80", Offset = "0x4A2580", VA = "0x1804A3B80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06005E02 RID: 24066 RVA: 0x00016998 File Offset: 0x00014B98
		[Token(Token = "0x17000D16")]
		public int OccupantCount
		{
			[Token(Token = "0x6005E02")]
			[Address(RVA = "0xA612B0", Offset = "0xA5FCB0", VA = "0x180A612B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E03")]
		[Address(RVA = "0xA604C0", Offset = "0xA5EEC0", VA = "0x180A604C0", Slot = "7")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E04")]
		[Address(RVA = "0xA611A0", Offset = "0xA5FBA0", VA = "0x180A611A0", Slot = "6")]
		public void SetGUID(Guid guid)
		{
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E05")]
		[Address(RVA = "0xA60A70", Offset = "0xA5F470", VA = "0x180A60A70", Slot = "8")]
		public virtual void NPCEnteredBuilding(NPC npc)
		{
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E06")]
		[Address(RVA = "0xA60E60", Offset = "0xA5F860", VA = "0x180A60E60", Slot = "9")]
		public virtual void NPCExitedBuilding(NPC npc)
		{
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E07")]
		[Address(RVA = "0xA608F0", Offset = "0xA5F2F0", VA = "0x180A608F0")]
		[Button]
		public void GetDoors()
		{
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0xA60940", Offset = "0xA5F340", VA = "0x180A60940")]
		public List<NPC> GetSummonableNPCs()
		{
			return null;
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0xA60790", Offset = "0xA5F190", VA = "0x180A60790")]
		public StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			return null;
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0xA61200", Offset = "0xA5FC00", VA = "0x180A61200")]
		public NPCEnterableBuilding()
		{
		}

		// Token: 0x04004455 RID: 17493
		[Token(Token = "0x4004455")]
		public const float DOOR_SOUND_DISTANCE_LIMIT = 15f;

		// Token: 0x04004457 RID: 17495
		[Token(Token = "0x4004457")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public string BuildingName;

		// Token: 0x04004458 RID: 17496
		[Token(Token = "0x4004458")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected string BakedGUID;

		// Token: 0x04004459 RID: 17497
		[Token(Token = "0x4004459")]
		[FieldOffset(Offset = "0x40")]
		[Header("References")]
		public StaticDoor[] Doors;

		// Token: 0x0400445A RID: 17498
		[Token(Token = "0x400445A")]
		[FieldOffset(Offset = "0x48")]
		[Header("Readonly")]
		[SerializeField]
		private List<NPC> Occupants;
	}
}
