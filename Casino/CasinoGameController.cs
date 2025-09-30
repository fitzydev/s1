using System;
using System.Runtime.CompilerServices;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Casino
{
	// Token: 0x020007D2 RID: 2002
	[Token(Token = "0x20007D2")]
	public class CasinoGameController : NetworkBehaviour
	{
		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06003626 RID: 13862 RVA: 0x0000EC70 File Offset: 0x0000CE70
		// (set) Token: 0x06003627 RID: 13863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007D0")]
		public bool IsOpen
		{
			[Token(Token = "0x6003626")]
			[Address(RVA = "0x542F10", Offset = "0x541910", VA = "0x180542F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003627")]
			[Address(RVA = "0x6775B0", Offset = "0x675FB0", VA = "0x1806775B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06003628 RID: 13864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007D1")]
		public CasinoGamePlayerData LocalPlayerData
		{
			[Token(Token = "0x6003628")]
			[Address(RVA = "0x7C75A0", Offset = "0x7C5FA0", VA = "0x1807C75A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003629")]
		[Address(RVA = "0x7C69B0", Offset = "0x7C53B0", VA = "0x1807C69B0", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362A")]
		[Address(RVA = "0x730440", Offset = "0x72EE40", VA = "0x180730440", Slot = "20")]
		protected virtual void OnLocalPlayerRequestJoin(Player player)
		{
		}

		// Token: 0x0600362B RID: 13867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362B")]
		[Address(RVA = "0x7C6F70", Offset = "0x7C5970", VA = "0x1807C6F70", Slot = "21")]
		protected virtual void Exit(ExitAction action)
		{
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362C")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "22")]
		protected virtual void Update()
		{
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362D")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "23")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362E")]
		[Address(RVA = "0x7C7010", Offset = "0x7C5A10", VA = "0x1807C7010", Slot = "24")]
		protected virtual void Open()
		{
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600362F")]
		[Address(RVA = "0x7C6B40", Offset = "0x7C5540", VA = "0x1807C6B40", Slot = "25")]
		protected virtual void Close()
		{
		}

		// Token: 0x06003630 RID: 13872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003630")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public CasinoGameController()
		{
		}

		// Token: 0x06003631 RID: 13873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003631")]
		[Address(RVA = "0x7C6FF0", Offset = "0x7C59F0", VA = "0x1807C6FF0", Slot = "26")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003632")]
		[Address(RVA = "0x7C6FD0", Offset = "0x7C59D0", VA = "0x1807C6FD0", Slot = "27")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003633")]
		[Address(RVA = "0x75FAE0", Offset = "0x75E4E0", VA = "0x18075FAE0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003634")]
		[Address(RVA = "0x7C6850", Offset = "0x7C5250", VA = "0x1807C6850", Slot = "28")]
		protected virtual void Awake_UserLogic_ScheduleOne.Casino.CasinoGameController_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040025BE RID: 9662
		[Token(Token = "0x40025BE")]
		public const float FOV = 65f;

		// Token: 0x040025BF RID: 9663
		[Token(Token = "0x40025BF")]
		public const float CAMERA_LERP_TIME = 0.2f;

		// Token: 0x040025C1 RID: 9665
		[Token(Token = "0x40025C1")]
		[FieldOffset(Offset = "0x120")]
		[Header("References")]
		public CasinoGamePlayers Players;

		// Token: 0x040025C2 RID: 9666
		[Token(Token = "0x40025C2")]
		[FieldOffset(Offset = "0x128")]
		public CasinoGameInteraction Interaction;

		// Token: 0x040025C3 RID: 9667
		[Token(Token = "0x40025C3")]
		[FieldOffset(Offset = "0x130")]
		public Transform[] DefaultCameraTransforms;

		// Token: 0x040025C4 RID: 9668
		[Token(Token = "0x40025C4")]
		[FieldOffset(Offset = "0x138")]
		protected Transform localDefaultCameraTransform;

		// Token: 0x040025C5 RID: 9669
		[Token(Token = "0x40025C5")]
		[FieldOffset(Offset = "0x140")]
		private bool NetworkInitialize___EarlyScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted;

		// Token: 0x040025C6 RID: 9670
		[Token(Token = "0x40025C6")]
		[FieldOffset(Offset = "0x141")]
		private bool NetworkInitialize__LateScheduleOne.Casino.CasinoGameControllerAssembly-CSharp.dll_Excuted;
	}
}
