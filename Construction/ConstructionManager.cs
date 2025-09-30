using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.Property;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Construction;
using UnityEngine;

namespace ScheduleOne.Construction
{
	// Token: 0x02000793 RID: 1939
	[Token(Token = "0x2000793")]
	public class ConstructionManager : Singleton<ConstructionManager>
	{
		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x0000E5B0 File Offset: 0x0000C7B0
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A2")]
		public bool constructionModeEnabled
		{
			[Token(Token = "0x600344C")]
			[Address(RVA = "0x4BE260", Offset = "0x4BCC60", VA = "0x1804BE260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600344D")]
			[Address(RVA = "0x4F3A70", Offset = "0x4F2470", VA = "0x1804F3A70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A3")]
		public bool isDeployingConstructable
		{
			[Token(Token = "0x600344E")]
			[Address(RVA = "0x4FA8A0", Offset = "0x4F92A0", VA = "0x1804FA8A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600344F")]
			[Address(RVA = "0x4FAC50", Offset = "0x4F9650", VA = "0x1804FAC50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A4")]
		public bool isMovingConstructable
		{
			[Token(Token = "0x6003450")]
			[Address(RVA = "0x4FA970", Offset = "0x4F9370", VA = "0x1804FA970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003451")]
			[Address(RVA = "0x4FACF0", Offset = "0x4F96F0", VA = "0x1804FACF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003452")]
		[Address(RVA = "0x79E4F0", Offset = "0x79CEF0", VA = "0x18079E4F0", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003453")]
		[Address(RVA = "0x79DF20", Offset = "0x79C920", VA = "0x18079DF20")]
		public void EnterConstructionMode(Property prop)
		{
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003454")]
		[Address(RVA = "0x79E0B0", Offset = "0x79CAB0", VA = "0x18079E0B0")]
		public void ExitConstructionMode()
		{
		}

		// Token: 0x06003455 RID: 13397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003455")]
		[Address(RVA = "0x79DD80", Offset = "0x79C780", VA = "0x18079DD80")]
		public void DeployConstructable(ConstructionMenu.ConstructionMenuListing listing)
		{
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003456")]
		[Address(RVA = "0x79E5A0", Offset = "0x79CFA0", VA = "0x18079E5A0")]
		public void StopConstructableDeploy()
		{
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003457")]
		[Address(RVA = "0x79E370", Offset = "0x79CD70", VA = "0x18079E370")]
		public void MoveConstructable(Constructable_GridBased c)
		{
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003458")]
		[Address(RVA = "0x79E610", Offset = "0x79D010", VA = "0x18079E610")]
		public void StopMovingConstructable()
		{
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003459")]
		[Address(RVA = "0x79E2A0", Offset = "0x79CCA0", VA = "0x18079E2A0")]
		private void Exit(ExitAction exit)
		{
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345A")]
		[Address(RVA = "0x79DBD0", Offset = "0x79C5D0", VA = "0x18079DBD0")]
		public Constructable_GridBased CreateConstructable_GridBased(string ID, Grid grid, Vector2 originCoordinate, float rotation)
		{
			return null;
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600345B")]
		[Address(RVA = "0x79DCF0", Offset = "0x79C6F0", VA = "0x18079DCF0")]
		public Constructable CreateConstructable(string prefabID)
		{
			return null;
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600345C")]
		[Address(RVA = "0x79E680", Offset = "0x79D080", VA = "0x18079E680")]
		public ConstructionManager()
		{
		}

		// Token: 0x04002462 RID: 9314
		[Token(Token = "0x4002462")]
		[FieldOffset(Offset = "0x28")]
		public NetworkObject networkObject;

		// Token: 0x04002464 RID: 9316
		[Token(Token = "0x4002464")]
		[FieldOffset(Offset = "0x38")]
		public Action onConstructionModeEnabled;

		// Token: 0x04002465 RID: 9317
		[Token(Token = "0x4002465")]
		[FieldOffset(Offset = "0x40")]
		public Action onConstructionModeDisabled;

		// Token: 0x04002467 RID: 9319
		[Token(Token = "0x4002467")]
		[FieldOffset(Offset = "0x50")]
		public GameObject constructHandler;

		// Token: 0x04002469 RID: 9321
		[Token(Token = "0x4002469")]
		[FieldOffset(Offset = "0x60")]
		public ConstructionManager.ConstructableNotification onNewConstructableBuilt;

		// Token: 0x0400246A RID: 9322
		[Token(Token = "0x400246A")]
		[FieldOffset(Offset = "0x68")]
		public ConstructionManager.ConstructableNotification onConstructableMoved;

		// Token: 0x0400246B RID: 9323
		[Token(Token = "0x400246B")]
		[FieldOffset(Offset = "0x70")]
		public Property currentProperty;

		// Token: 0x02000794 RID: 1940
		[Token(Token = "0x2000794")]
		public class WorldIntersection
		{
			// Token: 0x0600345D RID: 13405 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600345D")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public WorldIntersection()
			{
			}

			// Token: 0x0400246C RID: 9324
			[Token(Token = "0x400246C")]
			[FieldOffset(Offset = "0x10")]
			public FootprintTile footprint;

			// Token: 0x0400246D RID: 9325
			[Token(Token = "0x400246D")]
			[FieldOffset(Offset = "0x18")]
			public Tile tile;
		}

		// Token: 0x02000795 RID: 1941
		// (Invoke) Token: 0x0600345F RID: 13407
		[Token(Token = "0x2000795")]
		public delegate void ConstructableNotification(Constructable c);
	}
}
