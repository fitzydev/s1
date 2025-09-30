using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF9 RID: 3321
	[Token(Token = "0x2000CF9")]
	public class MapPositionUtility : Singleton<MapPositionUtility>
	{
		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06005DF9 RID: 24057 RVA: 0x00016950 File Offset: 0x00014B50
		// (set) Token: 0x06005DFA RID: 24058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D14")]
		private float conversionFactor
		{
			[Token(Token = "0x6005DF9")]
			[Address(RVA = "0x507400", Offset = "0x505E00", VA = "0x180507400")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005DFA")]
			[Address(RVA = "0x507420", Offset = "0x505E20", VA = "0x180507420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFB")]
		[Address(RVA = "0xA5E0A0", Offset = "0xA5CAA0", VA = "0x180A5E0A0", Slot = "5")]
		protected override void Awake()
		{
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x00016968 File Offset: 0x00014B68
		[Token(Token = "0x6005DFC")]
		[Address(RVA = "0xA5E230", Offset = "0xA5CC30", VA = "0x180A5E230")]
		public Vector2 GetMapPosition(Vector3 worldPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFD")]
		[Address(RVA = "0xA5E2C0", Offset = "0xA5CCC0", VA = "0x180A5E2C0")]
		[Button]
		public void Recalculate()
		{
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFE")]
		[Address(RVA = "0xA5E420", Offset = "0xA5CE20", VA = "0x180A5E420")]
		public MapPositionUtility()
		{
		}

		// Token: 0x04004450 RID: 17488
		[Token(Token = "0x4004450")]
		[FieldOffset(Offset = "0x28")]
		public Transform OriginPoint;

		// Token: 0x04004451 RID: 17489
		[Token(Token = "0x4004451")]
		[FieldOffset(Offset = "0x30")]
		public Transform EdgePoint;

		// Token: 0x04004452 RID: 17490
		[Token(Token = "0x4004452")]
		[FieldOffset(Offset = "0x38")]
		public float MapDimensions;
	}
}
