using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using UnityEngine;
using UnityEngine.InputSystem;

namespace ScheduleOne.Interaction
{
	// Token: 0x0200057F RID: 1407
	[Token(Token = "0x200057F")]
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001F88 RID: 8072 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x1700056F")]
		public LayerMask Interaction_SearchMask
		{
			[Token(Token = "0x6001F88")]
			[Address(RVA = "0x47D760", Offset = "0x47C160", VA = "0x18047D760")]
			get
			{
				return default(LayerMask);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0000A500 File Offset: 0x00008700
		// (set) Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000570")]
		public bool CanDestroy
		{
			[Token(Token = "0x6001F89")]
			[Address(RVA = "0x675BF0", Offset = "0x6745F0", VA = "0x180675BF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001F8A")]
			[Address(RVA = "0x675780", Offset = "0x674180", VA = "0x180675780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001F8B RID: 8075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F8C RID: 8076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000571")]
		public InteractableObject HoveredInteractableObject
		{
			[Token(Token = "0x6001F8B")]
			[Address(RVA = "0x4423B0", Offset = "0x440DB0", VA = "0x1804423B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F8C")]
			[Address(RVA = "0x4423E0", Offset = "0x440DE0", VA = "0x1804423E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001F8D RID: 8077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F8E RID: 8078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000572")]
		public InteractableObject HoveredValidInteractableObject
		{
			[Token(Token = "0x6001F8D")]
			[Address(RVA = "0x47D770", Offset = "0x47C170", VA = "0x18047D770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F8E")]
			[Address(RVA = "0x4F8890", Offset = "0x4F7290", VA = "0x1804F8890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06001F8F RID: 8079 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F90 RID: 8080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000573")]
		public InteractableObject InteractedObject
		{
			[Token(Token = "0x6001F8F")]
			[Address(RVA = "0x47D5A0", Offset = "0x47BFA0", VA = "0x18047D5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F90")]
			[Address(RVA = "0x5CDA00", Offset = "0x5CC400", VA = "0x1805CDA00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06001F91 RID: 8081 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001F92 RID: 8082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000574")]
		public string InteractKeyStr
		{
			[Token(Token = "0x6001F91")]
			[Address(RVA = "0x432BA0", Offset = "0x4315A0", VA = "0x180432BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001F92")]
			[Address(RVA = "0x4BEDD0", Offset = "0x4BD7D0", VA = "0x1804BEDD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x675790", Offset = "0x674190", VA = "0x180675790", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x6755F0", Offset = "0x673FF0", VA = "0x1806755F0", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x675510", Offset = "0x673F10", VA = "0x180675510")]
		private void LoadInteractKey()
		{
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x675AB0", Offset = "0x6744B0", VA = "0x180675AB0", Slot = "7")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x675430", Offset = "0x673E30", VA = "0x180675430", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x673BA0", Offset = "0x6725A0", VA = "0x180673BA0", Slot = "9")]
		protected virtual void CheckHover()
		{
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F99")]
		[Address(RVA = "0x674B30", Offset = "0x673530", VA = "0x180674B30", Slot = "10")]
		protected virtual void CheckInteraction()
		{
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9A")]
		[Address(RVA = "0x674E80", Offset = "0x673880", VA = "0x180674E80", Slot = "11")]
		protected virtual void CheckRightClick()
		{
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F9B")]
		[Address(RVA = "0x6752E0", Offset = "0x673CE0", VA = "0x1806752E0", Slot = "12")]
		protected virtual BuildableItem GetHoveredBuildableItem()
		{
			return null;
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9C")]
		[Address(RVA = "0x675780", Offset = "0x674180", VA = "0x180675780")]
		public void SetCanDestroy(bool canDestroy)
		{
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F9D")]
		[Address(RVA = "0x675B80", Offset = "0x674580", VA = "0x180675B80")]
		public InteractionManager()
		{
		}

		// Token: 0x040019DF RID: 6623
		[Token(Token = "0x40019DF")]
		public const float RayRadius = 0.075f;

		// Token: 0x040019E0 RID: 6624
		[Token(Token = "0x40019E0")]
		public const float MaxInteractionRange = 5f;

		// Token: 0x040019E1 RID: 6625
		[Token(Token = "0x40019E1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected LayerMask interaction_SearchMask;

		// Token: 0x040019E2 RID: 6626
		[Token(Token = "0x40019E2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected float rightClickRange;

		// Token: 0x040019E3 RID: 6627
		[Token(Token = "0x40019E3")]
		[FieldOffset(Offset = "0x30")]
		public EInteractionSearchType interactionSearchType;

		// Token: 0x040019E4 RID: 6628
		[Token(Token = "0x40019E4")]
		[FieldOffset(Offset = "0x34")]
		public bool DEBUG;

		// Token: 0x040019EA RID: 6634
		[Token(Token = "0x40019EA")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public InputActionReference InteractInput;

		// Token: 0x040019EB RID: 6635
		[Token(Token = "0x40019EB")]
		[FieldOffset(Offset = "0x60")]
		[Header("Visuals Settings")]
		public Color messageColor_Default;

		// Token: 0x040019EC RID: 6636
		[Token(Token = "0x40019EC")]
		[FieldOffset(Offset = "0x70")]
		public Color iconColor_Default;

		// Token: 0x040019ED RID: 6637
		[Token(Token = "0x40019ED")]
		[FieldOffset(Offset = "0x80")]
		public Color iconColor_Default_Key;

		// Token: 0x040019EE RID: 6638
		[Token(Token = "0x40019EE")]
		[FieldOffset(Offset = "0x90")]
		public Color messageColor_Invalid;

		// Token: 0x040019EF RID: 6639
		[Token(Token = "0x40019EF")]
		[FieldOffset(Offset = "0xA0")]
		public Color iconColor_Invalid;

		// Token: 0x040019F0 RID: 6640
		[Token(Token = "0x40019F0")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite icon_Key;

		// Token: 0x040019F1 RID: 6641
		[Token(Token = "0x40019F1")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite icon_LeftMouse;

		// Token: 0x040019F2 RID: 6642
		[Token(Token = "0x40019F2")]
		[FieldOffset(Offset = "0xC0")]
		public Sprite icon_Cross;

		// Token: 0x040019F3 RID: 6643
		[Token(Token = "0x40019F3")]
		[FieldOffset(Offset = "0x0")]
		public static float interactCooldown;

		// Token: 0x040019F4 RID: 6644
		[Token(Token = "0x40019F4")]
		[FieldOffset(Offset = "0xC8")]
		private float timeSinceLastInteractStart;

		// Token: 0x040019F5 RID: 6645
		[Token(Token = "0x40019F5")]
		[FieldOffset(Offset = "0xD0")]
		private BuildableItem itemBeingDestroyed;

		// Token: 0x040019F6 RID: 6646
		[Token(Token = "0x40019F6")]
		[FieldOffset(Offset = "0xD8")]
		private float destroyTime;

		// Token: 0x040019F7 RID: 6647
		[Token(Token = "0x40019F7")]
		[FieldOffset(Offset = "0x4")]
		private static float timeToDestroy;
	}
}
