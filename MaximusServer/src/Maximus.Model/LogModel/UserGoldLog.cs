﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace Maximus.Model
{
    /// <summary>
    /// 
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
	[EntityTable(AccessLevel.WriteOnly, DbConfig.Log, "UserGoldLog")]
    public class UserGoldLog : LogEntity
    {
        #region auto-generated static method
        static UserGoldLog()
        {
            EntitySchemaSet.InitSchema(typeof(UserGoldLog));
        }
        #endregion
        /// <summary>
        /// </summary>
        public UserGoldLog()
        {
            
        }        
        /// <summary>
        /// </summary>
        public UserGoldLog(long iD)
            : this()
        {
            _iD = iD;
        }

        #region 自动生成属性
        private long _iD;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public long ID
        {
            get
            {
                return _iD;
            } 
        }
        private int _userID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("UserID")]
        public int UserID
        {
            set
            {
                SetChange("UserID", value);
            }
        }
        private short _balanceType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("BalanceType")]
        public short BalanceType
        {
            set
            {
                SetChange("BalanceType", value);
            }
        }
        private short _currencyType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("CurrencyType")]
        public short CurrencyType
        {
            set
            {
                SetChange("CurrencyType", value);
            }
        }
        private short _opType;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("OpType")]
        public short OpType
        {
            set
            {
                SetChange("OpType", value);
            }
        }
        private int _detailID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("DetailID")]
        public int DetailID
        {
            set
            {
                SetChange("DetailID", value);
            }
        }
        private int _num;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Num")]
        public int Num
        {
            set
            {
                SetChange("Num", value);
            }
        }
        private int _gold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("Gold")]
        public int Gold
        {
            set
            {
                SetChange("Gold", value);
            }
        }
        private int _banGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("BanGold")]
        public int BanGold
        {
            set
            {
                SetChange("BanGold", value);
            }
        }
        private int _surplusGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(10)]
        [EntityField("SurplusGold")]
        public int SurplusGold
        {
            set
            {
                SetChange("SurplusGold", value);
            }
        }
        private int _surplusBanGold;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(11)]
        [EntityField("SurplusBanGold")]
        public int SurplusBanGold
        {
            set
            {
                SetChange("SurplusBanGold", value);
            }
        }
        private DateTime _createDate;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(12)]
        [EntityField("CreateDate")]
        public DateTime CreateDate
        {
            set
            {
                SetChange("CreateDate", value);
            }
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return _iD;
                    case "UserID": return _userID;
                    case "BalanceType": return _balanceType;
                    case "CurrencyType": return _currencyType;
                    case "OpType": return _opType;
                    case "DetailID": return _detailID;
                    case "Num": return _num;
                    case "Gold": return _gold;
                    case "BanGold": return _banGold;
                    case "SurplusGold": return _surplusGold;
                    case "SurplusBanGold": return _surplusBanGold;
                    case "CreateDate": return _createDate;
					default: throw new ArgumentException(string.Format("UserGoldLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _iD = MathUtils.ToLong(value);
                        break; 
                    case "UserID": 
                        _userID = value.ToInt();
                        break; 
                    case "BalanceType": 
                        _balanceType = value.ToShort();
                        break; 
                    case "CurrencyType": 
                        _currencyType = value.ToShort();
                        break; 
                    case "OpType": 
                        _opType = value.ToShort();
                        break; 
                    case "DetailID": 
                        _detailID = value.ToInt();
                        break; 
                    case "Num": 
                        _num = value.ToInt();
                        break; 
                    case "Gold": 
                        _gold = value.ToInt();
                        break; 
                    case "BanGold": 
                        _banGold = value.ToInt();
                        break; 
                    case "SurplusGold": 
                        _surplusGold = value.ToInt();
                        break; 
                    case "SurplusBanGold": 
                        _surplusBanGold = value.ToInt();
                        break; 
                    case "CreateDate": 
                        _createDate = value.ToDateTime();
                        break; 
					default: throw new ArgumentException(string.Format("UserGoldLog index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}