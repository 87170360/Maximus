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
    /// 扑克牌配置
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config, "PokerInfo")]
    public class PokerInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public PokerInfo()
            : base(AccessLevel.ReadOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public PokerInfo(int id)
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
        private CardColor _color;
        /// <summary>
        /// 牌花色[Enum<CardColor>]
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("Color")]
        public CardColor Color
        {
            get
            {
                return _color;
            } 
            
        }
        private short _value;
        /// <summary>
        /// 牌大小值
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("Value")]
        public short Value
        {
            get
            {
                return _value;
            } 
            
        }
        private string _headIcon;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("HeadIcon")]
        public string HeadIcon
        {
            get
            {
                return _headIcon;
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
                    case "Color": return _color;
                    case "Value": return _value;
                    case "HeadIcon": return _headIcon;
					default: throw new ArgumentException(string.Format("PokerInfo index[{0}] isn't exist.", index));
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
                    case "Color": 
                        _color = value.ToEnum<CardColor>();
                        break; 
                    case "Value": 
                        _value = value.ToShort();
                        break; 
                    case "HeadIcon": 
                        _headIcon = value.ToNotNullString();
                        break; 
					default: throw new ArgumentException(string.Format("PokerInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}