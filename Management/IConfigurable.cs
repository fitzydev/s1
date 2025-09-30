using System;
using FishNet.Connection;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Property;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.Management
{
	// Token: 0x020004EC RID: 1260
	[Token(Token = "0x20004EC")]
	public interface IConfigurable
	{
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600198B RID: 6539
		[Token(Token = "0x17000476")]
		EntityConfiguration Configuration
		{
			[Token(Token = "0x600198B")]
			get;
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600198C RID: 6540
		[Token(Token = "0x17000477")]
		ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x600198C")]
			get;
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600198D RID: 6541
		[Token(Token = "0x17000478")]
		EConfigurableType ConfigurableType
		{
			[Token(Token = "0x600198D")]
			get;
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600198E RID: 6542
		// (set) Token: 0x0600198F RID: 6543
		[Token(Token = "0x17000479")]
		WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x600198E")]
			get;
			[Token(Token = "0x600198F")]
			set;
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001990 RID: 6544
		// (set) Token: 0x06001991 RID: 6545
		[Token(Token = "0x1700047A")]
		NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6001990")]
			get;
			[Token(Token = "0x6001991")]
			set;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x1700047B")]
		bool IsBeingConfiguredByOtherPlayer
		{
			[Token(Token = "0x6001992")]
			[Address(RVA = "0x635420", Offset = "0x633E20", VA = "0x180635420", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x06001993 RID: 6547
		[Token(Token = "0x1700047C")]
		Sprite TypeIcon
		{
			[Token(Token = "0x6001993")]
			get;
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x06001994 RID: 6548
		[Token(Token = "0x1700047D")]
		Transform Transform
		{
			[Token(Token = "0x6001994")]
			get;
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06001995 RID: 6549
		[Token(Token = "0x1700047E")]
		Transform UIPoint
		{
			[Token(Token = "0x6001995")]
			get;
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x1700047F")]
		bool IsDestroyed
		{
			[Token(Token = "0x6001996")]
			[Address(RVA = "0x6354E0", Offset = "0x633EE0", VA = "0x1806354E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06001997 RID: 6551
		[Token(Token = "0x17000480")]
		bool CanBeSelected
		{
			[Token(Token = "0x6001997")]
			get;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001998 RID: 6552
		[Token(Token = "0x17000481")]
		Property ParentProperty
		{
			[Token(Token = "0x6001998")]
			get;
		}

		// Token: 0x06001999 RID: 6553
		[Token(Token = "0x6001999")]
		WorldspaceUIElement CreateWorldspaceUI();

		// Token: 0x0600199A RID: 6554
		[Token(Token = "0x600199A")]
		void DestroyWorldspaceUI();

		// Token: 0x0600199B RID: 6555
		[Token(Token = "0x600199B")]
		void ShowOutline(Color color);

		// Token: 0x0600199C RID: 6556
		[Token(Token = "0x600199C")]
		void HideOutline();

		// Token: 0x0600199D RID: 6557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x6353C0", Offset = "0x633DC0", VA = "0x1806353C0", Slot = "18")]
		void Selected()
		{
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x635360", Offset = "0x633D60", VA = "0x180635360", Slot = "19")]
		void Deselected()
		{
		}

		// Token: 0x0600199F RID: 6559
		[Token(Token = "0x600199F")]
		void SetConfigurer(NetworkObject player);

		// Token: 0x060019A0 RID: 6560
		[Token(Token = "0x60019A0")]
		void SendConfigurationToClient(NetworkConnection conn);
	}
}
