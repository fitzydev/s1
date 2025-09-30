using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004E8 RID: 1256
	[Token(Token = "0x20004E8")]
	public class QualityField : ConfigField
	{
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001973 RID: 6515 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000474")]
		public EQuality Value
		{
			[Token(Token = "0x6001973")]
			[Address(RVA = "0x447E90", Offset = "0x446890", VA = "0x180447E90")]
			[CompilerGenerated]
			get
			{
				return EQuality.Trash;
			}
			[Token(Token = "0x6001974")]
			[Address(RVA = "0x4A50C0", Offset = "0x4A3AC0", VA = "0x1804A50C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x64C040", Offset = "0x64AA40", VA = "0x18064C040")]
		public QualityField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x64BFB0", Offset = "0x64A9B0", VA = "0x18064BFB0")]
		public void SetValue(EQuality value, bool network)
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x64BF20", Offset = "0x64A920", VA = "0x18064BF20", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x64BEC0", Offset = "0x64A8C0", VA = "0x18064BEC0")]
		public QualityFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x64BF30", Offset = "0x64A930", VA = "0x18064BF30")]
		public void Load(QualityFieldData data)
		{
		}

		// Token: 0x04001653 RID: 5715
		[Token(Token = "0x4001653")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent<EQuality> onValueChanged;
	}
}
