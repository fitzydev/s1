using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ScheduleOne.Building;
using ScheduleOne.EntityFramework;
using ScheduleOne.Tiles;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C74 RID: 3188
	[Token(Token = "0x2000C74")]
	public class FloorRack : GridItem, IProceduralTileContainer
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BD4")]
		public List<ProceduralTile> ProceduralTiles
		{
			[Token(Token = "0x6005626")]
			[Address(RVA = "0x716CB0", Offset = "0x7156B0", VA = "0x180716CB0", Slot = "71")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005627")]
		[Address(RVA = "0x9C5770", Offset = "0x9C4170", VA = "0x1809C5770", Slot = "72")]
		public virtual void UpdateLegVisibility()
		{
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005628")]
		[Address(RVA = "0x9C4C20", Offset = "0x9C3620", VA = "0x1809C4C20")]
		protected void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005629")]
		[Address(RVA = "0x9C5390", Offset = "0x9C3D90", VA = "0x1809C5390")]
		private FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			return null;
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600562A")]
		[Address(RVA = "0x9C54C0", Offset = "0x9C3EC0", VA = "0x1809C54C0")]
		public List<FloorRack> GetSurroundingRacks()
		{
			return null;
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x00015588 File Offset: 0x00013788
		[Token(Token = "0x600562B")]
		[Address(RVA = "0x9C4B60", Offset = "0x9C3560", VA = "0x1809C4B60", Slot = "68")]
		public override bool CanShareTileWith(List<GridItem> obstacles)
		{
			return default(bool);
		}

		// Token: 0x0600562C RID: 22060 RVA: 0x000155A0 File Offset: 0x000137A0
		[Token(Token = "0x600562C")]
		[Address(RVA = "0x9C4960", Offset = "0x9C3360", VA = "0x1809C4960", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600562D RID: 22061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562D")]
		[Address(RVA = "0x9C5260", Offset = "0x9C3C60", VA = "0x1809C5260", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x0600562E RID: 22062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562E")]
		[Address(RVA = "0x9C5880", Offset = "0x9C4280", VA = "0x1809C5880")]
		public FloorRack()
		{
		}

		// Token: 0x0600562F RID: 22063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600562F")]
		[Address(RVA = "0x9C5750", Offset = "0x9C4150", VA = "0x1809C5750", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005630 RID: 22064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005630")]
		[Address(RVA = "0x9C5730", Offset = "0x9C4130", VA = "0x1809C5730", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005631 RID: 22065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005631")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005632")]
		[Address(RVA = "0x9C4910", Offset = "0x9C3310", VA = "0x1809C4910", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x04003FDC RID: 16348
		[Token(Token = "0x4003FDC")]
		[FieldOffset(Offset = "0x218")]
		[Header("References")]
		public Transform leg_BottomLeft;

		// Token: 0x04003FDD RID: 16349
		[Token(Token = "0x4003FDD")]
		[FieldOffset(Offset = "0x220")]
		public Transform leg_BottomRight;

		// Token: 0x04003FDE RID: 16350
		[Token(Token = "0x4003FDE")]
		[FieldOffset(Offset = "0x228")]
		public Transform leg_TopLeft;

		// Token: 0x04003FDF RID: 16351
		[Token(Token = "0x4003FDF")]
		[FieldOffset(Offset = "0x230")]
		public Transform leg_TopRight;

		// Token: 0x04003FE0 RID: 16352
		[Token(Token = "0x4003FE0")]
		[FieldOffset(Offset = "0x238")]
		public CornerObstacle obs_BottomLeft;

		// Token: 0x04003FE1 RID: 16353
		[Token(Token = "0x4003FE1")]
		[FieldOffset(Offset = "0x240")]
		public CornerObstacle obs_BottomRight;

		// Token: 0x04003FE2 RID: 16354
		[Token(Token = "0x4003FE2")]
		[FieldOffset(Offset = "0x248")]
		public CornerObstacle obs_TopLeft;

		// Token: 0x04003FE3 RID: 16355
		[Token(Token = "0x4003FE3")]
		[FieldOffset(Offset = "0x250")]
		public CornerObstacle obs_TopRight;

		// Token: 0x04003FE4 RID: 16356
		[Token(Token = "0x4003FE4")]
		[FieldOffset(Offset = "0x258")]
		public List<ProceduralTile> procTiles;

		// Token: 0x04003FE5 RID: 16357
		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0x260")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted;

		// Token: 0x04003FE6 RID: 16358
		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0x261")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted;
	}
}
