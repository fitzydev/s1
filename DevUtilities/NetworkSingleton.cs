using System;
using FishNet.Object;
using Il2CppDummyDll;

namespace ScheduleOne.DevUtilities
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	public abstract class NetworkSingleton<T> : NetworkBehaviour where T : NetworkSingleton<T>
	{
		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x0000E118 File Offset: 0x0000C318
		[Token(Token = "0x1700076B")]
		public static bool InstanceExists
		{
			[Token(Token = "0x6003304")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700076C")]
		public static T Instance
		{
			[Token(Token = "0x6003305")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003306")]
			protected set
			{
			}
		}

		// Token: 0x06003307 RID: 13063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003307")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003308")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003309")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600330A RID: 13066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330A")]
		protected NetworkSingleton()
		{
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330B")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330C")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600330D RID: 13069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330D")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600330E RID: 13070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600330E")]
		protected virtual void Awake_UserLogic_ScheduleOne.DevUtilities.NetworkSingleton`1_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400235B RID: 9051
		[Token(Token = "0x400235B")]
		[FieldOffset(Offset = "0x0")]
		private static T instance;

		// Token: 0x0400235C RID: 9052
		[Token(Token = "0x400235C")]
		[FieldOffset(Offset = "0x0")]
		protected bool Destroyed;

		// Token: 0x0400235D RID: 9053
		[Token(Token = "0x400235D")]
		[FieldOffset(Offset = "0x0")]
		private bool NetworkInitialize___EarlyScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted;

		// Token: 0x0400235E RID: 9054
		[Token(Token = "0x400235E")]
		[FieldOffset(Offset = "0x0")]
		private bool NetworkInitialize__LateScheduleOne.DevUtilities.NetworkSingleton`1Assembly-CSharp.dll_Excuted;
	}
}
