using System;
using System.Collections.Generic;
using FishNet.Serializing.Helping;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework
{
	// Token: 0x02000A10 RID: 2576
	[Token(Token = "0x2000A10")]
	[CreateAssetMenu(fileName = "Avatar Settings", menuName = "ScriptableObjects/Avatar Settings", order = 1)]
	[Serializable]
	public class AvatarSettings : ScriptableObject
	{
		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x00012828 File Offset: 0x00010A28
		[Token(Token = "0x170009D0")]
		public float UpperEyelidRestingPosition
		{
			[Token(Token = "0x60046A3")]
			[Address(RVA = "0x7BAA30", Offset = "0x7B9430", VA = "0x1807BAA30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060046A4 RID: 18084 RVA: 0x00012840 File Offset: 0x00010A40
		[Token(Token = "0x170009D1")]
		public float LowerEyelidRestingPosition
		{
			[Token(Token = "0x60046A4")]
			[Address(RVA = "0x8F4B50", Offset = "0x8F3550", VA = "0x1808F4B50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D2")]
		public string FaceLayer1Path
		{
			[Token(Token = "0x60046A5")]
			[Address(RVA = "0x8F4430", Offset = "0x8F2E30", VA = "0x1808F4430")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x170009D3")]
		public Color FaceLayer1Color
		{
			[Token(Token = "0x60046A6")]
			[Address(RVA = "0x8F4390", Offset = "0x8F2D90", VA = "0x1808F4390")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D4")]
		public string FaceLayer2Path
		{
			[Token(Token = "0x60046A7")]
			[Address(RVA = "0x8F4550", Offset = "0x8F2F50", VA = "0x1808F4550")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x060046A8 RID: 18088 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x170009D5")]
		public Color FaceLayer2Color
		{
			[Token(Token = "0x60046A8")]
			[Address(RVA = "0x8F44B0", Offset = "0x8F2EB0", VA = "0x1808F44B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D6")]
		public string FaceLayer3Path
		{
			[Token(Token = "0x60046A9")]
			[Address(RVA = "0x8F4670", Offset = "0x8F3070", VA = "0x1808F4670")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x00012888 File Offset: 0x00010A88
		[Token(Token = "0x170009D7")]
		public Color FaceLayer3Color
		{
			[Token(Token = "0x60046AA")]
			[Address(RVA = "0x8F45D0", Offset = "0x8F2FD0", VA = "0x1808F45D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009D8")]
		public string FaceLayer4Path
		{
			[Token(Token = "0x60046AB")]
			[Address(RVA = "0x8F4790", Offset = "0x8F3190", VA = "0x1808F4790")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x000128A0 File Offset: 0x00010AA0
		[Token(Token = "0x170009D9")]
		public Color FaceLayer4Color
		{
			[Token(Token = "0x60046AC")]
			[Address(RVA = "0x8F46F0", Offset = "0x8F30F0", VA = "0x1808F46F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DA")]
		public string FaceLayer5Path
		{
			[Token(Token = "0x60046AD")]
			[Address(RVA = "0x8F48B0", Offset = "0x8F32B0", VA = "0x1808F48B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x000128B8 File Offset: 0x00010AB8
		[Token(Token = "0x170009DB")]
		public Color FaceLayer5Color
		{
			[Token(Token = "0x60046AE")]
			[Address(RVA = "0x8F4810", Offset = "0x8F3210", VA = "0x1808F4810")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DC")]
		public string FaceLayer6Path
		{
			[Token(Token = "0x60046AF")]
			[Address(RVA = "0x8F49D0", Offset = "0x8F33D0", VA = "0x1808F49D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x000128D0 File Offset: 0x00010AD0
		[Token(Token = "0x170009DD")]
		public Color FaceLayer6Color
		{
			[Token(Token = "0x60046B0")]
			[Address(RVA = "0x8F4930", Offset = "0x8F3330", VA = "0x1808F4930")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009DE")]
		public string BodyLayer1Path
		{
			[Token(Token = "0x60046B1")]
			[Address(RVA = "0x8F3D70", Offset = "0x8F2770", VA = "0x1808F3D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x000128E8 File Offset: 0x00010AE8
		[Token(Token = "0x170009DF")]
		public Color BodyLayer1Color
		{
			[Token(Token = "0x60046B2")]
			[Address(RVA = "0x8F3CD0", Offset = "0x8F26D0", VA = "0x1808F3CD0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060046B3 RID: 18099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E0")]
		public string BodyLayer2Path
		{
			[Token(Token = "0x60046B3")]
			[Address(RVA = "0x8F3E90", Offset = "0x8F2890", VA = "0x1808F3E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x00012900 File Offset: 0x00010B00
		[Token(Token = "0x170009E1")]
		public Color BodyLayer2Color
		{
			[Token(Token = "0x60046B4")]
			[Address(RVA = "0x8F3DF0", Offset = "0x8F27F0", VA = "0x1808F3DF0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E2")]
		public string BodyLayer3Path
		{
			[Token(Token = "0x60046B5")]
			[Address(RVA = "0x8F3FB0", Offset = "0x8F29B0", VA = "0x1808F3FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x00012918 File Offset: 0x00010B18
		[Token(Token = "0x170009E3")]
		public Color BodyLayer3Color
		{
			[Token(Token = "0x60046B6")]
			[Address(RVA = "0x8F3F10", Offset = "0x8F2910", VA = "0x1808F3F10")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E4")]
		public string BodyLayer4Path
		{
			[Token(Token = "0x60046B7")]
			[Address(RVA = "0x8F40D0", Offset = "0x8F2AD0", VA = "0x1808F40D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00012930 File Offset: 0x00010B30
		[Token(Token = "0x170009E5")]
		public Color BodyLayer4Color
		{
			[Token(Token = "0x60046B8")]
			[Address(RVA = "0x8F4030", Offset = "0x8F2A30", VA = "0x1808F4030")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E6")]
		public string BodyLayer5Path
		{
			[Token(Token = "0x60046B9")]
			[Address(RVA = "0x8F41F0", Offset = "0x8F2BF0", VA = "0x1808F41F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x00012948 File Offset: 0x00010B48
		[Token(Token = "0x170009E7")]
		public Color BodyLayer5Color
		{
			[Token(Token = "0x60046BA")]
			[Address(RVA = "0x8F4150", Offset = "0x8F2B50", VA = "0x1808F4150")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009E8")]
		public string BodyLayer6Path
		{
			[Token(Token = "0x60046BB")]
			[Address(RVA = "0x8F4310", Offset = "0x8F2D10", VA = "0x1808F4310")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x00012960 File Offset: 0x00010B60
		[Token(Token = "0x170009E9")]
		public Color BodyLayer6Color
		{
			[Token(Token = "0x60046BC")]
			[Address(RVA = "0x8F4270", Offset = "0x8F2C70", VA = "0x1808F4270")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EA")]
		public string Accessory1Path
		{
			[Token(Token = "0x60046BD")]
			[Address(RVA = "0x8F3350", Offset = "0x8F1D50", VA = "0x1808F3350")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x00012978 File Offset: 0x00010B78
		[Token(Token = "0x170009EB")]
		public Color Accessory1Color
		{
			[Token(Token = "0x60046BE")]
			[Address(RVA = "0x8F32B0", Offset = "0x8F1CB0", VA = "0x1808F32B0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EC")]
		public string Accessory2Path
		{
			[Token(Token = "0x60046BF")]
			[Address(RVA = "0x8F3470", Offset = "0x8F1E70", VA = "0x1808F3470")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x00012990 File Offset: 0x00010B90
		[Token(Token = "0x170009ED")]
		public Color Accessory2Color
		{
			[Token(Token = "0x60046C0")]
			[Address(RVA = "0x8F33D0", Offset = "0x8F1DD0", VA = "0x1808F33D0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EE")]
		public string Accessory3Path
		{
			[Token(Token = "0x60046C1")]
			[Address(RVA = "0x8F3590", Offset = "0x8F1F90", VA = "0x1808F3590")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x000129A8 File Offset: 0x00010BA8
		[Token(Token = "0x170009EF")]
		public Color Accessory3Color
		{
			[Token(Token = "0x60046C2")]
			[Address(RVA = "0x8F34F0", Offset = "0x8F1EF0", VA = "0x1808F34F0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F0")]
		public string Accessory4Path
		{
			[Token(Token = "0x60046C3")]
			[Address(RVA = "0x8F36B0", Offset = "0x8F20B0", VA = "0x1808F36B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x000129C0 File Offset: 0x00010BC0
		[Token(Token = "0x170009F1")]
		public Color Accessory4Color
		{
			[Token(Token = "0x60046C4")]
			[Address(RVA = "0x8F3610", Offset = "0x8F2010", VA = "0x1808F3610")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060046C5 RID: 18117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F2")]
		public string Accessory5Path
		{
			[Token(Token = "0x60046C5")]
			[Address(RVA = "0x8F37D0", Offset = "0x8F21D0", VA = "0x1808F37D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060046C6 RID: 18118 RVA: 0x000129D8 File Offset: 0x00010BD8
		[Token(Token = "0x170009F3")]
		public Color Accessory5Color
		{
			[Token(Token = "0x60046C6")]
			[Address(RVA = "0x8F3730", Offset = "0x8F2130", VA = "0x1808F3730")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060046C7 RID: 18119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F4")]
		public string Accessory6Path
		{
			[Token(Token = "0x60046C7")]
			[Address(RVA = "0x8F38F0", Offset = "0x8F22F0", VA = "0x1808F38F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060046C8 RID: 18120 RVA: 0x000129F0 File Offset: 0x00010BF0
		[Token(Token = "0x170009F5")]
		public Color Accessory6Color
		{
			[Token(Token = "0x60046C8")]
			[Address(RVA = "0x8F3850", Offset = "0x8F2250", VA = "0x1808F3850")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060046C9 RID: 18121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F6")]
		public string Accessory7Path
		{
			[Token(Token = "0x60046C9")]
			[Address(RVA = "0x8F3A10", Offset = "0x8F2410", VA = "0x1808F3A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x00012A08 File Offset: 0x00010C08
		[Token(Token = "0x170009F7")]
		public Color Accessory7Color
		{
			[Token(Token = "0x60046CA")]
			[Address(RVA = "0x8F3970", Offset = "0x8F2370", VA = "0x1808F3970")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060046CB RID: 18123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009F8")]
		public string Accessory8Path
		{
			[Token(Token = "0x60046CB")]
			[Address(RVA = "0x8F3B30", Offset = "0x8F2530", VA = "0x1808F3B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x00012A20 File Offset: 0x00010C20
		[Token(Token = "0x170009F9")]
		public Color Accessory8Color
		{
			[Token(Token = "0x60046CC")]
			[Address(RVA = "0x8F3A90", Offset = "0x8F2490", VA = "0x1808F3A90")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060046CD RID: 18125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009FA")]
		public string Accessory9Path
		{
			[Token(Token = "0x60046CD")]
			[Address(RVA = "0x8F3C50", Offset = "0x8F2650", VA = "0x1808F3C50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x00012A38 File Offset: 0x00010C38
		[Token(Token = "0x170009FB")]
		public Color Accessory9Color
		{
			[Token(Token = "0x60046CE")]
			[Address(RVA = "0x8F3BB0", Offset = "0x8F25B0", VA = "0x1808F3BB0")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170009FC RID: 2556
		[Token(Token = "0x170009FC")]
		public object this[string propertyName]
		{
			[Token(Token = "0x60046CF")]
			[Address(RVA = "0x8F4A50", Offset = "0x8F3450", VA = "0x1808F4A50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x8F31A0", Offset = "0x8F1BA0", VA = "0x1808F31A0", Slot = "4")]
		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x8F31B0", Offset = "0x8F1BB0", VA = "0x1808F31B0")]
		public AvatarSettings()
		{
		}

		// Token: 0x04003188 RID: 12680
		[Token(Token = "0x4003188")]
		[FieldOffset(Offset = "0x18")]
		public Color SkinColor;

		// Token: 0x04003189 RID: 12681
		[Token(Token = "0x4003189")]
		[FieldOffset(Offset = "0x28")]
		public float Height;

		// Token: 0x0400318A RID: 12682
		[Token(Token = "0x400318A")]
		[FieldOffset(Offset = "0x2C")]
		public float Gender;

		// Token: 0x0400318B RID: 12683
		[Token(Token = "0x400318B")]
		[FieldOffset(Offset = "0x30")]
		public float Weight;

		// Token: 0x0400318C RID: 12684
		[Token(Token = "0x400318C")]
		[FieldOffset(Offset = "0x38")]
		public string HairPath;

		// Token: 0x0400318D RID: 12685
		[Token(Token = "0x400318D")]
		[FieldOffset(Offset = "0x40")]
		public Color HairColor;

		// Token: 0x0400318E RID: 12686
		[Token(Token = "0x400318E")]
		[FieldOffset(Offset = "0x50")]
		public float EyebrowScale;

		// Token: 0x0400318F RID: 12687
		[Token(Token = "0x400318F")]
		[FieldOffset(Offset = "0x54")]
		public float EyebrowThickness;

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x58")]
		public float EyebrowRestingHeight;

		// Token: 0x04003191 RID: 12689
		[Token(Token = "0x4003191")]
		[FieldOffset(Offset = "0x5C")]
		public float EyebrowRestingAngle;

		// Token: 0x04003192 RID: 12690
		[Token(Token = "0x4003192")]
		[FieldOffset(Offset = "0x60")]
		public Color LeftEyeLidColor;

		// Token: 0x04003193 RID: 12691
		[Token(Token = "0x4003193")]
		[FieldOffset(Offset = "0x70")]
		public Color RightEyeLidColor;

		// Token: 0x04003194 RID: 12692
		[Token(Token = "0x4003194")]
		[FieldOffset(Offset = "0x80")]
		public Eye.EyeLidConfiguration LeftEyeRestingState;

		// Token: 0x04003195 RID: 12693
		[Token(Token = "0x4003195")]
		[FieldOffset(Offset = "0x88")]
		public Eye.EyeLidConfiguration RightEyeRestingState;

		// Token: 0x04003196 RID: 12694
		[Token(Token = "0x4003196")]
		[FieldOffset(Offset = "0x90")]
		public string EyeballMaterialIdentifier;

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x98")]
		public Color EyeBallTint;

		// Token: 0x04003198 RID: 12696
		[Token(Token = "0x4003198")]
		[FieldOffset(Offset = "0xA8")]
		public float PupilDilation;

		// Token: 0x04003199 RID: 12697
		[Token(Token = "0x4003199")]
		[FieldOffset(Offset = "0xB0")]
		public List<AvatarSettings.LayerSetting> FaceLayerSettings;

		// Token: 0x0400319A RID: 12698
		[Token(Token = "0x400319A")]
		[FieldOffset(Offset = "0xB8")]
		public List<AvatarSettings.LayerSetting> BodyLayerSettings;

		// Token: 0x0400319B RID: 12699
		[Token(Token = "0x400319B")]
		[FieldOffset(Offset = "0xC0")]
		public List<AvatarSettings.AccessorySetting> AccessorySettings;

		// Token: 0x0400319C RID: 12700
		[Token(Token = "0x400319C")]
		[FieldOffset(Offset = "0xC8")]
		public bool UseCombinedLayer;

		// Token: 0x0400319D RID: 12701
		[Token(Token = "0x400319D")]
		[FieldOffset(Offset = "0xD0")]
		public string CombinedLayerPath;

		// Token: 0x0400319E RID: 12702
		[Token(Token = "0x400319E")]
		[FieldOffset(Offset = "0xD8")]
		[CodegenExclude]
		public Texture2D ImpostorTexture;

		// Token: 0x02000A11 RID: 2577
		[Token(Token = "0x2000A11")]
		[Serializable]
		public struct LayerSetting
		{
			// Token: 0x0400319F RID: 12703
			[Token(Token = "0x400319F")]
			[FieldOffset(Offset = "0x0")]
			public string layerPath;

			// Token: 0x040031A0 RID: 12704
			[Token(Token = "0x40031A0")]
			[FieldOffset(Offset = "0x8")]
			public Color layerTint;
		}

		// Token: 0x02000A12 RID: 2578
		[Token(Token = "0x2000A12")]
		[Serializable]
		public class AccessorySetting
		{
			// Token: 0x060046D2 RID: 18130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046D2")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public AccessorySetting()
			{
			}

			// Token: 0x040031A1 RID: 12705
			[Token(Token = "0x40031A1")]
			[FieldOffset(Offset = "0x10")]
			public string path;

			// Token: 0x040031A2 RID: 12706
			[Token(Token = "0x40031A2")]
			[FieldOffset(Offset = "0x18")]
			public Color color;
		}
	}
}
