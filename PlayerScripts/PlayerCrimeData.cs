using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x200055F")]
	public class PlayerCrimeData : NetworkBehaviour
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x00009EE8 File Offset: 0x000080E8
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000536")]
		public PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[Token(Token = "0x6001E2F")]
			[Address(RVA = "0x5489A0", Offset = "0x5473A0", VA = "0x1805489A0")]
			[CompilerGenerated]
			get
			{
				return PlayerCrimeData.EPursuitLevel.None;
			}
			[Token(Token = "0x6001E30")]
			[Address(RVA = "0x659890", Offset = "0x658290", VA = "0x180659890")]
			[CompilerGenerated]
			[ServerRpc(RunLocally = true)]
			protected set
			{
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x00009F00 File Offset: 0x00008100
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000537")]
		public Vector3 LastKnownPosition
		{
			[Token(Token = "0x6001E31")]
			[Address(RVA = "0x659830", Offset = "0x658230", VA = "0x180659830")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001E32")]
			[Address(RVA = "0x659A30", Offset = "0x658430", VA = "0x180659A30")]
			[ServerRpc(RunLocally = true)]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x00009F18 File Offset: 0x00008118
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000538")]
		public float CurrentArrestProgress
		{
			[Token(Token = "0x6001E33")]
			[Address(RVA = "0x538600", Offset = "0x537000", VA = "0x180538600")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E34")]
			[Address(RVA = "0x659870", Offset = "0x658270", VA = "0x180659870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x00009F30 File Offset: 0x00008130
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000539")]
		public float CurrentBodySearchProgress
		{
			[Token(Token = "0x6001E35")]
			[Address(RVA = "0x659810", Offset = "0x658210", VA = "0x180659810")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E36")]
			[Address(RVA = "0x659880", Offset = "0x658280", VA = "0x180659880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00009F48 File Offset: 0x00008148
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053A")]
		public int MinsSinceLastArrested
		{
			[Token(Token = "0x6001E37")]
			[Address(RVA = "0x659850", Offset = "0x658250", VA = "0x180659850")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E38")]
			[Address(RVA = "0x659B00", Offset = "0x658500", VA = "0x180659B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x00009F60 File Offset: 0x00008160
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053B")]
		public float TimeSinceLastBodySearch
		{
			[Token(Token = "0x6001E39")]
			[Address(RVA = "0x659860", Offset = "0x658260", VA = "0x180659860")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001E3A")]
			[Address(RVA = "0x659B10", Offset = "0x658510", VA = "0x180659B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x00009F78 File Offset: 0x00008178
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053C")]
		public bool EvadedArrest
		{
			[Token(Token = "0x6001E3B")]
			[Address(RVA = "0x659820", Offset = "0x658220", VA = "0x180659820")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E3C")]
			[Address(RVA = "0x659A20", Offset = "0x658420", VA = "0x180659A20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x656180", Offset = "0x654B80", VA = "0x180656180", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x658630", Offset = "0x657030", VA = "0x180658630")]
		private void Start()
		{
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x6572B0", Offset = "0x655CB0", VA = "0x1806572B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x658EF0", Offset = "0x6578F0", VA = "0x180658EF0", Slot = "20")]
		protected virtual void Update()
		{
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x656F20", Offset = "0x655920", VA = "0x180656F20")]
		private void MinPass()
		{
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x656CB0", Offset = "0x6556B0", VA = "0x180656CB0", Slot = "21")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x6582F0", Offset = "0x656CF0", VA = "0x1806582F0")]
		public void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level)
		{
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x6563B0", Offset = "0x654DB0", VA = "0x1806563B0")]
		public void Escalate()
		{
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x656350", Offset = "0x654D50", VA = "0x180656350")]
		public void Deescalate()
		{
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x6576D0", Offset = "0x6560D0", VA = "0x1806576D0")]
		[ObserversRpc(RunLocally = true)]
		public void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x658260", Offset = "0x656C60", VA = "0x180658260")]
		public void SetArrestProgress(float progress)
		{
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x657910", Offset = "0x656310", VA = "0x180657910")]
		public void ResetBodysearchCooldown()
		{
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x6582B0", Offset = "0x656CB0", VA = "0x1806582B0")]
		public void SetBodySearchProgress(float progress)
		{
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x657420", Offset = "0x655E20", VA = "0x180657420")]
		private void OnDie()
		{
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x655B20", Offset = "0x654520", VA = "0x180655B20")]
		public void AddCrime(Crime crime, int quantity = 1)
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x656300", Offset = "0x654D00", VA = "0x180656300")]
		public void ClearCrimes()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x656BA0", Offset = "0x6555A0", VA = "0x180656BA0")]
		public bool IsCrimeOnRecord(Type crime)
		{
			return default(bool);
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x6582E0", Offset = "0x656CE0", VA = "0x1806582E0")]
		public void SetEvaded()
		{
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x657470", Offset = "0x655E70", VA = "0x180657470")]
		private void OnSleepStart()
		{
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x658C20", Offset = "0x657620", VA = "0x180658C20")]
		private void UpdateEscalation()
		{
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x658D60", Offset = "0x657760", VA = "0x180658D60")]
		private void UpdateTimeout()
		{
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x658C70", Offset = "0x657670", VA = "0x180658C70")]
		private void UpdateMusic()
		{
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x6589C0", Offset = "0x6573C0", VA = "0x1806589C0")]
		private void TimeoutPursuit()
		{
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x656670", Offset = "0x655070", VA = "0x180656670")]
		public float GetSearchTime()
		{
			return 0f;
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x6566C0", Offset = "0x6550C0", VA = "0x1806566C0")]
		public float GetShotAccuracyMultiplier()
		{
			return 0f;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x657810", Offset = "0x656210", VA = "0x180657810")]
		public void RecordVehicleCollision(NPC victim)
		{
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x6561D0", Offset = "0x654BD0", VA = "0x1806561D0")]
		private void CheckNearestOfficer()
		{
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x659670", Offset = "0x658070", VA = "0x180659670")]
		public PlayerCrimeData()
		{
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x656FA0", Offset = "0x6559A0", VA = "0x180656FA0", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x656F30", Offset = "0x655930", VA = "0x180656F30", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x657EC0", Offset = "0x6568C0", VA = "0x180657EC0")]
		private void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x657A40", Offset = "0x656440", VA = "0x180657A40")]
		protected void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value)
		{
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x657C00", Offset = "0x656600", VA = "0x180657C00")]
		private void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x658070", Offset = "0x656A70", VA = "0x180658070")]
		private void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x657AD0", Offset = "0x6564D0", VA = "0x180657AD0")]
		protected void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x657C80", Offset = "0x656680", VA = "0x180657C80")]
		private void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x657D80", Offset = "0x656780", VA = "0x180657D80")]
		private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x657920", Offset = "0x656320", VA = "0x180657920")]
		public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x657B80", Offset = "0x656580", VA = "0x180657B80")]
		private void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00009FF0 File Offset: 0x000081F0
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053D")]
		public PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField
		{
			[Token(Token = "0x6001E67")]
			[Address(RVA = "0x5489A0", Offset = "0x5473A0", VA = "0x1805489A0")]
			get
			{
				return PlayerCrimeData.EPursuitLevel.None;
			}
			[Token(Token = "0x6001E68")]
			[Address(RVA = "0x659B20", Offset = "0x658520", VA = "0x180659B20")]
			set
			{
			}
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6001E69")]
		[Address(RVA = "0x6574E0", Offset = "0x655EE0", VA = "0x1806574E0", Slot = "24")]
		public virtual bool ReadSyncVar___ScheduleOne.PlayerScripts.PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x0000A020 File Offset: 0x00008220
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700053E")]
		public Vector3 SyncAccessor_<LastKnownPosition>k__BackingField
		{
			[Token(Token = "0x6001E6A")]
			[Address(RVA = "0x659830", Offset = "0x658230", VA = "0x180659830")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6001E6B")]
			[Address(RVA = "0x659BD0", Offset = "0x6585D0", VA = "0x180659BD0")]
			set
			{
			}
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x655D50", Offset = "0x654750", VA = "0x180655D50")]
		private void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerCrimeData_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		public const float SEARCH_TIME_INVESTIGATING = 60f;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		public const float SEARCH_TIME_ARRESTING = 25f;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		public const float SEARCH_TIME_NONLETHAL = 30f;

		// Token: 0x040018A7 RID: 6311
		[Token(Token = "0x40018A7")]
		public const float SEARCH_TIME_LETHAL = 40f;

		// Token: 0x040018A8 RID: 6312
		[Token(Token = "0x40018A8")]
		public const float ESCALATION_TIME_ARRESTING = 25f;

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		public const float ESCALATION_TIME_NONLETHAL = 120f;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		public const float SHOT_COOLDOWN_MIN = 2f;

		// Token: 0x040018AB RID: 6315
		[Token(Token = "0x40018AB")]
		public const float SHOT_COOLDOWN_MAX = 8f;

		// Token: 0x040018AC RID: 6316
		[Token(Token = "0x40018AC")]
		public const float VEHICLE_COLLISION_LIFETIME = 30f;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		public const float VEHICLE_COLLISION_LIMIT = 3f;

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x118")]
		public PoliceOfficer NearestOfficer;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x120")]
		public Player Player;

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x128")]
		public AudioSourceController onPursuitEscapedSound;

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x140")]
		public List<PoliceOfficer> Pursuers;

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x154")]
		public float TimeSincePursuitStart;

		// Token: 0x040018B8 RID: 6328
		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x158")]
		public float CurrentPursuitLevelDuration;

		// Token: 0x040018B9 RID: 6329
		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0x15C")]
		public float TimeSinceSighted;

		// Token: 0x040018BA RID: 6330
		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0x160")]
		public Dictionary<Crime, int> Crimes;

		// Token: 0x040018BB RID: 6331
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x168")]
		public bool BodySearchPending;

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x178")]
		protected List<PlayerCrimeData.VehicleCollisionInstance> Collisions;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x180")]
		private MusicTrack _lightCombatTrack;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x188")]
		private MusicTrack _heavyCombatTrack;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x190")]
		private float outOfSightTimeToDipMusic;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x194")]
		private float minMusicVolume;

		// Token: 0x040018C3 RID: 6339
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x198")]
		private float musicChangeRate_Down;

		// Token: 0x040018C4 RID: 6340
		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x19C")]
		private float musicChangeRate_Up;

		// Token: 0x040018C5 RID: 6341
		[Token(Token = "0x40018C5")]
		[FieldOffset(Offset = "0x1A0")]
		public SyncVar<PlayerCrimeData.EPursuitLevel> syncVar___<CurrentPursuitLevel>k__BackingField;

		// Token: 0x040018C6 RID: 6342
		[Token(Token = "0x40018C6")]
		[FieldOffset(Offset = "0x1A8")]
		public SyncVar<Vector3> syncVar___<LastKnownPosition>k__BackingField;

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x1B0")]
		private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted;

		// Token: 0x040018C8 RID: 6344
		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x1B1")]
		private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted;

		// Token: 0x02000560 RID: 1376
		[Token(Token = "0x2000560")]
		public class VehicleCollisionInstance
		{
			// Token: 0x06001E6D RID: 7789 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E6D")]
			[Address(RVA = "0x6670B0", Offset = "0x665AB0", VA = "0x1806670B0")]
			public VehicleCollisionInstance(NPC victim, float timeSince)
			{
			}

			// Token: 0x040018C9 RID: 6345
			[Token(Token = "0x40018C9")]
			[FieldOffset(Offset = "0x10")]
			public NPC Victim;

			// Token: 0x040018CA RID: 6346
			[Token(Token = "0x40018CA")]
			[FieldOffset(Offset = "0x18")]
			public float TimeSince;
		}

		// Token: 0x02000561 RID: 1377
		[Token(Token = "0x2000561")]
		public enum EPursuitLevel
		{
			// Token: 0x040018CC RID: 6348
			[Token(Token = "0x40018CC")]
			None,
			// Token: 0x040018CD RID: 6349
			[Token(Token = "0x40018CD")]
			Investigating,
			// Token: 0x040018CE RID: 6350
			[Token(Token = "0x40018CE")]
			Arresting,
			// Token: 0x040018CF RID: 6351
			[Token(Token = "0x40018CF")]
			NonLethal,
			// Token: 0x040018D0 RID: 6352
			[Token(Token = "0x40018D0")]
			Lethal
		}
	}
}
