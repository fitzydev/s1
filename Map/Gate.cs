using System;
using System.Runtime.CompilerServices;
using EasyButtons;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.Map
{
	// Token: 0x02000CF4 RID: 3316
	[Token(Token = "0x2000CF4")]
	public class Gate : NetworkBehaviour
	{
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06005DD2 RID: 24018 RVA: 0x000168F0 File Offset: 0x00014AF0
		// (set) Token: 0x06005DD3 RID: 24019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D13")]
		public bool IsOpen
		{
			[Token(Token = "0x6005DD2")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DD3")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD4")]
		[Address(RVA = "0xA5C500", Offset = "0xA5AF00", VA = "0x180A5C500")]
		private void Update()
		{
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD5")]
		[Address(RVA = "0xA5C010", Offset = "0xA5AA10", VA = "0x180A5C010")]
		[Button]
		[ObserversRpc(RunLocally = true)]
		public void Open()
		{
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD6")]
		[Address(RVA = "0xA5BE20", Offset = "0xA5A820", VA = "0x180A5BE20")]
		[Button]
		[ObserversRpc]
		public void Close()
		{
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD7")]
		[Address(RVA = "0xA5C9B0", Offset = "0xA5B3B0", VA = "0x180A5C9B0")]
		public Gate()
		{
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD8")]
		[Address(RVA = "0xA5BF40", Offset = "0xA5A940", VA = "0x180A5BF40", Slot = "19")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DD9")]
		[Address(RVA = "0x6806E0", Offset = "0x67F0E0", VA = "0x1806806E0", Slot = "20")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDA")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDB")]
		[Address(RVA = "0xA5C3F0", Offset = "0xA5ADF0", VA = "0x180A5C3F0")]
		private void RpcWriter___Observers_Open_2166136261()
		{
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDC")]
		[Address(RVA = "0xA5C200", Offset = "0xA5AC00", VA = "0x180A5C200")]
		public void RpcLogic___Open_2166136261()
		{
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDD")]
		[Address(RVA = "0xA5C3B0", Offset = "0xA5ADB0", VA = "0x180A5C3B0")]
		private void RpcReader___Observers_Open_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDE")]
		[Address(RVA = "0xA5BE20", Offset = "0xA5A820", VA = "0x180A5BE20")]
		private void RpcWriter___Observers_Close_2166136261()
		{
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DDF")]
		[Address(RVA = "0xA5C130", Offset = "0xA5AB30", VA = "0x180A5C130")]
		public void RpcLogic___Close_2166136261()
		{
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE0")]
		[Address(RVA = "0xA5C2D0", Offset = "0xA5ACD0", VA = "0x180A5C2D0")]
		private void RpcReader___Observers_Close_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DE1")]
		[Address(RVA = "0x601B00", Offset = "0x600500", VA = "0x180601B00", Slot = "21")]
		public virtual void Awake()
		{
		}

		// Token: 0x04004430 RID: 17456
		[Token(Token = "0x4004430")]
		[FieldOffset(Offset = "0x120")]
		public Transform Gate1;

		// Token: 0x04004431 RID: 17457
		[Token(Token = "0x4004431")]
		[FieldOffset(Offset = "0x128")]
		public Vector3 Gate1Open;

		// Token: 0x04004432 RID: 17458
		[Token(Token = "0x4004432")]
		[FieldOffset(Offset = "0x134")]
		public Vector3 Gate1Closed;

		// Token: 0x04004433 RID: 17459
		[Token(Token = "0x4004433")]
		[FieldOffset(Offset = "0x140")]
		public Transform Gate2;

		// Token: 0x04004434 RID: 17460
		[Token(Token = "0x4004434")]
		[FieldOffset(Offset = "0x148")]
		public Vector3 Gate2Open;

		// Token: 0x04004435 RID: 17461
		[Token(Token = "0x4004435")]
		[FieldOffset(Offset = "0x154")]
		public Vector3 Gate2Closed;

		// Token: 0x04004436 RID: 17462
		[Token(Token = "0x4004436")]
		[FieldOffset(Offset = "0x160")]
		public float OpenSpeed;

		// Token: 0x04004437 RID: 17463
		[Token(Token = "0x4004437")]
		[FieldOffset(Offset = "0x164")]
		public float Acceleration;

		// Token: 0x04004438 RID: 17464
		[Token(Token = "0x4004438")]
		[FieldOffset(Offset = "0x168")]
		[Header("Sound")]
		public AudioSourceController[] StartSounds;

		// Token: 0x04004439 RID: 17465
		[Token(Token = "0x4004439")]
		[FieldOffset(Offset = "0x170")]
		public AudioSourceController[] LoopSounds;

		// Token: 0x0400443A RID: 17466
		[Token(Token = "0x400443A")]
		[FieldOffset(Offset = "0x178")]
		public AudioSourceController[] StopSounds;

		// Token: 0x0400443B RID: 17467
		[Token(Token = "0x400443B")]
		[FieldOffset(Offset = "0x180")]
		private float Momentum;

		// Token: 0x0400443C RID: 17468
		[Token(Token = "0x400443C")]
		[FieldOffset(Offset = "0x184")]
		private float openDelta;

		// Token: 0x0400443D RID: 17469
		[Token(Token = "0x400443D")]
		[FieldOffset(Offset = "0x188")]
		private bool NetworkInitialize___EarlyScheduleOne.Map.GateAssembly-CSharp.dll_Excuted;

		// Token: 0x0400443E RID: 17470
		[Token(Token = "0x400443E")]
		[FieldOffset(Offset = "0x189")]
		private bool NetworkInitialize__LateScheduleOne.Map.GateAssembly-CSharp.dll_Excuted;
	}
}
