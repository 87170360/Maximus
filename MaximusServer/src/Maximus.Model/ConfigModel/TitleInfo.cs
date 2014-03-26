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
    /// 称号配置
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config, "TitleInfo")]
    public class TitleInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public TitleInfo()
            : base(AccessLevel.ReadOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public TitleInfo(int id)
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
        private int _targetNum;
        /// <summary>
        /// 达到值
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("TargetNum")]
        public int TargetNum
        {
            get
            {
                return _targetNum;
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
                    case "TargetNum": return _targetNum;
					default: throw new ArgumentException(string.Format("TitleInfo index[{0}] isn't exist.", index));
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
                    case "TargetNum": 
                        _targetNum = value.ToInt();
                        break; 
					default: throw new ArgumentException(string.Format("TitleInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}