using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	public class NumberField : ConfigField
	{
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00009078 File Offset: 0x00007278
		// (set) Token: 0x06001958 RID: 6488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000470")]
		public float Value
		{
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x486250", Offset = "0x484C50", VA = "0x180486250")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001958")]
			[Address(RVA = "0x641040", Offset = "0x63FA40", VA = "0x180641040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00009090 File Offset: 0x00007290
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000471")]
		public float MinValue
		{
			[Token(Token = "0x6001959")]
			[Address(RVA = "0x486260", Offset = "0x484C60", VA = "0x180486260")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600195A")]
			[Address(RVA = "0x4A50D0", Offset = "0x4A3AD0", VA = "0x1804A50D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x000090A8 File Offset: 0x000072A8
		// (set) Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000472")]
		public float MaxValue
		{
			[Token(Token = "0x600195B")]
			[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x4A4AF0", Offset = "0x4A34F0", VA = "0x1804A4AF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600195D RID: 6493 RVA: 0x000090C0 File Offset: 0x000072C0
		// (set) Token: 0x0600195E RID: 6494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000473")]
		public bool WholeNumbers
		{
			[Token(Token = "0x600195D")]
			[Address(RVA = "0x570E30", Offset = "0x56F830", VA = "0x180570E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600195E")]
			[Address(RVA = "0x570EA0", Offset = "0x56F8A0", VA = "0x180570EA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x640FB0", Offset = "0x63F9B0", VA = "0x180640FB0")]
		public NumberField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x640F20", Offset = "0x63F920", VA = "0x180640F20")]
		public void SetValue(float value, bool network)
		{
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x640E10", Offset = "0x63F810", VA = "0x180640E10")]
		public void Configure(float minValue, float maxValue, bool wholeNumbers)
		{
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x640E80", Offset = "0x63F880", VA = "0x180640E80", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x640E20", Offset = "0x63F820", VA = "0x180640E20")]
		public NumberFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001964 RID: 6500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001964")]
		[Address(RVA = "0x640EA0", Offset = "0x63F8A0", VA = "0x180640EA0")]
		public void Load(NumberFieldData data)
		{
		}

		// Token: 0x04001647 RID: 5703
		[Token(Token = "0x4001647")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<float> onItemChanged;
	}
}
