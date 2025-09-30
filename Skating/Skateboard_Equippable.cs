using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Skating
{
	// Token: 0x020002E0 RID: 736
	[Token(Token = "0x20002E0")]
	public class Skateboard_Equippable : Equippable_Viewmodel
	{
		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00007998 File Offset: 0x00005B98
		// (set) Token: 0x06000FFD RID: 4093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034E")]
		public bool IsRiding
		{
			[Token(Token = "0x6000FFC")]
			[Address(RVA = "0x850260", Offset = "0x84EC60", VA = "0x180850260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000FFD")]
			[Address(RVA = "0x850310", Offset = "0x84ED10", VA = "0x180850310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000FFE RID: 4094 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FFF RID: 4095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034F")]
		public Skateboard ActiveSkateboard
		{
			[Token(Token = "0x6000FFE")]
			[Address(RVA = "0x4573C0", Offset = "0x455DC0", VA = "0x1804573C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000FFF")]
			[Address(RVA = "0x6009E0", Offset = "0x5FF3E0", VA = "0x1806009E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001000")]
		[Address(RVA = "0xAE8490", Offset = "0xAE6E90", VA = "0x180AE8490", Slot = "4")]
		public override void Equip(ItemInstance item)
		{
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001001")]
		[Address(RVA = "0xAE85B0", Offset = "0xAE6FB0", VA = "0x180AE85B0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001002")]
		[Address(RVA = "0xAE95A0", Offset = "0xAE7FA0", VA = "0x180AE95A0", Slot = "6")]
		protected override void Update()
		{
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001003")]
		[Address(RVA = "0xAE9480", Offset = "0xAE7E80", VA = "0x180AE9480")]
		private void UpdateModel()
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001004")]
		[Address(RVA = "0xAE9370", Offset = "0xAE7D70", VA = "0x180AE9370", Slot = "5")]
		public override void Unequip()
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001005")]
		[Address(RVA = "0xAE9070", Offset = "0xAE7A70", VA = "0x180AE9070")]
		public void Mount()
		{
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001006")]
		[Address(RVA = "0xAE8060", Offset = "0xAE6A60", VA = "0x180AE8060")]
		public void Dismount()
		{
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x6001007")]
		[Address(RVA = "0xAE7F70", Offset = "0xAE6970", VA = "0x180AE7F70")]
		private bool CanMountHere()
		{
			return default(bool);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x6001008")]
		[Address(RVA = "0xAE8600", Offset = "0xAE7000", VA = "0x180AE8600")]
		private Pose GetSkateboardSpawnPose()
		{
			return default(Pose);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x850250", Offset = "0x84EC50", VA = "0x180850250")]
		public Skateboard_Equippable()
		{
		}

		// Token: 0x04001043 RID: 4163
		[Token(Token = "0x4001043")]
		public const float ModelLerpSpeed = 8f;

		// Token: 0x04001044 RID: 4164
		[Token(Token = "0x4001044")]
		public const float SurfaceSampleDistance = 0.4f;

		// Token: 0x04001045 RID: 4165
		[Token(Token = "0x4001045")]
		public const float SurfaceSampleRayLength = 0.7f;

		// Token: 0x04001046 RID: 4166
		[Token(Token = "0x4001046")]
		public const float BoardSpawnUpwardsShift = 0.05f;

		// Token: 0x04001047 RID: 4167
		[Token(Token = "0x4001047")]
		public const float BoardSpawnAngleLimit = 30f;

		// Token: 0x04001048 RID: 4168
		[Token(Token = "0x4001048")]
		public const float MountTime = 0.33f;

		// Token: 0x04001049 RID: 4169
		[Token(Token = "0x4001049")]
		public const float BoardMomentumTransfer = 1.2f;

		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		public const float DismountAngle = 80f;

		// Token: 0x0400104D RID: 4173
		[Token(Token = "0x400104D")]
		[FieldOffset(Offset = "0x78")]
		public Skateboard SkateboardPrefab;

		// Token: 0x0400104E RID: 4174
		[Token(Token = "0x400104E")]
		[FieldOffset(Offset = "0x80")]
		public bool blockDismount;

		// Token: 0x0400104F RID: 4175
		[Token(Token = "0x400104F")]
		[FieldOffset(Offset = "0x88")]
		[Header("References")]
		public Transform ModelContainer;

		// Token: 0x04001050 RID: 4176
		[Token(Token = "0x4001050")]
		[FieldOffset(Offset = "0x90")]
		public Transform ModelPosition_Raised;

		// Token: 0x04001051 RID: 4177
		[Token(Token = "0x4001051")]
		[FieldOffset(Offset = "0x98")]
		public Transform ModelPosition_Lowered;

		// Token: 0x04001052 RID: 4178
		[Token(Token = "0x4001052")]
		[FieldOffset(Offset = "0xA0")]
		private float mountTime;
	}
}
