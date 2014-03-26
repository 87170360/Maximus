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
    /// 房间配置
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config, "RoomInfo")]
    public class RoomInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public RoomInfo()
            : base(AccessLevel.ReadOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public RoomInfo(int id)
            : this()
        {
            _id = id;
        }

        #region 自动生成属性
        private int _id;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("Id", IsKey = true)]
        public int Id
        {
            get
            {
                return _id;
            } 
            
        }
        private string _name;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("Name")]
        public string Name
        {
            get
            {
                return _name;
            } 
            
        }
        private int _anteNum;
        /// <summary>
        /// 底注分
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("AnteNum")]
        public int AnteNum
        {
            get
            {
                return _anteNum;
            } 
            
        }
        private short _multipleNum;
        /// <summary>
        /// 房间倍数
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("MultipleNum")]
        public short MultipleNum
        {
            get
            {
                return _multipleNum;
            } 
            
        }
        private int _minGameCion;
        /// <summary>
        /// 金豆数限制
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("MinGameCion")]
        public int MinGameCion
        {
            get
            {
                return _minGameCion;
            } 
            
        }
        private int _giffCion;
        /// <summary>
        /// 每日赠豆,0:不赠送
        /// </summary>        
        [ProtoMember(6)]
        [EntityField("GiffCion")]
        public int GiffCion
        {
            get
            {
                return _giffCion;
            } 
            
        }
        private string _description;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(7)]
        [EntityField("Description")]
        public string Description
        {
            get
            {
                return _description;
            } 
            
        }
        private int _playerNum;
        /// <summary>
        /// 玩家人数
        /// </summary>        
        [ProtoMember(8)]
        [EntityField("PlayerNum")]
        public int PlayerNum
        {
            get
            {
                return _playerNum;
            } 
            
        }
        private int _cardPackNum;
        /// <summary>
        /// 卡牌几副
        /// </summary>        
        [ProtoMember(9)]
        [EntityField("CardPackNum")]
        public int CardPackNum
        {
            get
            {
                return _cardPackNum;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "Id": return _id;
                    case "Name": return _name;
                    case "AnteNum": return _anteNum;
                    case "MultipleNum": return _multipleNum;
                    case "MinGameCion": return _minGameCion;
                    case "GiffCion": return _giffCion;
                    case "Description": return _description;
                    case "PlayerNum": return _playerNum;
                    case "CardPackNum": return _cardPackNum;
					default: throw new ArgumentException(string.Format("RoomInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "Id": 
                        _id = value.ToInt();
                        break; 
                    case "Name": 
                        _name = value.ToNotNullString();
                        break; 
                    case "AnteNum": 
                        _anteNum = value.ToInt();
                        break; 
                    case "MultipleNum": 
                        _multipleNum = value.ToShort();
                        break; 
                    case "MinGameCion": 
                        _minGameCion = value.ToInt();
                        break; 
                    case "GiffCion": 
                        _giffCion = value.ToInt();
                        break; 
                    case "Description": 
                        _description = value.ToNotNullString();
                        break; 
                    case "PlayerNum": 
                        _playerNum = value.ToInt();
                        break; 
                    case "CardPackNum": 
                        _cardPackNum = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("RoomInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}