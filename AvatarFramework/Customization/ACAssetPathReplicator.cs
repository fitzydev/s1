using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000A62 RID: 2658
	[Token(Token = "0x2000A62")]
	public class ACAssetPathReplicator<T> : ACReplicator where T : global::UnityEngine.Object
	{
		// Token: 0x0600488A RID: 18570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488A")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600488B RID: 18571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488B")]
		protected override void AvatarSettingsChanged(AvatarSettings newSettings)
		{
		}

		// Token: 0x0600488C RID: 18572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600488C")]
		public ACAssetPathReplicator()
		{
		}

		// Token: 0x04003382 RID: 13186
		[Token(Token = "0x4003382")]
		[FieldOffset(Offset = "0x0")]
		private ACSelection<T> selection;
	}
}
