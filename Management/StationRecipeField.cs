using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.StationFramework;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	// Token: 0x020004EA RID: 1258
	[Token(Token = "0x20004EA")]
	public class StationRecipeField : ConfigField
	{
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000475")]
		public StationRecipe SelectedRecipe
		{
			[Token(Token = "0x6001982")]
			[Address(RVA = "0x42FFB0", Offset = "0x42E9B0", VA = "0x18042FFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001983")]
			[Address(RVA = "0x42FFE0", Offset = "0x42E9E0", VA = "0x18042FFE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x64DED0", Offset = "0x64C8D0", VA = "0x18064DED0")]
		public StationRecipeField(EntityConfiguration parentConfig)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x64DE30", Offset = "0x64C830", VA = "0x18064DE30")]
		public void SetRecipe(StationRecipe recipe, bool network)
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x64DCD0", Offset = "0x64C6D0", VA = "0x18064DCD0", Slot = "4")]
		public override bool IsValueDefault()
		{
			return default(bool);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x64DBF0", Offset = "0x64C5F0", VA = "0x18064DBF0")]
		public StationRecipeFieldData GetData()
		{
			return null;
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x64DD20", Offset = "0x64C720", VA = "0x18064DD20")]
		public void Load(StationRecipeFieldData data)
		{
		}

		// Token: 0x04001658 RID: 5720
		[Token(Token = "0x4001658")]
		[FieldOffset(Offset = "0x20")]
		public List<StationRecipe> Options;

		// Token: 0x04001659 RID: 5721
		[Token(Token = "0x4001659")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent<StationRecipe> onRecipeChanged;
	}
}
